// ---------------------------------------------------------
// Copyright (c) North East London ICB. All rights reserved.
// ---------------------------------------------------------

using System;
using Xeptions;

namespace LondonFhirService.Providers.FHIR.R4.Abstractions.Models.Foundations.Providers.Exceptions
{
    internal class ProviderServiceException : Xeption
    {
        public ProviderServiceException(string message, Exception innerException)
            : base(message, innerException)
        { }
    }
}