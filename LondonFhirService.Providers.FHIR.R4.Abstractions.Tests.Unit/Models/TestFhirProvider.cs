// ---------------------------------------------------------
// Copyright (c) North East London ICB. All rights reserved.
// ---------------------------------------------------------

using System;
using LondonFhirService.Providers.FHIR.R4.Abstractions.Operations;

namespace LondonFhirService.Providers.FHIR.R4.Abstractions.Tests.Unit.Models
{
    internal class TestFhirProvider : IFhirProvider
    {
        public string ProviderName { get; set; }

        public IAccountOperation Accounts => throw new NotImplementedException();

        public IActivityDefinitionOperation ActivityDefinitions => throw new NotImplementedException();

        public IAdverseEventOperation AdverseEvents => throw new NotImplementedException();

        public IAllergyIntoleranceOperation AllergyIntolerances => throw new NotImplementedException();

        public IAppointmentOperation Appointments => throw new NotImplementedException();

        public IAppointmentResponseOperation AppointmentResponses => throw new NotImplementedException();

        public IAuditEventOperation AuditEvents => throw new NotImplementedException();

        public IBasicOperation Basics => throw new NotImplementedException();

        public IBinaryOperation Binaries => throw new NotImplementedException();

        public IBiologicallyDerivedProductOperation BiologicallyDerivedProducts => throw new NotImplementedException();

        public IBodyStructureOperation BodyStructures => throw new NotImplementedException();

        public IBundleOperation Bundles => throw new NotImplementedException();

        public ICapabilityStatementOperation CapabilityStatements => throw new NotImplementedException();

        public ICarePlanOperation CarePlans => throw new NotImplementedException();

        public ICareTeamOperation CareTeams => throw new NotImplementedException();

        public ICatalogEntryOperation CatalogEntries => throw new NotImplementedException();

        public IChargeItemOperation ChargeItems => throw new NotImplementedException();

        public IChargeItemDefinitionOperation ChargeItemDefinitions => throw new NotImplementedException();

        public IClaimOperation Claims => throw new NotImplementedException();

        public IClaimResponseOperation ClaimResponses => throw new NotImplementedException();

        public IClinicalImpressionOperation ClinicalImpressions => throw new NotImplementedException();

        public ICodeSystemOperation CodeSystems => throw new NotImplementedException();

        public ICommunicationOperation Communications => throw new NotImplementedException();

        public ICommunicationRequestOperation CommunicationRequests => throw new NotImplementedException();

        public ICompartmentDefinitionOperation CompartmentDefinitions => throw new NotImplementedException();

        public ICompositionOperation Compositions => throw new NotImplementedException();

        public IConceptMapOperation ConceptMaps => throw new NotImplementedException();

        public IConditionOperation Conditions => throw new NotImplementedException();

        public IConsentOperation Consents => throw new NotImplementedException();

        public IContractOperation Contracts => throw new NotImplementedException();

        public ICoverageOperation Coverages => throw new NotImplementedException();

        public ICoverageEligibilityRequestOperation CoverageEligibilityRequests => throw new NotImplementedException();

        public ICoverageEligibilityResponseOperation CoverageEligibilityResponses => throw new NotImplementedException();

        public IDetectedIssueOperation DetectedIssues => throw new NotImplementedException();

        public IDeviceOperation Devices => throw new NotImplementedException();

        public IDeviceDefinitionOperation DeviceDefinitions => throw new NotImplementedException();

        public IDeviceMetricOperation DeviceMetrics => throw new NotImplementedException();

        public IDeviceRequestOperation DeviceRequests => throw new NotImplementedException();

        public IDeviceUseStatementOperation DeviceUseStatements => throw new NotImplementedException();

        public IDiagnosticReportOperation DiagnosticReports => throw new NotImplementedException();

        public IDocumentManifestOperation DocumentManifests => throw new NotImplementedException();

        public IDocumentReferenceOperation DocumentReferences => throw new NotImplementedException();

        public IEffectEvidenceSynthesisOperation EffectEvidenceSyntheses => throw new NotImplementedException();

        public IEncounterOperation Encounters => throw new NotImplementedException();

        public IEndpointOperation Endpoints => throw new NotImplementedException();

        public IEnrollmentRequestOperation EnrollmentRequests => throw new NotImplementedException();

        public IEnrollmentResponseOperation EnrollmentResponses => throw new NotImplementedException();

        public IEpisodeOfCareOperation EpisodesOfCare => throw new NotImplementedException();

        public IEventDefinitionOperation EventDefinitions => throw new NotImplementedException();

        public IEvidenceOperation Evidences => throw new NotImplementedException();

        public IEvidenceVariableOperation EvidenceVariables => throw new NotImplementedException();

        public IExampleScenarioOperation ExampleScenarios => throw new NotImplementedException();

        public IExplanationOfBenefitOperation ExplanationsOfBenefit => throw new NotImplementedException();

        public IFamilyMemberHistoryOperation FamilyMemberHistories => throw new NotImplementedException();

        public IFlagOperation Flags => throw new NotImplementedException();

        public IGoalOperation Goals => throw new NotImplementedException();

        public IGraphDefinitionOperation GraphDefinitions => throw new NotImplementedException();

        public IGroupOperation Groups => throw new NotImplementedException();

        public IGuidanceResponseOperation GuidanceResponses => throw new NotImplementedException();

        public IHealthcareServiceOperation HealthcareServices => throw new NotImplementedException();

        public IImagingStudyOperation ImagingStudies => throw new NotImplementedException();

        public IImmunizationOperation Immunizations => throw new NotImplementedException();

        public IImmunizationEvaluationOperation ImmunizationEvaluations => throw new NotImplementedException();

        public IImmunizationRecommendationOperation ImmunizationRecommendations => throw new NotImplementedException();

        public IImplementationGuideOperation ImplementationGuides => throw new NotImplementedException();

        public IInsurancePlanOperation InsurancePlans => throw new NotImplementedException();

        public IInvoiceOperation Invoices => throw new NotImplementedException();

        public ILibraryOperation Libraries => throw new NotImplementedException();

        public ILinkageOperation Linkages => throw new NotImplementedException();

        public IListOperation Lists => throw new NotImplementedException();

        public ILocationOperation Locations => throw new NotImplementedException();

        public IMeasureOperation Measures => throw new NotImplementedException();

        public IMeasureReportOperation MeasureReports => throw new NotImplementedException();

        public IMediaOperation Media => throw new NotImplementedException();

        public IMedicationOperation Medications => throw new NotImplementedException();

        public IMedicationAdministrationOperation MedicationAdministrations => throw new NotImplementedException();

        public IMedicationDispenseOperation MedicationDispenses => throw new NotImplementedException();

        public IMedicationKnowledgeOperation MedicationKnowledge => throw new NotImplementedException();

        public IMedicationRequestOperation MedicationRequests => throw new NotImplementedException();

        public IMedicationStatementOperation MedicationStatements => throw new NotImplementedException();

        public IMedicinalProductOperation MedicinalProducts => throw new NotImplementedException();

        public IMedicinalProductAuthorizationOperation MedicinalProductAuthorizations => throw new NotImplementedException();

        public IMedicinalProductContraindicationOperation MedicinalProductContraindications => throw new NotImplementedException();

        public IMedicinalProductIndicationOperation MedicinalProductIndications => throw new NotImplementedException();

        public IMedicinalProductIngredientOperation MedicinalProductIngredients => throw new NotImplementedException();

        public IMedicinalProductInteractionOperation MedicinalProductInteractions => throw new NotImplementedException();

        public IMedicinalProductManufacturedOperation MedicinalProductManufactureds => throw new NotImplementedException();

        public IMedicinalProductPackagedOperation MedicinalProductPackageds => throw new NotImplementedException();

        public IMedicinalProductPharmaceuticalOperation MedicinalProductPharmaceuticals => throw new NotImplementedException();

        public IMedicinalProductUndesirableEffectOperation MedicinalProductUndesirableEffects => throw new NotImplementedException();

        public IMessageDefinitionOperation MessageDefinitions => throw new NotImplementedException();

        public IMessageHeaderOperation MessageHeaders => throw new NotImplementedException();

        public IMolecularSequenceOperation MolecularSequences => throw new NotImplementedException();

        public INamingSystemOperation NamingSystems => throw new NotImplementedException();

        public INutritionOrderOperation NutritionOrders => throw new NotImplementedException();

        public IObservationOperation Observations => throw new NotImplementedException();

        public IObservationDefinitionOperation ObservationDefinitions => throw new NotImplementedException();

        public IOperationDefinitionOperation OperationDefinitions => throw new NotImplementedException();

        public IOperationOutcomeOperation OperationOutcomes => throw new NotImplementedException();

        public IOrganizationOperation Organizations => throw new NotImplementedException();

        public IOrganizationAffiliationOperation OrganizationAffiliations => throw new NotImplementedException();

        public IParametersOperation Parameters => throw new NotImplementedException();

        public IPatientOperation Patients => throw new NotImplementedException();

        public IPaymentNoticeOperation PaymentNotices => throw new NotImplementedException();

        public IPaymentReconciliationOperation PaymentReconciliations => throw new NotImplementedException();

        public IPersonOperation Persons => throw new NotImplementedException();

        public IPlanDefinitionOperation PlanDefinitions => throw new NotImplementedException();

        public IPractitionerOperation Practitioners => throw new NotImplementedException();

        public IPractitionerRoleOperation PractitionerRoles => throw new NotImplementedException();

        public IProcedureOperation Procedures => throw new NotImplementedException();

        public IProvenanceOperation Provenances => throw new NotImplementedException();

        public IQuestionnaireOperation Questionnaires => throw new NotImplementedException();

        public IQuestionnaireResponseOperation QuestionnaireResponses => throw new NotImplementedException();

        public IRelatedPersonOperation RelatedPersons => throw new NotImplementedException();

        public IRequestGroupOperation RequestGroups => throw new NotImplementedException();

        public IResearchDefinitionOperation ResearchDefinitions => throw new NotImplementedException();

        public IResearchElementDefinitionOperation ResearchElementDefinitions => throw new NotImplementedException();

        public IResearchStudyOperation ResearchStudies => throw new NotImplementedException();

        public IResearchSubjectOperation ResearchSubjects => throw new NotImplementedException();

        public IRiskAssessmentOperation RiskAssessments => throw new NotImplementedException();

        public IRiskEvidenceSynthesisOperation RiskEvidenceSyntheses => throw new NotImplementedException();

        public IScheduleOperation Schedules => throw new NotImplementedException();

        public ISearchParameterOperation SearchParameters => throw new NotImplementedException();

        public IServiceRequestOperation ServiceRequests => throw new NotImplementedException();

        public ISlotOperation Slots => throw new NotImplementedException();

        public ISpecimenOperation Specimens => throw new NotImplementedException();

        public ISpecimenDefinitionOperation SpecimenDefinitions => throw new NotImplementedException();

        public IStructureDefinitionOperation StructureDefinitions => throw new NotImplementedException();

        public IStructureMapOperation StructureMaps => throw new NotImplementedException();

        public ISubscriptionOperation Subscriptions => throw new NotImplementedException();

        public ISubstanceOperation Substances => throw new NotImplementedException();

        public ISubstanceNucleicAcidOperation SubstanceNucleicAcids => throw new NotImplementedException();

        public ISubstancePolymerOperation SubstancePolymers => throw new NotImplementedException();

        public ISubstanceProteinOperation SubstanceProteins => throw new NotImplementedException();

        public ISubstanceReferenceInformationOperation SubstanceReferenceInformations => throw new NotImplementedException();

        public ISubstanceSourceMaterialOperation SubstanceSourceMaterials => throw new NotImplementedException();

        public ISubstanceSpecificationOperation SubstanceSpecifications => throw new NotImplementedException();

        public ISupplyDeliveryOperation SupplyDeliveries => throw new NotImplementedException();

        public ISupplyRequestOperation SupplyRequests => throw new NotImplementedException();

        public ITaskOperation Tasks => throw new NotImplementedException();

        public ITerminologyCapabilitiesOperation TerminologyCapabilities => throw new NotImplementedException();

        public ITestReportOperation TestReports => throw new NotImplementedException();

        public ITestScriptOperation TestScripts => throw new NotImplementedException();

        public IValueSetOperation ValueSets => throw new NotImplementedException();

        public IVerificationResultOperation VerificationResults => throw new NotImplementedException();

        public IVisionPrescriptionOperation VisionPrescriptions => throw new NotImplementedException();
    }
}
