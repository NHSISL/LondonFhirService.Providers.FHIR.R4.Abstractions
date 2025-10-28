// ---------------------------------------------------------
// Copyright (c) North East London ICB. All rights reserved.
// ---------------------------------------------------------

using System;
using System.Linq;
using Hl7.Fhir.Model;

namespace LondonFhirService.Providers.FHIR.R4.Abstractions.Extensions
{
    /// <summary>
    /// Guard methods for checking whether a provider or resource operation
    /// supports specific resources or operations.
    /// </summary>
    public static class FhirProviderGuards
    {
        /// <summary>
        /// Checks whether the provider supports a given resource.
        /// </summary>
        /// <param name="provider">The FHIR provider instance.</param>
        /// <param name="resourceName">The resource name (e.g., "Patient").</param>
        /// <returns>
        /// True if the provider declares support for the given resource; otherwise false.
        /// </returns>
        /// <example>
        /// <code>
        /// IFhirProvider provider = GetProvider();
        /// bool supportsPatient = provider.SupportsResource("Patient");
        /// if (supportsPatient)
        /// {
        ///     Console.WriteLine("Provider supports Patient resource.");
        /// }
        /// </code>
        /// </example>
        public static bool SupportsResource(this IFhirProvider provider, string resourceName) =>
            provider?.Capabilities.SupportedResources.Any(
                resource => string.Equals(resource.ResourceName, resourceName, StringComparison.Ordinal)) == true;

        /// <summary>
        /// Checks whether the provider supports a given resource and a specific operation on it.
        /// </summary>
        /// <param name="provider">The FHIR provider instance.</param>
        /// <param name="resourceName">The resource name (e.g., "Patient").</param>
        /// <param name="operationName">The operation name (e.g., "Read", "Search", "Everything").</param>
        /// <returns>
        /// True if the provider declares support for the given resource and operation; otherwise false.
        /// </returns>
        /// <example>
        /// <code>
        /// IFhirProvider provider = GetProvider();
        /// bool supportsPatientRead = provider.SupportsResource("Patient", "Read");
        /// if (supportsPatientRead)
        /// {
        ///     var patient = provider.Patients.Read("12345");
        /// }
        /// </code>
        /// </example>
        public static bool SupportsResource(
            this IFhirProvider provider,
            string resourceName,
            string operationName) =>
            provider?.Capabilities.SupportedResources.Any(resource =>
                string.Equals(resource.ResourceName, resourceName, StringComparison.Ordinal) &&
                resource.SupportedOperations.Any(operation =>
                    string.Equals(operation, operationName, StringComparison.Ordinal))) == true;

        /// <summary>
        /// Checks whether the resource operation supports a given operation name.
        /// </summary>
        /// <typeparam name="TResource">FHIR R4 resource type.</typeparam>
        /// <param name="resource">The resource operation instance.</param>
        /// <param name="operationName">Operation name (e.g., "Read", "Search", "Everything").</param>
        /// <returns>True if the operation is supported; otherwise false.</returns>
        /// <example>
        /// <code>
        /// IResourceOperation&lt;Patient&gt; patientOps = provider.Patients;
        /// bool canSearch = patientOps.SupportsOperation("Search");
        /// if (canSearch)
        /// {
        ///     var results = patientOps.Search(new SearchParams().Where("name=Smith"));
        /// }
        /// </code>
        /// </example>
        public static bool SupportsOperation<TResource>(
            this IResourceOperation<TResource> resource,
            string operationName)
            where TResource : Resource =>
            resource?.Capabilities.SupportedOperations.Any(
                operation => string.Equals(operation, operationName, StringComparison.Ordinal)) == true;
    }
}
