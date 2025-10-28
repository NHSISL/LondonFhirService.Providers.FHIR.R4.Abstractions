// ---------------------------------------------------------
// Copyright (c) North East London ICB. All rights reserved.
// ---------------------------------------------------------

using System;
using System.Collections.Generic;

namespace LondonFhirService.Providers.FHIR.R4.Abstractions.Models.Capabilities
{
    /// <summary>
    /// Capabilities for a single resource (e.g., Patient).
    /// </summary>
    public sealed class ResourceCapabilities
    {
        /// <summary>The canonical FHIR resource name, e.g. "Patient".</summary>
        public string ResourceName { get; init; } = string.Empty;

        /// <summary>The operations implemented on this resource.</summary>
        public IReadOnlyCollection<string> SupportedOperations { get; init; } = Array.Empty<string>();
    }
}
