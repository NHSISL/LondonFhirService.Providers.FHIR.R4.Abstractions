// ---------------------------------------------------------
// Copyright (c) North East London ICB. All rights reserved.
// ---------------------------------------------------------

using Xeptions;

namespace LondonFhirService.Providers.FHIR.R4.Abstractions.Models.Foundations.Providers
{
    internal class ProviderDependencyException : Xeption
    {
        public ProviderDependencyException(string message, Xeption innerException)
            : base(message, innerException)
        { }
    }
}
