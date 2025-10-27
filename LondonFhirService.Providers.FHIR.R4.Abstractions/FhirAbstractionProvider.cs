// ---------------------------------------------------------
// Copyright (c) North East London ICB. All rights reserved.
// ---------------------------------------------------------

using System.Collections.Generic;
using LondonFhirService.Providers.FHIR.R4.Abstractions.Models.Resources;
using LondonFhirService.Providers.FHIR.R4.Abstractions.Services.Foundations;

namespace LondonFhirService.Providers.FHIR.R4.Abstractions
{
    public partial class FhirAbstractionProvider : IFhirAbstractionProvider
    {
        private IProviderService providerService { get; set; }

        public FhirAbstractionProvider(IEnumerable<IFhirProvider> fhirProviders) =>
            this.providerService = new ProviderService(fhirProviders);

        public IAccountResource Accounts(string providerName) =>
            TryCatch(() => providerService.GetProviderByName(providerName).Accounts);

        public IActivityDefinitionResource ActivityDefinitions(string providerName) =>
            TryCatch(() => providerService.GetProviderByName(providerName).ActivityDefinitions);

        public IAdverseEventResource AdverseEvents(string providerName) =>
            TryCatch(() => providerService.GetProviderByName(providerName).AdverseEvents);

        public IAllergyIntoleranceResource AllergyIntolerances(string providerName) =>
            TryCatch(() => providerService.GetProviderByName(providerName).AllergyIntolerances);

        public IAppointmentResponseResource AppointmentResponses(string providerName) =>
            TryCatch(() => providerService.GetProviderByName(providerName).AppointmentResponses);

        public IAppointmentResource Appointments(string providerName) =>
            TryCatch(() => providerService.GetProviderByName(providerName).Appointments);

        public IAuditEventResource AuditEvents(string providerName) =>
            TryCatch(() => providerService.GetProviderByName(providerName).AuditEvents);

        public IBasicResource Basics(string providerName) =>
            TryCatch(() => providerService.GetProviderByName(providerName).Basics);

        public IBinaryResource Binaries(string providerName) =>
            TryCatch(() => providerService.GetProviderByName(providerName).Binaries);

        public IBiologicallyDerivedProductResource BiologicallyDerivedProducts(string providerName) =>
            TryCatch(() => providerService.GetProviderByName(providerName).BiologicallyDerivedProducts);

        public IBodyStructureResource BodyStructures(string providerName) =>
            TryCatch(() => providerService.GetProviderByName(providerName).BodyStructures);

        public IBundleResource Bundles(string providerName) =>
            TryCatch(() => providerService.GetProviderByName(providerName).Bundles);

        public ICapabilityStatementResource CapabilityStatements(string providerName) =>
            TryCatch(() => providerService.GetProviderByName(providerName).CapabilityStatements);

        public ICarePlanResource CarePlans(string providerName) =>
            TryCatch(() => providerService.GetProviderByName(providerName).CarePlans);

        public ICareTeamResource CareTeams(string providerName) =>
            TryCatch(() => providerService.GetProviderByName(providerName).CareTeams);

        public ICatalogEntryResource CatalogEntries(string providerName) =>
            TryCatch(() => providerService.GetProviderByName(providerName).CatalogEntries);

        public IChargeItemDefinitionResource ChargeItemDefinitions(string providerName) =>
            TryCatch(() => providerService.GetProviderByName(providerName).ChargeItemDefinitions);

        public IChargeItemResource ChargeItems(string providerName) =>
            TryCatch(() => providerService.GetProviderByName(providerName).ChargeItems);

        public IClaimResponseResource ClaimResponses(string providerName) =>
            TryCatch(() => providerService.GetProviderByName(providerName).ClaimResponses);

        public IClaimResource Claims(string providerName) =>
            TryCatch(() => providerService.GetProviderByName(providerName).Claims);

        public IClinicalImpressionResource ClinicalImpressions(string providerName) =>
            TryCatch(() => providerService.GetProviderByName(providerName).ClinicalImpressions);

        public ICodeSystemResource CodeSystems(string providerName) =>
            TryCatch(() => providerService.GetProviderByName(providerName).CodeSystems);

        public ICommunicationRequestResource CommunicationRequests(string providerName) =>
            TryCatch(() => providerService.GetProviderByName(providerName).CommunicationRequests);

        public ICommunicationResource Communications(string providerName) =>
            TryCatch(() => providerService.GetProviderByName(providerName).Communications);

        public ICompartmentDefinitionResource CompartmentDefinitions(string providerName) =>
            TryCatch(() => providerService.GetProviderByName(providerName).CompartmentDefinitions);

        public ICompositionResource Compositions(string providerName) =>
            TryCatch(() => providerService.GetProviderByName(providerName).Compositions);

        public IConceptMapResource ConceptMaps(string providerName) =>
            TryCatch(() => providerService.GetProviderByName(providerName).ConceptMaps);

        public IConditionResource Conditions(string providerName) =>
            TryCatch(() => providerService.GetProviderByName(providerName).Conditions);

        public IConsentResource Consents(string providerName) =>
            TryCatch(() => providerService.GetProviderByName(providerName).Consents);

        public IContractResource Contracts(string providerName) =>
            TryCatch(() => providerService.GetProviderByName(providerName).Contracts);

        public ICoverageEligibilityRequestResource CoverageEligibilityRequests(string providerName) =>
            TryCatch(() => providerService.GetProviderByName(providerName).CoverageEligibilityRequests);

        public ICoverageEligibilityResponseResource CoverageEligibilityResponses(string providerName) =>
            TryCatch(() => providerService.GetProviderByName(providerName).CoverageEligibilityResponses);

        public ICoverageResource Coverages(string providerName) =>
            TryCatch(() => providerService.GetProviderByName(providerName).Coverages);

        public IDetectedIssueResource DetectedIssues(string providerName) =>
            TryCatch(() => providerService.GetProviderByName(providerName).DetectedIssues);

        public IDeviceDefinitionResource DeviceDefinitions(string providerName) =>
            TryCatch(() => providerService.GetProviderByName(providerName).DeviceDefinitions);

        public IDeviceMetricResource DeviceMetrics(string providerName) =>
            TryCatch(() => providerService.GetProviderByName(providerName).DeviceMetrics);

        public IDeviceRequestResource DeviceRequests(string providerName) =>
            TryCatch(() => providerService.GetProviderByName(providerName).DeviceRequests);

        public IDeviceResource Devices(string providerName) =>
            TryCatch(() => providerService.GetProviderByName(providerName).Devices);

        public IDeviceUseStatementResource DeviceUseStatements(string providerName) =>
            TryCatch(() => providerService.GetProviderByName(providerName).DeviceUseStatements);

        public IDiagnosticReportResource DiagnosticReports(string providerName) =>
            TryCatch(() => providerService.GetProviderByName(providerName).DiagnosticReports);

        public IDocumentManifestResource DocumentManifests(string providerName) =>
            TryCatch(() => providerService.GetProviderByName(providerName).DocumentManifests);

        public IDocumentReferenceResource DocumentReferences(string providerName) =>
            TryCatch(() => providerService.GetProviderByName(providerName).DocumentReferences);

        public IEffectEvidenceSynthesisResource EffectEvidenceSyntheses(string providerName) =>
            TryCatch(() => providerService.GetProviderByName(providerName).EffectEvidenceSyntheses);

        public IEncounterResource Encounters(string providerName) =>
            TryCatch(() => providerService.GetProviderByName(providerName).Encounters);

        public IEndpointResource Endpoints(string providerName) =>
            TryCatch(() => providerService.GetProviderByName(providerName).Endpoints);

        public IEnrollmentRequestResource EnrollmentRequests(string providerName) =>
            TryCatch(() => providerService.GetProviderByName(providerName).EnrollmentRequests);

        public IEnrollmentResponseResource EnrollmentResponses(string providerName) =>
            TryCatch(() => providerService.GetProviderByName(providerName).EnrollmentResponses);

        public IEpisodeOfCareResource EpisodesOfCare(string providerName) =>
            TryCatch(() => providerService.GetProviderByName(providerName).EpisodesOfCare);

        public IEventDefinitionResource EventDefinitions(string providerName) =>
            TryCatch(() => providerService.GetProviderByName(providerName).EventDefinitions);

        public IEvidenceResource Evidences(string providerName) =>
            TryCatch(() => providerService.GetProviderByName(providerName).Evidences);

        public IEvidenceVariableResource EvidenceVariables(string providerName) =>
            TryCatch(() => providerService.GetProviderByName(providerName).EvidenceVariables);

        public IExampleScenarioResource ExampleScenarios(string providerName) =>
            TryCatch(() => providerService.GetProviderByName(providerName).ExampleScenarios);

        public IExplanationOfBenefitResource ExplanationsOfBenefit(string providerName) =>
            TryCatch(() => providerService.GetProviderByName(providerName).ExplanationsOfBenefit);

        public IFamilyMemberHistoryResource FamilyMemberHistories(string providerName) =>
            TryCatch(() => providerService.GetProviderByName(providerName).FamilyMemberHistories);

        public IFlagResource Flags(string providerName) =>
            TryCatch(() => providerService.GetProviderByName(providerName).Flags);

        public IGoalResource Goals(string providerName) =>
            TryCatch(() => providerService.GetProviderByName(providerName).Goals);

        public IGraphDefinitionResource GraphDefinitions(string providerName) =>
            TryCatch(() => providerService.GetProviderByName(providerName).GraphDefinitions);

        public IGroupResource Groups(string providerName) =>
            TryCatch(() => providerService.GetProviderByName(providerName).Groups);

        public IGuidanceResponseResource GuidanceResponses(string providerName) =>
            TryCatch(() => providerService.GetProviderByName(providerName).GuidanceResponses);

        public IHealthcareServiceResource HealthcareServices(string providerName) =>
            TryCatch(() => providerService.GetProviderByName(providerName).HealthcareServices);

        public IImagingStudyResource ImagingStudies(string providerName) =>
            TryCatch(() => providerService.GetProviderByName(providerName).ImagingStudies);

        public IImmunizationEvaluationResource ImmunizationEvaluations(string providerName) =>
            TryCatch(() => providerService.GetProviderByName(providerName).ImmunizationEvaluations);

        public IImmunizationRecommendationResource ImmunizationRecommendations(string providerName) =>
            TryCatch(() => providerService.GetProviderByName(providerName).ImmunizationRecommendations);

        public IImmunizationResource Immunizations(string providerName) =>
            TryCatch(() => providerService.GetProviderByName(providerName).Immunizations);

        public IImplementationGuideResource ImplementationGuides(string providerName) =>
            TryCatch(() => providerService.GetProviderByName(providerName).ImplementationGuides);

        public IInsurancePlanResource InsurancePlans(string providerName) =>
            TryCatch(() => providerService.GetProviderByName(providerName).InsurancePlans);

        public IInvoiceResource Invoices(string providerName) =>
            TryCatch(() => providerService.GetProviderByName(providerName).Invoices);

        public ILibraryResource Libraries(string providerName) =>
            TryCatch(() => providerService.GetProviderByName(providerName).Libraries);

        public ILinkageResource Linkages(string providerName) =>
            TryCatch(() => providerService.GetProviderByName(providerName).Linkages);

        public IListResource Lists(string providerName) =>
            TryCatch(() => providerService.GetProviderByName(providerName).Lists);

        public ILocationResource Locations(string providerName) =>
            TryCatch(() => providerService.GetProviderByName(providerName).Locations);

        public IMeasureReportResource MeasureReports(string providerName) =>
            TryCatch(() => providerService.GetProviderByName(providerName).MeasureReports);

        public IMeasureResource Measures(string providerName) =>
            TryCatch(() => providerService.GetProviderByName(providerName).Measures);

        public IMediaResource Media(string providerName) =>
            TryCatch(() => providerService.GetProviderByName(providerName).Media);

        public IMedicationAdministrationResource MedicationAdministrations(string providerName) =>
            TryCatch(() => providerService.GetProviderByName(providerName).MedicationAdministrations);

        public IMedicationDispenseResource MedicationDispenses(string providerName) =>
            TryCatch(() => providerService.GetProviderByName(providerName).MedicationDispenses);

        public IMedicationKnowledgeResource MedicationKnowledge(string providerName) =>
            TryCatch(() => providerService.GetProviderByName(providerName).MedicationKnowledge);

        public IMedicationRequestResource MedicationRequests(string providerName) =>
            TryCatch(() => providerService.GetProviderByName(providerName).MedicationRequests);

        public IMedicationResource Medications(string providerName) =>
            TryCatch(() => providerService.GetProviderByName(providerName).Medications);

        public IMedicationStatementResource MedicationStatements(string providerName) =>
            TryCatch(() => providerService.GetProviderByName(providerName).MedicationStatements);

        public IMedicinalProductAuthorizationResource MedicinalProductAuthorizations(string providerName) =>
            TryCatch(() => providerService.GetProviderByName(providerName).MedicinalProductAuthorizations);

        public IMedicinalProductContraindicationResource MedicinalProductContraindications(string providerName) =>
            TryCatch(() => providerService.GetProviderByName(providerName).MedicinalProductContraindications);

        public IMedicinalProductIndicationResource MedicinalProductIndications(string providerName) =>
            TryCatch(() => providerService.GetProviderByName(providerName).MedicinalProductIndications);

        public IMedicinalProductIngredientResource MedicinalProductIngredients(string providerName) =>
            TryCatch(() => providerService.GetProviderByName(providerName).MedicinalProductIngredients);

        public IMedicinalProductInteractionResource MedicinalProductInteractions(string providerName) =>
            TryCatch(() => providerService.GetProviderByName(providerName).MedicinalProductInteractions);

        public IMedicinalProductManufacturedResource MedicinalProductManufactureds(string providerName) =>
            TryCatch(() => providerService.GetProviderByName(providerName).MedicinalProductManufactureds);

        public IMedicinalProductPackagedResource MedicinalProductPackageds(string providerName) =>
            TryCatch(() => providerService.GetProviderByName(providerName).MedicinalProductPackageds);

        public IMedicinalProductPharmaceuticalResource MedicinalProductPharmaceuticals(string providerName) =>
            TryCatch(() => providerService.GetProviderByName(providerName).MedicinalProductPharmaceuticals);

        public IMedicinalProductResource MedicinalProducts(string providerName) =>
            TryCatch(() => providerService.GetProviderByName(providerName).MedicinalProducts);

        public IMedicinalProductUndesirableEffectResource MedicinalProductUndesirableEffects(string providerName) =>
            TryCatch(() => providerService.GetProviderByName(providerName).MedicinalProductUndesirableEffects);

        public IMessageDefinitionResource MessageDefinitions(string providerName) =>
            TryCatch(() => providerService.GetProviderByName(providerName).MessageDefinitions);

        public IMessageHeaderResource MessageHeaders(string providerName) =>
            TryCatch(() => providerService.GetProviderByName(providerName).MessageHeaders);

        public IMolecularSequenceResource MolecularSequences(string providerName) =>
            TryCatch(() => providerService.GetProviderByName(providerName).MolecularSequences);

        public INamingSystemResource NamingSystems(string providerName) =>
            TryCatch(() => providerService.GetProviderByName(providerName).NamingSystems);

        public INutritionOrderResource NutritionOrders(string providerName) =>
            TryCatch(() => providerService.GetProviderByName(providerName).NutritionOrders);

        public IObservationDefinitionResource ObservationDefinitions(string providerName) =>
            TryCatch(() => providerService.GetProviderByName(providerName).ObservationDefinitions);

        public IObservationResource Observations(string providerName) =>
            TryCatch(() => providerService.GetProviderByName(providerName).Observations);

        public IOperationDefinitionResource OperationDefinitions(string providerName) =>
            TryCatch(() => providerService.GetProviderByName(providerName).OperationDefinitions);

        public IOperationOutcomeResource OperationOutcomes(string providerName) =>
            TryCatch(() => providerService.GetProviderByName(providerName).OperationOutcomes);

        public IOrganizationAffiliationResource OrganizationAffiliations(string providerName) =>
            TryCatch(() => providerService.GetProviderByName(providerName).OrganizationAffiliations);

        public IOrganizationResource Organizations(string providerName) =>
            TryCatch(() => providerService.GetProviderByName(providerName).Organizations);

        public IParametersResource Parameters(string providerName) =>
            TryCatch(() => providerService.GetProviderByName(providerName).Parameters);

        public IPatientResource Patients(string providerName) =>
            TryCatch(() => providerService.GetProviderByName(providerName).Patients);

        public IPaymentNoticeResource PaymentNotices(string providerName) =>
            TryCatch(() => providerService.GetProviderByName(providerName).PaymentNotices);

        public IPaymentReconciliationResource PaymentReconciliations(string providerName) =>
            TryCatch(() => providerService.GetProviderByName(providerName).PaymentReconciliations);

        public IPersonResource Persons(string providerName) =>
            TryCatch(() => providerService.GetProviderByName(providerName).Persons);

        public IPlanDefinitionResource PlanDefinitions(string providerName) =>
            TryCatch(() => providerService.GetProviderByName(providerName).PlanDefinitions);

        public IPractitionerRoleResource PractitionerRoles(string providerName) =>
            TryCatch(() => providerService.GetProviderByName(providerName).PractitionerRoles);

        public IPractitionerResource Practitioners(string providerName) =>
            TryCatch(() => providerService.GetProviderByName(providerName).Practitioners);

        public IProcedureResource Procedures(string providerName) =>
            TryCatch(() => providerService.GetProviderByName(providerName).Procedures);

        public IProvenanceResource Provenances(string providerName) =>
            TryCatch(() => providerService.GetProviderByName(providerName).Provenances);

        public IQuestionnaireResponseResource QuestionnaireResponses(string providerName) =>
            TryCatch(() => providerService.GetProviderByName(providerName).QuestionnaireResponses);

        public IQuestionnaireResource Questionnaires(string providerName) =>
            TryCatch(() => providerService.GetProviderByName(providerName).Questionnaires);

        public IRelatedPersonResource RelatedPersons(string providerName) =>
            TryCatch(() => providerService.GetProviderByName(providerName).RelatedPersons);

        public IRequestGroupResource RequestGroups(string providerName) =>
            TryCatch(() => providerService.GetProviderByName(providerName).RequestGroups);

        public IResearchDefinitionResource ResearchDefinitions(string providerName) =>
            TryCatch(() => providerService.GetProviderByName(providerName).ResearchDefinitions);

        public IResearchElementDefinitionResource ResearchElementDefinitions(string providerName) =>
            TryCatch(() => providerService.GetProviderByName(providerName).ResearchElementDefinitions);

        public IResearchStudyResource ResearchStudies(string providerName) =>
            TryCatch(() => providerService.GetProviderByName(providerName).ResearchStudies);

        public IResearchSubjectResource ResearchSubjects(string providerName) =>
            TryCatch(() => providerService.GetProviderByName(providerName).ResearchSubjects);

        public IRiskAssessmentResource RiskAssessments(string providerName) =>
            TryCatch(() => providerService.GetProviderByName(providerName).RiskAssessments);

        public IRiskEvidenceSynthesisResource RiskEvidenceSyntheses(string providerName) =>
            TryCatch(() => providerService.GetProviderByName(providerName).RiskEvidenceSyntheses);

        public IScheduleResource Schedules(string providerName) =>
            TryCatch(() => providerService.GetProviderByName(providerName).Schedules);

        public ISearchParameterResource SearchParameters(string providerName) =>
            TryCatch(() => providerService.GetProviderByName(providerName).SearchParameters);

        public IServiceRequestResource ServiceRequests(string providerName) =>
            TryCatch(() => providerService.GetProviderByName(providerName).ServiceRequests);

        public ISlotResource Slots(string providerName) =>
            TryCatch(() => providerService.GetProviderByName(providerName).Slots);

        public ISpecimenDefinitionResource SpecimenDefinitions(string providerName) =>
            TryCatch(() => providerService.GetProviderByName(providerName).SpecimenDefinitions);

        public ISpecimenResource Specimens(string providerName) =>
            TryCatch(() => providerService.GetProviderByName(providerName).Specimens);

        public IStructureDefinitionResource StructureDefinitions(string providerName) =>
            TryCatch(() => providerService.GetProviderByName(providerName).StructureDefinitions);

        public IStructureMapResource StructureMaps(string providerName) =>
            TryCatch(() => providerService.GetProviderByName(providerName).StructureMaps);

        public ISubscriptionResource Subscriptions(string providerName) =>
            TryCatch(() => providerService.GetProviderByName(providerName).Subscriptions);

        public ISubstanceNucleicAcidResource SubstanceNucleicAcids(string providerName) =>
            TryCatch(() => providerService.GetProviderByName(providerName).SubstanceNucleicAcids);

        public ISubstancePolymerResource SubstancePolymers(string providerName) =>
            TryCatch(() => providerService.GetProviderByName(providerName).SubstancePolymers);

        public ISubstanceProteinResource SubstanceProteins(string providerName) =>
            TryCatch(() => providerService.GetProviderByName(providerName).SubstanceProteins);

        public ISubstanceReferenceInformationResource SubstanceReferenceInformations(string providerName) =>
            TryCatch(() => providerService.GetProviderByName(providerName).SubstanceReferenceInformations);

        public ISubstanceResource Substances(string providerName) =>
            TryCatch(() => providerService.GetProviderByName(providerName).Substances);

        public ISubstanceSourceMaterialResource SubstanceSourceMaterials(string providerName) =>
            TryCatch(() => providerService.GetProviderByName(providerName).SubstanceSourceMaterials);

        public ISubstanceSpecificationResource SubstanceSpecifications(string providerName) =>
            TryCatch(() => providerService.GetProviderByName(providerName).SubstanceSpecifications);

        public ISupplyDeliveryResource SupplyDeliveries(string providerName) =>
            TryCatch(() => providerService.GetProviderByName(providerName).SupplyDeliveries);

        public ISupplyRequestResource SupplyRequests(string providerName) =>
            TryCatch(() => providerService.GetProviderByName(providerName).SupplyRequests);

        public ITaskResource Tasks(string providerName) =>
            TryCatch(() => providerService.GetProviderByName(providerName).Tasks);

        public ITerminologyCapabilitiesResource TerminologyCapabilities(string providerName) =>
            TryCatch(() => providerService.GetProviderByName(providerName).TerminologyCapabilities);

        public ITestReportResource TestReports(string providerName) =>
            TryCatch(() => providerService.GetProviderByName(providerName).TestReports);

        public ITestScriptResource TestScripts(string providerName) =>
            TryCatch(() => providerService.GetProviderByName(providerName).TestScripts);

        public IValueSetResource ValueSets(string providerName) =>
            TryCatch(() => providerService.GetProviderByName(providerName).ValueSets);

        public IVerificationResultResource VerificationResults(string providerName) =>
            TryCatch(() => providerService.GetProviderByName(providerName).VerificationResults);

        public IVisionPrescriptionResource VisionPrescriptions(string providerName) =>
            TryCatch(() => providerService.GetProviderByName(providerName).VisionPrescriptions);
    }
}
