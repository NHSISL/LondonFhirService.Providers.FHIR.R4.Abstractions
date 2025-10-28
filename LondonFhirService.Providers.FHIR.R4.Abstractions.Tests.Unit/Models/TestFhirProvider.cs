// ---------------------------------------------------------
// Copyright (c) North East London ICB. All rights reserved.
// ---------------------------------------------------------

using System;
using LondonFhirService.Providers.FHIR.R4.Abstractions.Models.Capabilities;
using LondonFhirService.Providers.FHIR.R4.Abstractions.Models.Resources;

namespace LondonFhirService.Providers.FHIR.R4.Abstractions.Tests.Unit.Models
{
    internal class TestFhirProvider : IFhirProvider
    {
        public string ProviderName { get; set; }

        public ProviderCapabilities Capabilities => throw new NotImplementedException();

        public IAccountResource Accounts => throw new NotImplementedException();

        public IActivityDefinitionResource ActivityDefinitions => throw new NotImplementedException();

        public IAdverseEventResource AdverseEvents => throw new NotImplementedException();

        public IAllergyIntoleranceResource AllergyIntolerances => throw new NotImplementedException();

        public IAppointmentResource Appointments => throw new NotImplementedException();

        public IAppointmentResponseResource AppointmentResponses => throw new NotImplementedException();

        public IAuditEventResource AuditEvents => throw new NotImplementedException();

        public IBasicResource Basics => throw new NotImplementedException();

        public IBinaryResource Binaries => throw new NotImplementedException();

        public IBiologicallyDerivedProductResource BiologicallyDerivedProducts => throw new NotImplementedException();

        public IBodyStructureResource BodyStructures => throw new NotImplementedException();

        public IBundleResource Bundles => throw new NotImplementedException();

        public ICapabilityStatementResource CapabilityStatements => throw new NotImplementedException();

        public ICarePlanResource CarePlans => throw new NotImplementedException();

        public ICareTeamResource CareTeams => throw new NotImplementedException();

        public ICatalogEntryResource CatalogEntries => throw new NotImplementedException();

        public IChargeItemResource ChargeItems => throw new NotImplementedException();

        public IChargeItemDefinitionResource ChargeItemDefinitions => throw new NotImplementedException();

        public IClaimResource Claims => throw new NotImplementedException();

        public IClaimResponseResource ClaimResponses => throw new NotImplementedException();

        public IClinicalImpressionResource ClinicalImpressions => throw new NotImplementedException();

        public ICodeSystemResource CodeSystems => throw new NotImplementedException();

        public ICommunicationResource Communications => throw new NotImplementedException();

        public ICommunicationRequestResource CommunicationRequests => throw new NotImplementedException();

        public ICompartmentDefinitionResource CompartmentDefinitions => throw new NotImplementedException();

        public ICompositionResource Compositions => throw new NotImplementedException();

        public IConceptMapResource ConceptMaps => throw new NotImplementedException();

        public IConditionResource Conditions => throw new NotImplementedException();

        public IConsentResource Consents => throw new NotImplementedException();

        public IContractResource Contracts => throw new NotImplementedException();

        public ICoverageResource Coverages => throw new NotImplementedException();

        public ICoverageEligibilityRequestResource CoverageEligibilityRequests => throw new NotImplementedException();

        public ICoverageEligibilityResponseResource CoverageEligibilityResponses => throw new NotImplementedException();

        public IDetectedIssueResource DetectedIssues => throw new NotImplementedException();

        public IDeviceResource Devices => throw new NotImplementedException();

        public IDeviceDefinitionResource DeviceDefinitions => throw new NotImplementedException();

        public IDeviceMetricResource DeviceMetrics => throw new NotImplementedException();

        public IDeviceRequestResource DeviceRequests => throw new NotImplementedException();

        public IDeviceUseStatementResource DeviceUseStatements => throw new NotImplementedException();

        public IDiagnosticReportResource DiagnosticReports => throw new NotImplementedException();

        public IDocumentManifestResource DocumentManifests => throw new NotImplementedException();

        public IDocumentReferenceResource DocumentReferences => throw new NotImplementedException();

        public IEffectEvidenceSynthesisResource EffectEvidenceSyntheses => throw new NotImplementedException();

        public IEncounterResource Encounters => throw new NotImplementedException();

        public IEndpointResource Endpoints => throw new NotImplementedException();

        public IEnrollmentRequestResource EnrollmentRequests => throw new NotImplementedException();

        public IEnrollmentResponseResource EnrollmentResponses => throw new NotImplementedException();

        public IEpisodeOfCareResource EpisodesOfCare => throw new NotImplementedException();

        public IEventDefinitionResource EventDefinitions => throw new NotImplementedException();

        public IEvidenceResource Evidences => throw new NotImplementedException();

        public IEvidenceVariableResource EvidenceVariables => throw new NotImplementedException();

        public IExampleScenarioResource ExampleScenarios => throw new NotImplementedException();

        public IExplanationOfBenefitResource ExplanationsOfBenefit => throw new NotImplementedException();

        public IFamilyMemberHistoryResource FamilyMemberHistories => throw new NotImplementedException();

        public IFlagResource Flags => throw new NotImplementedException();

        public IGoalResource Goals => throw new NotImplementedException();

        public IGraphDefinitionResource GraphDefinitions => throw new NotImplementedException();

        public IGroupResource Groups => throw new NotImplementedException();

        public IGuidanceResponseResource GuidanceResponses => throw new NotImplementedException();

        public IHealthcareServiceResource HealthcareServices => throw new NotImplementedException();

        public IImagingStudyResource ImagingStudies => throw new NotImplementedException();

        public IImmunizationResource Immunizations => throw new NotImplementedException();

        public IImmunizationEvaluationResource ImmunizationEvaluations => throw new NotImplementedException();

        public IImmunizationRecommendationResource ImmunizationRecommendations => throw new NotImplementedException();

        public IImplementationGuideResource ImplementationGuides => throw new NotImplementedException();

        public IInsurancePlanResource InsurancePlans => throw new NotImplementedException();

        public IInvoiceResource Invoices => throw new NotImplementedException();

        public ILibraryResource Libraries => throw new NotImplementedException();

        public ILinkageResource Linkages => throw new NotImplementedException();

        public IListResource Lists => throw new NotImplementedException();

        public ILocationResource Locations => throw new NotImplementedException();

        public IMeasureResource Measures => throw new NotImplementedException();

        public IMeasureReportResource MeasureReports => throw new NotImplementedException();

        public IMediaResource Media => throw new NotImplementedException();

        public IMedicationResource Medications => throw new NotImplementedException();

        public IMedicationAdministrationResource MedicationAdministrations => throw new NotImplementedException();

        public IMedicationDispenseResource MedicationDispenses => throw new NotImplementedException();

        public IMedicationKnowledgeResource MedicationKnowledge => throw new NotImplementedException();

        public IMedicationRequestResource MedicationRequests => throw new NotImplementedException();

        public IMedicationStatementResource MedicationStatements => throw new NotImplementedException();

        public IMedicinalProductResource MedicinalProducts => throw new NotImplementedException();

        public IMedicinalProductAuthorizationResource MedicinalProductAuthorizations => throw new NotImplementedException();

        public IMedicinalProductContraindicationResource MedicinalProductContraindications => throw new NotImplementedException();

        public IMedicinalProductIndicationResource MedicinalProductIndications => throw new NotImplementedException();

        public IMedicinalProductIngredientResource MedicinalProductIngredients => throw new NotImplementedException();

        public IMedicinalProductInteractionResource MedicinalProductInteractions => throw new NotImplementedException();

        public IMedicinalProductManufacturedResource MedicinalProductManufactureds => throw new NotImplementedException();

        public IMedicinalProductPackagedResource MedicinalProductPackageds => throw new NotImplementedException();

        public IMedicinalProductPharmaceuticalResource MedicinalProductPharmaceuticals => throw new NotImplementedException();

        public IMedicinalProductUndesirableEffectResource MedicinalProductUndesirableEffects => throw new NotImplementedException();

        public IMessageDefinitionResource MessageDefinitions => throw new NotImplementedException();

        public IMessageHeaderResource MessageHeaders => throw new NotImplementedException();

        public IMolecularSequenceResource MolecularSequences => throw new NotImplementedException();

        public INamingSystemResource NamingSystems => throw new NotImplementedException();

        public INutritionOrderResource NutritionOrders => throw new NotImplementedException();

        public IObservationResource Observations => throw new NotImplementedException();

        public IObservationDefinitionResource ObservationDefinitions => throw new NotImplementedException();

        public IOperationDefinitionResource OperationDefinitions => throw new NotImplementedException();

        public IOperationOutcomeResource OperationOutcomes => throw new NotImplementedException();

        public IOrganizationResource Organizations => throw new NotImplementedException();

        public IOrganizationAffiliationResource OrganizationAffiliations => throw new NotImplementedException();

        public IParametersResource Parameters => throw new NotImplementedException();

        public IPatientResource Patients => throw new NotImplementedException();

        public IPaymentNoticeResource PaymentNotices => throw new NotImplementedException();

        public IPaymentReconciliationResource PaymentReconciliations => throw new NotImplementedException();

        public IPersonResource Persons => throw new NotImplementedException();

        public IPlanDefinitionResource PlanDefinitions => throw new NotImplementedException();

        public IPractitionerResource Practitioners => throw new NotImplementedException();

        public IPractitionerRoleResource PractitionerRoles => throw new NotImplementedException();

        public IProcedureResource Procedures => throw new NotImplementedException();

        public IProvenanceResource Provenances => throw new NotImplementedException();

        public IQuestionnaireResource Questionnaires => throw new NotImplementedException();

        public IQuestionnaireResponseResource QuestionnaireResponses => throw new NotImplementedException();

        public IRelatedPersonResource RelatedPersons => throw new NotImplementedException();

        public IRequestGroupResource RequestGroups => throw new NotImplementedException();

        public IResearchDefinitionResource ResearchDefinitions => throw new NotImplementedException();

        public IResearchElementDefinitionResource ResearchElementDefinitions => throw new NotImplementedException();

        public IResearchStudyResource ResearchStudies => throw new NotImplementedException();

        public IResearchSubjectResource ResearchSubjects => throw new NotImplementedException();

        public IRiskAssessmentResource RiskAssessments => throw new NotImplementedException();

        public IRiskEvidenceSynthesisResource RiskEvidenceSyntheses => throw new NotImplementedException();

        public IScheduleResource Schedules => throw new NotImplementedException();

        public ISearchParameterResource SearchParameters => throw new NotImplementedException();

        public IServiceRequestResource ServiceRequests => throw new NotImplementedException();

        public ISlotResource Slots => throw new NotImplementedException();

        public ISpecimenResource Specimens => throw new NotImplementedException();

        public ISpecimenDefinitionResource SpecimenDefinitions => throw new NotImplementedException();

        public IStructureDefinitionResource StructureDefinitions => throw new NotImplementedException();

        public IStructureMapResource StructureMaps => throw new NotImplementedException();

        public ISubscriptionResource Subscriptions => throw new NotImplementedException();

        public ISubstanceResource Substances => throw new NotImplementedException();

        public ISubstanceNucleicAcidResource SubstanceNucleicAcids => throw new NotImplementedException();

        public ISubstancePolymerResource SubstancePolymers => throw new NotImplementedException();

        public ISubstanceProteinResource SubstanceProteins => throw new NotImplementedException();

        public ISubstanceReferenceInformationResource SubstanceReferenceInformations => throw new NotImplementedException();

        public ISubstanceSourceMaterialResource SubstanceSourceMaterials => throw new NotImplementedException();

        public ISubstanceSpecificationResource SubstanceSpecifications => throw new NotImplementedException();

        public ISupplyDeliveryResource SupplyDeliveries => throw new NotImplementedException();

        public ISupplyRequestResource SupplyRequests => throw new NotImplementedException();

        public ITaskResource Tasks => throw new NotImplementedException();

        public ITerminologyCapabilitiesResource TerminologyCapabilities => throw new NotImplementedException();

        public ITestReportResource TestReports => throw new NotImplementedException();

        public ITestScriptResource TestScripts => throw new NotImplementedException();

        public IValueSetResource ValueSets => throw new NotImplementedException();

        public IVerificationResultResource VerificationResults => throw new NotImplementedException();

        public IVisionPrescriptionResource VisionPrescriptions => throw new NotImplementedException();
    }
}
