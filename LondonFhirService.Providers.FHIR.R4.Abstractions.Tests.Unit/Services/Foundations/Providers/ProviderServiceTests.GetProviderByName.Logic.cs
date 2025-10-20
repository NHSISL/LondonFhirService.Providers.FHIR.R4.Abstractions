// ---------------------------------------------------------
// Copyright (c) North East London ICB. All rights reserved.
// ---------------------------------------------------------

using System.Linq;
using FluentAssertions;
using Force.DeepCloner;

namespace LondonFhirService.Providers.FHIR.R4.Abstractions.Tests.Unit.Services.Foundations.Providers
{
    public partial class ProviderServiceTests
    {
        [Fact]
        public void ShouldGetProviderByName()
        {
            // given
            IFhirProvider provider = fhirProviders.First();
            IFhirProvider expectedProvider = provider.DeepClone();

            // when
            IFhirProvider actualProvider =
                providerServiceMock.Object.GetProviderByName(provider.ProviderName);

            // then
            actualProvider.ProviderName.Should().BeEquivalentTo(expectedProvider.ProviderName);
        }
    }
}
