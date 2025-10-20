// ---------------------------------------------------------
// Copyright (c) North East London ICB. All rights reserved.
// ---------------------------------------------------------

using LondonFhirService.Providers.FHIR.R4.Abstractions.Models.Foundations.Providers.Exceptions;
using Xeptions;

namespace LondonFhirService.Providers.FHIR.R4.Abstractions.Services.Foundations
{
    internal partial class ProviderService : IProviderService
    {
        private delegate IFhirProvider ReturningFhirProviderFunction();

        private IFhirProvider TryCatch(ReturningFhirProviderFunction returningFhirProviderFunction)
        {
            try
            {
                return returningFhirProviderFunction();
            }
            catch (NullProviderServiceException nullProviderServiceException)
            {
                throw CreateValidationException(nullProviderServiceException);
            }
        }

        private ProviderServiceValidationException CreateValidationException(Xeption exception)
        {
            var providerServiceValidationException =
                new ProviderServiceValidationException(
                    message: "Provider validation errors occurred, please try again.",
                    innerException: exception);

            return providerServiceValidationException;
        }
    }
}
