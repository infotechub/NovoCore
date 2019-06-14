using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NovoCore.Data.Migrations
{
    public partial class classesss : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Bank",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Guid = table.Column<Guid>(nullable: false),
                    AddedBy = table.Column<string>(nullable: true),
                    CreatedOn = table.Column<DateTime>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bank", x => x.Id);
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
                    Status = table.Column<bool>(nullable: true),
                    AddedBy = table.Column<string>(nullable: true),
                    Guid = table.Column<Guid>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BenefitsCategory", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Lga",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Code = table.Column<string>(nullable: true),
                    State = table.Column<long>(nullable: true),
                    Status = table.Column<bool>(nullable: true),
                    Guid = table.Column<Guid>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: true)
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
                    Status = table.Column<string>(nullable: true),
                    Datepaymentstarted = table.Column<DateTime>(nullable: true),
                    Datepaymentcompleted = table.Column<DateTime>(nullable: true),
                    Terminationdate = table.Column<DateTime>(nullable: true),
                    Paidby = table.Column<int>(nullable: true),
                    CreatedBy = table.Column<int>(nullable: true),
                    Guid = table.Column<Guid>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: true),
                    Terminatedby = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentBatch", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Staff",
                columns: table => new
                {
                    CompanyId = table.Column<string>(nullable: true),
                    CompanySubsidiary = table.Column<int>(nullable: false),
                    StaffFullname = table.Column<string>(nullable: true),
                    HasProfile = table.Column<bool>(nullable: false),
                    IsExpunged = table.Column<bool>(nullable: false),
                    Profileid = table.Column<int>(nullable: false),
                    Createdby = table.Column<int>(nullable: false),
                    StaffId = table.Column<string>(nullable: false),
                    NewStaffId = table.Column<int>(nullable: false),
                    stafflinkDate = table.Column<DateTime>(nullable: true),
                    stafflinkUSer = table.Column<int>(nullable: false),
                    StaffJobId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Staff", x => x.StaffId);
                });

            migrationBuilder.CreateTable(
                name: "State",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Code = table.Column<string>(nullable: true),
                    Zone = table.Column<long>(nullable: true),
                    Status = table.Column<bool>(nullable: true),
                    Guid = table.Column<Guid>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: true),
                    SiteId = table.Column<int>(nullable: true),
                    EnrolleeDetailsPageId = table.Column<int>(nullable: true),
                    EnrolleeListPageId = table.Column<int>(nullable: true),
                    EnrolleePageId = table.Column<int>(nullable: true),
                    ProviderPageId = table.Column<int>(nullable: true),
                    EnrolleeRegPageId = table.Column<int>(nullable: true),
                    DelistedProviderPageId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_State", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Benefit",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Benefitlimit = table.Column<string>(nullable: true),
                    CategoryName = table.Column<string>(nullable: true),
                    Status = table.Column<bool>(nullable: true),
                    Guid = table.Column<Guid>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: true),
                    AddedBy = table.Column<string>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: true),
                    BenefitsCategoryId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Benefit", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Benefit_BenefitsCategory_BenefitsCategoryId",
                        column: x => x.BenefitsCategoryId,
                        principalTable: "BenefitsCategory",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ClaimBatch",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ProviderId = table.Column<int>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Month = table.Column<int>(nullable: true),
                    Year = table.Column<int>(nullable: true),
                    Batch = table.Column<string>(nullable: true),
                    Status = table.Column<string>(nullable: true),
                    SubmitedVetbyUser = table.Column<int>(nullable: true),
                    SubmitedReviewbyUser = table.Column<int>(nullable: true),
                    SubmitedForReviewDate = table.Column<DateTime>(nullable: true),
                    ReviewDate = table.Column<DateTime>(nullable: true),
                    ReviewedBy = table.Column<int>(nullable: true),
                    VetDate = table.Column<DateTime>(nullable: true),
                    SubmitedForPaymentDate = table.Column<DateTime>(nullable: true),
                    SubmitedPaymentbyUser = table.Column<int>(nullable: true),
                    AuthorizationStatus = table.Column<string>(nullable: true),
                    AuthorizationNote = table.Column<string>(nullable: true),
                    DisapprovalNote = table.Column<string>(nullable: true),
                    AuthorizedBy = table.Column<int>(nullable: true),
                    DisapprovedBy = table.Column<int>(nullable: true),
                    AuthorizedDate = table.Column<DateTime>(nullable: true),
                    DisapprovalDate = table.Column<DateTime>(nullable: true),
                    DeletionNote = table.Column<string>(nullable: true),
                    Guid = table.Column<Guid>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: true),
                    PaymentbatchId = table.Column<int>(nullable: true),
                    AmountPaid = table.Column<decimal>(nullable: true),
                    Paymentmethod = table.Column<string>(nullable: true),
                    Paymentref = table.Column<string>(nullable: true),
                    Chequeno = table.Column<string>(nullable: true),
                    SourceBankName = table.Column<string>(nullable: true),
                    SourceBankAccountNo = table.Column<string>(nullable: true),
                    DestBankName = table.Column<string>(nullable: true),
                    DestBankAccountNo = table.Column<string>(nullable: true),
                    Remark = table.Column<string>(nullable: true),
                    Paymentdate = table.Column<DateTime>(nullable: true),
                    Paidby = table.Column<string>(nullable: true),
                    Markpaidby = table.Column<int>(nullable: true),
                    ProviderName = table.Column<string>(nullable: true),
                    Claimscountfromclient = table.Column<int>(nullable: true),
                    Paymentmethodstring = table.Column<string>(nullable: true),
                    Paymentadvicesent = table.Column<bool>(nullable: true),
                    Datepaymentadvicesent = table.Column<DateTime>(nullable: true),
                    Isremote = table.Column<bool>(nullable: true),
                    AddedBy = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClaimBatch", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ClaimBatch_PaymentBatch_PaymentbatchId",
                        column: x => x.PaymentbatchId,
                        principalTable: "PaymentBatch",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
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
                    Parentid = table.Column<long>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Website = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    CreatedBy = table.Column<string>(nullable: true),
                    Logoid = table.Column<int>(nullable: true),
                    SubscriptionStatus = table.Column<int>(nullable: true),
                    Plans = table.Column<string>(nullable: true),
                    AuthorizationStatus = table.Column<int>(nullable: true),
                    AuthorizationNote = table.Column<string>(nullable: true),
                    DisapprovalNote = table.Column<string>(nullable: true),
                    AuthorizedBy = table.Column<int>(nullable: true),
                    DisapprovedBy = table.Column<int>(nullable: true),
                    AuthorizedDate = table.Column<DateTime>(nullable: true),
                    DisapprovalDate = table.Column<DateTime>(nullable: true),
                    DeletionNote = table.Column<string>(nullable: true),
                    Guid = table.Column<Guid>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: true),
                    Status = table.Column<bool>(nullable: true),
                    LogoLink = table.Column<string>(nullable: true),
                    RegCode = table.Column<string>(nullable: true),
                    RegAgeLimit = table.Column<int>(nullable: true),
                    IsRenewal = table.Column<bool>(nullable: true),
                    AddedBy = table.Column<string>(nullable: true),
                    StateId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Company", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Company_State_StateId",
                        column: x => x.StateId,
                        principalTable: "State",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
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
                    Providergpscordinate = table.Column<string>(nullable: true),
                    Providerservices = table.Column<string>(nullable: true),
                    Providerplans = table.Column<string>(nullable: true),
                    CreatedBy = table.Column<string>(nullable: true),
                    AuthorizationStatus = table.Column<string>(nullable: true),
                    AuthorizationNote = table.Column<string>(nullable: true),
                    DisapprovalNote = table.Column<string>(nullable: true),
                    AuthorizedBy = table.Column<string>(nullable: true),
                    DisapprovedBy = table.Column<string>(nullable: true),
                    AuthorizedDate = table.Column<DateTime>(nullable: true),
                    DisapprovalDate = table.Column<DateTime>(nullable: true),
                    Parentid = table.Column<long>(nullable: true),
                    Status = table.Column<bool>(nullable: true),
                    Guid = table.Column<Guid>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: true),
                    StateId = table.Column<int>(nullable: true),
                    LgaId = table.Column<int>(nullable: true),
                    SiteId = table.Column<int>(nullable: true),
                    ProviderTariffs = table.Column<string>(nullable: true),
                    Area = table.Column<string>(nullable: true),
                    Provideraccount2Id = table.Column<int>(nullable: true),
                    PaymentEmail1 = table.Column<string>(nullable: true),
                    PaymentEmail2 = table.Column<string>(nullable: true),
                    Category = table.Column<string>(nullable: true),
                    IsDelisted = table.Column<bool>(nullable: true),
                    DelistNote = table.Column<string>(nullable: true),
                    Delisteddate = table.Column<DateTime>(nullable: true),
                    DelistedBy = table.Column<string>(nullable: true),
                    DelistedProviderPageId = table.Column<int>(nullable: true),
                    CompanyConsession = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Provider", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Provider_Lga_LgaId",
                        column: x => x.LgaId,
                        principalTable: "Lga",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Provider_State_StateId",
                        column: x => x.StateId,
                        principalTable: "State",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CompanyBranch",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Subsidaryname = table.Column<string>(nullable: true),
                    Subsidaryprofile = table.Column<string>(nullable: true),
                    CreatedBy = table.Column<int>(nullable: true),
                    Guid = table.Column<Guid>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: true),
                    AddedBy = table.Column<string>(nullable: true),
                    Companyid = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanyBranch", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CompanyBranch_Company_Companyid",
                        column: x => x.Companyid,
                        principalTable: "Company",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Enrollee",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Parentid = table.Column<int>(nullable: false),
                    Parentrelationship = table.Column<int>(nullable: false),
                    Policynumber = table.Column<string>(nullable: true),
                    RefPolicynumber = table.Column<string>(nullable: true),
                    HasRefPolicyNumber = table.Column<bool>(nullable: false),
                    Title = table.Column<string>(nullable: true),
                    Surname = table.Column<string>(nullable: true),
                    Othernames = table.Column<string>(nullable: true),
                    Dob = table.Column<DateTime>(nullable: false),
                    Age = table.Column<int>(nullable: false),
                    Maritalstatus = table.Column<int>(nullable: false),
                    Occupation = table.Column<string>(nullable: true),
                    Sex = table.Column<int>(nullable: false),
                    Residentialaddress = table.Column<string>(nullable: true),
                    Stateid = table.Column<int>(nullable: true),
                    Lgaid = table.Column<int>(nullable: true),
                    Mobilenumber = table.Column<string>(nullable: true),
                    Mobilenumber2 = table.Column<string>(nullable: true),
                    Emailaddress = table.Column<string>(nullable: true),
                    Sponsorshiptype = table.Column<int>(nullable: false),
                    Sponsorshiptypeothername = table.Column<string>(nullable: true),
                    Preexistingmedicalhistory = table.Column<string>(nullable: true),
                    Sponsorshiptypenote = table.Column<string>(nullable: true),
                    CompanyId = table.Column<int>(nullable: true),
                    Subscriptionplanid = table.Column<int>(nullable: false),
                    Hasdependents = table.Column<bool>(nullable: false),
                    Specialidcardfield1 = table.Column<string>(nullable: true),
                    Specialidcardfield2 = table.Column<string>(nullable: true),
                    Specialidcardfield3 = table.Column<string>(nullable: true),
                    StaffId = table.Column<int>(nullable: true),
                    IdCardPrinted = table.Column<bool>(nullable: false),
                    Primaryprovider = table.Column<int>(nullable: false),
                    Status = table.Column<int>(nullable: false),
                    Hasactivesubscription = table.Column<bool>(nullable: false),
                    Isexpundged = table.Column<bool>(nullable: false),
                    ExpungeNote = table.Column<string>(nullable: true),
                    Expungedby = table.Column<int>(nullable: false),
                    Dateexpunged = table.Column<DateTime>(nullable: true),
                    Createdby = table.Column<int>(nullable: false),
                    Datereceived = table.Column<DateTime>(nullable: true),
                    LastyearBirthdaymsgsent = table.Column<int>(nullable: false),
                    Bulkjobid = table.Column<int>(nullable: false),
                    StaffId1 = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Enrollee", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Enrollee_Company_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Company",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Enrollee_Lga_Lgaid",
                        column: x => x.Lgaid,
                        principalTable: "Lga",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Enrollee_Staff_StaffId1",
                        column: x => x.StaffId1,
                        principalTable: "Staff",
                        principalColumn: "StaffId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Enrollee_State_Stateid",
                        column: x => x.Stateid,
                        principalTable: "State",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Subsidiary",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Subsidaryname = table.Column<string>(nullable: true),
                    Subsidaryprofile = table.Column<string>(nullable: true),
                    CreatedBy = table.Column<int>(nullable: true),
                    Guid = table.Column<Guid>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: true),
                    AddedBy = table.Column<string>(nullable: true),
                    Companyid = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subsidiary", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Subsidiary_Company_Companyid",
                        column: x => x.Companyid,
                        principalTable: "Company",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "IncomingClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Providerid = table.Column<int>(nullable: true),
                    Month = table.Column<int>(nullable: true),
                    Year = table.Column<int>(nullable: true),
                    FullDateofbill = table.Column<DateTime>(nullable: true),
                    Deliveredby = table.Column<string>(nullable: true),
                    DateReceived = table.Column<DateTime>(nullable: true),
                    ReceivedBy = table.Column<int>(nullable: true),
                    TransferedTo = table.Column<int>(nullable: true),
                    Transferstatus = table.Column<int>(nullable: true),
                    Noofencounter = table.Column<int>(nullable: true),
                    Totalamount = table.Column<decimal>(nullable: true),
                    Status = table.Column<string>(nullable: true),
                    DateTransferAcknowledged = table.Column<DateTime>(nullable: true),
                    Note = table.Column<string>(nullable: true),
                    CapturerList = table.Column<string>(nullable: true),
                    CaptureStarted = table.Column<DateTime>(nullable: true),
                    Guid = table.Column<Guid>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: true),
                    ClaimBatchId = table.Column<int>(nullable: true),
                    Caption = table.Column<string>(nullable: true),
                    IsRemoteSubmission = table.Column<bool>(nullable: true),
                    MonthString = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IncomingClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_IncomingClaims_ClaimBatch_ClaimBatchId",
                        column: x => x.ClaimBatchId,
                        principalTable: "ClaimBatch",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_IncomingClaims_Provider_Providerid",
                        column: x => x.Providerid,
                        principalTable: "Provider",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_IncomingClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ProviderAssignee",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AssignedBy = table.Column<int>(nullable: true),
                    Status = table.Column<bool>(nullable: true),
                    Guid = table.Column<Guid>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: true),
                    AddedBy = table.Column<string>(nullable: true),
                    Providerid = table.Column<int>(nullable: false),
                    UserId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProviderAssignee", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProviderAssignee_Provider_Providerid",
                        column: x => x.Providerid,
                        principalTable: "Provider",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProviderAssignee_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ProviderServices",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    OpeningDays = table.Column<string>(nullable: true),
                    Guid = table.Column<Guid>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: true),
                    ProviderId = table.Column<int>(nullable: true),
                    AddedBy = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProviderServices", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProviderServices_Provider_ProviderId",
                        column: x => x.ProviderId,
                        principalTable: "Provider",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AuthorizationCode",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AuthorizationCode = table.Column<string>(nullable: true),
                    PolicyNumber = table.Column<string>(nullable: true),
                    EnrolleeName = table.Column<string>(nullable: true),
                    EnrolleeCompany = table.Column<string>(nullable: true),
                    Diagnosis = table.Column<string>(nullable: true),
                    TypeofAuthorization = table.Column<string>(nullable: true),
                    EnrolleeAge = table.Column<int>(nullable: true),
                    Plan = table.Column<string>(nullable: true),
                    Note = table.Column<string>(nullable: true),
                    Requestername = table.Column<string>(nullable: true),
                    Requesterphone = table.Column<string>(nullable: true),
                    Generatedby = table.Column<int>(nullable: true),
                    Authorizedby = table.Column<int>(nullable: true),
                    AcknowledgedByAuthorizer = table.Column<bool>(nullable: true),
                    Guid = table.Column<Guid>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: true),
                    Isadmission = table.Column<bool>(nullable: true),
                    AdmissionDate = table.Column<DateTime>(nullable: true),
                    DaysApprovded = table.Column<int>(nullable: true),
                    DischargeDate = table.Column<DateTime>(nullable: true),
                    AdmissionStatus = table.Column<string>(nullable: true),
                    IsNhis = table.Column<bool>(nullable: true),
                    Isdelivery = table.Column<bool>(nullable: true),
                    Deliverysmssent = table.Column<bool>(nullable: true),
                    TreatmentAuthorized = table.Column<string>(nullable: true),
                    EnrolleeId = table.Column<int>(nullable: true),
                    ProviderId = table.Column<int>(nullable: true),
                    ApplicationUserId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AuthorizationCode", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AuthorizationCode_AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AuthorizationCode_Enrollee_EnrolleeId",
                        column: x => x.EnrolleeId,
                        principalTable: "Enrollee",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AuthorizationCode_Provider_ProviderId",
                        column: x => x.ProviderId,
                        principalTable: "Provider",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AuthorizationRequest",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ProviderName = table.Column<string>(nullable: true),
                    Policynumber = table.Column<string>(nullable: true),
                    Fullname = table.Column<string>(nullable: true),
                    Company = table.Column<string>(nullable: true),
                    Diagnosis = table.Column<string>(nullable: true),
                    Reasonforcode = table.Column<string>(nullable: true),
                    Isnew = table.Column<bool>(nullable: true),
                    Guid = table.Column<Guid>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: true),
                    EnrolleeId = table.Column<int>(nullable: true),
                    EnrolleeCompanyId = table.Column<int>(nullable: true),
                    ProviderId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AuthorizationRequest", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AuthorizationRequest_Company_EnrolleeCompanyId",
                        column: x => x.EnrolleeCompanyId,
                        principalTable: "Company",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AuthorizationRequest_Enrollee_EnrolleeId",
                        column: x => x.EnrolleeId,
                        principalTable: "Enrollee",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AuthorizationRequest_Provider_ProviderId",
                        column: x => x.ProviderId,
                        principalTable: "Provider",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Claim",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Enrolleeid = table.Column<int>(nullable: true),
                    EnrolleeFullname = table.Column<string>(nullable: true),
                    EnrolleeGender = table.Column<string>(nullable: true),
                    EnrolleeCompanyName = table.Column<string>(nullable: true),
                    EnrolleeCompanyId = table.Column<int>(nullable: true),
                    EnrolleePolicyNumber = table.Column<string>(nullable: true),
                    EnrolleePlan = table.Column<string>(nullable: true),
                    ClaimsSerialNo = table.Column<string>(nullable: true),
                    Evscode = table.Column<string>(nullable: true),
                    DoctorsName = table.Column<string>(nullable: true),
                    DoctorsId = table.Column<string>(nullable: true),
                    AreaOfSpecialty = table.Column<string>(nullable: true),
                    Signature = table.Column<string>(nullable: true),
                    DoctorSigned = table.Column<bool>(nullable: true),
                    DoctorSignecDate = table.Column<DateTime>(nullable: true),
                    SpecialistName = table.Column<string>(nullable: true),
                    AreaOfSpecialtyforspecialist = table.Column<string>(nullable: true),
                    Specialistphonenumber = table.Column<string>(nullable: true),
                    SpecialistSigned = table.Column<bool>(nullable: true),
                    SpecialistSignecDate = table.Column<DateTime>(nullable: true),
                    ServiceDate = table.Column<DateTime>(nullable: true),
                    AdmissionDate = table.Column<DateTime>(nullable: true),
                    DischargeDate = table.Column<DateTime>(nullable: true),
                    Durationoftreatment = table.Column<string>(nullable: true),
                    Diagnosis = table.Column<string>(nullable: true),
                    TreatmentGiven = table.Column<string>(nullable: true),
                    TreatmentCode = table.Column<string>(nullable: true),
                    ReferalCode = table.Column<string>(nullable: true),
                    EnrolleeSigned = table.Column<bool>(nullable: true),
                    EnrolleeSignDate = table.Column<DateTime>(nullable: true),
                    AllprescibedDrugs = table.Column<bool>(nullable: true),
                    LaboratoryInvestigation = table.Column<bool>(nullable: true),
                    Admission = table.Column<bool>(nullable: true),
                    Feeding = table.Column<bool>(nullable: true),
                    Note = table.Column<string>(nullable: true),
                    Tag = table.Column<string>(nullable: true),
                    CapturedBy = table.Column<int>(nullable: true),
                    VettedBy = table.Column<int>(nullable: true),
                    RevettedBy = table.Column<int>(nullable: true),
                    VettedDate = table.Column<DateTime>(nullable: true),
                    ReVettedDate = table.Column<DateTime>(nullable: true),
                    Status = table.Column<string>(nullable: true),
                    Guid = table.Column<Guid>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: true),
                    AddedBy = table.Column<string>(nullable: true),
                    Enrolleeage = table.Column<string>(nullable: true),
                    SubmitByProvider = table.Column<bool>(nullable: true),
                    Ipaddressofprovider = table.Column<string>(nullable: true),
                    ClaimBatchId = table.Column<int>(nullable: true),
                    ProviderId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Claim", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Claim_ClaimBatch_ClaimBatchId",
                        column: x => x.ClaimBatchId,
                        principalTable: "ClaimBatch",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Claim_Enrollee_Enrolleeid",
                        column: x => x.Enrolleeid,
                        principalTable: "Enrollee",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Claim_Provider_ProviderId",
                        column: x => x.ProviderId,
                        principalTable: "Provider",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "EnrolleePassport",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Imgraw = table.Column<byte[]>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Enrolleeid = table.Column<int>(nullable: true),
                    Enrolleepolicyno = table.Column<string>(nullable: true),
                    Guid = table.Column<Guid>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: true),
                    SiteId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EnrolleePassport", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EnrolleePassport_Enrollee_Enrolleeid",
                        column: x => x.Enrolleeid,
                        principalTable: "Enrollee",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ProviderRating",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ProviderId = table.Column<int>(nullable: true),
                    Rating = table.Column<int>(nullable: true),
                    FeedBack = table.Column<string>(nullable: true),
                    Fullname = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Guid = table.Column<Guid>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: true),
                    Enrolleeid = table.Column<int>(nullable: true),
                    Dateaccessed = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProviderRating", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProviderRating_Enrollee_Enrolleeid",
                        column: x => x.Enrolleeid,
                        principalTable: "Enrollee",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ProviderRating_Provider_ProviderId",
                        column: x => x.ProviderId,
                        principalTable: "Provider",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
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
                    Rate = table.Column<string>(nullable: true),
                    InitialAmount = table.Column<decimal>(nullable: true),
                    Costofdrug = table.Column<decimal>(nullable: true),
                    Flagred = table.Column<bool>(nullable: true),
                    DrugId = table.Column<int>(nullable: true),
                    VettedAmount = table.Column<decimal>(nullable: true),
                    VettingComment = table.Column<string>(nullable: true),
                    Status = table.Column<string>(nullable: true),
                    Guid = table.Column<Guid>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: true),
                    ClaimId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClaimDrug", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ClaimDrug_Claim_ClaimId",
                        column: x => x.ClaimId,
                        principalTable: "Claim",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
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
                    Rate = table.Column<string>(nullable: true),
                    InitialAmount = table.Column<decimal>(nullable: true),
                    Costofdrug = table.Column<decimal>(nullable: true),
                    Flagred = table.Column<bool>(nullable: true),
                    ServiceId = table.Column<int>(nullable: true),
                    VettedAmount = table.Column<decimal>(nullable: true),
                    VettingComment = table.Column<string>(nullable: true),
                    Status = table.Column<string>(nullable: true),
                    Guid = table.Column<Guid>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: true),
                    ClaimId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClaimService", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ClaimService_Claim_ClaimId",
                        column: x => x.ClaimId,
                        principalTable: "Claim",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AuthorizationCode_ApplicationUserId",
                table: "AuthorizationCode",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_AuthorizationCode_EnrolleeId",
                table: "AuthorizationCode",
                column: "EnrolleeId");

            migrationBuilder.CreateIndex(
                name: "IX_AuthorizationCode_ProviderId",
                table: "AuthorizationCode",
                column: "ProviderId");

            migrationBuilder.CreateIndex(
                name: "IX_AuthorizationRequest_EnrolleeCompanyId",
                table: "AuthorizationRequest",
                column: "EnrolleeCompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_AuthorizationRequest_EnrolleeId",
                table: "AuthorizationRequest",
                column: "EnrolleeId");

            migrationBuilder.CreateIndex(
                name: "IX_AuthorizationRequest_ProviderId",
                table: "AuthorizationRequest",
                column: "ProviderId");

            migrationBuilder.CreateIndex(
                name: "IX_Benefit_BenefitsCategoryId",
                table: "Benefit",
                column: "BenefitsCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Claim_ClaimBatchId",
                table: "Claim",
                column: "ClaimBatchId");

            migrationBuilder.CreateIndex(
                name: "IX_Claim_Enrolleeid",
                table: "Claim",
                column: "Enrolleeid");

            migrationBuilder.CreateIndex(
                name: "IX_Claim_ProviderId",
                table: "Claim",
                column: "ProviderId");

            migrationBuilder.CreateIndex(
                name: "IX_ClaimBatch_PaymentbatchId",
                table: "ClaimBatch",
                column: "PaymentbatchId");

            migrationBuilder.CreateIndex(
                name: "IX_ClaimDrug_ClaimId",
                table: "ClaimDrug",
                column: "ClaimId");

            migrationBuilder.CreateIndex(
                name: "IX_ClaimService_ClaimId",
                table: "ClaimService",
                column: "ClaimId");

            migrationBuilder.CreateIndex(
                name: "IX_Company_StateId",
                table: "Company",
                column: "StateId");

            migrationBuilder.CreateIndex(
                name: "IX_CompanyBranch_Companyid",
                table: "CompanyBranch",
                column: "Companyid");

            migrationBuilder.CreateIndex(
                name: "IX_Enrollee_CompanyId",
                table: "Enrollee",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_Enrollee_Lgaid",
                table: "Enrollee",
                column: "Lgaid");

            migrationBuilder.CreateIndex(
                name: "IX_Enrollee_StaffId1",
                table: "Enrollee",
                column: "StaffId1");

            migrationBuilder.CreateIndex(
                name: "IX_Enrollee_Stateid",
                table: "Enrollee",
                column: "Stateid");

            migrationBuilder.CreateIndex(
                name: "IX_EnrolleePassport_Enrolleeid",
                table: "EnrolleePassport",
                column: "Enrolleeid",
                unique: true,
                filter: "[Enrolleeid] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_IncomingClaims_ClaimBatchId",
                table: "IncomingClaims",
                column: "ClaimBatchId");

            migrationBuilder.CreateIndex(
                name: "IX_IncomingClaims_Providerid",
                table: "IncomingClaims",
                column: "Providerid");

            migrationBuilder.CreateIndex(
                name: "IX_IncomingClaims_UserId",
                table: "IncomingClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Provider_LgaId",
                table: "Provider",
                column: "LgaId");

            migrationBuilder.CreateIndex(
                name: "IX_Provider_StateId",
                table: "Provider",
                column: "StateId");

            migrationBuilder.CreateIndex(
                name: "IX_ProviderAssignee_Providerid",
                table: "ProviderAssignee",
                column: "Providerid",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ProviderAssignee_UserId",
                table: "ProviderAssignee",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_ProviderRating_Enrolleeid",
                table: "ProviderRating",
                column: "Enrolleeid");

            migrationBuilder.CreateIndex(
                name: "IX_ProviderRating_ProviderId",
                table: "ProviderRating",
                column: "ProviderId",
                unique: true,
                filter: "[ProviderId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_ProviderServices_ProviderId",
                table: "ProviderServices",
                column: "ProviderId");

            migrationBuilder.CreateIndex(
                name: "IX_Subsidiary_Companyid",
                table: "Subsidiary",
                column: "Companyid",
                unique: true,
                filter: "[Companyid] IS NOT NULL");
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
                name: "ClaimDrug");

            migrationBuilder.DropTable(
                name: "ClaimService");

            migrationBuilder.DropTable(
                name: "CompanyBranch");

            migrationBuilder.DropTable(
                name: "EnrolleePassport");

            migrationBuilder.DropTable(
                name: "IncomingClaims");

            migrationBuilder.DropTable(
                name: "ProviderAssignee");

            migrationBuilder.DropTable(
                name: "ProviderRating");

            migrationBuilder.DropTable(
                name: "ProviderServices");

            migrationBuilder.DropTable(
                name: "Subsidiary");

            migrationBuilder.DropTable(
                name: "BenefitsCategory");

            migrationBuilder.DropTable(
                name: "Claim");

            migrationBuilder.DropTable(
                name: "ClaimBatch");

            migrationBuilder.DropTable(
                name: "Enrollee");

            migrationBuilder.DropTable(
                name: "Provider");

            migrationBuilder.DropTable(
                name: "PaymentBatch");

            migrationBuilder.DropTable(
                name: "Company");

            migrationBuilder.DropTable(
                name: "Staff");

            migrationBuilder.DropTable(
                name: "Lga");

            migrationBuilder.DropTable(
                name: "State");
        }
    }
}
