// ---------------------------------------------------------
// Copyright (c) North East London ICB. All rights reserved.
// ---------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using LondonFhirService.Providers.FHIR.R4.Abstractions.Models.Foundations.Providers.Exceptions;

namespace LondonFhirService.Providers.FHIR.R4.Abstractions.Services.Foundations
{
    internal partial class ProviderService : IProviderService
    {
        private void ValidateOnGetProviderByName(string providerName)
        {
            ValidateProvidersIsNotNull(this.fhirProviders);
        }

        private void ValidateProvidersIsNotNull(IEnumerable<IFhirProvider> fhirProviders)
        {
            if (fhirProviders is null || fhirProviders.Count() == 0)
            {
                throw new NullProviderServiceException(message: "Provider is null.");
            }
        }
    }
}
