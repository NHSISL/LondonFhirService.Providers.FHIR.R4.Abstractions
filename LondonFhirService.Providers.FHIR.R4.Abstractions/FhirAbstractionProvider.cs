// ---------------------------------------------------------
// Copyright (c) North East London ICB. All rights reserved.
// ---------------------------------------------------------

using System.Collections.Generic;
using LondonFhirService.Providers.FHIR.R4.Abstractions.Operations;
using LondonFhirService.Providers.FHIR.R4.Abstractions.Services.Foundations;

namespace LondonFhirService.Providers.FHIR.R4.Abstractions
{
    public partial class FhirAbstractionProvider : IFhirAbstractionProvider
    {
        private IProviderService providerService { get; set; }

        public FhirAbstractionProvider(IEnumerable<IFhirProvider> fhirProviders) =>
            this.providerService = new ProviderService(fhirProviders);

        public IAccountOperation Accounts(string providerName) =>
            TryCatch(() => providerService.GetProviderByName(providerName).Accounts);

        public IActivityDefinitionOperation ActivityDefinitions(string providerName) =>
            TryCatch(() => providerService.GetProviderByName(providerName).ActivityDefinitions);

        public IAdverseEventOperation AdverseEvents(string providerName) =>
            TryCatch(() => providerService.GetProviderByName(providerName).AdverseEvents);

        public IAllergyIntoleranceOperation AllergyIntolerances(string providerName) =>
            TryCatch(() => providerService.GetProviderByName(providerName).AllergyIntolerances);

        public IAppointmentResponseOperation AppointmentResponses(string providerName) =>
            TryCatch(() => providerService.GetProviderByName(providerName).AppointmentResponses);

        public IAppointmentOperation Appointments(string providerName) =>
            TryCatch(() => providerService.GetProviderByName(providerName).Appointments);

        public IAuditEventOperation AuditEvents(string providerName) =>
            TryCatch(() => providerService.GetProviderByName(providerName).AuditEvents);

        public IBasicOperation Basics(string providerName) =>
            TryCatch(() => providerService.GetProviderByName(providerName).Basics);

        public IBinaryOperation Binaries(string providerName) =>
            TryCatch(() => providerService.GetProviderByName(providerName).Binaries);

        public IBiologicallyDerivedProductOperation BiologicallyDerivedProducts(string providerName) =>
            TryCatch(() => providerService.GetProviderByName(providerName).BiologicallyDerivedProducts);

        public IBodyStructureOperation BodyStructures(string providerName) =>
            TryCatch(() => providerService.GetProviderByName(providerName).BodyStructures);

        public IBundleOperation Bundles(string providerName) =>
            TryCatch(() => providerService.GetProviderByName(providerName).Bundles);

        public ICapabilityStatementOperation CapabilityStatements(string providerName) =>
            TryCatch(() => providerService.GetProviderByName(providerName).CapabilityStatements);

        public ICarePlanOperation CarePlans(string providerName) =>
            TryCatch(() => providerService.GetProviderByName(providerName).CarePlans);

        public ICareTeamOperation CareTeams(string providerName) =>
            TryCatch(() => providerService.GetProviderByName(providerName).CareTeams);

        public ICatalogEntryOperation CatalogEntries(string providerName) =>
            TryCatch(() => providerService.GetProviderByName(providerName).CatalogEntries);

        public IChargeItemDefinitionOperation ChargeItemDefinitions(string providerName) =>
            TryCatch(() => providerService.GetProviderByName(providerName).ChargeItemDefinitions);

        public IChargeItemOperation ChargeItems(string providerName) =>
            TryCatch(() => providerService.GetProviderByName(providerName).ChargeItems);

        public IClaimResponseOperation ClaimResponses(string providerName) =>
            TryCatch(() => providerService.GetProviderByName(providerName).ClaimResponses);

        public IClaimOperation Claims(string providerName) =>
            TryCatch(() => providerService.GetProviderByName(providerName).Claims);

        public IClinicalImpressionOperation ClinicalImpressions(string providerName) =>
            TryCatch(() => providerService.GetProviderByName(providerName).ClinicalImpressions);

        public ICodeSystemOperation CodeSystems(string providerName) =>
            TryCatch(() => providerService.GetProviderByName(providerName).CodeSystems);

        public ICommunicationRequestOperation CommunicationRequests(string providerName) =>
            TryCatch(() => providerService.GetProviderByName(providerName).CommunicationRequests);

        public ICommunicationOperation Communications(string providerName) =>
            TryCatch(() => providerService.GetProviderByName(providerName).Communications);

        public ICompartmentDefinitionOperation CompartmentDefinitions(string providerName) =>
            TryCatch(() => providerService.GetProviderByName(providerName).CompartmentDefinitions);

        public ICompositionOperation Compositions(string providerName) =>
            TryCatch(() => providerService.GetProviderByName(providerName).Compositions);

        public IConceptMapOperation ConceptMaps(string providerName) =>
            TryCatch(() => providerService.GetProviderByName(providerName).ConceptMaps);

        public IConditionOperation Conditions(string providerName) =>
            TryCatch(() => providerService.GetProviderByName(providerName).Conditions);

        public IConsentOperation Consents(string providerName) =>
            TryCatch(() => providerService.GetProviderByName(providerName).Consents);

        public IContractOperation Contracts(string providerName) =>
            TryCatch(() => providerService.GetProviderByName(providerName).Contracts);

        public ICoverageEligibilityRequestOperation CoverageEligibilityRequests(string providerName) =>
            TryCatch(() => providerService.GetProviderByName(providerName).CoverageEligibilityRequests);

        public ICoverageEligibilityResponseOperation CoverageEligibilityResponses(string providerName) =>
            TryCatch(() => providerService.GetProviderByName(providerName).CoverageEligibilityResponses);

        public ICoverageOperation Coverages(string providerName) =>
            TryCatch(() => providerService.GetProviderByName(providerName).Coverages);

        public IDetectedIssueOperation DetectedIssues(string providerName) =>
            TryCatch(() => providerService.GetProviderByName(providerName).DetectedIssues);

        public IDeviceDefinitionOperation DeviceDefinitions(string providerName) =>
            TryCatch(() => providerService.GetProviderByName(providerName).DeviceDefinitions);

        public IDeviceMetricOperation DeviceMetrics(string providerName) =>
            TryCatch(() => providerService.GetProviderByName(providerName).DeviceMetrics);

        public IDeviceRequestOperation DeviceRequests(string providerName) =>
            TryCatch(() => providerService.GetProviderByName(providerName).DeviceRequests);

        public IDeviceOperation Devices(string providerName) =>
            TryCatch(() => providerService.GetProviderByName(providerName).Devices);

        public IDeviceUseStatementOperation DeviceUseStatements(string providerName) =>
            TryCatch(() => providerService.GetProviderByName(providerName).DeviceUseStatements);

        public IDiagnosticReportOperation DiagnosticReports(string providerName) =>
            TryCatch(() => providerService.GetProviderByName(providerName).DiagnosticReports);

        public IDocumentManifestOperation DocumentManifests(string providerName) =>
            TryCatch(() => providerService.GetProviderByName(providerName).DocumentManifests);

        public IDocumentReferenceOperation DocumentReferences(string providerName) =>
            TryCatch(() => providerService.GetProviderByName(providerName).DocumentReferences);

        public IEffectEvidenceSynthesisOperation EffectEvidenceSyntheses(string providerName) =>
            TryCatch(() => providerService.GetProviderByName(providerName).EffectEvidenceSyntheses);

        public IEncounterOperation Encounters(string providerName) =>
            TryCatch(() => providerService.GetProviderByName(providerName).Encounters);

        public IEndpointOperation Endpoints(string providerName) =>
            TryCatch(() => providerService.GetProviderByName(providerName).Endpoints);

        public IEnrollmentRequestOperation EnrollmentRequests(string providerName) =>
            TryCatch(() => providerService.GetProviderByName(providerName).EnrollmentRequests);

        public IEnrollmentResponseOperation EnrollmentResponses(string providerName) =>
            TryCatch(() => providerService.GetProviderByName(providerName).EnrollmentResponses);

        public IEpisodeOfCareOperation EpisodesOfCare(string providerName) =>
            TryCatch(() => providerService.GetProviderByName(providerName).EpisodesOfCare);

        public IEventDefinitionOperation EventDefinitions(string providerName) =>
            TryCatch(() => providerService.GetProviderByName(providerName).EventDefinitions);

        public IEvidenceOperation Evidences(string providerName) =>
            TryCatch(() => providerService.GetProviderByName(providerName).Evidences);

        public IEvidenceVariableOperation EvidenceVariables(string providerName) =>
            TryCatch(() => providerService.GetProviderByName(providerName).EvidenceVariables);

        public IExampleScenarioOperation ExampleScenarios(string providerName) =>
            TryCatch(() => providerService.GetProviderByName(providerName).ExampleScenarios);

        public IExplanationOfBenefitOperation ExplanationsOfBenefit(string providerName) =>
            TryCatch(() => providerService.GetProviderByName(providerName).ExplanationsOfBenefit);

        public IFamilyMemberHistoryOperation FamilyMemberHistories(string providerName) =>
            TryCatch(() => providerService.GetProviderByName(providerName).FamilyMemberHistories);

        public IFlagOperation Flags(string providerName) =>
            TryCatch(() => providerService.GetProviderByName(providerName).Flags);

        public IGoalOperation Goals(string providerName) =>
            TryCatch(() => providerService.GetProviderByName(providerName).Goals);

        public IGraphDefinitionOperation GraphDefinitions(string providerName) =>
            TryCatch(() => providerService.GetProviderByName(providerName).GraphDefinitions);

        public IGroupOperation Groups(string providerName) =>
            TryCatch(() => providerService.GetProviderByName(providerName).Groups);

        public IGuidanceResponseOperation GuidanceResponses(string providerName) =>
            TryCatch(() => providerService.GetProviderByName(providerName).GuidanceResponses);

        public IHealthcareServiceOperation HealthcareServices(string providerName) =>
            TryCatch(() => providerService.GetProviderByName(providerName).HealthcareServices);

        public IImagingStudyOperation ImagingStudies(string providerName) =>
            TryCatch(() => providerService.GetProviderByName(providerName).ImagingStudies);

        public IImmunizationEvaluationOperation ImmunizationEvaluations(string providerName) =>
            TryCatch(() => providerService.GetProviderByName(providerName).ImmunizationEvaluations);

        public IImmunizationRecommendationOperation ImmunizationRecommendations(string providerName) =>
            TryCatch(() => providerService.GetProviderByName(providerName).ImmunizationRecommendations);

        public IImmunizationOperation Immunizations(string providerName) =>
            TryCatch(() => providerService.GetProviderByName(providerName).Immunizations);

        public IImplementationGuideOperation ImplementationGuides(string providerName) =>
            TryCatch(() => providerService.GetProviderByName(providerName).ImplementationGuides);

        public IInsurancePlanOperation InsurancePlans(string providerName) =>
            TryCatch(() => providerService.GetProviderByName(providerName).InsurancePlans);

        public IInvoiceOperation Invoices(string providerName) =>
            TryCatch(() => providerService.GetProviderByName(providerName).Invoices);

        public ILibraryOperation Libraries(string providerName) =>
            TryCatch(() => providerService.GetProviderByName(providerName).Libraries);

        public ILinkageOperation Linkages(string providerName) =>
            TryCatch(() => providerService.GetProviderByName(providerName).Linkages);

        public IListOperation Lists(string providerName) =>
            TryCatch(() => providerService.GetProviderByName(providerName).Lists);

        public ILocationOperation Locations(string providerName) =>
            TryCatch(() => providerService.GetProviderByName(providerName).Locations);

        public IMeasureReportOperation MeasureReports(string providerName) =>
            TryCatch(() => providerService.GetProviderByName(providerName).MeasureReports);

        public IMeasureOperation Measures(string providerName) =>
            TryCatch(() => providerService.GetProviderByName(providerName).Measures);

        public IMediaOperation Media(string providerName) =>
            TryCatch(() => providerService.GetProviderByName(providerName).Media);

        public IMedicationAdministrationOperation MedicationAdministrations(string providerName) =>
            TryCatch(() => providerService.GetProviderByName(providerName).MedicationAdministrations);

        public IMedicationDispenseOperation MedicationDispenses(string providerName) =>
            TryCatch(() => providerService.GetProviderByName(providerName).MedicationDispenses);

        public IMedicationKnowledgeOperation MedicationKnowledge(string providerName) =>
            TryCatch(() => providerService.GetProviderByName(providerName).MedicationKnowledge);

        public IMedicationRequestOperation MedicationRequests(string providerName) =>
            TryCatch(() => providerService.GetProviderByName(providerName).MedicationRequests);

        public IMedicationOperation Medications(string providerName) =>
            TryCatch(() => providerService.GetProviderByName(providerName).Medications);

        public IMedicationStatementOperation MedicationStatements(string providerName) =>
            TryCatch(() => providerService.GetProviderByName(providerName).MedicationStatements);

        public IMedicinalProductAuthorizationOperation MedicinalProductAuthorizations(string providerName) =>
            TryCatch(() => providerService.GetProviderByName(providerName).MedicinalProductAuthorizations);

        public IMedicinalProductContraindicationOperation MedicinalProductContraindications(string providerName) =>
            TryCatch(() => providerService.GetProviderByName(providerName).MedicinalProductContraindications);

        public IMedicinalProductIndicationOperation MedicinalProductIndications(string providerName) =>
            TryCatch(() => providerService.GetProviderByName(providerName).MedicinalProductIndications);

        public IMedicinalProductIngredientOperation MedicinalProductIngredients(string providerName) =>
            TryCatch(() => providerService.GetProviderByName(providerName).MedicinalProductIngredients);

        public IMedicinalProductInteractionOperation MedicinalProductInteractions(string providerName) =>
            TryCatch(() => providerService.GetProviderByName(providerName).MedicinalProductInteractions);

        public IMedicinalProductManufacturedOperation MedicinalProductManufactureds(string providerName) =>
            TryCatch(() => providerService.GetProviderByName(providerName).MedicinalProductManufactureds);

        public IMedicinalProductPackagedOperation MedicinalProductPackageds(string providerName) =>
            TryCatch(() => providerService.GetProviderByName(providerName).MedicinalProductPackageds);

        public IMedicinalProductPharmaceuticalOperation MedicinalProductPharmaceuticals(string providerName) =>
            TryCatch(() => providerService.GetProviderByName(providerName).MedicinalProductPharmaceuticals);

        public IMedicinalProductOperation MedicinalProducts(string providerName) =>
            TryCatch(() => providerService.GetProviderByName(providerName).MedicinalProducts);

        public IMedicinalProductUndesirableEffectOperation MedicinalProductUndesirableEffects(string providerName) =>
            TryCatch(() => providerService.GetProviderByName(providerName).MedicinalProductUndesirableEffects);

        public IMessageDefinitionOperation MessageDefinitions(string providerName) =>
            TryCatch(() => providerService.GetProviderByName(providerName).MessageDefinitions);

        public IMessageHeaderOperation MessageHeaders(string providerName) =>
            TryCatch(() => providerService.GetProviderByName(providerName).MessageHeaders);

        public IMolecularSequenceOperation MolecularSequences(string providerName) =>
            TryCatch(() => providerService.GetProviderByName(providerName).MolecularSequences);

        public INamingSystemOperation NamingSystems(string providerName) =>
            TryCatch(() => providerService.GetProviderByName(providerName).NamingSystems);

        public INutritionOrderOperation NutritionOrders(string providerName) =>
            TryCatch(() => providerService.GetProviderByName(providerName).NutritionOrders);

        public IObservationDefinitionOperation ObservationDefinitions(string providerName) =>
            TryCatch(() => providerService.GetProviderByName(providerName).ObservationDefinitions);

        public IObservationOperation Observations(string providerName) =>
            TryCatch(() => providerService.GetProviderByName(providerName).Observations);

        public IOperationDefinitionOperation OperationDefinitions(string providerName) =>
            TryCatch(() => providerService.GetProviderByName(providerName).OperationDefinitions);

        public IOperationOutcomeOperation OperationOutcomes(string providerName) =>
            TryCatch(() => providerService.GetProviderByName(providerName).OperationOutcomes);

        public IOrganizationAffiliationOperation OrganizationAffiliations(string providerName) =>
            TryCatch(() => providerService.GetProviderByName(providerName).OrganizationAffiliations);

        public IOrganizationOperation Organizations(string providerName) =>
            TryCatch(() => providerService.GetProviderByName(providerName).Organizations);

        public IParametersOperation Parameters(string providerName) =>
            TryCatch(() => providerService.GetProviderByName(providerName).Parameters);

        public IPatientOperation Patients(string providerName) =>
            TryCatch(() => providerService.GetProviderByName(providerName).Patients);

        public IPaymentNoticeOperation PaymentNotices(string providerName) =>
            TryCatch(() => providerService.GetProviderByName(providerName).PaymentNotices);

        public IPaymentReconciliationOperation PaymentReconciliations(string providerName) =>
            TryCatch(() => providerService.GetProviderByName(providerName).PaymentReconciliations);

        public IPersonOperation Persons(string providerName) =>
            TryCatch(() => providerService.GetProviderByName(providerName).Persons);

        public IPlanDefinitionOperation PlanDefinitions(string providerName) =>
            TryCatch(() => providerService.GetProviderByName(providerName).PlanDefinitions);

        public IPractitionerRoleOperation PractitionerRoles(string providerName) =>
            TryCatch(() => providerService.GetProviderByName(providerName).PractitionerRoles);

        public IPractitionerOperation Practitioners(string providerName) =>
            TryCatch(() => providerService.GetProviderByName(providerName).Practitioners);

        public IProcedureOperation Procedures(string providerName) =>
            TryCatch(() => providerService.GetProviderByName(providerName).Procedures);

        public IProvenanceOperation Provenances(string providerName) =>
            TryCatch(() => providerService.GetProviderByName(providerName).Provenances);

        public IQuestionnaireResponseOperation QuestionnaireResponses(string providerName) =>
            TryCatch(() => providerService.GetProviderByName(providerName).QuestionnaireResponses);

        public IQuestionnaireOperation Questionnaires(string providerName) =>
            TryCatch(() => providerService.GetProviderByName(providerName).Questionnaires);

        public IRelatedPersonOperation RelatedPersons(string providerName) =>
            TryCatch(() => providerService.GetProviderByName(providerName).RelatedPersons);

        public IRequestGroupOperation RequestGroups(string providerName) =>
            TryCatch(() => providerService.GetProviderByName(providerName).RequestGroups);

        public IResearchDefinitionOperation ResearchDefinitions(string providerName) =>
            TryCatch(() => providerService.GetProviderByName(providerName).ResearchDefinitions);

        public IResearchElementDefinitionOperation ResearchElementDefinitions(string providerName) =>
            TryCatch(() => providerService.GetProviderByName(providerName).ResearchElementDefinitions);

        public IResearchStudyOperation ResearchStudies(string providerName) =>
            TryCatch(() => providerService.GetProviderByName(providerName).ResearchStudies);

        public IResearchSubjectOperation ResearchSubjects(string providerName) =>
            TryCatch(() => providerService.GetProviderByName(providerName).ResearchSubjects);

        public IRiskAssessmentOperation RiskAssessments(string providerName) =>
            TryCatch(() => providerService.GetProviderByName(providerName).RiskAssessments);

        public IRiskEvidenceSynthesisOperation RiskEvidenceSyntheses(string providerName) =>
            TryCatch(() => providerService.GetProviderByName(providerName).RiskEvidenceSyntheses);

        public IScheduleOperation Schedules(string providerName) =>
            TryCatch(() => providerService.GetProviderByName(providerName).Schedules);

        public ISearchParameterOperation SearchParameters(string providerName) =>
            TryCatch(() => providerService.GetProviderByName(providerName).SearchParameters);

        public IServiceRequestOperation ServiceRequests(string providerName) =>
            TryCatch(() => providerService.GetProviderByName(providerName).ServiceRequests);

        public ISlotOperation Slots(string providerName) =>
            TryCatch(() => providerService.GetProviderByName(providerName).Slots);

        public ISpecimenDefinitionOperation SpecimenDefinitions(string providerName) =>
            TryCatch(() => providerService.GetProviderByName(providerName).SpecimenDefinitions);

        public ISpecimenOperation Specimens(string providerName) =>
            TryCatch(() => providerService.GetProviderByName(providerName).Specimens);

        public IStructureDefinitionOperation StructureDefinitions(string providerName) =>
            TryCatch(() => providerService.GetProviderByName(providerName).StructureDefinitions);

        public IStructureMapOperation StructureMaps(string providerName) =>
            TryCatch(() => providerService.GetProviderByName(providerName).StructureMaps);

        public ISubscriptionOperation Subscriptions(string providerName) =>
            TryCatch(() => providerService.GetProviderByName(providerName).Subscriptions);

        public ISubstanceNucleicAcidOperation SubstanceNucleicAcids(string providerName) =>
            TryCatch(() => providerService.GetProviderByName(providerName).SubstanceNucleicAcids);

        public ISubstancePolymerOperation SubstancePolymers(string providerName) =>
            TryCatch(() => providerService.GetProviderByName(providerName).SubstancePolymers);

        public ISubstanceProteinOperation SubstanceProteins(string providerName) =>
            TryCatch(() => providerService.GetProviderByName(providerName).SubstanceProteins);

        public ISubstanceReferenceInformationOperation SubstanceReferenceInformations(string providerName) =>
            TryCatch(() => providerService.GetProviderByName(providerName).SubstanceReferenceInformations);

        public ISubstanceOperation Substances(string providerName) =>
            TryCatch(() => providerService.GetProviderByName(providerName).Substances);

        public ISubstanceSourceMaterialOperation SubstanceSourceMaterials(string providerName) =>
            TryCatch(() => providerService.GetProviderByName(providerName).SubstanceSourceMaterials);

        public ISubstanceSpecificationOperation SubstanceSpecifications(string providerName) =>
            TryCatch(() => providerService.GetProviderByName(providerName).SubstanceSpecifications);

        public ISupplyDeliveryOperation SupplyDeliveries(string providerName) =>
            TryCatch(() => providerService.GetProviderByName(providerName).SupplyDeliveries);

        public ISupplyRequestOperation SupplyRequests(string providerName) =>
            TryCatch(() => providerService.GetProviderByName(providerName).SupplyRequests);

        public ITaskOperation Tasks(string providerName) =>
            TryCatch(() => providerService.GetProviderByName(providerName).Tasks);

        public ITerminologyCapabilitiesOperation TerminologyCapabilities(string providerName) =>
            TryCatch(() => providerService.GetProviderByName(providerName).TerminologyCapabilities);

        public ITestReportOperation TestReports(string providerName) =>
            TryCatch(() => providerService.GetProviderByName(providerName).TestReports);

        public ITestScriptOperation TestScripts(string providerName) =>
            TryCatch(() => providerService.GetProviderByName(providerName).TestScripts);

        public IValueSetOperation ValueSets(string providerName) =>
            TryCatch(() => providerService.GetProviderByName(providerName).ValueSets);

        public IVerificationResultOperation VerificationResults(string providerName) =>
            TryCatch(() => providerService.GetProviderByName(providerName).VerificationResults);

        public IVisionPrescriptionOperation VisionPrescriptions(string providerName) =>
            TryCatch(() => providerService.GetProviderByName(providerName).VisionPrescriptions);
    }
}
