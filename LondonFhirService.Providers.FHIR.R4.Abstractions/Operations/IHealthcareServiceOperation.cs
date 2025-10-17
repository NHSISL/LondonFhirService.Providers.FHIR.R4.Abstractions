using Hl7.Fhir.Model;
using Hl7.Fhir.Rest;

namespace LondonFhirService.Operations.FHIR.R4.Abstractions.Operations
{
    /// <summary>FHIR R4 provider interface for HealthcareService.</summary>
    public interface IHealthcareServiceOperation : IResourceOperation<HealthcareService> { }
}
