using Hl7.Fhir.Model;
using Hl7.Fhir.Rest;

namespace LondonFhirService.Providers.FHIR.R4.Abstractions.Models.Resources
{
    /// <summary>FHIR R4 provider interface for MedicationRequest.</summary>
    public interface IMedicationRequestResource : IResourceOperation<MedicationRequest> { }
}
