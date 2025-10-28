// ---------------------------------------------------------
// Copyright (c) North East London ICB. All rights reserved.
// ---------------------------------------------------------

using System;

namespace LondonFhirService.Providers.FHIR.R4.Abstractions.Models.Capabilities
{
    /// <summary>
    /// Marker attribute for **non-standard, resource-specific operations** 
    /// (e.g., <c>$everything</c>, <c>$match</c>).
    ///
    /// <para>
    /// This attribute is only required for methods that are **not part of the 
    /// standard RESTful surface** defined by <see cref="IResourceOperation{TResource}"/>.
    /// </para>
    ///
    /// <para>
    /// Standard operations from <see cref="IResourceOperation{TResource}"/> 
    /// (e.g., <c>Read</c>, <c>Search</c>, <c>Create</c>, etc.) 
    /// are automatically included in capabilities when overridden, 
    /// and therefore do **not** require this attribute.
    /// </para>
    ///
    /// <para>
    /// For methods marked with this attribute, the method name itself 
    /// will always be used as the operation name in capabilities.
    /// </para>
    /// </summary>
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = false, Inherited = true)]
    public sealed class FhirOperationAttribute : Attribute { }
}
