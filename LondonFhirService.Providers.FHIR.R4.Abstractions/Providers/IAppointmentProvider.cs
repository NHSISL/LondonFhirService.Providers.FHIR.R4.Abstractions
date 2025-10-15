using Hl7.Fhir.Model;
using Hl7.Fhir.Rest;

namespace Fhir.R4.Providers
{
    /// <summary>FHIR R4 provider interface for Appointment.</summary>
    public interface IAppointmentProvider : IResourceProvider<Appointment> { }
}
