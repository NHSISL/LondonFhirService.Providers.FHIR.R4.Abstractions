// ---------------------------------------------------------
// Copyright (c) North East London ICB. All rights reserved.
// ---------------------------------------------------------

using LondonFhirService.Providers.FHIR.R4.Abstractions.Extensions;
using LondonFhirService.Providers.FHIR.R4.Abstractions.Tests.Unit.Models;
using Xunit.Abstractions;


namespace LondonFhirService.Providers.FHIR.R4.Abstractions.Tests.Unit.Extensions
{
    public class FhirProviderGuardsTests
    {
        ITestOutputHelper output;

        public FhirProviderGuardsTests(ITestOutputHelper output)
        {
            this.output = output;
        }

        [Fact]
        public void SupportsResourceReturnsTrueForPatient()
        {
            // given
            var provider = new TestFhirProvider();
            OutputCapabilities(provider);

            // when
            bool result = provider.SupportsResource("Patients");

            // then
            Assert.True(result);
        }

        [Fact]
        public void SupportsResourceReturnsFalseForUnknownResource()
        {
            // given
            var provider = new TestFhirProvider();
            OutputCapabilities(provider);

            // when
            bool result = provider.SupportsResource("Observations");

            // then
            Assert.False(result);
        }

        [Fact]
        public void SupportsResourceWithOperationReturnsTrueForPatientEverything()
        {
            // given
            var provider = new TestFhirProvider();
            OutputCapabilities(provider);

            // when
            bool result = provider.SupportsResource("Patients", "Everything");

            // then
            Assert.True(result);
        }

        [Theory]
        [InlineData("Patient", "Read")]
        [InlineData("Patient", "Search")]
        [InlineData("Patient", "Match")]
        public void SupportsResourceWithOperationReturnsFalseForUnsupportedOperations(string resource, string operation)
        {
            // given
            var provider = new TestFhirProvider();
            OutputCapabilities(provider);

            // when
            bool result = provider.SupportsResource(resource, operation);

            // then
            Assert.False(result);
        }

        [Fact]
        public void SupportsOperationOnResourceReturnsTrueForEverything()
        {
            // given
            var provider = new TestFhirProvider();
            OutputCapabilities(provider);
            var patientOps = provider.Patients;

            // when
            bool result = patientOps.SupportsOperation("Everything");

            // then
            Assert.True(result);
        }

        [Theory]
        [InlineData("Read")]
        [InlineData("Search")]
        [InlineData("Match")]
        public void SupportsOperationOnResourceReturnsFalseForUnsupportedOperations(string operation)
        {
            // given
            var provider = new TestFhirProvider();
            OutputCapabilities(provider);
            var patientOps = provider.Patients;

            // when
            bool result = patientOps.SupportsOperation(operation);

            // then
            Assert.False(result);
        }

        private void OutputCapabilities(TestFhirProvider provider)
        {
            output.WriteLine($"Provider Name: {provider.Capabilities.ProviderName}");
            output.WriteLine("   - Supported Resources:");

            foreach (var resource in provider.Capabilities.SupportedResources)
            {
                output.WriteLine($"      - {resource.ResourceName}");
                output.WriteLine($"         - Supported Operations:");
                foreach (var operation in resource.SupportedOperations)
                {
                    output.WriteLine($"            - {operation}");
                }
                output.WriteLine("");
            }
        }
    }
}
