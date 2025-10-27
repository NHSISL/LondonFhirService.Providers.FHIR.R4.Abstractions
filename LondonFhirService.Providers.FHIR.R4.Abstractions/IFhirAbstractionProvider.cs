// ---------------------------------------------------------
// Copyright (c) North East London ICB. All rights reserved.
// ---------------------------------------------------------

using LondonFhirService.Providers.FHIR.R4.Abstractions.Operations;

namespace LondonFhirService.Providers.FHIR.R4.Abstractions
{
    public interface IFhirAbstractionProvider
    {
        /// <summary>Access FHIR Account resources.</summary>
        IAccountOperation Accounts(string providerName);

        /// <summary>Access FHIR ActivityDefinition resources.</summary>
        IActivityDefinitionOperation ActivityDefinitions(string providerName);

        /// <summary>Access FHIR AdverseEvent resources.</summary>
        IAdverseEventOperation AdverseEvents(string providerName);

        /// <summary>Access FHIR AllergyIntolerance resources.</summary>
        IAllergyIntoleranceOperation AllergyIntolerances(string providerName);

        /// <summary>Access FHIR Appointment resources.</summary>
        IAppointmentOperation Appointments(string providerName);

        /// <summary>Access FHIR AppointmentResponse resources.</summary>
        IAppointmentResponseOperation AppointmentResponses(string providerName);

        /// <summary>Access FHIR AuditEvent resources.</summary>
        IAuditEventOperation AuditEvents(string providerName);

        /// <summary>Access FHIR Basic resources.</summary>
        IBasicOperation Basics(string providerName);

        /// <summary>Access FHIR Binary resources.</summary>
        IBinaryOperation Binaries(string providerName);

        /// <summary>Access FHIR BiologicallyDerivedProduct resources.</summary>
        IBiologicallyDerivedProductOperation BiologicallyDerivedProducts(string providerName);

        /// <summary>Access FHIR BodyStructure resources.</summary>
        IBodyStructureOperation BodyStructures(string providerName);

        /// <summary>Access FHIR Bundle resources.</summary>
        IBundleOperation Bundles(string providerName);

        /// <summary>Access FHIR CapabilityStatement resources.</summary>
        ICapabilityStatementOperation CapabilityStatements(string providerName);

        /// <summary>Access FHIR CarePlan resources.</summary>
        ICarePlanOperation CarePlans(string providerName);

        /// <summary>Access FHIR CareTeam resources.</summary>
        ICareTeamOperation CareTeams(string providerName);

        /// <summary>Access FHIR CatalogEntry resources.</summary>
        ICatalogEntryOperation CatalogEntries(string providerName);

        /// <summary>Access FHIR ChargeItem resources.</summary>
        IChargeItemOperation ChargeItems(string providerName);

        /// <summary>Access FHIR ChargeItemDefinition resources.</summary>
        IChargeItemDefinitionOperation ChargeItemDefinitions(string providerName);

        /// <summary>Access FHIR Claim resources.</summary>
        IClaimOperation Claims(string providerName);

        /// <summary>Access FHIR ClaimResponse resources.</summary>
        IClaimResponseOperation ClaimResponses(string providerName);

        /// <summary>Access FHIR ClinicalImpression resources.</summary>
        IClinicalImpressionOperation ClinicalImpressions(string providerName);

        /// <summary>Access FHIR CodeSystem resources.</summary>
        ICodeSystemOperation CodeSystems(string providerName);

        /// <summary>Access FHIR Communication resources.</summary>
        ICommunicationOperation Communications(string providerName);

        /// <summary>Access FHIR CommunicationRequest resources.</summary>
        ICommunicationRequestOperation CommunicationRequests(string providerName);

        /// <summary>Access FHIR CompartmentDefinition resources.</summary>
        ICompartmentDefinitionOperation CompartmentDefinitions(string providerName);

        /// <summary>Access FHIR Composition resources.</summary>
        ICompositionOperation Compositions(string providerName);

        /// <summary>Access FHIR ConceptMap resources.</summary>
        IConceptMapOperation ConceptMaps(string providerName);

        /// <summary>Access FHIR Condition resources.</summary>
        IConditionOperation Conditions(string providerName);

        /// <summary>Access FHIR Consent resources.</summary>
        IConsentOperation Consents(string providerName);

        /// <summary>Access FHIR Contract resources.</summary>
        IContractOperation Contracts(string providerName);

        /// <summary>Access FHIR Coverage resources.</summary>
        ICoverageOperation Coverages(string providerName);

        /// <summary>Access FHIR CoverageEligibilityRequest resources.</summary>
        ICoverageEligibilityRequestOperation CoverageEligibilityRequests(string providerName);

        /// <summary>Access FHIR CoverageEligibilityResponse resources.</summary>
        ICoverageEligibilityResponseOperation CoverageEligibilityResponses(string providerName);

        /// <summary>Access FHIR DetectedIssue resources.</summary>
        IDetectedIssueOperation DetectedIssues(string providerName);

        /// <summary>Access FHIR Device resources.</summary>
        IDeviceOperation Devices(string providerName);

        /// <summary>Access FHIR DeviceDefinition resources.</summary>
        IDeviceDefinitionOperation DeviceDefinitions(string providerName);

        /// <summary>Access FHIR DeviceMetric resources.</summary>
        IDeviceMetricOperation DeviceMetrics(string providerName);

        /// <summary>Access FHIR DeviceRequest resources.</summary>
        IDeviceRequestOperation DeviceRequests(string providerName);

        /// <summary>Access FHIR DeviceUseStatement resources.</summary>
        IDeviceUseStatementOperation DeviceUseStatements(string providerName);

        /// <summary>Access FHIR DiagnosticReport resources.</summary>
        IDiagnosticReportOperation DiagnosticReports(string providerName);

        /// <summary>Access FHIR DocumentManifest resources.</summary>
        IDocumentManifestOperation DocumentManifests(string providerName);

        /// <summary>Access FHIR DocumentReference resources.</summary>
        IDocumentReferenceOperation DocumentReferences(string providerName);

        /// <summary>Access FHIR EffectEvidenceSynthesis resources.</summary>
        IEffectEvidenceSynthesisOperation EffectEvidenceSyntheses(string providerName);

        /// <summary>Access FHIR Encounter resources.</summary>
        IEncounterOperation Encounters(string providerName);

        /// <summary>Access FHIR Endpoint resources.</summary>
        IEndpointOperation Endpoints(string providerName);

        /// <summary>Access FHIR EnrollmentRequest resources.</summary>
        IEnrollmentRequestOperation EnrollmentRequests(string providerName);

        /// <summary>Access FHIR EnrollmentResponse resources.</summary>
        IEnrollmentResponseOperation EnrollmentResponses(string providerName);

        /// <summary>Access FHIR EpisodeOfCare resources.</summary>
        IEpisodeOfCareOperation EpisodesOfCare(string providerName);

        /// <summary>Access FHIR EventDefinition resources.</summary>
        IEventDefinitionOperation EventDefinitions(string providerName);

        /// <summary>Access FHIR Evidence resources.</summary>
        IEvidenceOperation Evidences(string providerName);

        /// <summary>Access FHIR EvidenceVariable resources.</summary>
        IEvidenceVariableOperation EvidenceVariables(string providerName);

        /// <summary>Access FHIR ExampleScenario resources.</summary>
        IExampleScenarioOperation ExampleScenarios(string providerName);

        /// <summary>Access FHIR ExplanationOfBenefit resources.</summary>
        IExplanationOfBenefitOperation ExplanationsOfBenefit(string providerName);

        /// <summary>Access FHIR FamilyMemberHistory resources.</summary>
        IFamilyMemberHistoryOperation FamilyMemberHistories(string providerName);

        /// <summary>Access FHIR Flag resources.</summary>
        IFlagOperation Flags(string providerName);

        /// <summary>Access FHIR Goal resources.</summary>
        IGoalOperation Goals(string providerName);

        /// <summary>Access FHIR GraphDefinition resources.</summary>
        IGraphDefinitionOperation GraphDefinitions(string providerName);

        /// <summary>Access FHIR Group resources.</summary>
        IGroupOperation Groups(string providerName);

        /// <summary>Access FHIR GuidanceResponse resources.</summary>
        IGuidanceResponseOperation GuidanceResponses(string providerName);

        /// <summary>Access FHIR HealthcareService resources.</summary>
        IHealthcareServiceOperation HealthcareServices(string providerName);

        /// <summary>Access FHIR ImagingStudy resources.</summary>
        IImagingStudyOperation ImagingStudies(string providerName);

        /// <summary>Access FHIR Immunization resources.</summary>
        IImmunizationOperation Immunizations(string providerName);

        /// <summary>Access FHIR ImmunizationEvaluation resources.</summary>
        IImmunizationEvaluationOperation ImmunizationEvaluations(string providerName);

        /// <summary>Access FHIR ImmunizationRecommendation resources.</summary>
        IImmunizationRecommendationOperation ImmunizationRecommendations(string providerName);

        /// <summary>Access FHIR ImplementationGuide resources.</summary>
        IImplementationGuideOperation ImplementationGuides(string providerName);

        /// <summary>Access FHIR InsurancePlan resources.</summary>
        IInsurancePlanOperation InsurancePlans(string providerName);

        /// <summary>Access FHIR Invoice resources.</summary>
        IInvoiceOperation Invoices(string providerName);

        /// <summary>Access FHIR Library resources.</summary>
        ILibraryOperation Libraries(string providerName);

        /// <summary>Access FHIR Linkage resources.</summary>
        ILinkageOperation Linkages(string providerName);

        /// <summary>Access FHIR List resources.</summary>
        IListOperation Lists(string providerName);

        /// <summary>Access FHIR Location resources.</summary>
        ILocationOperation Locations(string providerName);

        /// <summary>Access FHIR Measure resources.</summary>
        IMeasureOperation Measures(string providerName);

        /// <summary>Access FHIR MeasureReport resources.</summary>
        IMeasureReportOperation MeasureReports(string providerName);

        /// <summary>Access FHIR Media resources.</summary>
        IMediaOperation Media(string providerName);

        /// <summary>Access FHIR Medication resources.</summary>
        IMedicationOperation Medications(string providerName);

        /// <summary>Access FHIR MedicationAdministration resources.</summary>
        IMedicationAdministrationOperation MedicationAdministrations(string providerName);

        /// <summary>Access FHIR MedicationDispense resources.</summary>
        IMedicationDispenseOperation MedicationDispenses(string providerName);

        /// <summary>Access FHIR MedicationKnowledge resources.</summary>
        IMedicationKnowledgeOperation MedicationKnowledge(string providerName);

        /// <summary>Access FHIR MedicationRequest resources.</summary>
        IMedicationRequestOperation MedicationRequests(string providerName);

        /// <summary>Access FHIR MedicationStatement resources.</summary>
        IMedicationStatementOperation MedicationStatements(string providerName);

        /// <summary>Access FHIR MedicinalProduct resources.</summary>
        IMedicinalProductOperation MedicinalProducts(string providerName);

        /// <summary>Access FHIR MedicinalProductAuthorization resources.</summary>
        IMedicinalProductAuthorizationOperation MedicinalProductAuthorizations(string providerName);

        /// <summary>Access FHIR MedicinalProductContraindication resources.</summary>
        IMedicinalProductContraindicationOperation MedicinalProductContraindications(string providerName);

        /// <summary>Access FHIR MedicinalProductIndication resources.</summary>
        IMedicinalProductIndicationOperation MedicinalProductIndications(string providerName);

        /// <summary>Access FHIR MedicinalProductIngredient resources.</summary>
        IMedicinalProductIngredientOperation MedicinalProductIngredients(string providerName);

        /// <summary>Access FHIR MedicinalProductInteraction resources.</summary>
        IMedicinalProductInteractionOperation MedicinalProductInteractions(string providerName);

        /// <summary>Access FHIR MedicinalProductManufactured resources.</summary>
        IMedicinalProductManufacturedOperation MedicinalProductManufactureds(string providerName);

        /// <summary>Access FHIR MedicinalProductPackaged resources.</summary>
        IMedicinalProductPackagedOperation MedicinalProductPackageds(string providerName);

        /// <summary>Access FHIR MedicinalProductPharmaceutical resources.</summary>
        IMedicinalProductPharmaceuticalOperation MedicinalProductPharmaceuticals(string providerName);

        /// <summary>Access FHIR MedicinalProductUndesirableEffect resources.</summary>
        IMedicinalProductUndesirableEffectOperation MedicinalProductUndesirableEffects(string providerName);

        /// <summary>Access FHIR MessageDefinition resources.</summary>
        IMessageDefinitionOperation MessageDefinitions(string providerName);

        /// <summary>Access FHIR MessageHeader resources.</summary>
        IMessageHeaderOperation MessageHeaders(string providerName);

        /// <summary>Access FHIR MolecularSequence resources.</summary>
        IMolecularSequenceOperation MolecularSequences(string providerName);

        /// <summary>Access FHIR NamingSystem resources.</summary>
        INamingSystemOperation NamingSystems(string providerName);

        /// <summary>Access FHIR NutritionOrder resources.</summary>
        INutritionOrderOperation NutritionOrders(string providerName);

        /// <summary>Access FHIR Observation resources.</summary>
        IObservationOperation Observations(string providerName);

        /// <summary>Access FHIR ObservationDefinition resources.</summary>
        IObservationDefinitionOperation ObservationDefinitions(string providerName);

        /// <summary>Access FHIR OperationDefinition resources.</summary>
        IOperationDefinitionOperation OperationDefinitions(string providerName);

        /// <summary>Access FHIR OperationOutcome resources.</summary>
        IOperationOutcomeOperation OperationOutcomes(string providerName);

        /// <summary>Access FHIR Organization resources.</summary>
        IOrganizationOperation Organizations(string providerName);

        /// <summary>Access FHIR OrganizationAffiliation resources.</summary>
        IOrganizationAffiliationOperation OrganizationAffiliations(string providerName);

        /// <summary>Access FHIR Parameters resources.</summary>
        IParametersOperation Parameters(string providerName);

        /// <summary>Access FHIR Patient resources.</summary>
        IPatientOperation Patients(string providerName);

        /// <summary>Access FHIR PaymentNotice resources.</summary>
        IPaymentNoticeOperation PaymentNotices(string providerName);

        /// <summary>Access FHIR PaymentReconciliation resources.</summary>
        IPaymentReconciliationOperation PaymentReconciliations(string providerName);

        /// <summary>Access FHIR Person resources.</summary>
        IPersonOperation Persons(string providerName);

        /// <summary>Access FHIR PlanDefinition resources.</summary>
        IPlanDefinitionOperation PlanDefinitions(string providerName);

        /// <summary>Access FHIR Practitioner resources.</summary>
        IPractitionerOperation Practitioners(string providerName);

        /// <summary>Access FHIR PractitionerRole resources.</summary>
        IPractitionerRoleOperation PractitionerRoles(string providerName);

        /// <summary>Access FHIR Procedure resources.</summary>
        IProcedureOperation Procedures(string providerName);

        /// <summary>Access FHIR Provenance resources.</summary>
        IProvenanceOperation Provenances(string providerName);

        /// <summary>Access FHIR Questionnaire resources.</summary>
        IQuestionnaireOperation Questionnaires(string providerName);

        /// <summary>Access FHIR QuestionnaireResponse resources.</summary>
        IQuestionnaireResponseOperation QuestionnaireResponses(string providerName);

        /// <summary>Access FHIR RelatedPerson resources.</summary>
        IRelatedPersonOperation RelatedPersons(string providerName);

        /// <summary>Access FHIR RequestGroup resources.</summary>
        IRequestGroupOperation RequestGroups(string providerName);

        /// <summary>Access FHIR ResearchDefinition resources.</summary>
        IResearchDefinitionOperation ResearchDefinitions(string providerName);

        /// <summary>Access FHIR ResearchElementDefinition resources.</summary>
        IResearchElementDefinitionOperation ResearchElementDefinitions(string providerName);

        /// <summary>Access FHIR ResearchStudy resources.</summary>
        IResearchStudyOperation ResearchStudies(string providerName);

        /// <summary>Access FHIR ResearchSubject resources.</summary>
        IResearchSubjectOperation ResearchSubjects(string providerName);

        /// <summary>Access FHIR RiskAssessment resources.</summary>
        IRiskAssessmentOperation RiskAssessments(string providerName);

        /// <summary>Access FHIR RiskEvidenceSynthesis resources.</summary>
        IRiskEvidenceSynthesisOperation RiskEvidenceSyntheses(string providerName);

        /// <summary>Access FHIR Schedule resources.</summary>
        IScheduleOperation Schedules(string providerName);

        /// <summary>Access FHIR SearchParameter resources.</summary>
        ISearchParameterOperation SearchParameters(string providerName);

        /// <summary>Access FHIR ServiceRequest resources.</summary>
        IServiceRequestOperation ServiceRequests(string providerName);

        /// <summary>Access FHIR Slot resources.</summary>
        ISlotOperation Slots(string providerName);

        /// <summary>Access FHIR Specimen resources.</summary>
        ISpecimenOperation Specimens(string providerName);

        /// <summary>Access FHIR SpecimenDefinition resources.</summary>
        ISpecimenDefinitionOperation SpecimenDefinitions(string providerName);

        /// <summary>Access FHIR StructureDefinition resources.</summary>
        IStructureDefinitionOperation StructureDefinitions(string providerName);

        /// <summary>Access FHIR StructureMap resources.</summary>
        IStructureMapOperation StructureMaps(string providerName);

        /// <summary>Access FHIR Subscription resources.</summary>
        ISubscriptionOperation Subscriptions(string providerName);

        /// <summary>Access FHIR Substance resources.</summary>
        ISubstanceOperation Substances(string providerName);

        /// <summary>Access FHIR SubstanceNucleicAcid resources.</summary>
        ISubstanceNucleicAcidOperation SubstanceNucleicAcids(string providerName);

        /// <summary>Access FHIR SubstancePolymer resources.</summary>
        ISubstancePolymerOperation SubstancePolymers(string providerName);

        /// <summary>Access FHIR SubstanceProtein resources.</summary>
        ISubstanceProteinOperation SubstanceProteins(string providerName);

        /// <summary>Access FHIR SubstanceReferenceInformation resources.</summary>
        ISubstanceReferenceInformationOperation SubstanceReferenceInformations(string providerName);

        /// <summary>Access FHIR SubstanceSourceMaterial resources.</summary>
        ISubstanceSourceMaterialOperation SubstanceSourceMaterials(string providerName);

        /// <summary>Access FHIR SubstanceSpecification resources.</summary>
        ISubstanceSpecificationOperation SubstanceSpecifications(string providerName);

        /// <summary>Access FHIR SupplyDelivery resources.</summary>
        ISupplyDeliveryOperation SupplyDeliveries(string providerName);

        /// <summary>Access FHIR SupplyRequest resources.</summary>
        ISupplyRequestOperation SupplyRequests(string providerName);

        /// <summary>Access FHIR Task resources.</summary>
        ITaskOperation Tasks(string providerName);

        /// <summary>Access FHIR TerminologyCapabilities resources.</summary>
        ITerminologyCapabilitiesOperation TerminologyCapabilities(string providerName);

        /// <summary>Access FHIR TestReport resources.</summary>
        ITestReportOperation TestReports(string providerName);

        /// <summary>Access FHIR TestScript resources.</summary>
        ITestScriptOperation TestScripts(string providerName);

        /// <summary>Access FHIR ValueSet resources.</summary>
        IValueSetOperation ValueSets(string providerName);

        /// <summary>Access FHIR VerificationResult resources.</summary>
        IVerificationResultOperation VerificationResults(string providerName);

        /// <summary>Access FHIR VisionPrescription resources.</summary>
        IVisionPrescriptionOperation VisionPrescriptions(string providerName);

    }
}
