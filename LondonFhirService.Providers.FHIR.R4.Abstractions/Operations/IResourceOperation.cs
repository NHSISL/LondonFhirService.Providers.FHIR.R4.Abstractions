// ---------------------------------------------------------
// Copyright (c) North East London ICB. All rights reserved.
// ---------------------------------------------------------

using System;
using Hl7.Fhir.Model;
using Hl7.Fhir.Rest;

namespace LondonFhirService.Providers.FHIR.R4.Abstractions.Operations
{
    /// <summary>
    /// Canonical FHIR REST surface for a resource type.
    /// </summary>
    /// <typeparam name="TResource">FHIR resource type (R4).</typeparam>
    public interface IResourceOperation<TResource> where TResource : Resource
    {
        TResource Read(string id);
        TResource VRead(string id, string versionId);
        Bundle HistoryInstance(string id, DateTimeOffset? since = null, int? count = null);
        Bundle Search(SearchParams @params);
        Bundle HistoryType(DateTimeOffset? since = null, int? count = null);
        Bundle HistorySystem(DateTimeOffset? since = null, int? count = null);
        TResource Create(TResource resource);
        TResource Update(TResource resource);
        TResource Patch(string id, Parameters patchParameters);
        OperationOutcome Delete(string id);
    }
}
