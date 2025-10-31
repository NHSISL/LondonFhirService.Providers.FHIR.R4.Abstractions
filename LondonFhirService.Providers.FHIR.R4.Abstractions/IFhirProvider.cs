// ---------------------------------------------------------
// Copyright (c) North East London ICB. All rights reserved.
// ---------------------------------------------------------

using LondonFhirService.Providers.FHIR.R4.Abstractions.Models.Capabilities;
using LondonFhirService.Providers.FHIR.R4.Abstractions.Models.Resources;

namespace LondonFhirService.Providers.FHIR.R4.Abstractions
{
    public interface IFhirProvider
    {
        /// <summary>Gets the unique name used to identify the provider.</summary>
        string ProviderName { get; }

        /// <summary>
        /// Gets the canonical source URI for the provider. This value is placed in Bundle.meta.source to
        /// indicate the origin system of the resources.
        /// </summary>
        string Source { get; }

        /// <summary>
        /// Gets the short code representing this provider. This value is placed in Bundle.meta.tag.code
        /// for quick filtering and grouping of Bundles.
        /// </summary>
        string Code { get; }

        /// <summary>
        /// Gets the CodeSystem URI that defines the namespace for provider codes. This value is placed
        /// in Bundle.meta.tag.system alongside the Code.
        /// </summary>
        string System { get; }

        /// <summary>
        /// Gets the capability statement for this provider. Describes which FHIR resources and operations
        /// are supported, enabling discovery and validation of provider functionality at runtime.
        /// </summary>
        ProviderCapabilities Capabilities { get; }

        /// <summary>Access FHIR Account resources.</summary>
        IAccountResource Accounts { get; }

        /// <summary>Access FHIR ActivityDefinition resources.</summary>
        IActivityDefinitionResource ActivityDefinitions { get; }

        /// <summary>Access FHIR AdverseEvent resources.</summary>
        IAdverseEventResource AdverseEvents { get; }

        /// <summary>Access FHIR AllergyIntolerance resources.</summary>
        IAllergyIntoleranceResource AllergyIntolerances { get; }

        /// <summary>Access FHIR Appointment resources.</summary>
        IAppointmentResource Appointments { get; }

        /// <summary>Access FHIR AppointmentResponse resources.</summary>
        IAppointmentResponseResource AppointmentResponses { get; }

        /// <summary>Access FHIR AuditEvent resources.</summary>
        IAuditEventResource AuditEvents { get; }

        /// <summary>Access FHIR Basic resources.</summary>
        IBasicResource Basics { get; }

        /// <summary>Access FHIR Binary resources.</summary>
        IBinaryResource Binaries { get; }

        /// <summary>Access FHIR BiologicallyDerivedProduct resources.</summary>
        IBiologicallyDerivedProductResource BiologicallyDerivedProducts { get; }

        /// <summary>Access FHIR BodyStructure resources.</summary>
        IBodyStructureResource BodyStructures { get; }

        /// <summary>Access FHIR Bundle resources.</summary>
        IBundleResource Bundles { get; }

        /// <summary>Access FHIR CapabilityStatement resources.</summary>
        ICapabilityStatementResource CapabilityStatements { get; }

        /// <summary>Access FHIR CarePlan resources.</summary>
        ICarePlanResource CarePlans { get; }

        /// <summary>Access FHIR CareTeam resources.</summary>
        ICareTeamResource CareTeams { get; }

        /// <summary>Access FHIR CatalogEntry resources.</summary>
        ICatalogEntryResource CatalogEntries { get; }

        /// <summary>Access FHIR ChargeItem resources.</summary>
        IChargeItemResource ChargeItems { get; }

        /// <summary>Access FHIR ChargeItemDefinition resources.</summary>
        IChargeItemDefinitionResource ChargeItemDefinitions { get; }

        /// <summary>Access FHIR Claim resources.</summary>
        IClaimResource Claims { get; }

        /// <summary>Access FHIR ClaimResponse resources.</summary>
        IClaimResponseResource ClaimResponses { get; }

        /// <summary>Access FHIR ClinicalImpression resources.</summary>
        IClinicalImpressionResource ClinicalImpressions { get; }

        /// <summary>Access FHIR CodeSystem resources.</summary>
        ICodeSystemResource CodeSystems { get; }

        /// <summary>Access FHIR Communication resources.</summary>
        ICommunicationResource Communications { get; }

        /// <summary>Access FHIR CommunicationRequest resources.</summary>
        ICommunicationRequestResource CommunicationRequests { get; }

        /// <summary>Access FHIR CompartmentDefinition resources.</summary>
        ICompartmentDefinitionResource CompartmentDefinitions { get; }

        /// <summary>Access FHIR Composition resources.</summary>
        ICompositionResource Compositions { get; }

        /// <summary>Access FHIR ConceptMap resources.</summary>
        IConceptMapResource ConceptMaps { get; }

        /// <summary>Access FHIR Condition resources.</summary>
        IConditionResource Conditions { get; }

        /// <summary>Access FHIR Consent resources.</summary>
        IConsentResource Consents { get; }

        /// <summary>Access FHIR Contract resources.</summary>
        IContractResource Contracts { get; }

        /// <summary>Access FHIR Coverage resources.</summary>
        ICoverageResource Coverages { get; }

        /// <summary>Access FHIR CoverageEligibilityRequest resources.</summary>
        ICoverageEligibilityRequestResource CoverageEligibilityRequests { get; }

        /// <summary>Access FHIR CoverageEligibilityResponse resources.</summary>
        ICoverageEligibilityResponseResource CoverageEligibilityResponses { get; }

        /// <summary>Access FHIR DetectedIssue resources.</summary>
        IDetectedIssueResource DetectedIssues { get; }

        /// <summary>Access FHIR Device resources.</summary>
        IDeviceResource Devices { get; }

        /// <summary>Access FHIR DeviceDefinition resources.</summary>
        IDeviceDefinitionResource DeviceDefinitions { get; }

        /// <summary>Access FHIR DeviceMetric resources.</summary>
        IDeviceMetricResource DeviceMetrics { get; }

        /// <summary>Access FHIR DeviceRequest resources.</summary>
        IDeviceRequestResource DeviceRequests { get; }

        /// <summary>Access FHIR DeviceUseStatement resources.</summary>
        IDeviceUseStatementResource DeviceUseStatements { get; }

        /// <summary>Access FHIR DiagnosticReport resources.</summary>
        IDiagnosticReportResource DiagnosticReports { get; }

        /// <summary>Access FHIR DocumentManifest resources.</summary>
        IDocumentManifestResource DocumentManifests { get; }

        /// <summary>Access FHIR DocumentReference resources.</summary>
        IDocumentReferenceResource DocumentReferences { get; }

        /// <summary>Access FHIR EffectEvidenceSynthesis resources.</summary>
        IEffectEvidenceSynthesisResource EffectEvidenceSyntheses { get; }

        /// <summary>Access FHIR Encounter resources.</summary>
        IEncounterResource Encounters { get; }

        /// <summary>Access FHIR Endpoint resources.</summary>
        IEndpointResource Endpoints { get; }

        /// <summary>Access FHIR EnrollmentRequest resources.</summary>
        IEnrollmentRequestResource EnrollmentRequests { get; }

        /// <summary>Access FHIR EnrollmentResponse resources.</summary>
        IEnrollmentResponseResource EnrollmentResponses { get; }

        /// <summary>Access FHIR EpisodeOfCare resources.</summary>
        IEpisodeOfCareResource EpisodesOfCare { get; }

        /// <summary>Access FHIR EventDefinition resources.</summary>
        IEventDefinitionResource EventDefinitions { get; }

        /// <summary>Access FHIR Evidence resources.</summary>
        IEvidenceResource Evidences { get; }

        /// <summary>Access FHIR EvidenceVariable resources.</summary>
        IEvidenceVariableResource EvidenceVariables { get; }

        /// <summary>Access FHIR ExampleScenario resources.</summary>
        IExampleScenarioResource ExampleScenarios { get; }

        /// <summary>Access FHIR ExplanationOfBenefit resources.</summary>
        IExplanationOfBenefitResource ExplanationsOfBenefit { get; }

        /// <summary>Access FHIR FamilyMemberHistory resources.</summary>
        IFamilyMemberHistoryResource FamilyMemberHistories { get; }

        /// <summary>Access FHIR Flag resources.</summary>
        IFlagResource Flags { get; }

        /// <summary>Access FHIR Goal resources.</summary>
        IGoalResource Goals { get; }

        /// <summary>Access FHIR GraphDefinition resources.</summary>
        IGraphDefinitionResource GraphDefinitions { get; }

        /// <summary>Access FHIR Group resources.</summary>
        IGroupResource Groups { get; }

        /// <summary>Access FHIR GuidanceResponse resources.</summary>
        IGuidanceResponseResource GuidanceResponses { get; }

        /// <summary>Access FHIR HealthcareService resources.</summary>
        IHealthcareServiceResource HealthcareServices { get; }

        /// <summary>Access FHIR ImagingStudy resources.</summary>
        IImagingStudyResource ImagingStudies { get; }

        /// <summary>Access FHIR Immunization resources.</summary>
        IImmunizationResource Immunizations { get; }

        /// <summary>Access FHIR ImmunizationEvaluation resources.</summary>
        IImmunizationEvaluationResource ImmunizationEvaluations { get; }

        /// <summary>Access FHIR ImmunizationRecommendation resources.</summary>
        IImmunizationRecommendationResource ImmunizationRecommendations { get; }

        /// <summary>Access FHIR ImplementationGuide resources.</summary>
        IImplementationGuideResource ImplementationGuides { get; }

        /// <summary>Access FHIR InsurancePlan resources.</summary>
        IInsurancePlanResource InsurancePlans { get; }

        /// <summary>Access FHIR Invoice resources.</summary>
        IInvoiceResource Invoices { get; }

        /// <summary>Access FHIR Library resources.</summary>
        ILibraryResource Libraries { get; }

        /// <summary>Access FHIR Linkage resources.</summary>
        ILinkageResource Linkages { get; }

        /// <summary>Access FHIR List resources.</summary>
        IListResource Lists { get; }

        /// <summary>Access FHIR Location resources.</summary>
        ILocationResource Locations { get; }

        /// <summary>Access FHIR Measure resources.</summary>
        IMeasureResource Measures { get; }

        /// <summary>Access FHIR MeasureReport resources.</summary>
        IMeasureReportResource MeasureReports { get; }

        /// <summary>Access FHIR Media resources.</summary>
        IMediaResource Media { get; }

        /// <summary>Access FHIR Medication resources.</summary>
        IMedicationResource Medications { get; }

        /// <summary>Access FHIR MedicationAdministration resources.</summary>
        IMedicationAdministrationResource MedicationAdministrations { get; }

        /// <summary>Access FHIR MedicationDispense resources.</summary>
        IMedicationDispenseResource MedicationDispenses { get; }

        /// <summary>Access FHIR MedicationKnowledge resources.</summary>
        IMedicationKnowledgeResource MedicationKnowledge { get; }

        /// <summary>Access FHIR MedicationRequest resources.</summary>
        IMedicationRequestResource MedicationRequests { get; }

        /// <summary>Access FHIR MedicationStatement resources.</summary>
        IMedicationStatementResource MedicationStatements { get; }

        /// <summary>Access FHIR MedicinalProduct resources.</summary>
        IMedicinalProductResource MedicinalProducts { get; }

        /// <summary>Access FHIR MedicinalProductAuthorization resources.</summary>
        IMedicinalProductAuthorizationResource MedicinalProductAuthorizations { get; }

        /// <summary>Access FHIR MedicinalProductContraindication resources.</summary>
        IMedicinalProductContraindicationResource MedicinalProductContraindications { get; }

        /// <summary>Access FHIR MedicinalProductIndication resources.</summary>
        IMedicinalProductIndicationResource MedicinalProductIndications { get; }

        /// <summary>Access FHIR MedicinalProductIngredient resources.</summary>
        IMedicinalProductIngredientResource MedicinalProductIngredients { get; }

        /// <summary>Access FHIR MedicinalProductInteraction resources.</summary>
        IMedicinalProductInteractionResource MedicinalProductInteractions { get; }

        /// <summary>Access FHIR MedicinalProductManufactured resources.</summary>
        IMedicinalProductManufacturedResource MedicinalProductManufactureds { get; }

        /// <summary>Access FHIR MedicinalProductPackaged resources.</summary>
        IMedicinalProductPackagedResource MedicinalProductPackageds { get; }

        /// <summary>Access FHIR MedicinalProductPharmaceutical resources.</summary>
        IMedicinalProductPharmaceuticalResource MedicinalProductPharmaceuticals { get; }

        /// <summary>Access FHIR MedicinalProductUndesirableEffect resources.</summary>
        IMedicinalProductUndesirableEffectResource MedicinalProductUndesirableEffects { get; }

        /// <summary>Access FHIR MessageDefinition resources.</summary>
        IMessageDefinitionResource MessageDefinitions { get; }

        /// <summary>Access FHIR MessageHeader resources.</summary>
        IMessageHeaderResource MessageHeaders { get; }

        /// <summary>Access FHIR MolecularSequence resources.</summary>
        IMolecularSequenceResource MolecularSequences { get; }

        /// <summary>Access FHIR NamingSystem resources.</summary>
        INamingSystemResource NamingSystems { get; }

        /// <summary>Access FHIR NutritionOrder resources.</summary>
        INutritionOrderResource NutritionOrders { get; }

        /// <summary>Access FHIR Observation resources.</summary>
        IObservationResource Observations { get; }

        /// <summary>Access FHIR ObservationDefinition resources.</summary>
        IObservationDefinitionResource ObservationDefinitions { get; }

        /// <summary>Access FHIR OperationDefinition resources.</summary>
        IOperationDefinitionResource OperationDefinitions { get; }

        /// <summary>Access FHIR OperationOutcome resources.</summary>
        IOperationOutcomeResource OperationOutcomes { get; }

        /// <summary>Access FHIR Organization resources.</summary>
        IOrganizationResource Organizations { get; }

        /// <summary>Access FHIR OrganizationAffiliation resources.</summary>
        IOrganizationAffiliationResource OrganizationAffiliations { get; }

        /// <summary>Access FHIR Parameters resources.</summary>
        IParametersResource Parameters { get; }

        /// <summary>Access FHIR Patient resources.</summary>
        IPatientResource Patients { get; }

        /// <summary>Access FHIR PaymentNotice resources.</summary>
        IPaymentNoticeResource PaymentNotices { get; }

        /// <summary>Access FHIR PaymentReconciliation resources.</summary>
        IPaymentReconciliationResource PaymentReconciliations { get; }

        /// <summary>Access FHIR Person resources.</summary>
        IPersonResource Persons { get; }

        /// <summary>Access FHIR PlanDefinition resources.</summary>
        IPlanDefinitionResource PlanDefinitions { get; }

        /// <summary>Access FHIR Practitioner resources.</summary>
        IPractitionerResource Practitioners { get; }

        /// <summary>Access FHIR PractitionerRole resources.</summary>
        IPractitionerRoleResource PractitionerRoles { get; }

        /// <summary>Access FHIR Procedure resources.</summary>
        IProcedureResource Procedures { get; }

        /// <summary>Access FHIR Provenance resources.</summary>
        IProvenanceResource Provenances { get; }

        /// <summary>Access FHIR Questionnaire resources.</summary>
        IQuestionnaireResource Questionnaires { get; }

        /// <summary>Access FHIR QuestionnaireResponse resources.</summary>
        IQuestionnaireResponseResource QuestionnaireResponses { get; }

        /// <summary>Access FHIR RelatedPerson resources.</summary>
        IRelatedPersonResource RelatedPersons { get; }

        /// <summary>Access FHIR RequestGroup resources.</summary>
        IRequestGroupResource RequestGroups { get; }

        /// <summary>Access FHIR ResearchDefinition resources.</summary>
        IResearchDefinitionResource ResearchDefinitions { get; }

        /// <summary>Access FHIR ResearchElementDefinition resources.</summary>
        IResearchElementDefinitionResource ResearchElementDefinitions { get; }

        /// <summary>Access FHIR ResearchStudy resources.</summary>
        IResearchStudyResource ResearchStudies { get; }

        /// <summary>Access FHIR ResearchSubject resources.</summary>
        IResearchSubjectResource ResearchSubjects { get; }

        /// <summary>Access FHIR RiskAssessment resources.</summary>
        IRiskAssessmentResource RiskAssessments { get; }

        /// <summary>Access FHIR RiskEvidenceSynthesis resources.</summary>
        IRiskEvidenceSynthesisResource RiskEvidenceSyntheses { get; }

        /// <summary>Access FHIR Schedule resources.</summary>
        IScheduleResource Schedules { get; }

        /// <summary>Access FHIR SearchParameter resources.</summary>
        ISearchParameterResource SearchParameters { get; }

        /// <summary>Access FHIR ServiceRequest resources.</summary>
        IServiceRequestResource ServiceRequests { get; }

        /// <summary>Access FHIR Slot resources.</summary>
        ISlotResource Slots { get; }

        /// <summary>Access FHIR Specimen resources.</summary>
        ISpecimenResource Specimens { get; }

        /// <summary>Access FHIR SpecimenDefinition resources.</summary>
        ISpecimenDefinitionResource SpecimenDefinitions { get; }

        /// <summary>Access FHIR StructureDefinition resources.</summary>
        IStructureDefinitionResource StructureDefinitions { get; }

        /// <summary>Access FHIR StructureMap resources.</summary>
        IStructureMapResource StructureMaps { get; }

        /// <summary>Access FHIR Subscription resources.</summary>
        ISubscriptionResource Subscriptions { get; }

        /// <summary>Access FHIR Substance resources.</summary>
        ISubstanceResource Substances { get; }

        /// <summary>Access FHIR SubstanceNucleicAcid resources.</summary>
        ISubstanceNucleicAcidResource SubstanceNucleicAcids { get; }

        /// <summary>Access FHIR SubstancePolymer resources.</summary>
        ISubstancePolymerResource SubstancePolymers { get; }

        /// <summary>Access FHIR SubstanceProtein resources.</summary>
        ISubstanceProteinResource SubstanceProteins { get; }

        /// <summary>Access FHIR SubstanceReferenceInformation resources.</summary>
        ISubstanceReferenceInformationResource SubstanceReferenceInformations { get; }

        /// <summary>Access FHIR SubstanceSourceMaterial resources.</summary>
        ISubstanceSourceMaterialResource SubstanceSourceMaterials { get; }

        /// <summary>Access FHIR SubstanceSpecification resources.</summary>
        ISubstanceSpecificationResource SubstanceSpecifications { get; }

        /// <summary>Access FHIR SupplyDelivery resources.</summary>
        ISupplyDeliveryResource SupplyDeliveries { get; }

        /// <summary>Access FHIR SupplyRequest resources.</summary>
        ISupplyRequestResource SupplyRequests { get; }

        /// <summary>Access FHIR Task resources.</summary>
        ITaskResource Tasks { get; }

        /// <summary>Access FHIR TerminologyCapabilities resources.</summary>
        ITerminologyCapabilitiesResource TerminologyCapabilities { get; }

        /// <summary>Access FHIR TestReport resources.</summary>
        ITestReportResource TestReports { get; }

        /// <summary>Access FHIR TestScript resources.</summary>
        ITestScriptResource TestScripts { get; }

        /// <summary>Access FHIR ValueSet resources.</summary>
        IValueSetResource ValueSets { get; }

        /// <summary>Access FHIR VerificationResult resources.</summary>
        IVerificationResultResource VerificationResults { get; }

        /// <summary>Access FHIR VisionPrescription resources.</summary>
        IVisionPrescriptionResource VisionPrescriptions { get; }
    }
}
