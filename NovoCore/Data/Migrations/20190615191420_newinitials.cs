using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NovoCore.Data.Migrations
{
    public partial class newinitials : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOn",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CugMobileNumber",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Dob",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "Guid",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastLoginDate",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "LoginAttempts",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedOn",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "AspNetRoles",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "AspNetRoles",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "AuthorizationCode",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    authorizationCode = table.Column<string>(nullable: true),
                    policyNumber = table.Column<string>(nullable: true),
                    enrolleeName = table.Column<string>(nullable: true),
                    EnrolleeCompany = table.Column<string>(nullable: true),
                    Diagnosis = table.Column<string>(nullable: true),
                    TypeofAuthorization = table.Column<string>(nullable: true),
                    enrolleeAge = table.Column<int>(nullable: false),
                    enrolleeID = table.Column<int>(nullable: false),
                    Plan = table.Column<string>(nullable: true),
                    Note = table.Column<string>(nullable: true),
                    requestername = table.Column<string>(nullable: true),
                    requesterphone = table.Column<string>(nullable: true),
                    provider = table.Column<int>(nullable: false),
                    generatedby = table.Column<int>(nullable: false),
                    Authorizedby = table.Column<int>(nullable: false),
                    AcknowledgedByAuthorizer = table.Column<bool>(nullable: false),
                    Guid = table.Column<Guid>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    UpdatedOn = table.Column<DateTime>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    Isadmission = table.Column<bool>(nullable: false),
                    AdmissionDate = table.Column<DateTime>(nullable: false),
                    DaysApprovded = table.Column<int>(nullable: false),
                    DischargeDate = table.Column<DateTime>(nullable: false),
                    admissionStatus = table.Column<string>(nullable: true),
                    IsNHIS = table.Column<bool>(nullable: false),
                    isdelivery = table.Column<bool>(nullable: false),
                    deliverysmssent = table.Column<bool>(nullable: false),
                    treatmentAuthorized = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AuthorizationCode", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AuthorizationRequest",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    providerid = table.Column<int>(nullable: false),
                    providerName = table.Column<string>(nullable: true),
                    policynumber = table.Column<string>(nullable: true),
                    fullname = table.Column<string>(nullable: true),
                    company = table.Column<string>(nullable: true),
                    diagnosis = table.Column<string>(nullable: true),
                    reasonforcode = table.Column<string>(nullable: true),
                    isnew = table.Column<bool>(nullable: false),
                    Guid = table.Column<Guid>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    UpdatedOn = table.Column<DateTime>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AuthorizationRequest", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Bank",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Guid = table.Column<Guid>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    UpdatedOn = table.Column<DateTime>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bank", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Benefit",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Benefitcategory = table.Column<int>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    Benefitlimit = table.Column<string>(nullable: true),
                    CategoryName = table.Column<string>(nullable: true),
                    Status = table.Column<bool>(nullable: false),
                    Guid = table.Column<Guid>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    UpdatedOn = table.Column<DateTime>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Benefit", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BenefitsCategory",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Code = table.Column<string>(nullable: true),
                    Servicetype = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Status = table.Column<bool>(nullable: false),
                    Guid = table.Column<Guid>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    UpdatedOn = table.Column<DateTime>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BenefitsCategory", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Company",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Code = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    Stateid = table.Column<long>(nullable: false),
                    Parentid = table.Column<long>(nullable: false),
                    Email = table.Column<string>(nullable: true),
                    Website = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    CreatedBy = table.Column<string>(nullable: true),
                    Logoid = table.Column<int>(nullable: false),
                    SubscriptionStatus = table.Column<int>(nullable: false),
                    Plans = table.Column<string>(nullable: true),
                    AuthorizationStatus = table.Column<int>(nullable: false),
                    AuthorizationNote = table.Column<string>(nullable: true),
                    DisapprovalNote = table.Column<string>(nullable: true),
                    AuthorizedBy = table.Column<int>(nullable: false),
                    DisapprovedBy = table.Column<int>(nullable: false),
                    AuthorizedDate = table.Column<DateTime>(nullable: false),
                    DisapprovalDate = table.Column<DateTime>(nullable: false),
                    DeletionNote = table.Column<string>(nullable: true),
                    Guid = table.Column<Guid>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    UpdatedOn = table.Column<DateTime>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    SubsidiaryId = table.Column<int>(nullable: false),
                    CompanyListPageId = table.Column<int>(nullable: false),
                    Status = table.Column<bool>(nullable: false),
                    LogoLink = table.Column<string>(nullable: true),
                    regCode = table.Column<string>(nullable: true),
                    RegAgeLimit = table.Column<int>(nullable: false),
                    WeboperationMode = table.Column<bool>(nullable: false),
                    isRenewal = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Company", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CompanySubsidiary",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ParentcompanyId = table.Column<int>(nullable: false),
                    Subsidaryname = table.Column<string>(nullable: true),
                    Subsidaryprofile = table.Column<string>(nullable: true),
                    CreatedBy = table.Column<int>(nullable: false),
                    Guid = table.Column<Guid>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    UpdatedOn = table.Column<DateTime>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanySubsidiary", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EnrolleePassport",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Imgraw = table.Column<byte[]>(nullable: true),
                    Enrolleeid = table.Column<int>(nullable: false),
                    Enrolleepolicyno = table.Column<string>(nullable: true),
                    Guid = table.Column<Guid>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    UpdatedOn = table.Column<DateTime>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EnrolleePassport", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FacilitiesAllowed",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CompanyPlanId = table.Column<string>(nullable: true),
                    Planid = table.Column<string>(nullable: true),
                    ProviderId = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Status = table.Column<string>(nullable: true),
                    Guid = table.Column<Guid>(nullable: true),
                    CreatedOn = table.Column<DateTime>(nullable: true),
                    DeletedOn = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: true),
                    SiteId = table.Column<int>(nullable: true),
                    FacilitiesAllowedPageId = table.Column<int>(nullable: true),
                    CompanyName = table.Column<string>(nullable: true),
                    CompanyId = table.Column<string>(nullable: true),
                    AddedBy = table.Column<string>(nullable: true),
                    DeletedBy = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FacilitiesAllowed", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Lga",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Code = table.Column<string>(nullable: true),
                    State = table.Column<long>(nullable: false),
                    Status = table.Column<bool>(nullable: false),
                    Guid = table.Column<Guid>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    UpdatedOn = table.Column<DateTime>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    EnrolleeDetailsPageId = table.Column<int>(nullable: false),
                    EnrolleeListPageId = table.Column<int>(nullable: false),
                    EnrolleePageId = table.Column<int>(nullable: false),
                    ProviderPageId = table.Column<int>(nullable: false),
                    EnrolleeRegPageId = table.Column<int>(nullable: false),
                    DelistedProviderPageId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lga", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PaymentBatch",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Title = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Note = table.Column<string>(nullable: true),
                    status = table.Column<string>(nullable: true),
                    datepaymentstarted = table.Column<DateTime>(nullable: false),
                    datepaymentcompleted = table.Column<DateTime>(nullable: false),
                    terminationdate = table.Column<DateTime>(nullable: false),
                    paidby = table.Column<int>(nullable: false),
                    createdBy = table.Column<int>(nullable: false),
                    Guid = table.Column<Guid>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    UpdatedOn = table.Column<DateTime>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    terminatedby = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentBatch", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Provider",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Code = table.Column<string>(nullable: true),
                    SubCode = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Phone = table.Column<string>(nullable: true),
                    Phone2 = table.Column<string>(nullable: true),
                    Website = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    Assignee = table.Column<int>(nullable: false),
                    Providergpscordinate = table.Column<string>(nullable: true),
                    Providerservices = table.Column<string>(nullable: true),
                    Providerplans = table.Column<string>(nullable: true),
                    CreatedBy = table.Column<string>(nullable: true),
                    AuthorizationStatus = table.Column<int>(nullable: false),
                    AuthorizationNote = table.Column<string>(nullable: true),
                    DisapprovalNote = table.Column<string>(nullable: true),
                    AuthorizedBy = table.Column<int>(nullable: false),
                    DisapprovedBy = table.Column<int>(nullable: false),
                    AuthorizedDate = table.Column<DateTime>(nullable: false),
                    DisapprovalDate = table.Column<DateTime>(nullable: false),
                    Parentid = table.Column<long>(nullable: false),
                    Status = table.Column<bool>(nullable: false),
                    Guid = table.Column<Guid>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    UpdatedOn = table.Column<DateTime>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    StateId = table.Column<int>(nullable: false),
                    LgaId = table.Column<int>(nullable: false),
                    ProvideraccountId = table.Column<int>(nullable: false),
                    ProviderListPageId = table.Column<int>(nullable: false),
                    ProviderApprovalPageId = table.Column<int>(nullable: false),
                    DeletionNote = table.Column<string>(nullable: true),
                    TariffPageId = table.Column<int>(nullable: false),
                    TariffContentPageId = table.Column<int>(nullable: false),
                    ProviderTariffs = table.Column<string>(nullable: true),
                    Area = table.Column<string>(nullable: true),
                    Provideraccount2Id = table.Column<int>(nullable: false),
                    PaymentEmail1 = table.Column<string>(nullable: true),
                    PaymentEmail2 = table.Column<string>(nullable: true),
                    providerloginId = table.Column<int>(nullable: false),
                    Category = table.Column<string>(nullable: true),
                    isDelisted = table.Column<bool>(nullable: false),
                    DelistNote = table.Column<string>(nullable: true),
                    delisteddate = table.Column<DateTime>(nullable: false),
                    delistedBy = table.Column<int>(nullable: false),
                    DelistedProviderPageId = table.Column<int>(nullable: false),
                    CompanyConsession = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Provider", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProviderAccount",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Providerid = table.Column<int>(nullable: false),
                    BankId = table.Column<int>(nullable: false),
                    Bankaccountname = table.Column<string>(nullable: true),
                    Bankaccountnum = table.Column<string>(nullable: true),
                    Bankbranch = table.Column<string>(nullable: true),
                    Note = table.Column<string>(nullable: true),
                    Status = table.Column<bool>(nullable: false),
                    AuthorizationStatus = table.Column<int>(nullable: false),
                    AuthorizationNote = table.Column<string>(nullable: true),
                    DisapprovalNote = table.Column<string>(nullable: true),
                    AuthorizedBy = table.Column<int>(nullable: false),
                    DisapprovedBy = table.Column<int>(nullable: false),
                    AuthorizedDate = table.Column<DateTime>(nullable: false),
                    DisapprovalDate = table.Column<DateTime>(nullable: false),
                    Guid = table.Column<Guid>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    UpdatedOn = table.Column<DateTime>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProviderAccount", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProviderAssignee",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Providerid = table.Column<int>(nullable: false),
                    Userid = table.Column<int>(nullable: false),
                    AssignedBy = table.Column<int>(nullable: false),
                    Status = table.Column<bool>(nullable: false),
                    Guid = table.Column<Guid>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    UpdatedOn = table.Column<DateTime>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProviderAssignee", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProviderLogin",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    password = table.Column<string>(nullable: true),
                    passwordchange = table.Column<bool>(nullable: false),
                    browserid = table.Column<string>(nullable: true),
                    lastloginId = table.Column<string>(nullable: true),
                    lastlogin = table.Column<DateTime>(nullable: false),
                    active = table.Column<bool>(nullable: false),
                    LastClaimSubmited = table.Column<DateTime>(nullable: false),
                    Guid = table.Column<Guid>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    UpdatedOn = table.Column<DateTime>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    ProviderId = table.Column<int>(nullable: false),
                    email = table.Column<string>(nullable: true),
                    Altemail = table.Column<string>(nullable: true),
                    Altemail2 = table.Column<string>(nullable: true),
                    Altemail3 = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProviderLogin", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProviderRating",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    providerID = table.Column<int>(nullable: false),
                    rating = table.Column<int>(nullable: false),
                    FeedBack = table.Column<string>(nullable: true),
                    Fullname = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Guid = table.Column<Guid>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    UpdatedOn = table.Column<DateTime>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    enrolleeid = table.Column<int>(nullable: false),
                    dateaccessed = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProviderRating", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "State",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Code = table.Column<string>(nullable: true),
                    Zone = table.Column<long>(nullable: false),
                    Status = table.Column<bool>(nullable: false),
                    Guid = table.Column<Guid>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    UpdatedOn = table.Column<DateTime>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    EnrolleeDetailsPageId = table.Column<int>(nullable: false),
                    EnrolleeListPageId = table.Column<int>(nullable: false),
                    EnrolleePageId = table.Column<int>(nullable: false),
                    ProviderPageId = table.Column<int>(nullable: false),
                    EnrolleeRegPageId = table.Column<int>(nullable: false),
                    DelistedProviderPageId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_State", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CompanyBranch",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Statecode = table.Column<int>(nullable: false),
                    Branch = table.Column<string>(nullable: true),
                    Guid = table.Column<Guid>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    UpdatedOn = table.Column<DateTime>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    companyId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanyBranch", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CompanyBranch_Company_companyId",
                        column: x => x.companyId,
                        principalTable: "Company",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ClaimBatch",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ProviderId = table.Column<int>(nullable: false),
                    month = table.Column<int>(nullable: false),
                    year = table.Column<int>(nullable: false),
                    Batch = table.Column<string>(nullable: true),
                    status = table.Column<string>(nullable: true),
                    submitedVetbyUser = table.Column<int>(nullable: false),
                    submitedReviewbyUser = table.Column<int>(nullable: false),
                    SubmitedForReviewDate = table.Column<DateTime>(nullable: false),
                    reviewDate = table.Column<DateTime>(nullable: false),
                    reviewedBy = table.Column<int>(nullable: false),
                    VetDate = table.Column<DateTime>(nullable: false),
                    SubmitedForPaymentDate = table.Column<DateTime>(nullable: false),
                    submitedPaymentbyUser = table.Column<int>(nullable: false),
                    AuthorizationStatus = table.Column<string>(nullable: true),
                    AuthorizationNote = table.Column<string>(nullable: true),
                    DisapprovalNote = table.Column<string>(nullable: true),
                    AuthorizedBy = table.Column<int>(nullable: false),
                    DisapprovedBy = table.Column<int>(nullable: false),
                    AuthorizedDate = table.Column<DateTime>(nullable: false),
                    DisapprovalDate = table.Column<DateTime>(nullable: false),
                    DeletionNote = table.Column<string>(nullable: true),
                    Guid = table.Column<Guid>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    UpdatedOn = table.Column<DateTime>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    paymentbatchId = table.Column<int>(nullable: false),
                    AmountPaid = table.Column<decimal>(nullable: false),
                    paymentmethod = table.Column<string>(nullable: true),
                    paymentref = table.Column<string>(nullable: true),
                    chequeno = table.Column<string>(nullable: true),
                    sourceBankName = table.Column<string>(nullable: true),
                    sourceBankAccountNo = table.Column<string>(nullable: true),
                    DestBankName = table.Column<string>(nullable: true),
                    DestBankAccountNo = table.Column<string>(nullable: true),
                    remark = table.Column<string>(nullable: true),
                    paymentdate = table.Column<DateTime>(nullable: false),
                    paidby = table.Column<string>(nullable: true),
                    markpaidby = table.Column<int>(nullable: false),
                    ProviderName = table.Column<string>(nullable: true),
                    claimscountfromclient = table.Column<int>(nullable: false),
                    paymentmethodstring = table.Column<string>(nullable: true),
                    paymentadvicesent = table.Column<bool>(nullable: false),
                    datepaymentadvicesent = table.Column<DateTime>(nullable: false),
                    isremote = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClaimBatch", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ClaimBatch_PaymentBatch_paymentbatchId",
                        column: x => x.paymentbatchId,
                        principalTable: "PaymentBatch",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProviderServices",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    description = table.Column<string>(nullable: true),
                    OpeningDays = table.Column<string>(nullable: true),
                    Guid = table.Column<Guid>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    UpdatedOn = table.Column<DateTime>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    providerId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProviderServices", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProviderServices_Provider_providerId",
                        column: x => x.providerId,
                        principalTable: "Provider",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Claim",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ProviderId = table.Column<int>(nullable: false),
                    Enrolleeid = table.Column<int>(nullable: false),
                    enrolleeFullname = table.Column<string>(nullable: true),
                    enrolleeGender = table.Column<string>(nullable: true),
                    enrolleeCompanyName = table.Column<string>(nullable: true),
                    enrolleeCompanyId = table.Column<int>(nullable: false),
                    enrolleePolicyNumber = table.Column<string>(nullable: true),
                    EnrolleePlan = table.Column<string>(nullable: true),
                    ClaimsSerialNo = table.Column<string>(nullable: true),
                    EVSCode = table.Column<string>(nullable: true),
                    DoctorsName = table.Column<string>(nullable: true),
                    DoctorsId = table.Column<string>(nullable: true),
                    AreaOfSpecialty = table.Column<string>(nullable: true),
                    Signature = table.Column<string>(nullable: true),
                    DoctorSigned = table.Column<bool>(nullable: false),
                    DoctorSignecDate = table.Column<DateTime>(nullable: false),
                    specialistName = table.Column<string>(nullable: true),
                    AreaOfSpecialtyforspecialist = table.Column<string>(nullable: true),
                    specialistphonenumber = table.Column<string>(nullable: true),
                    specialistSigned = table.Column<bool>(nullable: false),
                    specialistSignecDate = table.Column<DateTime>(nullable: false),
                    ServiceDate = table.Column<DateTime>(nullable: false),
                    AdmissionDate = table.Column<DateTime>(nullable: false),
                    DischargeDate = table.Column<DateTime>(nullable: false),
                    Durationoftreatment = table.Column<string>(nullable: true),
                    Diagnosis = table.Column<string>(nullable: true),
                    TreatmentGiven = table.Column<string>(nullable: true),
                    TreatmentCode = table.Column<string>(nullable: true),
                    referalCode = table.Column<string>(nullable: true),
                    enrolleeSigned = table.Column<bool>(nullable: false),
                    EnrolleeSignDate = table.Column<DateTime>(nullable: false),
                    AllprescibedDrugs = table.Column<bool>(nullable: false),
                    LaboratoryInvestigation = table.Column<bool>(nullable: false),
                    Admission = table.Column<bool>(nullable: false),
                    Feeding = table.Column<bool>(nullable: false),
                    Note = table.Column<string>(nullable: true),
                    Tag = table.Column<string>(nullable: true),
                    capturedBy = table.Column<int>(nullable: false),
                    capturedName = table.Column<string>(nullable: true),
                    vettedBy = table.Column<int>(nullable: false),
                    RevettedBy = table.Column<int>(nullable: false),
                    VettedDate = table.Column<DateTime>(nullable: false),
                    ReVettedDate = table.Column<DateTime>(nullable: false),
                    status = table.Column<string>(nullable: true),
                    Guid = table.Column<Guid>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    UpdatedOn = table.Column<DateTime>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    ClaimBatchId = table.Column<int>(nullable: false),
                    enrolleeage = table.Column<string>(nullable: true),
                    ClientsideID = table.Column<string>(nullable: true),
                    diagnosticsIDString = table.Column<string>(nullable: true),
                    SubmitByProvider = table.Column<bool>(nullable: false),
                    ipaddressofprovider = table.Column<string>(nullable: true),
                    vettedName = table.Column<string>(nullable: true),
                    MyUserId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Claim", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Claim_ClaimBatch_ClaimBatchId",
                        column: x => x.ClaimBatchId,
                        principalTable: "ClaimBatch",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "IncomingClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    providerid = table.Column<int>(nullable: false),
                    month = table.Column<int>(nullable: false),
                    year = table.Column<int>(nullable: false),
                    fullDateofbill = table.Column<DateTime>(nullable: false),
                    deliveredby = table.Column<string>(nullable: true),
                    DateReceived = table.Column<DateTime>(nullable: false),
                    receivedBy = table.Column<int>(nullable: false),
                    transferedTo = table.Column<int>(nullable: false),
                    transferstatus = table.Column<int>(nullable: false),
                    noofencounter = table.Column<int>(nullable: false),
                    totalamount = table.Column<decimal>(nullable: false),
                    status = table.Column<string>(nullable: true),
                    dateTransferAcknowledged = table.Column<DateTime>(nullable: false),
                    Note = table.Column<string>(nullable: true),
                    CapturerList = table.Column<string>(nullable: true),
                    captureStarted = table.Column<DateTime>(nullable: false),
                    Guid = table.Column<Guid>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    UpdatedOn = table.Column<DateTime>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    ClaimBatchId = table.Column<int>(nullable: false),
                    caption = table.Column<string>(nullable: true),
                    IsRemoteSubmission = table.Column<bool>(nullable: false),
                    month_string = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IncomingClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_IncomingClaims_ClaimBatch_ClaimBatchId",
                        column: x => x.ClaimBatchId,
                        principalTable: "ClaimBatch",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ClaimDrug",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DrugName = table.Column<string>(nullable: true),
                    DrugDescription = table.Column<string>(nullable: true),
                    Quantity = table.Column<string>(nullable: true),
                    rate = table.Column<string>(nullable: true),
                    InitialAmount = table.Column<decimal>(nullable: false),
                    costofdrug = table.Column<decimal>(nullable: false),
                    flagred = table.Column<bool>(nullable: false),
                    DrugId = table.Column<int>(nullable: false),
                    VettedAmount = table.Column<decimal>(nullable: false),
                    VettingComment = table.Column<string>(nullable: true),
                    status = table.Column<string>(nullable: true),
                    Guid = table.Column<Guid>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    UpdatedOn = table.Column<DateTime>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    ClaimId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClaimDrug", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ClaimDrug_Claim_ClaimId",
                        column: x => x.ClaimId,
                        principalTable: "Claim",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ClaimService",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ServiceName = table.Column<string>(nullable: true),
                    ServiceDescription = table.Column<string>(nullable: true),
                    Duration = table.Column<string>(nullable: true),
                    rate = table.Column<string>(nullable: true),
                    InitialAmount = table.Column<decimal>(nullable: false),
                    costofdrug = table.Column<decimal>(nullable: false),
                    flagred = table.Column<bool>(nullable: false),
                    ServiceId = table.Column<int>(nullable: false),
                    VettedAmount = table.Column<decimal>(nullable: false),
                    VettingComment = table.Column<string>(nullable: true),
                    status = table.Column<string>(nullable: true),
                    Guid = table.Column<Guid>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    UpdatedOn = table.Column<DateTime>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    ClaimId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClaimService", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ClaimService_Claim_ClaimId",
                        column: x => x.ClaimId,
                        principalTable: "Claim",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Claim_ClaimBatchId",
                table: "Claim",
                column: "ClaimBatchId");

            migrationBuilder.CreateIndex(
                name: "IX_ClaimBatch_paymentbatchId",
                table: "ClaimBatch",
                column: "paymentbatchId");

            migrationBuilder.CreateIndex(
                name: "IX_ClaimDrug_ClaimId",
                table: "ClaimDrug",
                column: "ClaimId");

            migrationBuilder.CreateIndex(
                name: "IX_ClaimService_ClaimId",
                table: "ClaimService",
                column: "ClaimId");

            migrationBuilder.CreateIndex(
                name: "IX_CompanyBranch_companyId",
                table: "CompanyBranch",
                column: "companyId");

            migrationBuilder.CreateIndex(
                name: "IX_IncomingClaims_ClaimBatchId",
                table: "IncomingClaims",
                column: "ClaimBatchId");

            migrationBuilder.CreateIndex(
                name: "IX_ProviderServices_providerId",
                table: "ProviderServices",
                column: "providerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AuthorizationCode");

            migrationBuilder.DropTable(
                name: "AuthorizationRequest");

            migrationBuilder.DropTable(
                name: "Bank");

            migrationBuilder.DropTable(
                name: "Benefit");

            migrationBuilder.DropTable(
                name: "BenefitsCategory");

            migrationBuilder.DropTable(
                name: "ClaimDrug");

            migrationBuilder.DropTable(
                name: "ClaimService");

            migrationBuilder.DropTable(
                name: "CompanyBranch");

            migrationBuilder.DropTable(
                name: "CompanySubsidiary");

            migrationBuilder.DropTable(
                name: "EnrolleePassport");

            migrationBuilder.DropTable(
                name: "FacilitiesAllowed");

            migrationBuilder.DropTable(
                name: "IncomingClaims");

            migrationBuilder.DropTable(
                name: "Lga");

            migrationBuilder.DropTable(
                name: "ProviderAccount");

            migrationBuilder.DropTable(
                name: "ProviderAssignee");

            migrationBuilder.DropTable(
                name: "ProviderLogin");

            migrationBuilder.DropTable(
                name: "ProviderRating");

            migrationBuilder.DropTable(
                name: "ProviderServices");

            migrationBuilder.DropTable(
                name: "State");

            migrationBuilder.DropTable(
                name: "Claim");

            migrationBuilder.DropTable(
                name: "Company");

            migrationBuilder.DropTable(
                name: "Provider");

            migrationBuilder.DropTable(
                name: "ClaimBatch");

            migrationBuilder.DropTable(
                name: "PaymentBatch");

            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "CugMobileNumber",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Dob",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Guid",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastLoginDate",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LoginAttempts",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "UpdatedOn",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "AspNetRoles");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "AspNetRoles");
        }
    }
}
