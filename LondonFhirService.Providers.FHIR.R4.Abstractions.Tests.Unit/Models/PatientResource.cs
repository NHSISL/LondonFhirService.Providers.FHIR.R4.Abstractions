// ---------------------------------------------------------
// Copyright (c) North East London ICB. All rights reserved.
// ---------------------------------------------------------

using System;
using Hl7.Fhir.Model;
using LondonFhirService.Providers.FHIR.R4.Abstractions.Models.Capabilities;
using LondonFhirService.Providers.FHIR.R4.Abstractions.Models.Resources;

namespace LondonFhirService.Providers.FHIR.R4.Abstractions.Tests.Unit.Models
{
    /// <summary>
    /// Patient resource operations. Demonstrates a non-standard operation (<c>$everything</c>) included via
    /// <see cref="FhirOperationAttribute"/>.
    /// </summary>
    public sealed class PatientResource : ResourceOperationBase<Patient>, IPatientResource
    {
        /// <summary>
        /// Returns the patient and related resources. The method name appears in capabilities because it is decorated
        /// with <see cref="FhirOperationAttribute"/>.
        /// </summary>
        /// <param name="id">Patient id.</param>
        /// <param name="start">Optional lower bound for event period.</param>
        /// <param name="end">Optional upper bound for event period.</param>
        /// <param name="typeFilter">Optional comma-separated type filter.</param>
        /// <param name="since">Optional timestamp to restrict to changes since.</param>
        /// <param name="count">Optional page size limit.</param>
        /// <returns>A bundle of resources related to the patient.</returns>
        [FhirOperation]
        public Bundle Everything(
            string id,
            DateTimeOffset? start = null,
            DateTimeOffset? end = null,
            string typeFilter = null,
            DateTimeOffset? since = null,
            int? count = null)
        {
            return new Bundle { Type = Bundle.BundleType.Searchset };
        }

        /// <summary>
        /// Patient matching operation. Not decorated, so it will not appear in capabilities.
        /// </summary>
        /// <param name="parameters">FHIR parameters for the match operation.</param>
        /// <returns>A bundle with match results.</returns>
        public Bundle Match(Parameters parameters) => throw new NotImplementedException();
    }
}
