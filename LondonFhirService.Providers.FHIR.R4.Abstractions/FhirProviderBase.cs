// ---------------------------------------------------------
// Copyright (c) North East London ICB. All rights reserved.
// ---------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Hl7.Fhir.Rest;
using LondonFhirService.Providers.FHIR.R4.Abstractions.Models.Capabilities;
using LondonFhirService.Providers.FHIR.R4.Abstractions.Models.Resources;

namespace LondonFhirService.Providers.FHIR.R4.Abstractions
{
    /// <summary>
    /// Base class for concrete FHIR providers. By default, all resource properties return <c>null</c> and the
    /// <see cref="Capabilities"/> are computed via reflection from any non-null resource that implements
    /// <see cref="IResourceOperation{TResource}"/>.
    /// </summary>
    public abstract class FhirProviderBase : IFhirProvider
    {
        private ProviderCapabilities providerCapabilities;

        /// <summary>
        /// Gets the unique name used to identify the provider. Defaults to the full type name
        /// (namespace + class name).
        /// </summary>
        public virtual string ProviderName => GetType().FullName ?? GetType().Name;

        /// <summary>
        /// Gets the provider capabilities, including the set of supported resources. This is computed lazily
        /// by scanning all public instance properties that implement <see cref="IResourceOperation{TResource}"/>
        /// and are non-null, and then reading each instance’s <c>Capabilities</c> property.
        /// </summary>
        public ProviderCapabilities Capabilities => providerCapabilities ??= ComputeCapabilities();

        /// <summary>
        /// Computes the provider capabilities by reflecting over resource properties.
        /// </summary>
        /// <returns>The computed <see cref="ProviderCapabilities"/>.</returns>
        protected virtual ProviderCapabilities ComputeCapabilities()
        {
            var resourceCapabilities = new List<ResourceCapabilities>();

            var properties = GetType()
                .GetProperties(BindingFlags.Instance | BindingFlags.Public)
                .Where(property => property.GetMethod != null &&
                    ImplementsIResourceOperation(property.PropertyType));

            foreach (var property in properties)
            {
                var instance = property.GetValue(this);
                if (instance is null)
                    continue;

                if (TryGetResourceCapabilities(instance, out var implCaps))
                {
                    // IMPORTANT: Use the PROVIDER PROPERTY NAME for the resource name,
                    // but keep the supported operations from the implementation.
                    resourceCapabilities.Add(new ResourceCapabilities
                    {
                        ResourceName = property.Name,
                        SupportedOperations = implCaps.SupportedOperations
                    });
                }
            }

            var uniqueSorted = resourceCapabilities
                .Where(capability => capability is not null)
                .GroupBy(capability => capability.ResourceName, StringComparer.Ordinal)
                .Select(group => group.First())
                .OrderBy(capability => capability.ResourceName, StringComparer.Ordinal)
                .ToArray();

            return new ProviderCapabilities
            {
                ProviderName = ProviderName,
                SupportedResources = uniqueSorted
            };
        }

        /// <summary>
        /// Checks whether a type implements <see cref="IResourceOperation{TResource}"/> for any T.
        /// </summary>
        private static bool ImplementsIResourceOperation(Type type) =>
            type.GetInterfaces().Any(@interface =>
                @interface.IsGenericType && @interface.GetGenericTypeDefinition() == typeof(IResourceOperation<>));

        /// <summary>
        /// Attempts to read a <see cref="ResourceCapabilities"/> instance from the provided resource object by
        /// accessing its public <c>Capabilities</c> property.
        /// </summary>
        private static bool TryGetResourceCapabilities(
            object instance,
            out ResourceCapabilities capabilities)
        {
            var property = instance.GetType().GetProperty(
                name: "Capabilities",
                bindingAttr: BindingFlags.Public | BindingFlags.Instance);

            if (property != null && typeof(ResourceCapabilities).IsAssignableFrom(property.PropertyType))
            {
                var value = property.GetValue(instance);

                if (value is ResourceCapabilities resourceCapabilities)
                {
                    capabilities = resourceCapabilities;

                    return true;
                }
            }

            capabilities = default!;

            return false;
        }

        /// <summary>Access FHIR Account resources.</summary>
        public virtual IAccountResource Accounts => null!;

        /// <summary>Access FHIR ActivityDefinition resources.</summary>
        public virtual IActivityDefinitionResource ActivityDefinitions => null!;

        /// <summary>Access FHIR AdverseEvent resources.</summary>
        public virtual IAdverseEventResource AdverseEvents => null!;

        /// <summary>Access FHIR AllergyIntolerance resources.</summary>
        public virtual IAllergyIntoleranceResource AllergyIntolerances => null!;

        /// <summary>Access FHIR Appointment resources.</summary>
        public virtual IAppointmentResource Appointments => null!;

        /// <summary>Access FHIR AppointmentResponse resources.</summary>
        public virtual IAppointmentResponseResource AppointmentResponses => null!;

        /// <summary>Access FHIR AuditEvent resources.</summary>
        public virtual IAuditEventResource AuditEvents => null!;

        /// <summary>Access FHIR Basic resources.</summary>
        public virtual IBasicResource Basics => null!;

        /// <summary>Access FHIR Binary resources.</summary>
        public virtual IBinaryResource Binaries => null!;

        /// <summary>Access FHIR BiologicallyDerivedProduct resources.</summary>
        public virtual IBiologicallyDerivedProductResource BiologicallyDerivedProducts => null!;

        /// <summary>Access FHIR BodyStructure resources.</summary>
        public virtual IBodyStructureResource BodyStructures => null!;

        /// <summary>Access FHIR Bundle resources.</summary>
        public virtual IBundleResource Bundles => null!;

        /// <summary>Access FHIR CapabilityStatement resources.</summary>
        public virtual ICapabilityStatementResource CapabilityStatements => null!;

        /// <summary>Access FHIR CarePlan resources.</summary>
        public virtual ICarePlanResource CarePlans => null!;

        /// <summary>Access FHIR CareTeam resources.</summary>
        public virtual ICareTeamResource CareTeams => null!;

        /// <summary>Access FHIR CatalogEntry resources.</summary>
        public virtual ICatalogEntryResource CatalogEntries => null!;

        /// <summary>Access FHIR ChargeItem resources.</summary>
        public virtual IChargeItemResource ChargeItems => null!;

        /// <summary>Access FHIR ChargeItemDefinition resources.</summary>
        public virtual IChargeItemDefinitionResource ChargeItemDefinitions => null!;

        /// <summary>Access FHIR Claim resources.</summary>
        public virtual IClaimResource Claims => null!;

        /// <summary>Access FHIR ClaimResponse resources.</summary>
        public virtual IClaimResponseResource ClaimResponses => null!;

        /// <summary>Access FHIR ClinicalImpression resources.</summary>
        public virtual IClinicalImpressionResource ClinicalImpressions => null!;

        /// <summary>Access FHIR CodeSystem resources.</summary>
        public virtual ICodeSystemResource CodeSystems => null!;

        /// <summary>Access FHIR Communication resources.</summary>
        public virtual ICommunicationResource Communications => null!;

        /// <summary>Access FHIR CommunicationRequest resources.</summary>
        public virtual ICommunicationRequestResource CommunicationRequests => null!;

        /// <summary>Access FHIR CompartmentDefinition resources.</summary>
        public virtual ICompartmentDefinitionResource CompartmentDefinitions => null!;

        /// <summary>Access FHIR Composition resources.</summary>
        public virtual ICompositionResource Compositions => null!;

        /// <summary>Access FHIR ConceptMap resources.</summary>
        public virtual IConceptMapResource ConceptMaps => null!;

        /// <summary>Access FHIR Condition resources.</summary>
        public virtual IConditionResource Conditions => null!;

        /// <summary>Access FHIR Consent resources.</summary>
        public virtual IConsentResource Consents => null!;

        /// <summary>Access FHIR Contract resources.</summary>
        public virtual IContractResource Contracts => null!;

        /// <summary>Access FHIR Coverage resources.</summary>
        public virtual ICoverageResource Coverages => null!;

        /// <summary>Access FHIR CoverageEligibilityRequest resources.</summary>
        public virtual ICoverageEligibilityRequestResource CoverageEligibilityRequests => null!;

        /// <summary>Access FHIR CoverageEligibilityResponse resources.</summary>
        public virtual ICoverageEligibilityResponseResource CoverageEligibilityResponses => null!;

        /// <summary>Access FHIR DetectedIssue resources.</summary>
        public virtual IDetectedIssueResource DetectedIssues => null!;

        /// <summary>Access FHIR Device resources.</summary>
        public virtual IDeviceResource Devices => null!;

        /// <summary>Access FHIR DeviceDefinition resources.</summary>
        public virtual IDeviceDefinitionResource DeviceDefinitions => null!;

        /// <summary>Access FHIR DeviceMetric resources.</summary>
        public virtual IDeviceMetricResource DeviceMetrics => null!;

        /// <summary>Access FHIR DeviceRequest resources.</summary>
        public virtual IDeviceRequestResource DeviceRequests => null!;

        /// <summary>Access FHIR DeviceUseStatement resources.</summary>
        public virtual IDeviceUseStatementResource DeviceUseStatements => null!;

        /// <summary>Access FHIR DiagnosticReport resources.</summary>
        public virtual IDiagnosticReportResource DiagnosticReports => null!;

        /// <summary>Access FHIR DocumentManifest resources.</summary>
        public virtual IDocumentManifestResource DocumentManifests => null!;

        /// <summary>Access FHIR DocumentReference resources.</summary>
        public virtual IDocumentReferenceResource DocumentReferences => null!;

        /// <summary>Access FHIR EffectEvidenceSynthesis resources.</summary>
        public virtual IEffectEvidenceSynthesisResource EffectEvidenceSyntheses => null!;

        /// <summary>Access FHIR Encounter resources.</summary>
        public virtual IEncounterResource Encounters => null!;

        /// <summary>Access FHIR Endpoint resources.</summary>
        public virtual IEndpointResource Endpoints => null!;

        /// <summary>Access FHIR EnrollmentRequest resources.</summary>
        public virtual IEnrollmentRequestResource EnrollmentRequests => null!;

        /// <summary>Access FHIR EnrollmentResponse resources.</summary>
        public virtual IEnrollmentResponseResource EnrollmentResponses => null!;

        /// <summary>Access FHIR EpisodeOfCare resources.</summary>
        public virtual IEpisodeOfCareResource EpisodesOfCare => null!;

        /// <summary>Access FHIR EventDefinition resources.</summary>
        public virtual IEventDefinitionResource EventDefinitions => null!;

        /// <summary>Access FHIR Evidence resources.</summary>
        public virtual IEvidenceResource Evidences => null!;

        /// <summary>Access FHIR EvidenceVariable resources.</summary>
        public virtual IEvidenceVariableResource EvidenceVariables => null!;

        /// <summary>Access FHIR ExampleScenario resources.</summary>
        public virtual IExampleScenarioResource ExampleScenarios => null!;

        /// <summary>Access FHIR ExplanationOfBenefit resources.</summary>
        public virtual IExplanationOfBenefitResource ExplanationsOfBenefit => null!;

        /// <summary>Access FHIR FamilyMemberHistory resources.</summary>
        public virtual IFamilyMemberHistoryResource FamilyMemberHistories => null!;

        /// <summary>Access FHIR Flag resources.</summary>
        public virtual IFlagResource Flags => null!;

        /// <summary>Access FHIR Goal resources.</summary>
        public virtual IGoalResource Goals => null!;

        /// <summary>Access FHIR GraphDefinition resources.</summary>
        public virtual IGraphDefinitionResource GraphDefinitions => null!;

        /// <summary>Access FHIR Group resources.</summary>
        public virtual IGroupResource Groups => null!;

        /// <summary>Access FHIR GuidanceResponse resources.</summary>
        public virtual IGuidanceResponseResource GuidanceResponses => null!;

        /// <summary>Access FHIR HealthcareService resources.</summary>
        public virtual IHealthcareServiceResource HealthcareServices => null!;

        /// <summary>Access FHIR ImagingStudy resources.</summary>
        public virtual IImagingStudyResource ImagingStudies => null!;

        /// <summary>Access FHIR Immunization resources.</summary>
        public virtual IImmunizationResource Immunizations => null!;

        /// <summary>Access FHIR ImmunizationEvaluation resources.</summary>
        public virtual IImmunizationEvaluationResource ImmunizationEvaluations => null!;

        /// <summary>Access FHIR ImmunizationRecommendation resources.</summary>
        public virtual IImmunizationRecommendationResource ImmunizationRecommendations => null!;

        /// <summary>Access FHIR ImplementationGuide resources.</summary>
        public virtual IImplementationGuideResource ImplementationGuides => null!;

        /// <summary>Access FHIR InsurancePlan resources.</summary>
        public virtual IInsurancePlanResource InsurancePlans => null!;

        /// <summary>Access FHIR Invoice resources.</summary>
        public virtual IInvoiceResource Invoices => null!;

        /// <summary>Access FHIR Library resources.</summary>
        public virtual ILibraryResource Libraries => null!;

        /// <summary>Access FHIR Linkage resources.</summary>
        public virtual ILinkageResource Linkages => null!;

        /// <summary>Access FHIR List resources.</summary>
        public virtual IListResource Lists => null!;

        /// <summary>Access FHIR Location resources.</summary>
        public virtual ILocationResource Locations => null!;

        /// <summary>Access FHIR Measure resources.</summary>
        public virtual IMeasureResource Measures => null!;

        /// <summary>Access FHIR MeasureReport resources.</summary>
        public virtual IMeasureReportResource MeasureReports => null!;

        /// <summary>Access FHIR Media resources.</summary>
        public virtual IMediaResource Media => null!;

        /// <summary>Access FHIR Medication resources.</summary>
        public virtual IMedicationResource Medications => null!;

        /// <summary>Access FHIR MedicationAdministration resources.</summary>
        public virtual IMedicationAdministrationResource MedicationAdministrations => null!;

        /// <summary>Access FHIR MedicationDispense resources.</summary>
        public virtual IMedicationDispenseResource MedicationDispenses => null!;

        /// <summary>Access FHIR MedicationKnowledge resources.</summary>
        public virtual IMedicationKnowledgeResource MedicationKnowledge => null!;

        /// <summary>Access FHIR MedicationRequest resources.</summary>
        public virtual IMedicationRequestResource MedicationRequests => null!;

        /// <summary>Access FHIR MedicationStatement resources.</summary>
        public virtual IMedicationStatementResource MedicationStatements => null!;

        /// <summary>Access FHIR MedicinalProduct resources.</summary>
        public virtual IMedicinalProductResource MedicinalProducts => null!;

        /// <summary>Access FHIR MedicinalProductAuthorization resources.</summary>
        public virtual IMedicinalProductAuthorizationResource MedicinalProductAuthorizations => null!;

        /// <summary>Access FHIR MedicinalProductContraindication resources.</summary>
        public virtual IMedicinalProductContraindicationResource MedicinalProductContraindications => null!;

        /// <summary>Access FHIR MedicinalProductIndication resources.</summary>
        public virtual IMedicinalProductIndicationResource MedicinalProductIndications => null!;

        /// <summary>Access FHIR MedicinalProductIngredient resources.</summary>
        public virtual IMedicinalProductIngredientResource MedicinalProductIngredients => null!;

        /// <summary>Access FHIR MedicinalProductInteraction resources.</summary>
        public virtual IMedicinalProductInteractionResource MedicinalProductInteractions => null!;

        /// <summary>Access FHIR MedicinalProductManufactured resources.</summary>
        public virtual IMedicinalProductManufacturedResource MedicinalProductManufactureds => null!;

        /// <summary>Access FHIR MedicinalProductPackaged resources.</summary>
        public virtual IMedicinalProductPackagedResource MedicinalProductPackageds => null!;

        /// <summary>Access FHIR MedicinalProductPharmaceutical resources.</summary>
        public virtual IMedicinalProductPharmaceuticalResource MedicinalProductPharmaceuticals => null!;

        /// <summary>Access FHIR MedicinalProductUndesirableEffect resources.</summary>
        public virtual IMedicinalProductUndesirableEffectResource
            MedicinalProductUndesirableEffects => null!;

        /// <summary>Access FHIR MessageDefinition resources.</summary>
        public virtual IMessageDefinitionResource MessageDefinitions => null!;

        /// <summary>Access FHIR MessageHeader resources.</summary>
        public virtual IMessageHeaderResource MessageHeaders => null!;

        /// <summary>Access FHIR MolecularSequence resources.</summary>
        public virtual IMolecularSequenceResource MolecularSequences => null!;

        /// <summary>Access FHIR NamingSystem resources.</summary>
        public virtual INamingSystemResource NamingSystems => null!;

        /// <summary>Access FHIR NutritionOrder resources.</summary>
        public virtual INutritionOrderResource NutritionOrders => null!;

        /// <summary>Access FHIR Observation resources.</summary>
        public virtual IObservationResource Observations => null!;

        /// <summary>Access FHIR ObservationDefinition resources.</summary>
        public virtual IObservationDefinitionResource ObservationDefinitions => null!;

        /// <summary>Access FHIR OperationDefinition resources.</summary>
        public virtual IOperationDefinitionResource OperationDefinitions => null!;

        /// <summary>Access FHIR OperationOutcome resources.</summary>
        public virtual IOperationOutcomeResource OperationOutcomes => null!;

        /// <summary>Access FHIR Organization resources.</summary>
        public virtual IOrganizationResource Organizations => null!;

        /// <summary>Access FHIR OrganizationAffiliation resources.</summary>
        public virtual IOrganizationAffiliationResource OrganizationAffiliations => null!;

        /// <summary>Access FHIR Parameters resources.</summary>
        public virtual IParametersResource Parameters => null!;

        /// <summary>Access FHIR Patient resources.</summary>
        public virtual IPatientResource Patients => null!;

        /// <summary>Access FHIR PaymentNotice resources.</summary>
        public virtual IPaymentNoticeResource PaymentNotices => null!;

        /// <summary>Access FHIR PaymentReconciliation resources.</summary>
        public virtual IPaymentReconciliationResource PaymentReconciliations => null!;

        /// <summary>Access FHIR Person resources.</summary>
        public virtual IPersonResource Persons => null!;

        /// <summary>Access FHIR PlanDefinition resources.</summary>
        public virtual IPlanDefinitionResource PlanDefinitions => null!;

        /// <summary>Access FHIR Practitioner resources.</summary>
        public virtual IPractitionerResource Practitioners => null!;

        /// <summary>Access FHIR PractitionerRole resources.</summary>
        public virtual IPractitionerRoleResource PractitionerRoles => null!;

        /// <summary>Access FHIR Procedure resources.</summary>
        public virtual IProcedureResource Procedures => null!;

        /// <summary>Access FHIR Provenance resources.</summary>
        public virtual IProvenanceResource Provenances => null!;

        /// <summary>Access FHIR Questionnaire resources.</summary>
        public virtual IQuestionnaireResource Questionnaires => null!;

        /// <summary>Access FHIR QuestionnaireResponse resources.</summary>
        public virtual IQuestionnaireResponseResource QuestionnaireResponses => null!;

        /// <summary>Access FHIR RelatedPerson resources.</summary>
        public virtual IRelatedPersonResource RelatedPersons => null!;

        /// <summary>Access FHIR RequestGroup resources.</summary>
        public virtual IRequestGroupResource RequestGroups => null!;

        /// <summary>Access FHIR ResearchDefinition resources.</summary>
        public virtual IResearchDefinitionResource ResearchDefinitions => null!;

        /// <summary>Access FHIR ResearchElementDefinition resources.</summary>
        public virtual IResearchElementDefinitionResource ResearchElementDefinitions => null!;

        /// <summary>Access FHIR ResearchStudy resources.</summary>
        public virtual IResearchStudyResource ResearchStudies => null!;

        /// <summary>Access FHIR ResearchSubject resources.</summary>
        public virtual IResearchSubjectResource ResearchSubjects => null!;

        /// <summary>Access FHIR RiskAssessment resources.</summary>
        public virtual IRiskAssessmentResource RiskAssessments => null!;

        /// <summary>Access FHIR RiskEvidenceSynthesis resources.</summary>
        public virtual IRiskEvidenceSynthesisResource RiskEvidenceSyntheses => null!;

        /// <summary>Access FHIR Schedule resources.</summary>
        public virtual IScheduleResource Schedules => null!;

        /// <summary>Access FHIR SearchParameter resources.</summary>
        public virtual ISearchParameterResource SearchParameters => null!;

        /// <summary>Access FHIR ServiceRequest resources.</summary>
        public virtual IServiceRequestResource ServiceRequests => null!;

        /// <summary>Access FHIR Slot resources.</summary>
        public virtual ISlotResource Slots => null!;

        /// <summary>Access FHIR Specimen resources.</summary>
        public virtual ISpecimenResource Specimens => null!;

        /// <summary>Access FHIR SpecimenDefinition resources.</summary>
        public virtual ISpecimenDefinitionResource SpecimenDefinitions => null!;

        /// <summary>Access FHIR StructureDefinition resources.</summary>
        public virtual IStructureDefinitionResource StructureDefinitions => null!;

        /// <summary>Access FHIR StructureMap resources.</summary>
        public virtual IStructureMapResource StructureMaps => null!;

        /// <summary>Access FHIR Subscription resources.</summary>
        public virtual ISubscriptionResource Subscriptions => null!;

        /// <summary>Access FHIR Substance resources.</summary>
        public virtual ISubstanceResource Substances => null!;

        /// <summary>Access FHIR SubstanceNucleicAcid resources.</summary>
        public virtual ISubstanceNucleicAcidResource SubstanceNucleicAcids => null!;

        /// <summary>Access FHIR SubstancePolymer resources.</summary>
        public virtual ISubstancePolymerResource SubstancePolymers => null!;

        /// <summary>Access FHIR SubstanceProtein resources.</summary>
        public virtual ISubstanceProteinResource SubstanceProteins => null!;

        /// <summary>Access FHIR SubstanceReferenceInformation resources.</summary>
        public virtual ISubstanceReferenceInformationResource
            SubstanceReferenceInformations => null!;

        /// <summary>Access FHIR SubstanceSourceMaterial resources.</summary>
        public virtual ISubstanceSourceMaterialResource SubstanceSourceMaterials => null!;

        /// <summary>Access FHIR SubstanceSpecification resources.</summary>
        public virtual ISubstanceSpecificationResource SubstanceSpecifications => null!;

        /// <summary>Access FHIR SupplyDelivery resources.</summary>
        public virtual ISupplyDeliveryResource SupplyDeliveries => null!;

        /// <summary>Access FHIR SupplyRequest resources.</summary>
        public virtual ISupplyRequestResource SupplyRequests => null!;

        /// <summary>Access FHIR Task resources.</summary>
        public virtual ITaskResource Tasks => null!;

        /// <summary>Access FHIR TerminologyCapabilities resources.</summary>
        public virtual ITerminologyCapabilitiesResource TerminologyCapabilities => null!;

        /// <summary>Access FHIR TestReport resources.</summary>
        public virtual ITestReportResource TestReports => null!;

        /// <summary>Access FHIR TestScript resources.</summary>
        public virtual ITestScriptResource TestScripts => null!;

        /// <summary>Access FHIR ValueSet resources.</summary>
        public virtual IValueSetResource ValueSets => null!;

        /// <summary>Access FHIR VerificationResult resources.</summary>
        public virtual IVerificationResultResource VerificationResults => null!;

        /// <summary>Access FHIR VisionPrescription resources.</summary>
        public virtual IVisionPrescriptionResource VisionPrescriptions => null!;
    }
}
