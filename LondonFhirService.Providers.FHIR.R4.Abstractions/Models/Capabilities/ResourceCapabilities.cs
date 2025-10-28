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
        /// <summary>
        /// The canonical FHIR resource name (for example, "Patient").
        /// </summary>
        public string ResourceName { get; init; } = string.Empty;

        /// <summary>
        /// The operations implemented on this resource. Standard methods appear when overridden on the base
        /// resource class. Non-standard operations appear when decorated with <see cref="FhirOperationAttribute"/>.
        /// </summary>

        public IReadOnlyCollection<string> SupportedOperations { get; init; } = Array.Empty<string>();
    }
}
