// ---------------------------------------------------------
// Copyright (c) North East London ICB. All rights reserved.
// ---------------------------------------------------------

using System;
using System.Threading;
using System.Threading.Tasks;
using Hl7.Fhir.Model;
using LondonFhirService.Providers.FHIR.R4.Abstractions.Models.Capabilities;
using LondonFhirService.Providers.FHIR.R4.Abstractions.Models.Resources;

namespace LondonFhirService.Providers.FHIR.R4.Abstractions.Tests.Unit.Models
{
    /// <summary>
    /// Patient resource operations. Demonstrates a non-standard operation (<c>$everything</c>) included via
    /// <see cref="FhirOperationAttribute"/>.
    /// </summary>
    public sealed class TestPatientResource : ResourceOperationBase<Patient>, IPatientResource
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
        public async ValueTask<Bundle> EverythingAsync(
            string id,
            DateTimeOffset? start = null,
            DateTimeOffset? end = null,
            string typeFilter = null,
            DateTimeOffset? since = null,
            int? count = null,
            CancellationToken cancellationToken = default)
        {
            return new Bundle { Type = Bundle.BundleType.Searchset };
        }

        /// <summary>
        /// Executes the FHIR R4 <c>$everything</c> operation for a given patient
        /// and returns the raw serialized FHIR payload (e.g. JSON) instead of a parsed
        /// <see cref="Bundle"/>.
        /// Optional parameters: <paramref name="start"/>, <paramref name="end"/>,
        /// <paramref name="typeFilter"/> (<c>_type</c>), <paramref name="since"/> (<c>_since</c>),
        /// and <paramref name="count"/> (<c>_count</c>).
        /// </summary>
        /// <param name="id">Logical id of the patient resource.</param>
        /// <param name="start">Optional start date/time for records to include.</param>
        /// <param name="end">Optional end date/time for records to include.</param>
        /// <param name="typeFilter">Optional FHIR resource type filter (_type).</param>
        /// <param name="since">Optional date/time to restrict results to resources updated since this point (_since).</param>
        /// <param name="count">Optional maximum number of resources to return (_count).</param>
        /// <param name="cancellationToken">
        /// Optional token to observe while awaiting the operation.  
        /// Defaults to <see cref="CancellationToken.None"/> if not supplied.
        /// </param>
        /// <returns>
        /// A <see cref="string"/> containing the raw serialized FHIR payload returned by the provider.
        /// </returns>
        public async ValueTask<string> EverythingSerialisedAsync(
            string id,
            DateTimeOffset? start = null,
            DateTimeOffset? end = null,
            string typeFilter = null,
            DateTimeOffset? since = null,
            int? count = null,
            CancellationToken cancellationToken = default) =>
            throw new NotImplementedException();

        /// <summary>
        /// Patient matching operation. Not decorated, so it will not appear in capabilities.
        /// </summary>
        /// <param name="parameters">FHIR parameters for the match operation.</param>
        /// <returns>A bundle with match results.</returns>
        public async ValueTask<Bundle> MatchAsync(Parameters parameters,
            CancellationToken cancellationToken = default) =>
            throw new NotImplementedException();
    }
}
