// ---------------------------------------------------------
// Copyright (c) North East London ICB. All rights reserved.
// ---------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using FluentAssertions;
using LondonFhirService.Providers.FHIR.R4.Abstractions.Models.Foundations.Providers.Exceptions;
using LondonFhirService.Providers.FHIR.R4.Abstractions.Services.Foundations;
using Moq;

namespace LondonFhirService.Providers.FHIR.R4.Abstractions.Tests.Unit.Services.Foundations.Providers
{
    public partial class ProviderServiceTests
    {
        [Fact]
        public async Task ShouldThrowValidationExceptionOnGetProviderByName()
        {
            // given
            IEnumerable<IFhirProvider> nullFhirProvider = null;
            string randomProviderName = GetRandomString();
            string inputProviderName = randomProviderName;

            var providerServiceMock = new Mock<ProviderService>(nullFhirProvider)
            {
                CallBase = true
            };

            var nullProviderServiceException =
                new NullProviderServiceException(message: "Provider is null.");

            var expectedProviderServiceValidationException =
                new ProviderServiceValidationException(
                    message: "Provider validation errors occurred, please try again.",
                    innerException: nullProviderServiceException);

            // when
            Action getProviderByNameAction = () =>
                providerServiceMock.Object.GetProviderByName(inputProviderName);

            ProviderServiceValidationException actualProviderServiceValidationException =
                Assert.Throws<ProviderServiceValidationException>(getProviderByNameAction);

            // then
            actualProviderServiceValidationException.Should().BeEquivalentTo(expectedProviderServiceValidationException);
            providerServiceMock.VerifyNoOtherCalls();
        }
    }
}
