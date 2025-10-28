// ---------------------------------------------------------
// Copyright (c) North East London ICB. All rights reserved.
// ---------------------------------------------------------

using System;
using System.Collections.Generic;

namespace LondonFhirService.Providers.FHIR.R4.Abstractions.Models.Capabilities
{
    /// <summary>
    /// Capabilities for a single provider.
    /// </summary>
    public sealed class ProviderCapabilities
    {
        /// <summary>
        /// The canonical FHIR provider name (for example, "LondonFhirService.Providers.FHIR.R4").
        /// </summary>
        public string ResourceName { get; init; } = string.Empty;

        /// <summary>
        /// The resources implemented on this provider.
        /// </summary>
        public IReadOnlyCollection<string> SupportedResources { get; init; } = Array.Empty<string>();
    }
}
