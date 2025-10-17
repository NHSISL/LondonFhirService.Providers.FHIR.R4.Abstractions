// ---------------------------------------------------------
// Copyright (c) North East London ICB. All rights reserved.
// ---------------------------------------------------------

using System.Collections;
using Xeptions;

namespace LondonFhirService.Providers.FHIR.R4.Abstractions.Models.Foundations.Providers
{
    internal class FhirAbstractionProviderValidationException : Xeption
    {
        public FhirAbstractionProviderValidationException(string message, Xeption innerException, IDictionary data)
            : base(message, innerException)
        { }
    }
}