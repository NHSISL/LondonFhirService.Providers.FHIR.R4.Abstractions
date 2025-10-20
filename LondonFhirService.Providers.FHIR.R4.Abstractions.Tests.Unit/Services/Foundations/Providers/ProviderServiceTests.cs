// ---------------------------------------------------------
// Copyright (c) North East London ICB. All rights reserved.
// ---------------------------------------------------------

using System.Collections.Generic;
using LondonFhirService.Providers.FHIR.R4.Abstractions.Services.Foundations;
using LondonFhirService.Providers.FHIR.R4.Abstractions.Tests.Unit.Models;
using Moq;

namespace LondonFhirService.Providers.FHIR.R4.Abstractions.Tests.Unit.Services.Foundations.Providers
{
    public partial class ProviderServiceTests
    {
        private readonly IEnumerable<IFhirProvider> fhirProviders;
        private readonly Mock<ProviderService> providerServiceMock;

        public ProviderServiceTests()
        {
            this.fhirProviders = new List<IFhirProvider>
            {
                new TestFhirProvider
                {
                    ProviderName = "ProviderA",
                },
                new TestFhirProvider
                {
                    ProviderName = "ProviderB",
                },
                new TestFhirProvider
                {
                    ProviderName = "ProviderC",
                }
            };

            this.providerServiceMock = new Mock<ProviderService>(this.fhirProviders)
            {
                CallBase = true
            };
        }
    }
}
