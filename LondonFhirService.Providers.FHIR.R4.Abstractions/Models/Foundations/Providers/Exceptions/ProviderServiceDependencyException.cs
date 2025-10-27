// ---------------------------------------------------------
// Copyright (c) North East London ICB. All rights reserved.
// ---------------------------------------------------------

using Xeptions;

namespace LondonFhirService.Providers.FHIR.R4.Abstractions.Models.Foundations.Providers.Exceptions
{
    internal class ProviderServiceDependencyException : Xeption
    {
        public ProviderServiceDependencyException(string message, Xeption innerException)
            : base(message, innerException)
        { }
    }
}
