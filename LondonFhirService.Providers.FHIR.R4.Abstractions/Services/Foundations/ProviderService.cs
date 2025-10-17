// ---------------------------------------------------------
// Copyright (c) North East London ICB. All rights reserved.
// ---------------------------------------------------------

using System;

namespace LondonFhirService.Providers.FHIR.R4.Abstractions.Services.Foundations
{
    internal class ProviderService : IProviderService
    {
        private readonly IFhirProvider[] fhirProviders;

        public ProviderService(IFhirProvider[] fhirProviders)
        {
            this.fhirProviders = fhirProviders;
        }

        public IFhirProvider GetProviderByName(string providerName) =>
            throw new NotImplementedException();
    }
}
