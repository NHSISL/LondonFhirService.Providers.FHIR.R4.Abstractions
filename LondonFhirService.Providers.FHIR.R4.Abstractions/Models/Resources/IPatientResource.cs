// ---------------------------------------------------------
// Copyright (c) North East London ICB. All rights reserved.
// ---------------------------------------------------------

using System;
using System.Threading;
using Hl7.Fhir.Model;

namespace LondonFhirService.Providers.FHIR.R4.Abstractions.Models.Resources
{
    /// <summary>
    /// R4 Patient provider
    /// </summary>
    public interface IPatientResource : IResourceOperation<Patient>
    {
        /// <summary>
        /// Patient plus all related resources.
        /// Returns a Bundle (usually type "searchset").
        /// Optional parameters: start, end, _type, _since, _count (exposed as arguments here).
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
        Bundle Everything(
            string id,
            DateTimeOffset? start = null,
            DateTimeOffset? end = null,
            string typeFilter = null,
            DateTimeOffset? since = null,
            int? count = null,
            CancellationToken cancellationToken = default);

        /// <summary>
        /// Patient matching operation.
        /// Request/response are Parameters/Bundle per spec (response Bundle type "searchset").
        /// </summary>
        /// <param name="parameters">Parameters resource containing the match criteria.</param>
        /// <param name="cancellationToken">
        /// Optional token to observe while awaiting the operation.  
        /// Defaults to <see cref="CancellationToken.None"/> if not supplied.
        /// </param>
        Bundle Match(
            Parameters parameters,
            CancellationToken cancellationToken = default);
    }
}
