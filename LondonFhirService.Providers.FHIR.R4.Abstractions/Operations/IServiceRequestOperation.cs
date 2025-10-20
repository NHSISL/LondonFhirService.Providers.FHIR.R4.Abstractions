using Hl7.Fhir.Model;
using Hl7.Fhir.Rest;

namespace LondonFhirService.Providers.FHIR.R4.Abstractions.Operations
{
    /// <summary>FHIR R4 provider interface for ServiceRequest.</summary>
    public interface IServiceRequestOperation : IResourceOperation<ServiceRequest> { }
}
