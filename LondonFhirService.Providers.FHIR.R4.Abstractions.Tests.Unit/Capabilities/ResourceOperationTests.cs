// ---------------------------------------------------------
// Copyright (c) North East London ICB. All rights reserved.
// ---------------------------------------------------------

using System.Linq;
using FluentAssertions;
using LondonFhirService.Providers.FHIR.R4.Abstractions.Tests.Unit.Models;
using Xunit.Abstractions;

namespace LondonFhirService.Providers.FHIR.R4.Abstractions.Tests.Unit.Capabilities
{
    public partial class ResourceOperationTests
    {
        ITestOutputHelper output;

        public ResourceOperationTests(ITestOutputHelper output)
        {
            this.output = output;
        }

        [Fact]
        public void CapabilitiesShouldContainOnlyEverything()
        {
            // given
            var resource = new PatientResource();

            // when
            var capabilities = resource.Capabilities;

            // then
            output.WriteLine($"Resource Name: {capabilities.ResourceName}");
            output.WriteLine($"Supported Operations: {capabilities.ResourceName}");

            foreach (var operation in capabilities.SupportedOperations)
            {
                output.WriteLine($"- {operation}");
            }

            capabilities.ResourceName.Should().Be("Patient");
            var operations = capabilities.SupportedOperations.ToArray();
            operations.Single();
            operations.Contains("Everything");
        }
    }
}
