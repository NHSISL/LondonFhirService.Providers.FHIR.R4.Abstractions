// ---------------------------------------------------------
// Copyright (c) North East London ICB. All rights reserved.
// ---------------------------------------------------------

using System;
using LondonFhirService.Providers.FHIR.R4.Abstractions.Models.Foundations.Providers;
using Xeptions;

namespace LondonFhirService.Providers.FHIR.R4.Abstractions
{
    public partial class FhirAbstractionProvider
    {
        private delegate T ReturningFunction<T>();

        private T TryCatch<T>(ReturningFunction<T> returningFunction)
        {
            try
            {
                return returningFunction();
            }
            catch (ProviderValidationException providerValidationException)
            {
                throw CreateValidationException(providerValidationException);
            }
            catch (ProviderDependencyValidationException providerDependencyValidationException)
            {
                throw CreateValidationException(providerDependencyValidationException.InnerException as Xeption);
            }
            catch (ProviderDependencyException providerDependencyException)
            {
                throw CreateDependencyException(providerDependencyException);
            }
            catch (ProviderServiceException providerServiceException)
            {
                throw CreateServiceException(providerServiceException);
            }
            catch (Exception exception)
            {
                throw CreateServiceException(exception);
            }
        }

        private FhirAbstractionProviderValidationException CreateValidationException(
            Xeption exception)
        {
            var fhirAbstractionProviderValidationException =
                new FhirAbstractionProviderValidationException(
                    message: exception.Message,
                    innerException: exception,
                    data: exception.Data);

            return fhirAbstractionProviderValidationException;
        }

        private FhirAbstractionProviderDependencyException CreateDependencyException(
            Xeption exception)
        {
            var fhirAbstractionProviderDependencyException = new FhirAbstractionProviderDependencyException(
                message: exception.Message,
                innerException: exception,
                data: exception.Data);

            return fhirAbstractionProviderDependencyException;
        }

        private FhirAbstractionProviderServiceException CreateServiceException(
            Exception exception)
        {
            var fhirAbstractionProviderServiceException = new FhirAbstractionProviderServiceException(
                message: exception.Message,
                innerException: exception,
                data: exception.Data);

            return fhirAbstractionProviderServiceException;
        }
    }
}
