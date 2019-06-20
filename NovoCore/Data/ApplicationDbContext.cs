using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using NovoClasses.Models;
using NovoCore.Models;

namespace NovoCore.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser, ApplicationRole, string>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) { }


      
        public  DbSet<AdminAllowedRole> AdminAllowedRoles { get; set; }
        public  DbSet<AdminDisallowedRole> AdminDisallowedRoles { get; set; }
        public  DbSet<AuthorizationCode> AuthorizationCodes { get; set; }
        public  DbSet<AuthorizationRequest> AuthorizationRequests { get; set; }
        public  DbSet<AutomaticExpungeStaff> AutomaticExpungeStaffs { get; set; }
        public  DbSet<Bank> Banks { get; set; }
        public  DbSet<Batch> Batches { get; set; }
        public  DbSet<BatchJob> BatchJobs { get; set; }
        public  DbSet<BatchRun> BatchRuns { get; set; }
        public  DbSet<BatchRunResult> BatchRunResults { get; set; }
        public  DbSet<Benefit> Benefits { get; set; }
        public  DbSet<BenefitsCategory> BenefitsCategories { get; set; }
        public  DbSet<Claim> Claims { get; set; }
        public  DbSet<ClaimAnalysisOffline> ClaimAnalysisOfflines { get; set; }
        public  DbSet<ClaimBatch> ClaimBatches { get; set; }
        public  DbSet<ClaimDrug> ClaimDrugs { get; set; }
        public  DbSet<ClaimHistory> ClaimHistories { get; set; }
        public  DbSet<ClaimService> ClaimServices { get; set; }
        public  DbSet<Company> Companies { get; set; }
        public  DbSet<CompanyAssignee> CompanyAssignees { get; set; }
        public  DbSet<CompanyBenefit> CompanyBenefits { get; set; }
        public  DbSet<CompanyBranch> CompanyBranches { get; set; }
        public  DbSet<CompanyPlan> CompanyPlans { get; set; }
        public  DbSet<CompanySubsidiary> CompanySubsidiaries { get; set; }
        public  DbSet<ConnectCareBeneficiary> ConnectCareBeneficiaries { get; set; }
        public  DbSet<ConnectcarePaymentDetail> ConnectcarePaymentDetails { get; set; }
        public  DbSet<ConnectCareSponsor> ConnectCareSponsors { get; set; }
        public  DbSet<Country> Countries { get; set; }
        public  DbSet<DeletedEnrollee> DeletedEnrollees { get; set; }
        public  DbSet<DownloadFile> DownloadFiles { get; set; }
        public  DbSet<DrugTariff> DrugTariffs { get; set; }
        public  DbSet<EmailDEST> EmailDESTs { get; set; }
        public  DbSet<EnrolleePassport> EnrolleePassports { get; set; }
        public  DbSet<EnrolleePreexistingMedicalHistory> EnrolleePreexistingMedicalHistories { get; set; }
        public  DbSet<EnrolleeVerificationCode> EnrolleeVerificationCodes { get; set; }
        public  DbSet<ExpungedEnrollee> ExpungedEnrollees { get; set; }
        public  DbSet<FacilitiesAllowed> FacilitiesAlloweds { get; set; }
        public  DbSet<Faq> Faqs { get; set; }
        public  DbSet<FormListOption> FormListOptions { get; set; }
        public  DbSet<FormPosting> FormPostings { get; set; }
        public  DbSet<FormProperty> FormProperties { get; set; }
        public  DbSet<FormValue> FormValues { get; set; }
        
        public  DbSet<Gender> Genders { get; set; }
        
        public  DbSet<IncomingClaim> IncomingClaims { get; set; }
        public  DbSet<Issue> Issues { get; set; }
        
        public  DbSet<Lga> Lgas { get; set; }
        public  DbSet<Log> Logs { get; set; }
        public  DbSet<LuceneFieldBoost> LuceneFieldBoosts { get; set; }
        public  DbSet<MaritalStatu> MaritalStatus { get; set; }
        public  DbSet<MediaFile> MediaFiles { get; set; }
        public  DbSet<MessageTemplate> MessageTemplates { get; set; }
        public  DbSet<MobileSignup> MobileSignups { get; set; }
        public  DbSet<Notification> Notifications { get; set; }
        public  DbSet<NotificationTable> NotificationTables { get; set; }
        public  DbSet<NovoStaff> NovoStaffs { get; set; }
        public  DbSet<NovoStaffResponsibility> NovoStaffResponsibilities { get; set; }
        public  DbSet<OfflineMessage> OfflineMessages { get; set; }
        public  DbSet<PageTemplate> PageTemplates { get; set; }
       
        public  DbSet<PaymentBatch> PaymentBatches { get; set; }
        public  DbSet<PendingDependant> PendingDependants { get; set; }
        public  DbSet<Plan> Plans { get; set; }
        public  DbSet<PlanDefaultBenefit> PlanDefaultBenefits { get; set; }
        public  DbSet<PreExistingMedicalHistoryList> PreExistingMedicalHistoryLists { get; set; }
        public  DbSet<Provider> Providers { get; set; }
        public  DbSet<ProviderAccount> ProviderAccounts { get; set; }
        public  DbSet<ProviderAssignee> ProviderAssignees { get; set; }
        public  DbSet<ProviderClaimBK> ProviderClaimBKs { get; set; }
        public  DbSet<ProviderLogin> ProviderLogins { get; set; }
        public  DbSet<ProviderRating> ProviderRatings { get; set; }
        public  DbSet<ProviderService> ProviderServices { get; set; }
        public  DbSet<QueuedMessage> QueuedMessages { get; set; }
        public  DbSet<QueuedMessageAttachment> QueuedMessageAttachments { get; set; }
        public  DbSet<QueuedTask> QueuedTasks { get; set; }
        public  DbSet<RedirectedDomain> RedirectedDomains { get; set; }
        public  DbSet<ResizedImage> ResizedImages { get; set; }
        public  DbSet<ScheduledTask> ScheduledTasks { get; set; }
        public  DbSet<NovoService> Services { get; set; }
        public  DbSet<ServiceTariff> ServiceTariffs { get; set; }
        public  DbSet<Setting> Settings { get; set; }
        public  DbSet<ShortCodeMsg> ShortCodeMsgs { get; set; }
      
        public  DbSet<Site> Sites { get; set; }
        public  DbSet<Sm> Sms { get; set; }
        public  DbSet<SmsConfig> SmsConfigs { get; set; }
        public  DbSet<SponsorShipType> SponsorShipTypes { get; set; }
       
        public  DbSet<StaffUploadJob> StaffUploadJobs { get; set; }
        public  DbSet<State> States { get; set; }
        public  DbSet<StringResource> StringResources { get; set; }
        public  DbSet<Subscription> Subscriptions { get; set; }
        public  DbSet<Symposium> Symposiums { get; set; }
        public  DbSet<Tag> Tags { get; set; }
        public  DbSet<Tariff> Tariffs { get; set; }
        public  DbSet<TariffCategory> TariffCategories { get; set; }
        public  DbSet<TaskShit> TaskShits { get; set; }
        public  DbSet<TempEnrollee> TempEnrollees { get; set; }
        public  DbSet<TerminatedSubscription> TerminatedSubscriptions { get; set; }
        public  DbSet<testable> testables { get; set; }
        public  DbSet<UrlHistory> UrlHistories { get; set; }
       
        public  DbSet<UserNotification> UserNotifications { get; set; }
        public  DbSet<UserProfileData> UserProfileDatas { get; set; }
      
        public  DbSet<VettingProtocol> VettingProtocols { get; set; }
       
        public  DbSet<Zone> Zones { get; set; }
        public  DbSet<Enrollee> Enrollees { get; set; }
       
        public  DbSet<Query> Queries { get; set; }
        public  DbSet<Staff> Staffs { get; set; }
       
        public  DbSet<WrongProfile> WrongProfiles { get; set; }
    }

        
}
