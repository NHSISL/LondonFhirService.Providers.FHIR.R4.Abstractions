// ---------------------------------------------------------
// Copyright (c) North East London ICB. All rights reserved.
// ---------------------------------------------------------

using System;
using System.Collections.Generic;

namespace LondonFhirService.Providers.FHIR.R4.Abstractions.Services.Foundations
{
    internal class ProviderService : IProviderService
    {
        private readonly IEnumerable<IFhirProvider> fhirProviders;

        public ProviderService(IEnumerable<IFhirProvider> fhirProviders)
        {
            this.fhirProviders = fhirProviders;
        }

        public IFhirProvider GetProviderByName(string providerName) =>
            throw new NotImplementedException();
    }
}
