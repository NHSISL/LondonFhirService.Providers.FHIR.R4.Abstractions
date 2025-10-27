// ---------------------------------------------------------
// Copyright (c) North East London ICB. All rights reserved.
// ---------------------------------------------------------

using System;
using Hl7.Fhir.Model;

namespace LondonFhirService.Providers.FHIR.R4.Abstractions.Models.Resources
{
    /// <summary>R4 Patient provider including $everything and $match operations.</summary>
    public interface IPatientResource : IResourceOperation<Patient>
    {
        /// <summary>
        /// GET [base]/Patient/{id}/$everything — Patient plus all related resources.
        /// Returns a Bundle (usually type "searchset").
        /// Optional parameters: start, end, _type, _since, _count (exposed as arguments here).
        /// </summary>
        Bundle Everything(
            string id,
            DateTimeOffset? start = null,
            DateTimeOffset? end = null,
            string typeFilter = null,
            DateTimeOffset? since = null,
            int? count = null);

        /// <summary>
        /// POST [base]/Patient/$match — Patient matching operation.
        /// Request/response are Parameters/Bundle per spec (response Bundle type "searchset").
        /// </summary>
        Bundle Match(Parameters parameters);
    }
}
