using System;
using Hl7.Fhir.Model;

namespace LondonFhirService.Providers.FHIR.R4.Abstractions.Operations
{
    /// <summary>R4 Patient provider including $everything and $match operations.</summary>
    public interface IPatientOperation : IResourceOperation<Patient>
    {
        /// <summary>
        /// Domain-specific helper (not standard FHIR): returns a patient’s consolidated record
        /// as a Bundle (e.g., via Patient/$everything or a server-specific API).
        /// </summary>
        /// <param name="patientNHSNumber">Identifier value for the patient (e.g., NHS number).</param>
        /// <param name="patientDateOfBirth">Optional DoB to disambiguate.</param>
        /// <param name="demographicsOnly">If true, limit to demographics.</param>
        /// <param name="includeInactivePatients">Include inactive patients if true.</param>
        /// <returns>Bundle of patient-related resources (often type=searchset).</returns>
        [Obsolete]
        Bundle GetStructuredRecord(
            string patientNHSNumber,
            DateTime? patientDateOfBirth = null,
            bool? demographicsOnly = false,
            bool? includeInactivePatients = false);

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
