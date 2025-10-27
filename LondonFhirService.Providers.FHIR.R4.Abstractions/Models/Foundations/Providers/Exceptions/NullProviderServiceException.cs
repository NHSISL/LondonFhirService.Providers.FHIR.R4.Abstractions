// ---------------------------------------------------------
// Copyright (c) North East London ICB. All rights reserved.
// ---------------------------------------------------------

using Xeptions;

namespace LondonFhirService.Providers.FHIR.R4.Abstractions.Models.Foundations.Providers.Exceptions
{
    public class NullProviderServiceException : Xeption
    {
        public NullProviderServiceException(string message)
            : base(message)
        { }
    }
}