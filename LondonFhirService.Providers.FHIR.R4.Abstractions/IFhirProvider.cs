// ---------------------------------------------------------
// Copyright (c) North East London ICB. All rights reserved.
// ---------------------------------------------------------

using LondonFhirService.Providers.FHIR.R4.Abstractions.Operations;

namespace LondonFhirService.Providers.FHIR.R4.Abstractions
{
    public interface IFhirProvider
    {
        /// <summary>Gets the unique name used to identify the provider.</summary>
        string ProviderName { get; }

        /// <summary>Access FHIR Account resources.</summary>
        IAccountOperation Accounts { get; }

        /// <summary>Access FHIR ActivityDefinition resources.</summary>
        IActivityDefinitionOperation ActivityDefinitions { get; }

        /// <summary>Access FHIR AdverseEvent resources.</summary>
        IAdverseEventOperation AdverseEvents { get; }

        /// <summary>Access FHIR AllergyIntolerance resources.</summary>
        IAllergyIntoleranceOperation AllergyIntolerances { get; }

        /// <summary>Access FHIR Appointment resources.</summary>
        IAppointmentOperation Appointments { get; }

        /// <summary>Access FHIR AppointmentResponse resources.</summary>
        IAppointmentResponseOperation AppointmentResponses { get; }

        /// <summary>Access FHIR AuditEvent resources.</summary>
        IAuditEventOperation AuditEvents { get; }

        /// <summary>Access FHIR Basic resources.</summary>
        IBasicOperation Basics { get; }

        /// <summary>Access FHIR Binary resources.</summary>
        IBinaryOperation Binaries { get; }

        /// <summary>Access FHIR BiologicallyDerivedProduct resources.</summary>
        IBiologicallyDerivedProductOperation BiologicallyDerivedProducts { get; }

        /// <summary>Access FHIR BodyStructure resources.</summary>
        IBodyStructureOperation BodyStructures { get; }

        /// <summary>Access FHIR Bundle resources.</summary>
        IBundleOperation Bundles { get; }

        /// <summary>Access FHIR CapabilityStatement resources.</summary>
        ICapabilityStatementOperation CapabilityStatements { get; }

        /// <summary>Access FHIR CarePlan resources.</summary>
        ICarePlanOperation CarePlans { get; }

        /// <summary>Access FHIR CareTeam resources.</summary>
        ICareTeamOperation CareTeams { get; }

        /// <summary>Access FHIR CatalogEntry resources.</summary>
        ICatalogEntryOperation CatalogEntries { get; }

        /// <summary>Access FHIR ChargeItem resources.</summary>
        IChargeItemOperation ChargeItems { get; }

        /// <summary>Access FHIR ChargeItemDefinition resources.</summary>
        IChargeItemDefinitionOperation ChargeItemDefinitions { get; }

        /// <summary>Access FHIR Claim resources.</summary>
        IClaimOperation Claims { get; }

        /// <summary>Access FHIR ClaimResponse resources.</summary>
        IClaimResponseOperation ClaimResponses { get; }

        /// <summary>Access FHIR ClinicalImpression resources.</summary>
        IClinicalImpressionOperation ClinicalImpressions { get; }

        /// <summary>Access FHIR CodeSystem resources.</summary>
        ICodeSystemOperation CodeSystems { get; }

        /// <summary>Access FHIR Communication resources.</summary>
        ICommunicationOperation Communications { get; }

        /// <summary>Access FHIR CommunicationRequest resources.</summary>
        ICommunicationRequestOperation CommunicationRequests { get; }

        /// <summary>Access FHIR CompartmentDefinition resources.</summary>
        ICompartmentDefinitionOperation CompartmentDefinitions { get; }

        /// <summary>Access FHIR Composition resources.</summary>
        ICompositionOperation Compositions { get; }

        /// <summary>Access FHIR ConceptMap resources.</summary>
        IConceptMapOperation ConceptMaps { get; }

        /// <summary>Access FHIR Condition resources.</summary>
        IConditionOperation Conditions { get; }

        /// <summary>Access FHIR Consent resources.</summary>
        IConsentOperation Consents { get; }

        /// <summary>Access FHIR Contract resources.</summary>
        IContractOperation Contracts { get; }

        /// <summary>Access FHIR Coverage resources.</summary>
        ICoverageOperation Coverages { get; }

        /// <summary>Access FHIR CoverageEligibilityRequest resources.</summary>
        ICoverageEligibilityRequestOperation CoverageEligibilityRequests { get; }

        /// <summary>Access FHIR CoverageEligibilityResponse resources.</summary>
        ICoverageEligibilityResponseOperation CoverageEligibilityResponses { get; }

        /// <summary>Access FHIR DetectedIssue resources.</summary>
        IDetectedIssueOperation DetectedIssues { get; }

        /// <summary>Access FHIR Device resources.</summary>
        IDeviceOperation Devices { get; }

        /// <summary>Access FHIR DeviceDefinition resources.</summary>
        IDeviceDefinitionOperation DeviceDefinitions { get; }

        /// <summary>Access FHIR DeviceMetric resources.</summary>
        IDeviceMetricOperation DeviceMetrics { get; }

        /// <summary>Access FHIR DeviceRequest resources.</summary>
        IDeviceRequestOperation DeviceRequests { get; }

        /// <summary>Access FHIR DeviceUseStatement resources.</summary>
        IDeviceUseStatementOperation DeviceUseStatements { get; }

        /// <summary>Access FHIR DiagnosticReport resources.</summary>
        IDiagnosticReportOperation DiagnosticReports { get; }

        /// <summary>Access FHIR DocumentManifest resources.</summary>
        IDocumentManifestOperation DocumentManifests { get; }

        /// <summary>Access FHIR DocumentReference resources.</summary>
        IDocumentReferenceOperation DocumentReferences { get; }

        /// <summary>Access FHIR EffectEvidenceSynthesis resources.</summary>
        IEffectEvidenceSynthesisOperation EffectEvidenceSyntheses { get; }

        /// <summary>Access FHIR Encounter resources.</summary>
        IEncounterOperation Encounters { get; }

        /// <summary>Access FHIR Endpoint resources.</summary>
        IEndpointOperation Endpoints { get; }

        /// <summary>Access FHIR EnrollmentRequest resources.</summary>
        IEnrollmentRequestOperation EnrollmentRequests { get; }

        /// <summary>Access FHIR EnrollmentResponse resources.</summary>
        IEnrollmentResponseOperation EnrollmentResponses { get; }

        /// <summary>Access FHIR EpisodeOfCare resources.</summary>
        IEpisodeOfCareOperation EpisodesOfCare { get; }

        /// <summary>Access FHIR EventDefinition resources.</summary>
        IEventDefinitionOperation EventDefinitions { get; }

        /// <summary>Access FHIR Evidence resources.</summary>
        IEvidenceOperation Evidences { get; }

        /// <summary>Access FHIR EvidenceVariable resources.</summary>
        IEvidenceVariableOperation EvidenceVariables { get; }

        /// <summary>Access FHIR ExampleScenario resources.</summary>
        IExampleScenarioOperation ExampleScenarios { get; }

        /// <summary>Access FHIR ExplanationOfBenefit resources.</summary>
        IExplanationOfBenefitOperation ExplanationsOfBenefit { get; }

        /// <summary>Access FHIR FamilyMemberHistory resources.</summary>
        IFamilyMemberHistoryOperation FamilyMemberHistories { get; }

        /// <summary>Access FHIR Flag resources.</summary>
        IFlagOperation Flags { get; }

        /// <summary>Access FHIR Goal resources.</summary>
        IGoalOperation Goals { get; }

        /// <summary>Access FHIR GraphDefinition resources.</summary>
        IGraphDefinitionOperation GraphDefinitions { get; }

        /// <summary>Access FHIR Group resources.</summary>
        IGroupOperation Groups { get; }

        /// <summary>Access FHIR GuidanceResponse resources.</summary>
        IGuidanceResponseOperation GuidanceResponses { get; }

        /// <summary>Access FHIR HealthcareService resources.</summary>
        IHealthcareServiceOperation HealthcareServices { get; }

        /// <summary>Access FHIR ImagingStudy resources.</summary>
        IImagingStudyOperation ImagingStudies { get; }

        /// <summary>Access FHIR Immunization resources.</summary>
        IImmunizationOperation Immunizations { get; }

        /// <summary>Access FHIR ImmunizationEvaluation resources.</summary>
        IImmunizationEvaluationOperation ImmunizationEvaluations { get; }

        /// <summary>Access FHIR ImmunizationRecommendation resources.</summary>
        IImmunizationRecommendationOperation ImmunizationRecommendations { get; }

        /// <summary>Access FHIR ImplementationGuide resources.</summary>
        IImplementationGuideOperation ImplementationGuides { get; }

        /// <summary>Access FHIR InsurancePlan resources.</summary>
        IInsurancePlanOperation InsurancePlans { get; }

        /// <summary>Access FHIR Invoice resources.</summary>
        IInvoiceOperation Invoices { get; }

        /// <summary>Access FHIR Library resources.</summary>
        ILibraryOperation Libraries { get; }

        /// <summary>Access FHIR Linkage resources.</summary>
        ILinkageOperation Linkages { get; }

        /// <summary>Access FHIR List resources.</summary>
        IListOperation Lists { get; }

        /// <summary>Access FHIR Location resources.</summary>
        ILocationOperation Locations { get; }

        /// <summary>Access FHIR Measure resources.</summary>
        IMeasureOperation Measures { get; }

        /// <summary>Access FHIR MeasureReport resources.</summary>
        IMeasureReportOperation MeasureReports { get; }

        /// <summary>Access FHIR Media resources.</summary>
        IMediaOperation Media { get; }

        /// <summary>Access FHIR Medication resources.</summary>
        IMedicationOperation Medications { get; }

        /// <summary>Access FHIR MedicationAdministration resources.</summary>
        IMedicationAdministrationOperation MedicationAdministrations { get; }

        /// <summary>Access FHIR MedicationDispense resources.</summary>
        IMedicationDispenseOperation MedicationDispenses { get; }

        /// <summary>Access FHIR MedicationKnowledge resources.</summary>
        IMedicationKnowledgeOperation MedicationKnowledge { get; }

        /// <summary>Access FHIR MedicationRequest resources.</summary>
        IMedicationRequestOperation MedicationRequests { get; }

        /// <summary>Access FHIR MedicationStatement resources.</summary>
        IMedicationStatementOperation MedicationStatements { get; }

        /// <summary>Access FHIR MedicinalProduct resources.</summary>
        IMedicinalProductOperation MedicinalProducts { get; }

        /// <summary>Access FHIR MedicinalProductAuthorization resources.</summary>
        IMedicinalProductAuthorizationOperation MedicinalProductAuthorizations { get; }

        /// <summary>Access FHIR MedicinalProductContraindication resources.</summary>
        IMedicinalProductContraindicationOperation MedicinalProductContraindications { get; }

        /// <summary>Access FHIR MedicinalProductIndication resources.</summary>
        IMedicinalProductIndicationOperation MedicinalProductIndications { get; }

        /// <summary>Access FHIR MedicinalProductIngredient resources.</summary>
        IMedicinalProductIngredientOperation MedicinalProductIngredients { get; }

        /// <summary>Access FHIR MedicinalProductInteraction resources.</summary>
        IMedicinalProductInteractionOperation MedicinalProductInteractions { get; }

        /// <summary>Access FHIR MedicinalProductManufactured resources.</summary>
        IMedicinalProductManufacturedOperation MedicinalProductManufactureds { get; }

        /// <summary>Access FHIR MedicinalProductPackaged resources.</summary>
        IMedicinalProductPackagedOperation MedicinalProductPackageds { get; }

        /// <summary>Access FHIR MedicinalProductPharmaceutical resources.</summary>
        IMedicinalProductPharmaceuticalOperation MedicinalProductPharmaceuticals { get; }

        /// <summary>Access FHIR MedicinalProductUndesirableEffect resources.</summary>
        IMedicinalProductUndesirableEffectOperation MedicinalProductUndesirableEffects { get; }

        /// <summary>Access FHIR MessageDefinition resources.</summary>
        IMessageDefinitionOperation MessageDefinitions { get; }

        /// <summary>Access FHIR MessageHeader resources.</summary>
        IMessageHeaderOperation MessageHeaders { get; }

        /// <summary>Access FHIR MolecularSequence resources.</summary>
        IMolecularSequenceOperation MolecularSequences { get; }

        /// <summary>Access FHIR NamingSystem resources.</summary>
        INamingSystemOperation NamingSystems { get; }

        /// <summary>Access FHIR NutritionOrder resources.</summary>
        INutritionOrderOperation NutritionOrders { get; }

        /// <summary>Access FHIR Observation resources.</summary>
        IObservationOperation Observations { get; }

        /// <summary>Access FHIR ObservationDefinition resources.</summary>
        IObservationDefinitionOperation ObservationDefinitions { get; }

        /// <summary>Access FHIR OperationDefinition resources.</summary>
        IOperationDefinitionOperation OperationDefinitions { get; }

        /// <summary>Access FHIR OperationOutcome resources.</summary>
        IOperationOutcomeOperation OperationOutcomes { get; }

        /// <summary>Access FHIR Organization resources.</summary>
        IOrganizationOperation Organizations { get; }

        /// <summary>Access FHIR OrganizationAffiliation resources.</summary>
        IOrganizationAffiliationOperation OrganizationAffiliations { get; }

        /// <summary>Access FHIR Parameters resources.</summary>
        IParametersOperation Parameters { get; }

        /// <summary>Access FHIR Patient resources.</summary>
        IPatientOperation Patients { get; }

        /// <summary>Access FHIR PaymentNotice resources.</summary>
        IPaymentNoticeOperation PaymentNotices { get; }

        /// <summary>Access FHIR PaymentReconciliation resources.</summary>
        IPaymentReconciliationOperation PaymentReconciliations { get; }

        /// <summary>Access FHIR Person resources.</summary>
        IPersonOperation Persons { get; }

        /// <summary>Access FHIR PlanDefinition resources.</summary>
        IPlanDefinitionOperation PlanDefinitions { get; }

        /// <summary>Access FHIR Practitioner resources.</summary>
        IPractitionerOperation Practitioners { get; }

        /// <summary>Access FHIR PractitionerRole resources.</summary>
        IPractitionerRoleOperation PractitionerRoles { get; }

        /// <summary>Access FHIR Procedure resources.</summary>
        IProcedureOperation Procedures { get; }

        /// <summary>Access FHIR Provenance resources.</summary>
        IProvenanceOperation Provenances { get; }

        /// <summary>Access FHIR Questionnaire resources.</summary>
        IQuestionnaireOperation Questionnaires { get; }

        /// <summary>Access FHIR QuestionnaireResponse resources.</summary>
        IQuestionnaireResponseOperation QuestionnaireResponses { get; }

        /// <summary>Access FHIR RelatedPerson resources.</summary>
        IRelatedPersonOperation RelatedPersons { get; }

        /// <summary>Access FHIR RequestGroup resources.</summary>
        IRequestGroupOperation RequestGroups { get; }

        /// <summary>Access FHIR ResearchDefinition resources.</summary>
        IResearchDefinitionOperation ResearchDefinitions { get; }

        /// <summary>Access FHIR ResearchElementDefinition resources.</summary>
        IResearchElementDefinitionOperation ResearchElementDefinitions { get; }

        /// <summary>Access FHIR ResearchStudy resources.</summary>
        IResearchStudyOperation ResearchStudies { get; }

        /// <summary>Access FHIR ResearchSubject resources.</summary>
        IResearchSubjectOperation ResearchSubjects { get; }

        /// <summary>Access FHIR RiskAssessment resources.</summary>
        IRiskAssessmentOperation RiskAssessments { get; }

        /// <summary>Access FHIR RiskEvidenceSynthesis resources.</summary>
        IRiskEvidenceSynthesisOperation RiskEvidenceSyntheses { get; }

        /// <summary>Access FHIR Schedule resources.</summary>
        IScheduleOperation Schedules { get; }

        /// <summary>Access FHIR SearchParameter resources.</summary>
        ISearchParameterOperation SearchParameters { get; }

        /// <summary>Access FHIR ServiceRequest resources.</summary>
        IServiceRequestOperation ServiceRequests { get; }

        /// <summary>Access FHIR Slot resources.</summary>
        ISlotOperation Slots { get; }

        /// <summary>Access FHIR Specimen resources.</summary>
        ISpecimenOperation Specimens { get; }

        /// <summary>Access FHIR SpecimenDefinition resources.</summary>
        ISpecimenDefinitionOperation SpecimenDefinitions { get; }

        /// <summary>Access FHIR StructureDefinition resources.</summary>
        IStructureDefinitionOperation StructureDefinitions { get; }

        /// <summary>Access FHIR StructureMap resources.</summary>
        IStructureMapOperation StructureMaps { get; }

        /// <summary>Access FHIR Subscription resources.</summary>
        ISubscriptionOperation Subscriptions { get; }

        /// <summary>Access FHIR Substance resources.</summary>
        ISubstanceOperation Substances { get; }

        /// <summary>Access FHIR SubstanceNucleicAcid resources.</summary>
        ISubstanceNucleicAcidOperation SubstanceNucleicAcids { get; }

        /// <summary>Access FHIR SubstancePolymer resources.</summary>
        ISubstancePolymerOperation SubstancePolymers { get; }

        /// <summary>Access FHIR SubstanceProtein resources.</summary>
        ISubstanceProteinOperation SubstanceProteins { get; }

        /// <summary>Access FHIR SubstanceReferenceInformation resources.</summary>
        ISubstanceReferenceInformationOperation SubstanceReferenceInformations { get; }

        /// <summary>Access FHIR SubstanceSourceMaterial resources.</summary>
        ISubstanceSourceMaterialOperation SubstanceSourceMaterials { get; }

        /// <summary>Access FHIR SubstanceSpecification resources.</summary>
        ISubstanceSpecificationOperation SubstanceSpecifications { get; }

        /// <summary>Access FHIR SupplyDelivery resources.</summary>
        ISupplyDeliveryOperation SupplyDeliveries { get; }

        /// <summary>Access FHIR SupplyRequest resources.</summary>
        ISupplyRequestOperation SupplyRequests { get; }

        /// <summary>Access FHIR Task resources.</summary>
        ITaskOperation Tasks { get; }

        /// <summary>Access FHIR TerminologyCapabilities resources.</summary>
        ITerminologyCapabilitiesOperation TerminologyCapabilities { get; }

        /// <summary>Access FHIR TestReport resources.</summary>
        ITestReportOperation TestReports { get; }

        /// <summary>Access FHIR TestScript resources.</summary>
        ITestScriptOperation TestScripts { get; }

        /// <summary>Access FHIR ValueSet resources.</summary>
        IValueSetOperation ValueSets { get; }

        /// <summary>Access FHIR VerificationResult resources.</summary>
        IVerificationResultOperation VerificationResults { get; }

        /// <summary>Access FHIR VisionPrescription resources.</summary>
        IVisionPrescriptionOperation VisionPrescriptions { get; }
    }
}
