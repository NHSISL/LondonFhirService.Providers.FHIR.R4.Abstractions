// ---------------------------------------------------------
// Copyright (c) North East London ICB. All rights reserved.
// ---------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Hl7.Fhir.Model;
using Hl7.Fhir.Rest;
using LondonFhirService.Providers.FHIR.R4.Abstractions.Models.Capabilities;

namespace LondonFhirService.Providers.FHIR.R4.Abstractions.Models.Resources
{
    /// <summary>
    /// Base class for resource operations.
    /// Capabilities include:
    ///  • Standard REST methods you override here
    ///  • Methods declared on the derived class marked with [FhirOperation] (name = method name)
    /// </summary>
    public abstract class ResourceOperationBase<TResource> : IResourceOperation<TResource>
        where TResource : Resource
    {
        private ResourceCapabilities resourceCapabilities;

        public ResourceCapabilities Capabilities => resourceCapabilities ??= ComputeCapabilities();

        protected virtual string GetResourceName()
        {
            var n = GetType().Name;
            return n.EndsWith("Resource", StringComparison.Ordinal) ? n[..^"Resource".Length] : n;
        }

        #region Standard REST surface (override what you support)

        public virtual TResource Read(string id) =>
            throw new NotImplementedException();

        public virtual TResource VRead(string id, string versionId) =>
            throw new NotImplementedException();

        public virtual Bundle HistoryInstance(string id, DateTimeOffset? since = null, int? count = null) =>
            throw new NotImplementedException();

        public virtual Bundle Search(SearchParams @params) =>
            throw new NotImplementedException();

        public virtual Bundle HistoryType(DateTimeOffset? since = null, int? count = null) =>
            throw new NotImplementedException();

        public virtual Bundle HistorySystem(DateTimeOffset? since = null, int? count = null) =>
            throw new NotImplementedException();

        public virtual TResource Create(TResource resource) => throw new NotImplementedException();
        public virtual TResource Update(TResource resource) => throw new NotImplementedException();
        public virtual TResource Patch(string id, Parameters patchParameters) => throw new NotImplementedException();
        public virtual OperationOutcome Delete(string id) => throw new NotImplementedException();

        #endregion

        private ResourceCapabilities ComputeCapabilities()
        {
            var derived = GetType();

            // 1) Standard REST overrides
            var baseVirtuals = typeof(ResourceOperationBase<TResource>)
                .GetMethods(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic)
                .Where(m => m.IsVirtual && m.DeclaringType == typeof(ResourceOperationBase<TResource>))
                .ToArray();

            var overriddenRest = new List<string>();
            foreach (var baseMethod in baseVirtuals)
            {
                var parms = baseMethod.GetParameters().Select(p => p.ParameterType).ToArray();
                var candidate = derived.GetMethod(
                    baseMethod.Name,
                    BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic,
                    binder: null,
                    types: parms,
                    modifiers: null);

                if (candidate != null &&
                    candidate.IsVirtual &&
                    candidate.GetBaseDefinition() == baseMethod)
                {
                    overriddenRest.Add(baseMethod.Name);
                }
            }

            // 2) Non-standard ops marked with [FhirOperation]
            var annotated = derived
                .GetMethods(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.DeclaredOnly)
                .Where(m => m.GetCustomAttribute<FhirOperationAttribute>(inherit: true) != null)
                .Select(m => m.Name)
                .ToList();

            var supported = overriddenRest
                .Concat(annotated)
                .Distinct(StringComparer.Ordinal)
                .OrderBy(n => n, StringComparer.Ordinal)
                .ToArray();

            return new ResourceCapabilities
            {
                ResourceName = GetResourceName(),
                SupportedOperations = supported
            };
        }
    }
}
