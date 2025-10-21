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
        public async Task ShouldThrowServiceExceptionOnGetProviderByNameAsync()
        {
            // given
            IEnumerable<IFhirProvider> nullFhirProvider = null;
            string randomProviderName = GetRandomString();
            string inputProviderName = randomProviderName;

            string randomMessage = GetRandomString();
            var serviceException = new Exception(message: randomMessage);

            var providerServiceMock = new Mock<ProviderService>(nullFhirProvider)
            {
                CallBase = true
            };

            var failedProviderServiceException =
                new FailedProviderServiceException(
                    message: "Failed provider service occurred, please contact support",
                    innerException: serviceException);

            var expectedProviderServiceException =
                new ProviderServiceException(
                    message: "Provider validation errors occurred, please try again.",
                    innerException: failedProviderServiceException);

            // when
            Action getProviderByNameAction = () =>
                providerServiceMock.Object.GetProviderByName(inputProviderName);

            ProviderServiceException actualProviderServiceException =
                Assert.Throws<ProviderServiceException>(getProviderByNameAction);

            // then
            actualProviderServiceException.Should()
                .BeEquivalentTo(expectedProviderServiceException);

            providerServiceMock.VerifyNoOtherCalls();
        }
    }
}
