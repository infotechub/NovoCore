using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NovoCore.Data.Migrations
{
    public partial class newclasses2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Claim_ClaimBatch_ClaimBatchId",
                table: "Claim");

            migrationBuilder.DropForeignKey(
                name: "FK_ClaimBatch_PaymentBatch_paymentbatchId",
                table: "ClaimBatch");

            migrationBuilder.DropForeignKey(
                name: "FK_ClaimDrug_Claim_ClaimId",
                table: "ClaimDrug");

            migrationBuilder.DropForeignKey(
                name: "FK_ClaimService_Claim_ClaimId",
                table: "ClaimService");

            migrationBuilder.DropForeignKey(
                name: "FK_CompanyBranch_Company_companyId",
                table: "CompanyBranch");

            migrationBuilder.DropForeignKey(
                name: "FK_IncomingClaims_ClaimBatch_ClaimBatchId",
                table: "IncomingClaims");

            migrationBuilder.DropForeignKey(
                name: "FK_ProviderServices_Provider_providerId",
                table: "ProviderServices");

            migrationBuilder.DropColumn(
                name: "MyUserId",
                table: "Claim");

            migrationBuilder.DropColumn(
                name: "vettedName",
                table: "Claim");

            migrationBuilder.AlterColumn<long>(
                name: "Zone",
                table: "State",
                nullable: true,
                oldClrType: typeof(long));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedOn",
                table: "State",
                nullable: true,
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<bool>(
                name: "Status",
                table: "State",
                nullable: true,
                oldClrType: typeof(bool));

            migrationBuilder.AlterColumn<int>(
                name: "ProviderPageId",
                table: "State",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<bool>(
                name: "IsDeleted",
                table: "State",
                nullable: true,
                oldClrType: typeof(bool));

            migrationBuilder.AlterColumn<int>(
                name: "EnrolleeRegPageId",
                table: "State",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "EnrolleePageId",
                table: "State",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "EnrolleeListPageId",
                table: "State",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "EnrolleeDetailsPageId",
                table: "State",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "DelistedProviderPageId",
                table: "State",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "State",
                nullable: true,
                oldClrType: typeof(DateTime));

            migrationBuilder.AddColumn<int>(
                name: "SiteId",
                table: "State",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "providerId",
                table: "ProviderServices",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedOn",
                table: "ProviderServices",
                nullable: true,
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<bool>(
                name: "IsDeleted",
                table: "ProviderServices",
                nullable: true,
                oldClrType: typeof(bool));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "ProviderServices",
                nullable: true,
                oldClrType: typeof(DateTime));

            migrationBuilder.AddColumn<int>(
                name: "SiteId",
                table: "ProviderServices",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "rating",
                table: "ProviderRating",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "providerID",
                table: "ProviderRating",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "enrolleeid",
                table: "ProviderRating",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<DateTime>(
                name: "dateaccessed",
                table: "ProviderRating",
                nullable: true,
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedOn",
                table: "ProviderRating",
                nullable: true,
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<bool>(
                name: "IsDeleted",
                table: "ProviderRating",
                nullable: true,
                oldClrType: typeof(bool));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "ProviderRating",
                nullable: true,
                oldClrType: typeof(DateTime));

            migrationBuilder.AddColumn<int>(
                name: "SiteId",
                table: "ProviderRating",
                nullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "passwordchange",
                table: "ProviderLogin",
                nullable: true,
                oldClrType: typeof(bool));

            migrationBuilder.AlterColumn<DateTime>(
                name: "lastlogin",
                table: "ProviderLogin",
                nullable: true,
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<bool>(
                name: "active",
                table: "ProviderLogin",
                nullable: true,
                oldClrType: typeof(bool));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedOn",
                table: "ProviderLogin",
                nullable: true,
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<int>(
                name: "ProviderId",
                table: "ProviderLogin",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastClaimSubmited",
                table: "ProviderLogin",
                nullable: true,
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<bool>(
                name: "IsDeleted",
                table: "ProviderLogin",
                nullable: true,
                oldClrType: typeof(bool));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "ProviderLogin",
                nullable: true,
                oldClrType: typeof(DateTime));

            migrationBuilder.AddColumn<int>(
                name: "SiteId",
                table: "ProviderLogin",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Userid",
                table: "ProviderAssignee",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedOn",
                table: "ProviderAssignee",
                nullable: true,
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<bool>(
                name: "Status",
                table: "ProviderAssignee",
                nullable: true,
                oldClrType: typeof(bool));

            migrationBuilder.AlterColumn<int>(
                name: "Providerid",
                table: "ProviderAssignee",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<bool>(
                name: "IsDeleted",
                table: "ProviderAssignee",
                nullable: true,
                oldClrType: typeof(bool));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "ProviderAssignee",
                nullable: true,
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<int>(
                name: "AssignedBy",
                table: "ProviderAssignee",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "SiteId",
                table: "ProviderAssignee",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedOn",
                table: "ProviderAccount",
                nullable: true,
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<bool>(
                name: "Status",
                table: "ProviderAccount",
                nullable: true,
                oldClrType: typeof(bool));

            migrationBuilder.AlterColumn<int>(
                name: "Providerid",
                table: "ProviderAccount",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<bool>(
                name: "IsDeleted",
                table: "ProviderAccount",
                nullable: true,
                oldClrType: typeof(bool));

            migrationBuilder.AlterColumn<int>(
                name: "DisapprovedBy",
                table: "ProviderAccount",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DisapprovalDate",
                table: "ProviderAccount",
                nullable: true,
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "ProviderAccount",
                nullable: true,
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<int>(
                name: "BankId",
                table: "ProviderAccount",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<DateTime>(
                name: "AuthorizedDate",
                table: "ProviderAccount",
                nullable: true,
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<int>(
                name: "AuthorizedBy",
                table: "ProviderAccount",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "AuthorizationStatus",
                table: "ProviderAccount",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "SiteId",
                table: "ProviderAccount",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "providerloginId",
                table: "Provider",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<bool>(
                name: "isDelisted",
                table: "Provider",
                nullable: true,
                oldClrType: typeof(bool));

            migrationBuilder.AlterColumn<DateTime>(
                name: "delisteddate",
                table: "Provider",
                nullable: true,
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<int>(
                name: "delistedBy",
                table: "Provider",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedOn",
                table: "Provider",
                nullable: true,
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<int>(
                name: "TariffPageId",
                table: "Provider",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "TariffContentPageId",
                table: "Provider",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<bool>(
                name: "Status",
                table: "Provider",
                nullable: true,
                oldClrType: typeof(bool));

            migrationBuilder.AlterColumn<int>(
                name: "StateId",
                table: "Provider",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "ProvideraccountId",
                table: "Provider",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "Provideraccount2Id",
                table: "Provider",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "ProviderListPageId",
                table: "Provider",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "ProviderApprovalPageId",
                table: "Provider",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<long>(
                name: "Parentid",
                table: "Provider",
                nullable: true,
                oldClrType: typeof(long));

            migrationBuilder.AlterColumn<int>(
                name: "LgaId",
                table: "Provider",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<bool>(
                name: "IsDeleted",
                table: "Provider",
                nullable: true,
                oldClrType: typeof(bool));

            migrationBuilder.AlterColumn<int>(
                name: "DisapprovedBy",
                table: "Provider",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DisapprovalDate",
                table: "Provider",
                nullable: true,
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<int>(
                name: "DelistedProviderPageId",
                table: "Provider",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Provider",
                nullable: true,
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<string>(
                name: "Category",
                table: "Provider",
                maxLength: 255,
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "AuthorizedDate",
                table: "Provider",
                nullable: true,
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<int>(
                name: "AuthorizedBy",
                table: "Provider",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "AuthorizationStatus",
                table: "Provider",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "Assignee",
                table: "Provider",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "SiteId",
                table: "Provider",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "terminationdate",
                table: "PaymentBatch",
                nullable: true,
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<int>(
                name: "terminatedby",
                table: "PaymentBatch",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<string>(
                name: "status",
                table: "PaymentBatch",
                maxLength: 255,
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "paidby",
                table: "PaymentBatch",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<DateTime>(
                name: "datepaymentstarted",
                table: "PaymentBatch",
                nullable: true,
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<DateTime>(
                name: "datepaymentcompleted",
                table: "PaymentBatch",
                nullable: true,
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<int>(
                name: "createdBy",
                table: "PaymentBatch",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedOn",
                table: "PaymentBatch",
                nullable: true,
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<bool>(
                name: "IsDeleted",
                table: "PaymentBatch",
                nullable: true,
                oldClrType: typeof(bool));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "PaymentBatch",
                nullable: true,
                oldClrType: typeof(DateTime));

            migrationBuilder.AddColumn<int>(
                name: "SiteId",
                table: "PaymentBatch",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedOn",
                table: "Lga",
                nullable: true,
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<bool>(
                name: "Status",
                table: "Lga",
                nullable: true,
                oldClrType: typeof(bool));

            migrationBuilder.AlterColumn<long>(
                name: "State",
                table: "Lga",
                nullable: true,
                oldClrType: typeof(long));

            migrationBuilder.AlterColumn<int>(
                name: "ProviderPageId",
                table: "Lga",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<bool>(
                name: "IsDeleted",
                table: "Lga",
                nullable: true,
                oldClrType: typeof(bool));

            migrationBuilder.AlterColumn<int>(
                name: "EnrolleeRegPageId",
                table: "Lga",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "EnrolleePageId",
                table: "Lga",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "EnrolleeListPageId",
                table: "Lga",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "EnrolleeDetailsPageId",
                table: "Lga",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "DelistedProviderPageId",
                table: "Lga",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Lga",
                nullable: true,
                oldClrType: typeof(DateTime));

            migrationBuilder.AddColumn<int>(
                name: "SiteId",
                table: "Lga",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "year",
                table: "IncomingClaims",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "transferstatus",
                table: "IncomingClaims",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "transferedTo",
                table: "IncomingClaims",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<decimal>(
                name: "totalamount",
                table: "IncomingClaims",
                nullable: true,
                oldClrType: typeof(decimal));

            migrationBuilder.AlterColumn<string>(
                name: "status",
                table: "IncomingClaims",
                maxLength: 255,
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "receivedBy",
                table: "IncomingClaims",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "providerid",
                table: "IncomingClaims",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "noofencounter",
                table: "IncomingClaims",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "month",
                table: "IncomingClaims",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<DateTime>(
                name: "fullDateofbill",
                table: "IncomingClaims",
                nullable: true,
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<DateTime>(
                name: "dateTransferAcknowledged",
                table: "IncomingClaims",
                nullable: true,
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<DateTime>(
                name: "captureStarted",
                table: "IncomingClaims",
                nullable: true,
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedOn",
                table: "IncomingClaims",
                nullable: true,
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<bool>(
                name: "IsRemoteSubmission",
                table: "IncomingClaims",
                nullable: true,
                oldClrType: typeof(bool));

            migrationBuilder.AlterColumn<bool>(
                name: "IsDeleted",
                table: "IncomingClaims",
                nullable: true,
                oldClrType: typeof(bool));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateReceived",
                table: "IncomingClaims",
                nullable: true,
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "IncomingClaims",
                nullable: true,
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<int>(
                name: "ClaimBatchId",
                table: "IncomingClaims",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "SiteId",
                table: "IncomingClaims",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedOn",
                table: "EnrolleePassport",
                nullable: true,
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<bool>(
                name: "IsDeleted",
                table: "EnrolleePassport",
                nullable: true,
                oldClrType: typeof(bool));

            migrationBuilder.AlterColumn<int>(
                name: "Enrolleeid",
                table: "EnrolleePassport",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "EnrolleePassport",
                nullable: true,
                oldClrType: typeof(DateTime));

            migrationBuilder.AddColumn<int>(
                name: "SiteId",
                table: "EnrolleePassport",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedOn",
                table: "CompanySubsidiary",
                nullable: true,
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<int>(
                name: "ParentcompanyId",
                table: "CompanySubsidiary",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<bool>(
                name: "IsDeleted",
                table: "CompanySubsidiary",
                nullable: true,
                oldClrType: typeof(bool));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "CompanySubsidiary",
                nullable: true,
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<int>(
                name: "CreatedBy",
                table: "CompanySubsidiary",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "SiteId",
                table: "CompanySubsidiary",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "companyId",
                table: "CompanyBranch",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedOn",
                table: "CompanyBranch",
                nullable: true,
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<int>(
                name: "Statecode",
                table: "CompanyBranch",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<bool>(
                name: "IsDeleted",
                table: "CompanyBranch",
                nullable: true,
                oldClrType: typeof(bool));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "CompanyBranch",
                nullable: true,
                oldClrType: typeof(DateTime));

            migrationBuilder.AddColumn<int>(
                name: "SiteId",
                table: "CompanyBranch",
                nullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "isRenewal",
                table: "Company",
                nullable: true,
                oldClrType: typeof(bool));

            migrationBuilder.AlterColumn<bool>(
                name: "WeboperationMode",
                table: "Company",
                nullable: true,
                oldClrType: typeof(bool));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedOn",
                table: "Company",
                nullable: true,
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<int>(
                name: "SubsidiaryId",
                table: "Company",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "SubscriptionStatus",
                table: "Company",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<bool>(
                name: "Status",
                table: "Company",
                nullable: true,
                oldClrType: typeof(bool));

            migrationBuilder.AlterColumn<long>(
                name: "Stateid",
                table: "Company",
                nullable: true,
                oldClrType: typeof(long));

            migrationBuilder.AlterColumn<int>(
                name: "RegAgeLimit",
                table: "Company",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<long>(
                name: "Parentid",
                table: "Company",
                nullable: true,
                oldClrType: typeof(long));

            migrationBuilder.AlterColumn<int>(
                name: "Logoid",
                table: "Company",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<bool>(
                name: "IsDeleted",
                table: "Company",
                nullable: true,
                oldClrType: typeof(bool));

            migrationBuilder.AlterColumn<int>(
                name: "DisapprovedBy",
                table: "Company",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DisapprovalDate",
                table: "Company",
                nullable: true,
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Company",
                nullable: true,
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<int>(
                name: "CompanyListPageId",
                table: "Company",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<DateTime>(
                name: "AuthorizedDate",
                table: "Company",
                nullable: true,
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<int>(
                name: "AuthorizedBy",
                table: "Company",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "AuthorizationStatus",
                table: "Company",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "SiteId",
                table: "Company",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "status",
                table: "ClaimService",
                maxLength: 255,
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "flagred",
                table: "ClaimService",
                nullable: true,
                oldClrType: typeof(bool));

            migrationBuilder.AlterColumn<decimal>(
                name: "costofdrug",
                table: "ClaimService",
                nullable: true,
                oldClrType: typeof(decimal));

            migrationBuilder.AlterColumn<decimal>(
                name: "VettedAmount",
                table: "ClaimService",
                nullable: true,
                oldClrType: typeof(decimal));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedOn",
                table: "ClaimService",
                nullable: true,
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<int>(
                name: "ServiceId",
                table: "ClaimService",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<bool>(
                name: "IsDeleted",
                table: "ClaimService",
                nullable: true,
                oldClrType: typeof(bool));

            migrationBuilder.AlterColumn<decimal>(
                name: "InitialAmount",
                table: "ClaimService",
                nullable: true,
                oldClrType: typeof(decimal));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "ClaimService",
                nullable: true,
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<int>(
                name: "ClaimId",
                table: "ClaimService",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "SiteId",
                table: "ClaimService",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "status",
                table: "ClaimDrug",
                maxLength: 255,
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "flagred",
                table: "ClaimDrug",
                nullable: true,
                oldClrType: typeof(bool));

            migrationBuilder.AlterColumn<decimal>(
                name: "costofdrug",
                table: "ClaimDrug",
                nullable: true,
                oldClrType: typeof(decimal));

            migrationBuilder.AlterColumn<decimal>(
                name: "VettedAmount",
                table: "ClaimDrug",
                nullable: true,
                oldClrType: typeof(decimal));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedOn",
                table: "ClaimDrug",
                nullable: true,
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<bool>(
                name: "IsDeleted",
                table: "ClaimDrug",
                nullable: true,
                oldClrType: typeof(bool));

            migrationBuilder.AlterColumn<decimal>(
                name: "InitialAmount",
                table: "ClaimDrug",
                nullable: true,
                oldClrType: typeof(decimal));

            migrationBuilder.AlterColumn<int>(
                name: "DrugId",
                table: "ClaimDrug",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "ClaimDrug",
                nullable: true,
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<int>(
                name: "ClaimId",
                table: "ClaimDrug",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "SiteId",
                table: "ClaimDrug",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "year",
                table: "ClaimBatch",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "submitedVetbyUser",
                table: "ClaimBatch",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "submitedReviewbyUser",
                table: "ClaimBatch",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "submitedPaymentbyUser",
                table: "ClaimBatch",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<string>(
                name: "status",
                table: "ClaimBatch",
                maxLength: 255,
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "reviewedBy",
                table: "ClaimBatch",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<DateTime>(
                name: "reviewDate",
                table: "ClaimBatch",
                nullable: true,
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<string>(
                name: "paymentmethod",
                table: "ClaimBatch",
                maxLength: 255,
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "paymentdate",
                table: "ClaimBatch",
                nullable: true,
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<int>(
                name: "paymentbatchId",
                table: "ClaimBatch",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<bool>(
                name: "paymentadvicesent",
                table: "ClaimBatch",
                nullable: true,
                oldClrType: typeof(bool));

            migrationBuilder.AlterColumn<int>(
                name: "month",
                table: "ClaimBatch",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "markpaidby",
                table: "ClaimBatch",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<bool>(
                name: "isremote",
                table: "ClaimBatch",
                nullable: true,
                oldClrType: typeof(bool));

            migrationBuilder.AlterColumn<DateTime>(
                name: "datepaymentadvicesent",
                table: "ClaimBatch",
                nullable: true,
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<int>(
                name: "claimscountfromclient",
                table: "ClaimBatch",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<DateTime>(
                name: "VetDate",
                table: "ClaimBatch",
                nullable: true,
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedOn",
                table: "ClaimBatch",
                nullable: true,
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<DateTime>(
                name: "SubmitedForReviewDate",
                table: "ClaimBatch",
                nullable: true,
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<DateTime>(
                name: "SubmitedForPaymentDate",
                table: "ClaimBatch",
                nullable: true,
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<int>(
                name: "ProviderId",
                table: "ClaimBatch",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<bool>(
                name: "IsDeleted",
                table: "ClaimBatch",
                nullable: true,
                oldClrType: typeof(bool));

            migrationBuilder.AlterColumn<int>(
                name: "DisapprovedBy",
                table: "ClaimBatch",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DisapprovalDate",
                table: "ClaimBatch",
                nullable: true,
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "ClaimBatch",
                nullable: true,
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<string>(
                name: "Batch",
                table: "ClaimBatch",
                maxLength: 255,
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "AuthorizedDate",
                table: "ClaimBatch",
                nullable: true,
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<int>(
                name: "AuthorizedBy",
                table: "ClaimBatch",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<string>(
                name: "AuthorizationStatus",
                table: "ClaimBatch",
                maxLength: 255,
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "AmountPaid",
                table: "ClaimBatch",
                nullable: true,
                oldClrType: typeof(decimal));

            migrationBuilder.AddColumn<int>(
                name: "SiteId",
                table: "ClaimBatch",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "vettedBy",
                table: "Claim",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<string>(
                name: "status",
                table: "Claim",
                maxLength: 255,
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "specialistSigned",
                table: "Claim",
                nullable: true,
                oldClrType: typeof(bool));

            migrationBuilder.AlterColumn<DateTime>(
                name: "specialistSignecDate",
                table: "Claim",
                nullable: true,
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<bool>(
                name: "enrolleeSigned",
                table: "Claim",
                nullable: true,
                oldClrType: typeof(bool));

            migrationBuilder.AlterColumn<int>(
                name: "enrolleeCompanyId",
                table: "Claim",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "capturedBy",
                table: "Claim",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<DateTime>(
                name: "VettedDate",
                table: "Claim",
                nullable: true,
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedOn",
                table: "Claim",
                nullable: true,
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<string>(
                name: "Tag",
                table: "Claim",
                maxLength: 255,
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "SubmitByProvider",
                table: "Claim",
                nullable: true,
                oldClrType: typeof(bool));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ServiceDate",
                table: "Claim",
                nullable: true,
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<int>(
                name: "RevettedBy",
                table: "Claim",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ReVettedDate",
                table: "Claim",
                nullable: true,
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<int>(
                name: "ProviderId",
                table: "Claim",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<bool>(
                name: "LaboratoryInvestigation",
                table: "Claim",
                nullable: true,
                oldClrType: typeof(bool));

            migrationBuilder.AlterColumn<bool>(
                name: "IsDeleted",
                table: "Claim",
                nullable: true,
                oldClrType: typeof(bool));

            migrationBuilder.AlterColumn<bool>(
                name: "Feeding",
                table: "Claim",
                nullable: true,
                oldClrType: typeof(bool));

            migrationBuilder.AlterColumn<int>(
                name: "Enrolleeid",
                table: "Claim",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<DateTime>(
                name: "EnrolleeSignDate",
                table: "Claim",
                nullable: true,
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<bool>(
                name: "DoctorSigned",
                table: "Claim",
                nullable: true,
                oldClrType: typeof(bool));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DoctorSignecDate",
                table: "Claim",
                nullable: true,
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DischargeDate",
                table: "Claim",
                nullable: true,
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Claim",
                nullable: true,
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<int>(
                name: "ClaimBatchId",
                table: "Claim",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<bool>(
                name: "AllprescibedDrugs",
                table: "Claim",
                nullable: true,
                oldClrType: typeof(bool));

            migrationBuilder.AlterColumn<DateTime>(
                name: "AdmissionDate",
                table: "Claim",
                nullable: true,
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<bool>(
                name: "Admission",
                table: "Claim",
                nullable: true,
                oldClrType: typeof(bool));

            migrationBuilder.AddColumn<int>(
                name: "SiteId",
                table: "Claim",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedOn",
                table: "BenefitsCategory",
                nullable: true,
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<bool>(
                name: "Status",
                table: "BenefitsCategory",
                nullable: true,
                oldClrType: typeof(bool));

            migrationBuilder.AlterColumn<bool>(
                name: "IsDeleted",
                table: "BenefitsCategory",
                nullable: true,
                oldClrType: typeof(bool));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "BenefitsCategory",
                nullable: true,
                oldClrType: typeof(DateTime));

            migrationBuilder.AddColumn<int>(
                name: "SiteId",
                table: "BenefitsCategory",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedOn",
                table: "Benefit",
                nullable: true,
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<bool>(
                name: "Status",
                table: "Benefit",
                nullable: true,
                oldClrType: typeof(bool));

            migrationBuilder.AlterColumn<bool>(
                name: "IsDeleted",
                table: "Benefit",
                nullable: true,
                oldClrType: typeof(bool));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Benefit",
                nullable: true,
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<int>(
                name: "Benefitcategory",
                table: "Benefit",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "SiteId",
                table: "Benefit",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedOn",
                table: "Bank",
                nullable: true,
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<bool>(
                name: "IsDeleted",
                table: "Bank",
                nullable: true,
                oldClrType: typeof(bool));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Bank",
                nullable: true,
                oldClrType: typeof(DateTime));

            migrationBuilder.AddColumn<int>(
                name: "SiteId",
                table: "Bank",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "providerid",
                table: "AuthorizationRequest",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<bool>(
                name: "isnew",
                table: "AuthorizationRequest",
                nullable: true,
                oldClrType: typeof(bool));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedOn",
                table: "AuthorizationRequest",
                nullable: true,
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<bool>(
                name: "IsDeleted",
                table: "AuthorizationRequest",
                nullable: true,
                oldClrType: typeof(bool));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "AuthorizationRequest",
                nullable: true,
                oldClrType: typeof(DateTime));

            migrationBuilder.AddColumn<int>(
                name: "SiteId",
                table: "AuthorizationRequest",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "provider",
                table: "AuthorizationCode",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<bool>(
                name: "isdelivery",
                table: "AuthorizationCode",
                nullable: true,
                oldClrType: typeof(bool));

            migrationBuilder.AlterColumn<int>(
                name: "generatedby",
                table: "AuthorizationCode",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "enrolleeID",
                table: "AuthorizationCode",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "enrolleeAge",
                table: "AuthorizationCode",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<bool>(
                name: "deliverysmssent",
                table: "AuthorizationCode",
                nullable: true,
                oldClrType: typeof(bool));

            migrationBuilder.AlterColumn<string>(
                name: "admissionStatus",
                table: "AuthorizationCode",
                maxLength: 255,
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedOn",
                table: "AuthorizationCode",
                nullable: true,
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<bool>(
                name: "Isadmission",
                table: "AuthorizationCode",
                nullable: true,
                oldClrType: typeof(bool));

            migrationBuilder.AlterColumn<bool>(
                name: "IsNHIS",
                table: "AuthorizationCode",
                nullable: true,
                oldClrType: typeof(bool));

            migrationBuilder.AlterColumn<bool>(
                name: "IsDeleted",
                table: "AuthorizationCode",
                nullable: true,
                oldClrType: typeof(bool));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DischargeDate",
                table: "AuthorizationCode",
                nullable: true,
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<int>(
                name: "DaysApprovded",
                table: "AuthorizationCode",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "AuthorizationCode",
                nullable: true,
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<int>(
                name: "Authorizedby",
                table: "AuthorizationCode",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<DateTime>(
                name: "AdmissionDate",
                table: "AuthorizationCode",
                nullable: true,
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<bool>(
                name: "AcknowledgedByAuthorizer",
                table: "AuthorizationCode",
                nullable: true,
                oldClrType: typeof(bool));

            migrationBuilder.AddColumn<int>(
                name: "SiteId",
                table: "AuthorizationCode",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "AdminAllowedRole",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IsRecursive = table.Column<bool>(nullable: true),
                    Guid = table.Column<Guid>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: true),
                    WebpageId = table.Column<int>(nullable: true),
                    UserRoleId = table.Column<int>(nullable: true),
                    SiteId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdminAllowedRole", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AdminDisallowedRole",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IsRecursive = table.Column<bool>(nullable: true),
                    Guid = table.Column<Guid>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: true),
                    WebpageId = table.Column<int>(nullable: true),
                    UserRoleId = table.Column<int>(nullable: true),
                    SiteId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdminDisallowedRole", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AutomaticExpungeStaff",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    StaffId = table.Column<int>(nullable: true),
                    CreatedBy = table.Column<int>(nullable: true),
                    Guid = table.Column<Guid>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: true),
                    SiteId = table.Column<int>(nullable: true),
                    Subsidiary = table.Column<int>(nullable: true),
                    Companyid = table.Column<int>(nullable: true),
                    Showtouser = table.Column<bool>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AutomaticExpungeStaff", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Batch",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Guid = table.Column<Guid>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: true),
                    SiteId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Batch", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ClaimAnalysisOffline",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    PROVIDER = table.Column<string>(nullable: true),
                    LOCATION = table.Column<string>(nullable: true),
                    CLIENTNAME = table.Column<string>(nullable: true),
                    COMPANY = table.Column<string>(nullable: true),
                    POLICYNUMBER = table.Column<string>(nullable: true),
                    HEALTHPLAN = table.Column<string>(nullable: true),
                    ENCOUNTERDATE = table.Column<DateTime>(nullable: true),
                    DATERECEIVED = table.Column<DateTime>(nullable: true),
                    DIAGNOSIS = table.Column<string>(nullable: true),
                    CLASS = table.Column<string>(nullable: true),
                    AMOUNTSUBMITTED = table.Column<decimal>(nullable: true),
                    AMOUNTPROCESSED = table.Column<decimal>(nullable: true),
                    TREATMENT = table.Column<string>(nullable: true),
                    Guid = table.Column<Guid>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: true),
                    SiteId = table.Column<int>(nullable: true),
                    PROVIDERID = table.Column<int>(nullable: true),
                    SerialNo = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClaimAnalysisOffline", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ClaimHistory",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    PROVIDER = table.Column<string>(nullable: true),
                    LOCATION = table.Column<string>(nullable: true),
                    CLIENTNAME = table.Column<string>(nullable: true),
                    COMPANY = table.Column<string>(nullable: true),
                    POLICYNUMBER = table.Column<string>(nullable: true),
                    HEALTHPLAN = table.Column<string>(nullable: true),
                    ENCOUNTERDATE = table.Column<DateTime>(nullable: true),
                    DATERECEIVED = table.Column<DateTime>(nullable: true),
                    DIAGNOSIS = table.Column<string>(nullable: true),
                    CLASS = table.Column<string>(nullable: true),
                    AMOUNTSUBMITTED = table.Column<decimal>(nullable: true),
                    AMOUNTPROCESSED = table.Column<decimal>(nullable: true),
                    TREATMENT = table.Column<string>(nullable: true),
                    Guid = table.Column<Guid>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: true),
                    SiteId = table.Column<int>(nullable: true),
                    PROVIDERID = table.Column<int>(nullable: true),
                    SerialNo = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClaimHistory", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CompanyAssignee",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Companyid = table.Column<int>(nullable: true),
                    Userid = table.Column<int>(nullable: true),
                    Status = table.Column<bool>(nullable: true),
                    Guid = table.Column<Guid>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: true),
                    SiteId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanyAssignee", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CompanyBenefit",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Companyid = table.Column<int>(nullable: true),
                    CompanyPlanid = table.Column<int>(nullable: true),
                    BenefitId = table.Column<int>(nullable: true),
                    BenefitLimit = table.Column<string>(nullable: true),
                    Guid = table.Column<Guid>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: true),
                    SiteId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanyBenefit", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CompanyPlan",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Companyid = table.Column<int>(nullable: true),
                    Planid = table.Column<int>(nullable: true),
                    Planfriendlyname = table.Column<string>(nullable: true),
                    AnnualPremium = table.Column<decimal>(nullable: true),
                    Discountlump = table.Column<decimal>(nullable: true),
                    Discountperenrollee = table.Column<decimal>(nullable: true),
                    Createdby = table.Column<int>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    AuthorizationStatus = table.Column<int>(nullable: true),
                    AuthorizationNote = table.Column<string>(nullable: true),
                    AllowChildEnrollee = table.Column<bool>(nullable: true),
                    DisapprovalNote = table.Column<string>(nullable: true),
                    AuthorizedBy = table.Column<int>(nullable: true),
                    DisapprovedBy = table.Column<int>(nullable: true),
                    AuthorizedDate = table.Column<DateTime>(nullable: true),
                    DisapprovalDate = table.Column<DateTime>(nullable: true),
                    Status = table.Column<bool>(nullable: true),
                    Guid = table.Column<Guid>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: true),
                    SiteId = table.Column<int>(nullable: true),
                    MaxNoOfDependant = table.Column<int>(nullable: true),
                    ProviderConsession = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanyPlan", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ConnectcarePaymentDetails",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    paymentid = table.Column<string>(nullable: true),
                    sponsorID = table.Column<int>(nullable: true),
                    sponsorIDString = table.Column<string>(nullable: true),
                    beneficiaryID = table.Column<string>(nullable: true),
                    policyid = table.Column<string>(nullable: true),
                    amountpaid = table.Column<decimal>(nullable: true),
                    planpurchased = table.Column<string>(nullable: true),
                    addon = table.Column<bool>(nullable: true),
                    paymentDate = table.Column<DateTime>(nullable: true),
                    Guid = table.Column<Guid>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: true),
                    SiteId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConnectcarePaymentDetails", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ConnectCareSponsor",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    fullname = table.Column<string>(nullable: true),
                    gender = table.Column<string>(nullable: true),
                    occupation = table.Column<string>(nullable: true),
                    country = table.Column<string>(nullable: true),
                    state = table.Column<string>(nullable: true),
                    address = table.Column<string>(nullable: true),
                    email = table.Column<string>(nullable: true),
                    phonenumber = table.Column<string>(nullable: true),
                    emailsent = table.Column<bool>(nullable: true),
                    Guid = table.Column<Guid>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: true),
                    SiteId = table.Column<int>(nullable: true),
                    SubscriptionType = table.Column<string>(nullable: true),
                    sponsorID = table.Column<string>(nullable: true),
                    firstname = table.Column<string>(nullable: true),
                    lastname = table.Column<string>(nullable: true),
                    secondarysponsor = table.Column<string>(nullable: true),
                    zipcode = table.Column<string>(nullable: true),
                    Addon = table.Column<bool>(nullable: true),
                    SponsorStartDate = table.Column<DateTime>(nullable: true),
                    PolicyStartDate = table.Column<DateTime>(nullable: true),
                    PolicyEndDate = table.Column<DateTime>(nullable: true),
                    PolicynotificationConfig = table.Column<int>(nullable: true),
                    instalment = table.Column<int>(nullable: true),
                    policynumner = table.Column<string>(nullable: true),
                    active = table.Column<bool>(nullable: true),
                    Administeredby = table.Column<int>(nullable: true),
                    AdministrationDate = table.Column<DateTime>(nullable: true),
                    EnrolleeprofileId = table.Column<int>(nullable: true),
                    sponsorSTRID = table.Column<string>(nullable: true),
                    policynumber = table.Column<string>(nullable: true),
                    pushedtoMatontine = table.Column<bool>(nullable: true),
                    pushedDate = table.Column<DateTime>(nullable: true),
                    ManageSponsorPageId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConnectCareSponsor", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Country",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Code = table.Column<string>(nullable: true),
                    Status = table.Column<bool>(nullable: true),
                    Guid = table.Column<Guid>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: true),
                    SiteId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Country", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DeletedEnrollee",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Parentid = table.Column<int>(nullable: true),
                    Parentrelationship = table.Column<int>(nullable: true),
                    Policynumber = table.Column<string>(nullable: true),
                    RefPolicynumber = table.Column<string>(nullable: true),
                    HasRefPolicyNumber = table.Column<bool>(nullable: true),
                    Title = table.Column<string>(nullable: true),
                    Surname = table.Column<string>(nullable: true),
                    Othernames = table.Column<string>(nullable: true),
                    Dob = table.Column<DateTime>(nullable: true),
                    Age = table.Column<int>(nullable: true),
                    Maritalstatus = table.Column<int>(nullable: true),
                    Occupation = table.Column<string>(nullable: true),
                    Sex = table.Column<int>(nullable: true),
                    Residentialaddress = table.Column<string>(nullable: true),
                    Stateid = table.Column<int>(nullable: true),
                    Lgaid = table.Column<int>(nullable: true),
                    Mobilenumber = table.Column<string>(nullable: true),
                    Mobilenumber2 = table.Column<string>(nullable: true),
                    Emailaddress = table.Column<string>(nullable: true),
                    Sponsorshiptype = table.Column<int>(nullable: true),
                    Sponsorshiptypeothername = table.Column<string>(nullable: true),
                    Preexistingmedicalhistory = table.Column<string>(nullable: true),
                    Sponsorshiptypenote = table.Column<string>(nullable: true),
                    Companyid = table.Column<int>(nullable: true),
                    Subscriptionplanid = table.Column<int>(nullable: true),
                    Hasdependents = table.Column<bool>(nullable: true),
                    Specialidcardfield1 = table.Column<string>(nullable: true),
                    Specialidcardfield2 = table.Column<string>(nullable: true),
                    Specialidcardfield3 = table.Column<string>(nullable: true),
                    Staffprofileid = table.Column<int>(nullable: true),
                    IdCardPrinted = table.Column<bool>(nullable: true),
                    Primaryprovider = table.Column<int>(nullable: true),
                    Status = table.Column<int>(nullable: true),
                    Hasactivesubscription = table.Column<bool>(nullable: true),
                    Isexpundged = table.Column<bool>(nullable: true),
                    ExpungeNote = table.Column<string>(nullable: true),
                    Expungedby = table.Column<int>(nullable: true),
                    Dateexpunged = table.Column<DateTime>(nullable: true),
                    Createdby = table.Column<int>(nullable: true),
                    Datereceived = table.Column<DateTime>(nullable: true),
                    Guid = table.Column<Guid>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: true),
                    EnrolleePassportId = table.Column<int>(nullable: true),
                    SiteId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeletedEnrollee", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DownloadFile",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    fileName = table.Column<string>(nullable: true),
                    filelink = table.Column<string>(nullable: true),
                    filestaus = table.Column<int>(nullable: true),
                    createdby = table.Column<int>(nullable: true),
                    downloadedBy = table.Column<int>(nullable: true),
                    downloadCount = table.Column<int>(nullable: true),
                    Guid = table.Column<Guid>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: true),
                    SiteId = table.Column<int>(nullable: true),
                    DownloadFilesPageId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DownloadFile", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DrugTariff",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Strenght = table.Column<string>(nullable: true),
                    Unit = table.Column<string>(nullable: true),
                    Price = table.Column<decimal>(nullable: true),
                    PreauthorizationRequired = table.Column<bool>(nullable: true),
                    GroupId = table.Column<int>(nullable: true),
                    Groupname = table.Column<string>(nullable: true),
                    Guid = table.Column<Guid>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: true),
                    SiteId = table.Column<int>(nullable: true),
                    AlternatePrice = table.Column<string>(nullable: true),
                    Remark = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DrugTariff", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EmailDEST",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    code = table.Column<string>(nullable: true),
                    desc = table.Column<string>(nullable: true),
                    emailaddress = table.Column<string>(nullable: true),
                    Guid = table.Column<Guid>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: true),
                    SiteId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmailDEST", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Enrollee",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    Parentid = table.Column<int>(nullable: true),
                    Parentrelationship = table.Column<int>(nullable: true),
                    Policynumber = table.Column<string>(nullable: true),
                    Title = table.Column<string>(nullable: true),
                    Surname = table.Column<string>(nullable: true),
                    Othernames = table.Column<string>(nullable: true),
                    Dob = table.Column<DateTime>(nullable: true),
                    Age = table.Column<int>(nullable: true),
                    Maritalstatus = table.Column<int>(nullable: true),
                    Occupation = table.Column<string>(nullable: true),
                    Sex = table.Column<int>(nullable: true),
                    Residentialaddress = table.Column<string>(nullable: true),
                    Stateid = table.Column<int>(nullable: true),
                    Lgaid = table.Column<int>(nullable: true),
                    Mobilenumber = table.Column<string>(nullable: true),
                    Emailaddress = table.Column<string>(nullable: true),
                    Sponsorshiptype = table.Column<int>(nullable: true),
                    Sponsorshiptypeothername = table.Column<string>(nullable: true),
                    Preexistingmedicalhistory = table.Column<string>(nullable: true),
                    Sponsorshiptypenote = table.Column<string>(nullable: true),
                    Companyid = table.Column<int>(nullable: true),
                    Subscriptionplanid = table.Column<int>(nullable: true),
                    Hasdependents = table.Column<bool>(nullable: true),
                    Specialidcardfield1 = table.Column<string>(nullable: true),
                    Specialidcardfield2 = table.Column<string>(nullable: true),
                    Specialidcardfield3 = table.Column<string>(nullable: true),
                    Staffprofileid = table.Column<int>(nullable: true),
                    Primaryprovider = table.Column<int>(nullable: true),
                    Status = table.Column<int>(nullable: true),
                    Hasactivesubscription = table.Column<bool>(nullable: true),
                    Isexpundged = table.Column<bool>(nullable: true),
                    ExpungeNote = table.Column<string>(nullable: true),
                    Expungedby = table.Column<int>(nullable: true),
                    Dateexpunged = table.Column<DateTime>(nullable: true),
                    Createdby = table.Column<int>(nullable: true),
                    Datereceived = table.Column<DateTime>(nullable: true),
                    Guid = table.Column<Guid>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: true),
                    EnrolleePassportId = table.Column<int>(nullable: true),
                    SiteId = table.Column<int>(nullable: true),
                    IdCardPrinted = table.Column<bool>(nullable: true),
                    RefPolicynumber = table.Column<string>(nullable: true),
                    HasRefPolicyNumber = table.Column<bool>(nullable: true),
                    Mobilenumber2 = table.Column<string>(nullable: true),
                    LastyearBirthdaymsgsent = table.Column<int>(nullable: true),
                    Bulkjobid = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Enrollee", x => x.Guid);
                });

            migrationBuilder.CreateTable(
                name: "EnrolleePreexistingMedicalHistory",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Pemhid = table.Column<int>(nullable: true),
                    Enrolleeid = table.Column<int>(nullable: true),
                    Answeryesno = table.Column<bool>(nullable: true),
                    Answerstring = table.Column<string>(nullable: true),
                    Status = table.Column<bool>(nullable: true),
                    Guid = table.Column<Guid>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: true),
                    SiteId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EnrolleePreexistingMedicalHistory", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EnrolleeVerificationCode",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    EnrolleeId = table.Column<int>(nullable: true),
                    Status = table.Column<string>(maxLength: 255, nullable: true),
                    VerificationCode = table.Column<string>(nullable: true),
                    EncounterDate = table.Column<DateTime>(nullable: true),
                    DateAuthenticated = table.Column<DateTime>(nullable: true),
                    DateExpired = table.Column<DateTime>(nullable: true),
                    Channel = table.Column<int>(nullable: true),
                    RequestPhoneNumber = table.Column<string>(nullable: true),
                    CreatedBy = table.Column<int>(nullable: true),
                    VisitPurpose = table.Column<int>(nullable: true),
                    ProviderId = table.Column<int>(nullable: true),
                    Note = table.Column<string>(nullable: true),
                    Guid = table.Column<Guid>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: true),
                    SiteId = table.Column<int>(nullable: true),
                    AuthChannel = table.Column<int>(nullable: true),
                    Pickedup = table.Column<bool>(nullable: true),
                    PickedUpById = table.Column<int>(nullable: true),
                    AttendedTo = table.Column<bool>(nullable: true),
                    DateAttendedTo = table.Column<DateTime>(nullable: true),
                    ServiceAccessed = table.Column<string>(nullable: true),
                    AuthorizationCodeGiven = table.Column<bool>(nullable: true),
                    AuthorizationCode = table.Column<string>(nullable: true),
                    AuthorizedByUserId = table.Column<int>(nullable: true),
                    DateAuthorized = table.Column<DateTime>(nullable: true),
                    AgentNote = table.Column<string>(nullable: true),
                    PostSMSSent = table.Column<bool>(nullable: true),
                    visittype = table.Column<string>(maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EnrolleeVerificationCode", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ExpungedEnrollee",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Enrolleeid = table.Column<int>(nullable: true),
                    Enrolleepolicyno = table.Column<string>(nullable: true),
                    ExpungeNote = table.Column<string>(nullable: true),
                    Expungedby = table.Column<int>(nullable: true),
                    Dateexpunged = table.Column<DateTime>(nullable: true),
                    Guid = table.Column<Guid>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: true),
                    SiteId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExpungedEnrollee", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Faq",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Answer = table.Column<string>(nullable: true),
                    Question = table.Column<string>(nullable: true),
                    Guid = table.Column<Guid>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: true),
                    ShowFaqsId = table.Column<int>(nullable: true),
                    SiteId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Faq", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FormPosting",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Guid = table.Column<Guid>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: true),
                    WebpageId = table.Column<int>(nullable: true),
                    SiteId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FormPosting", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FormProperty",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    PropertyType = table.Column<string>(maxLength: 255, nullable: false),
                    Name = table.Column<string>(nullable: true),
                    LabelText = table.Column<string>(nullable: true),
                    Required = table.Column<bool>(nullable: true),
                    CssClass = table.Column<string>(nullable: true),
                    HtmlId = table.Column<string>(nullable: true),
                    DisplayOrder = table.Column<int>(nullable: true),
                    Guid = table.Column<Guid>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: true),
                    WebpageId = table.Column<int>(nullable: true),
                    SiteId = table.Column<int>(nullable: true),
                    PlaceHolder = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FormProperty", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Gender",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Guid = table.Column<Guid>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: true),
                    SiteId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gender", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Issues",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    subject = table.Column<string>(nullable: true),
                    Details = table.Column<string>(nullable: true),
                    status = table.Column<string>(maxLength: 255, nullable: true),
                    providers = table.Column<string>(nullable: true),
                    companies = table.Column<string>(nullable: true),
                    prority = table.Column<string>(maxLength: 255, nullable: true),
                    users = table.Column<string>(nullable: true),
                    report = table.Column<string>(nullable: true),
                    escalated = table.Column<bool>(nullable: true),
                    Guid = table.Column<Guid>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: true),
                    SiteId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Issues", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Log",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Error = table.Column<byte[]>(nullable: true),
                    Message = table.Column<string>(nullable: true),
                    Detail = table.Column<string>(nullable: true),
                    Type = table.Column<string>(maxLength: 255, nullable: true),
                    Guid = table.Column<Guid>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: true),
                    SiteId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Log", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LuceneFieldBoost",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Definition = table.Column<string>(nullable: true),
                    Boost = table.Column<float>(nullable: true),
                    Guid = table.Column<Guid>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: true),
                    SiteId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LuceneFieldBoost", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MaritalStatus",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Guid = table.Column<Guid>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: true),
                    SiteId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MaritalStatus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MediaFile",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    MediaFileType = table.Column<string>(maxLength: 255, nullable: false),
                    Description = table.Column<string>(nullable: true),
                    Title = table.Column<string>(maxLength: 4000, nullable: true),
                    FileUrl = table.Column<string>(nullable: true),
                    FileExtension = table.Column<string>(nullable: true),
                    ContentType = table.Column<string>(nullable: true),
                    ContentLength = table.Column<long>(nullable: true),
                    FileName = table.Column<string>(nullable: true),
                    DisplayOrder = table.Column<int>(nullable: true),
                    Width = table.Column<int>(nullable: true),
                    Height = table.Column<int>(nullable: true),
                    Guid = table.Column<Guid>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: true),
                    MediaCategoryId = table.Column<int>(nullable: true),
                    SiteId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MediaFile", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MessageTemplate",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    MessageTemplateType = table.Column<string>(nullable: true),
                    FromAddress = table.Column<string>(nullable: true),
                    FromName = table.Column<string>(nullable: true),
                    ToAddress = table.Column<string>(nullable: true),
                    ToName = table.Column<string>(nullable: true),
                    Cc = table.Column<string>(nullable: true),
                    Bcc = table.Column<string>(nullable: true),
                    Subject = table.Column<string>(nullable: true),
                    Body = table.Column<string>(nullable: true),
                    IsHtml = table.Column<bool>(nullable: true),
                    Imported = table.Column<bool>(nullable: true),
                    Guid = table.Column<Guid>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: true),
                    SiteId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MessageTemplate", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MobileSignup",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    PolicyNumber = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    CodeGenerated = table.Column<string>(nullable: true),
                    Status = table.Column<int>(nullable: true),
                    Smsid = table.Column<string>(nullable: true),
                    Guid = table.Column<Guid>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: true),
                    SiteId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MobileSignup", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Notification",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Message = table.Column<string>(nullable: true),
                    NotificationType = table.Column<string>(maxLength: 255, nullable: true),
                    Guid = table.Column<Guid>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: true),
                    UserId = table.Column<int>(nullable: true),
                    SiteId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notification", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "NotificationTable",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Notificationcode = table.Column<int>(nullable: true),
                    Roles = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Active = table.Column<bool>(nullable: true),
                    Guid = table.Column<Guid>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: true),
                    SiteId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NotificationTable", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "NovoStaff",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Staff_Name = table.Column<string>(nullable: true),
                    Staff_No = table.Column<string>(nullable: true),
                    Role = table.Column<string>(nullable: true),
                    Grade = table.Column<string>(nullable: true),
                    Job_Desc = table.Column<string>(nullable: true),
                    DOB = table.Column<DateTime>(nullable: true),
                    LineManager = table.Column<int>(nullable: true),
                    Staff_Email = table.Column<string>(nullable: true),
                    Guid = table.Column<Guid>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: true),
                    SiteId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NovoStaff", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "NovoStaffResponsibility",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Staff_Id = table.Column<int>(nullable: true),
                    Staff_Resp = table.Column<string>(nullable: true),
                    Guid = table.Column<Guid>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: true),
                    SiteId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NovoStaffResponsibility", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OfflineMessage",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FromId = table.Column<string>(nullable: true),
                    ToId = table.Column<string>(nullable: true),
                    Message = table.Column<string>(nullable: true),
                    MsgDate = table.Column<string>(nullable: true),
                    Read = table.Column<bool>(nullable: true),
                    Guid = table.Column<Guid>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: true),
                    SiteId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OfflineMessage", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PageTemplate",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    PageTemplateName = table.Column<string>(nullable: true),
                    PageType = table.Column<string>(nullable: true),
                    UrlGeneratorType = table.Column<string>(nullable: true),
                    SingleUse = table.Column<bool>(nullable: true),
                    Guid = table.Column<Guid>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: true),
                    LayoutId = table.Column<int>(nullable: true),
                    SiteId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PageTemplate", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PendingDependant",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ImgRaw = table.Column<byte[]>(nullable: true),
                    firstName = table.Column<string>(nullable: true),
                    lastname = table.Column<string>(nullable: true),
                    dob = table.Column<DateTime>(nullable: true),
                    sex = table.Column<int>(nullable: true),
                    hospital = table.Column<int>(nullable: true),
                    mobile = table.Column<string>(nullable: true),
                    preexisting = table.Column<string>(nullable: true),
                    relationship = table.Column<int>(nullable: true),
                    Note = table.Column<string>(nullable: true),
                    Principalpolicynum = table.Column<string>(nullable: true),
                    principalGuid = table.Column<string>(nullable: true),
                    Guid = table.Column<Guid>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: true),
                    SiteId = table.Column<int>(nullable: true),
                    Approved = table.Column<bool>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PendingDependant", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Plan",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Code = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Status = table.Column<bool>(nullable: true),
                    CreatedBy = table.Column<string>(nullable: true),
                    Guid = table.Column<Guid>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: true),
                    SiteId = table.Column<int>(nullable: true),
                    PlanPageId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Plan", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PlanDefaultBenefit",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Planid = table.Column<int>(nullable: true),
                    BenefitId = table.Column<int>(nullable: true),
                    BenefitLimit = table.Column<string>(nullable: true),
                    Guid = table.Column<Guid>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: true),
                    SiteId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlanDefaultBenefit", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PreExistingMedicalHistoryList",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Status = table.Column<bool>(nullable: true),
                    Guid = table.Column<Guid>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: true),
                    SiteId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PreExistingMedicalHistoryList", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProviderClaimBK",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    clientkey = table.Column<string>(nullable: true),
                    data = table.Column<string>(nullable: true),
                    Guid = table.Column<Guid>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: true),
                    providerId = table.Column<int>(nullable: true),
                    SiteId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProviderClaimBK", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProviderClaimBK_Provider_providerId",
                        column: x => x.providerId,
                        principalTable: "Provider",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Query",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    Imgraw = table.Column<byte[]>(type: "image", nullable: true),
                    S_Imgraw = table.Column<byte[]>(type: "image", nullable: true),
                    child1_Imgraw = table.Column<byte[]>(type: "image", nullable: true),
                    child2_Imgraw = table.Column<byte[]>(type: "image", nullable: true),
                    child3_Imgraw = table.Column<byte[]>(type: "image", nullable: true),
                    child4_Imgraw = table.Column<byte[]>(type: "image", nullable: true),
                    Policynumber = table.Column<string>(type: "ntext", nullable: true),
                    RefPolicynumber = table.Column<string>(type: "ntext", nullable: true),
                    HasRefPolicyNumber = table.Column<bool>(nullable: true),
                    Title = table.Column<string>(type: "ntext", nullable: true),
                    Surname = table.Column<string>(type: "ntext", nullable: true),
                    Othernames = table.Column<string>(type: "ntext", nullable: true),
                    Dob = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Age = table.Column<int>(nullable: true),
                    Maritalstatus = table.Column<int>(nullable: true),
                    Occupation = table.Column<string>(type: "ntext", nullable: true),
                    Sex = table.Column<int>(nullable: true),
                    Residentialaddress = table.Column<string>(type: "ntext", nullable: true),
                    Stateoforiginid = table.Column<int>(nullable: true),
                    Lga = table.Column<string>(type: "ntext", nullable: true),
                    Stateofresidence = table.Column<int>(nullable: true),
                    Mobilenumber = table.Column<string>(type: "ntext", nullable: true),
                    Mobilenumber2 = table.Column<string>(type: "ntext", nullable: true),
                    Emailaddress = table.Column<string>(type: "ntext", nullable: true),
                    Sponsorshiptype = table.Column<int>(nullable: true),
                    Sponsorshiptypeothername = table.Column<string>(type: "ntext", nullable: true),
                    Preexistingmedicalhistory = table.Column<string>(type: "ntext", nullable: true),
                    Sponsorshiptypenote = table.Column<string>(type: "ntext", nullable: true),
                    Companyid = table.Column<int>(nullable: true),
                    officestate = table.Column<int>(nullable: true),
                    BranchName = table.Column<string>(type: "ntext", nullable: true),
                    staffid = table.Column<string>(type: "ntext", nullable: true),
                    Subscriptionplanid = table.Column<int>(nullable: true),
                    Hasdependents = table.Column<bool>(nullable: true),
                    Specialidcardfield1 = table.Column<string>(type: "ntext", nullable: true),
                    Specialidcardfield2 = table.Column<string>(type: "ntext", nullable: true),
                    Specialidcardfield3 = table.Column<string>(type: "ntext", nullable: true),
                    Staffprofileid = table.Column<int>(nullable: true),
                    IdCardPrinted = table.Column<bool>(nullable: true),
                    Primaryprovider = table.Column<string>(type: "ntext", nullable: true),
                    Status = table.Column<int>(nullable: true),
                    Hasactivesubscription = table.Column<bool>(nullable: true),
                    Isexpundged = table.Column<bool>(nullable: true),
                    ExpungeNote = table.Column<string>(type: "ntext", nullable: true),
                    Expungedby = table.Column<int>(nullable: true),
                    Dateexpunged = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Createdby = table.Column<int>(nullable: true),
                    Datereceived = table.Column<DateTime>(type: "datetime2", nullable: true),
                    BranchID = table.Column<string>(type: "ntext", nullable: true),
                    s_Surname = table.Column<string>(type: "ntext", nullable: true),
                    s_Othernames = table.Column<string>(type: "ntext", nullable: true),
                    s_Dob = table.Column<DateTime>(type: "datetime2", nullable: true),
                    S_Sex = table.Column<int>(nullable: true),
                    S_mobile = table.Column<string>(type: "ntext", nullable: true),
                    S_email = table.Column<string>(type: "ntext", nullable: true),
                    S_hospital = table.Column<string>(type: "ntext", nullable: true),
                    S_medicalhistory = table.Column<string>(type: "ntext", nullable: true),
                    child1_Surname = table.Column<string>(type: "ntext", nullable: true),
                    child1_Othernames = table.Column<string>(type: "ntext", nullable: true),
                    child1_Dob = table.Column<DateTime>(type: "datetime2", nullable: true),
                    child1_Sex = table.Column<int>(nullable: true),
                    child1_mobile = table.Column<string>(type: "ntext", nullable: true),
                    child1_email = table.Column<string>(type: "ntext", nullable: true),
                    child1_hospital = table.Column<string>(type: "ntext", nullable: true),
                    child1_medicalhistory = table.Column<string>(type: "ntext", nullable: true),
                    child2_Surname = table.Column<string>(type: "ntext", nullable: true),
                    child2_Othernames = table.Column<string>(type: "ntext", nullable: true),
                    child2_Dob = table.Column<DateTime>(type: "datetime2", nullable: true),
                    child2_Sex = table.Column<int>(nullable: true),
                    child2_mobile = table.Column<string>(type: "ntext", nullable: true),
                    child2_email = table.Column<string>(type: "ntext", nullable: true),
                    child2_hospital = table.Column<string>(type: "ntext", nullable: true),
                    child2_medicalhistory = table.Column<string>(type: "ntext", nullable: true),
                    child3_Surname = table.Column<string>(type: "ntext", nullable: true),
                    child3_Othernames = table.Column<string>(type: "ntext", nullable: true),
                    child3_Dob = table.Column<DateTime>(type: "datetime2", nullable: true),
                    child3_Sex = table.Column<int>(nullable: true),
                    child3_mobile = table.Column<string>(type: "ntext", nullable: true),
                    child3_email = table.Column<string>(type: "ntext", nullable: true),
                    child3_hospital = table.Column<string>(type: "ntext", nullable: true),
                    child3_medicalhistory = table.Column<string>(type: "ntext", nullable: true),
                    child4_Surname = table.Column<string>(type: "ntext", nullable: true),
                    child4_Othernames = table.Column<string>(type: "ntext", nullable: true),
                    child4_Dob = table.Column<DateTime>(type: "datetime2", nullable: true),
                    child4_Sex = table.Column<int>(nullable: true),
                    child4_mobile = table.Column<string>(type: "ntext", nullable: true),
                    child4_email = table.Column<string>(type: "ntext", nullable: true),
                    child4_hospital = table.Column<string>(type: "ntext", nullable: true),
                    child4_medicalhistory = table.Column<string>(type: "ntext", nullable: true),
                    addspouse = table.Column<bool>(nullable: true),
                    addchild1 = table.Column<bool>(nullable: true),
                    addchild2 = table.Column<bool>(nullable: true),
                    addchild3 = table.Column<bool>(nullable: true),
                    addchild4 = table.Column<bool>(nullable: true),
                    Guid = table.Column<Guid>(nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(nullable: true),
                    EnrolleePassportId = table.Column<int>(nullable: true),
                    SiteId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Query", x => x.Guid);
                });

            migrationBuilder.CreateTable(
                name: "QueuedMessage",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Body = table.Column<string>(nullable: true),
                    FromAddress = table.Column<string>(nullable: true),
                    FromName = table.Column<string>(nullable: true),
                    ToAddress = table.Column<string>(nullable: true),
                    ToName = table.Column<string>(nullable: true),
                    Cc = table.Column<string>(nullable: true),
                    Bcc = table.Column<string>(nullable: true),
                    Subject = table.Column<string>(nullable: true),
                    SentOn = table.Column<DateTime>(nullable: true),
                    Tries = table.Column<int>(nullable: true),
                    IsHtml = table.Column<bool>(nullable: true),
                    Guid = table.Column<Guid>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: true),
                    SiteId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QueuedMessage", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "QueuedTask",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Data = table.Column<string>(nullable: true),
                    Type = table.Column<string>(nullable: true),
                    Status = table.Column<string>(maxLength: 255, nullable: true),
                    Tries = table.Column<int>(nullable: true),
                    Priority = table.Column<int>(nullable: true),
                    QueuedAt = table.Column<DateTime>(nullable: true),
                    StartedAt = table.Column<DateTime>(nullable: true),
                    CompletedAt = table.Column<DateTime>(nullable: true),
                    FailedAt = table.Column<DateTime>(nullable: true),
                    Guid = table.Column<Guid>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: true),
                    SiteId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QueuedTask", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ScheduledTask",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Type = table.Column<string>(nullable: true),
                    EveryXSeconds = table.Column<int>(nullable: true),
                    LastQueuedAt = table.Column<DateTime>(nullable: true),
                    LastComplete = table.Column<DateTime>(nullable: true),
                    Status = table.Column<string>(maxLength: 255, nullable: true),
                    Guid = table.Column<Guid>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: true),
                    SiteId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ScheduledTask", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Service",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Code = table.Column<string>(nullable: true),
                    Status = table.Column<bool>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    CreatedBy = table.Column<int>(nullable: true),
                    AuthorizationStatus = table.Column<int>(nullable: true),
                    AuthorizationNote = table.Column<string>(nullable: true),
                    DisapprovalNote = table.Column<string>(nullable: true),
                    AuthorizedBy = table.Column<int>(nullable: true),
                    DisapprovedBy = table.Column<int>(nullable: true),
                    AuthorizedDate = table.Column<DateTime>(nullable: true),
                    DisapprovalDate = table.Column<DateTime>(nullable: true),
                    Guid = table.Column<Guid>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: true),
                    SiteId = table.Column<int>(nullable: true),
                    ServicesPageId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Service", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ServiceTariff",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Unit = table.Column<string>(nullable: true),
                    Price = table.Column<decimal>(nullable: true),
                    PreauthorizationRequired = table.Column<bool>(nullable: true),
                    GroupId = table.Column<int>(nullable: true),
                    Groupname = table.Column<string>(nullable: true),
                    Guid = table.Column<Guid>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: true),
                    SiteId = table.Column<int>(nullable: true),
                    AlternatePrice = table.Column<string>(nullable: true),
                    Remark = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServiceTariff", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Setting",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Value = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Guid = table.Column<Guid>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: true),
                    SiteId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Setting", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ShortCodeMsg",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Mobile = table.Column<string>(nullable: true),
                    Msg = table.Column<string>(nullable: true),
                    MsgTime = table.Column<DateTime>(nullable: true),
                    Status = table.Column<bool>(nullable: true),
                    Guid = table.Column<Guid>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: true),
                    SiteId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShortCodeMsg", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Site",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    BaseUrl = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Guid = table.Column<Guid>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Site", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sms",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Msisdn = table.Column<string>(nullable: true),
                    EnrolleeId = table.Column<int>(nullable: true),
                    FromId = table.Column<string>(nullable: true),
                    Message = table.Column<string>(nullable: true),
                    Status = table.Column<string>(maxLength: 255, nullable: true),
                    Type = table.Column<string>(maxLength: 255, nullable: true),
                    DeliveryDate = table.Column<DateTime>(nullable: true),
                    DateDelivered = table.Column<DateTime>(nullable: true),
                    ServerResponse = table.Column<string>(nullable: true),
                    ServerCode = table.Column<string>(nullable: true),
                    ServerStatus = table.Column<string>(nullable: true),
                    CreatedBy = table.Column<int>(nullable: true),
                    Guid = table.Column<Guid>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: true),
                    SiteId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sms", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SmsConfig",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    BdaySmsTemplate = table.Column<string>(nullable: true),
                    PreScheduleText = table.Column<bool>(nullable: true),
                    Mode = table.Column<int>(nullable: true),
                    Active = table.Column<bool>(nullable: true),
                    UserName = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    Guid = table.Column<Guid>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: true),
                    SiteId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SmsConfig", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SponsorShipType",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Typename = table.Column<string>(nullable: true),
                    Guid = table.Column<Guid>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: true),
                    SiteId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SponsorShipType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Staff",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    CompanyId = table.Column<string>(nullable: true),
                    CompanySubsidiary = table.Column<int>(nullable: true),
                    StaffFullname = table.Column<string>(nullable: true),
                    StaffPlanid = table.Column<int>(nullable: true),
                    HasProfile = table.Column<bool>(nullable: true),
                    Profileid = table.Column<int>(nullable: true),
                    Createdby = table.Column<int>(nullable: true),
                    Guid = table.Column<Guid>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: true),
                    SiteId = table.Column<int>(nullable: true),
                    IsExpunged = table.Column<bool>(nullable: true),
                    StaffId = table.Column<string>(nullable: true),
                    NewStaffId = table.Column<int>(nullable: true),
                    stafflinkDate = table.Column<DateTime>(nullable: true),
                    stafflinkUSer = table.Column<int>(nullable: true),
                    StaffJobId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Staff", x => x.Guid);
                });

            migrationBuilder.CreateTable(
                name: "StaffUploadJob",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    filelink = table.Column<string>(nullable: true),
                    JobStatus = table.Column<string>(maxLength: 255, nullable: true),
                    UploadedBy = table.Column<int>(nullable: true),
                    CompanyID = table.Column<int>(nullable: true),
                    Subsidiary = table.Column<int>(nullable: true),
                    ExpungeMode = table.Column<string>(maxLength: 255, nullable: true),
                    TotalRecord = table.Column<int>(nullable: true),
                    TotalRecordDone = table.Column<int>(nullable: true),
                    TotalRecordSuccess = table.Column<int>(nullable: true),
                    TotalRecordFailed = table.Column<int>(nullable: true),
                    TotalStaffForExpunged = table.Column<int>(nullable: true),
                    TotalStaffAdded = table.Column<int>(nullable: true),
                    StartTime = table.Column<DateTime>(nullable: true),
                    FinishTime = table.Column<DateTime>(nullable: true),
                    Guid = table.Column<Guid>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: true),
                    SiteId = table.Column<int>(nullable: true),
                    errorlist = table.Column<string>(nullable: true),
                    Analysislink = table.Column<string>(nullable: true),
                    approved = table.Column<bool>(nullable: true),
                    dateapproved = table.Column<DateTime>(nullable: true),
                    approvedby = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StaffUploadJob", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StringResource",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Key = table.Column<string>(nullable: true),
                    Value = table.Column<string>(nullable: true),
                    UICulture = table.Column<string>(nullable: true),
                    Guid = table.Column<Guid>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: true),
                    SiteId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StringResource", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Subscription",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    SubscriptionCode = table.Column<string>(nullable: true),
                    CompanyId = table.Column<int>(nullable: true),
                    Companyplans = table.Column<string>(nullable: true),
                    Startdate = table.Column<DateTime>(nullable: true),
                    Duration = table.Column<int>(nullable: true),
                    Expirationdate = table.Column<DateTime>(nullable: true),
                    Note = table.Column<string>(nullable: true),
                    Status = table.Column<int>(nullable: true),
                    Createdby = table.Column<int>(nullable: true),
                    AuthorizationStatus = table.Column<int>(nullable: true),
                    AuthorizationNote = table.Column<string>(nullable: true),
                    DisapprovalNote = table.Column<string>(nullable: true),
                    TerminationNote = table.Column<string>(nullable: true),
                    Terminatedby = table.Column<int>(nullable: true),
                    AuthorizedBy = table.Column<int>(nullable: true),
                    DisapprovedBy = table.Column<int>(nullable: true),
                    AuthorizedDate = table.Column<DateTime>(nullable: true),
                    DisapprovalDate = table.Column<DateTime>(nullable: true),
                    Guid = table.Column<Guid>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: true),
                    SiteId = table.Column<int>(nullable: true),
                    SubscriptionMode = table.Column<string>(maxLength: 255, nullable: true),
                    Subsidiaries = table.Column<string>(nullable: true),
                    SubsidiaryId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subscription", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Symposium",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(nullable: true),
                    occupation = table.Column<string>(nullable: true),
                    email = table.Column<string>(nullable: true),
                    phone = table.Column<string>(nullable: true),
                    Guid = table.Column<Guid>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: true),
                    SiteId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Symposium", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tag",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Guid = table.Column<Guid>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: true),
                    SiteId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tag", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tariff",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Status = table.Column<bool>(nullable: true),
                    CreatedBy = table.Column<int>(nullable: true),
                    Guid = table.Column<Guid>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: true),
                    SiteId = table.Column<int>(nullable: true),
                    TariffPageId = table.Column<int>(nullable: true),
                    authstatus = table.Column<bool>(nullable: true),
                    authBy = table.Column<int>(nullable: true),
                    AuthorizedDate = table.Column<DateTime>(nullable: true),
                    defaultProvider = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tariff", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TariffCategory",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TariffId = table.Column<int>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Type = table.Column<int>(nullable: true),
                    Guid = table.Column<Guid>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: true),
                    SiteId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TariffCategory", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TaskShit",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    LastRun = table.Column<DateTime>(nullable: true),
                    RunTimerSeconds = table.Column<long>(nullable: true),
                    status = table.Column<bool>(nullable: true),
                    Enabled = table.Column<bool>(nullable: true),
                    Guid = table.Column<Guid>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: true),
                    SiteId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaskShit", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TempEnrollee",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Imgraw = table.Column<byte[]>(nullable: true),
                    S_Imgraw = table.Column<byte[]>(nullable: true),
                    child1_Imgraw = table.Column<byte[]>(nullable: true),
                    child2_Imgraw = table.Column<byte[]>(nullable: true),
                    child3_Imgraw = table.Column<byte[]>(nullable: true),
                    child4_Imgraw = table.Column<byte[]>(nullable: true),
                    Policynumber = table.Column<string>(nullable: true),
                    RefPolicynumber = table.Column<string>(nullable: true),
                    HasRefPolicyNumber = table.Column<bool>(nullable: true),
                    Title = table.Column<string>(nullable: true),
                    Surname = table.Column<string>(nullable: true),
                    Othernames = table.Column<string>(nullable: true),
                    Dob = table.Column<DateTime>(nullable: true),
                    Age = table.Column<int>(nullable: true),
                    Maritalstatus = table.Column<int>(nullable: true),
                    Occupation = table.Column<string>(nullable: true),
                    Sex = table.Column<int>(nullable: true),
                    Residentialaddress = table.Column<string>(nullable: true),
                    Stateoforiginid = table.Column<int>(nullable: true),
                    Lga = table.Column<string>(nullable: true),
                    Stateofresidence = table.Column<int>(nullable: true),
                    Mobilenumber = table.Column<string>(nullable: true),
                    Mobilenumber2 = table.Column<string>(nullable: true),
                    Emailaddress = table.Column<string>(nullable: true),
                    Sponsorshiptype = table.Column<int>(nullable: true),
                    Sponsorshiptypeothername = table.Column<string>(nullable: true),
                    Preexistingmedicalhistory = table.Column<string>(nullable: true),
                    Sponsorshiptypenote = table.Column<string>(nullable: true),
                    Companyid = table.Column<int>(nullable: true),
                    officestate = table.Column<int>(nullable: true),
                    BranchName = table.Column<string>(nullable: true),
                    staffid = table.Column<string>(nullable: true),
                    Subscriptionplanid = table.Column<int>(nullable: true),
                    Hasdependents = table.Column<bool>(nullable: true),
                    Specialidcardfield1 = table.Column<string>(nullable: true),
                    Specialidcardfield2 = table.Column<string>(nullable: true),
                    Specialidcardfield3 = table.Column<string>(nullable: true),
                    Staffprofileid = table.Column<int>(nullable: true),
                    IdCardPrinted = table.Column<bool>(nullable: true),
                    Primaryprovider = table.Column<string>(nullable: true),
                    Status = table.Column<int>(nullable: true),
                    Hasactivesubscription = table.Column<bool>(nullable: true),
                    Isexpundged = table.Column<bool>(nullable: true),
                    ExpungeNote = table.Column<string>(nullable: true),
                    Expungedby = table.Column<int>(nullable: true),
                    Dateexpunged = table.Column<DateTime>(nullable: true),
                    Createdby = table.Column<int>(nullable: true),
                    Datereceived = table.Column<DateTime>(nullable: true),
                    BranchID = table.Column<string>(nullable: true),
                    s_Surname = table.Column<string>(nullable: true),
                    s_Othernames = table.Column<string>(nullable: true),
                    s_Dob = table.Column<DateTime>(nullable: true),
                    S_Sex = table.Column<int>(nullable: true),
                    S_mobile = table.Column<string>(nullable: true),
                    S_email = table.Column<string>(nullable: true),
                    S_hospital = table.Column<string>(nullable: true),
                    S_medicalhistory = table.Column<string>(nullable: true),
                    child1_Surname = table.Column<string>(nullable: true),
                    child1_Othernames = table.Column<string>(nullable: true),
                    child1_Dob = table.Column<DateTime>(nullable: true),
                    child1_Sex = table.Column<int>(nullable: true),
                    child1_mobile = table.Column<string>(nullable: true),
                    child1_email = table.Column<string>(nullable: true),
                    child1_hospital = table.Column<string>(nullable: true),
                    child1_medicalhistory = table.Column<string>(nullable: true),
                    child2_Surname = table.Column<string>(nullable: true),
                    child2_Othernames = table.Column<string>(nullable: true),
                    child2_Dob = table.Column<DateTime>(nullable: true),
                    child2_Sex = table.Column<int>(nullable: true),
                    child2_mobile = table.Column<string>(nullable: true),
                    child2_email = table.Column<string>(nullable: true),
                    child2_hospital = table.Column<string>(nullable: true),
                    child2_medicalhistory = table.Column<string>(nullable: true),
                    child3_Surname = table.Column<string>(nullable: true),
                    child3_Othernames = table.Column<string>(nullable: true),
                    child3_Dob = table.Column<DateTime>(nullable: true),
                    child3_Sex = table.Column<int>(nullable: true),
                    child3_mobile = table.Column<string>(nullable: true),
                    child3_email = table.Column<string>(nullable: true),
                    child3_hospital = table.Column<string>(nullable: true),
                    child3_medicalhistory = table.Column<string>(nullable: true),
                    child4_Surname = table.Column<string>(nullable: true),
                    child4_Othernames = table.Column<string>(nullable: true),
                    child4_Dob = table.Column<DateTime>(nullable: true),
                    child4_Sex = table.Column<int>(nullable: true),
                    child4_mobile = table.Column<string>(nullable: true),
                    child4_email = table.Column<string>(nullable: true),
                    child4_hospital = table.Column<string>(nullable: true),
                    child4_medicalhistory = table.Column<string>(nullable: true),
                    addspouse = table.Column<bool>(nullable: true),
                    addchild1 = table.Column<bool>(nullable: true),
                    addchild2 = table.Column<bool>(nullable: true),
                    addchild3 = table.Column<bool>(nullable: true),
                    addchild4 = table.Column<bool>(nullable: true),
                    Guid = table.Column<Guid>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: true),
                    EnrolleePassportId = table.Column<int>(nullable: true),
                    SiteId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TempEnrollee", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TerminatedSubscription",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    SubscriptionId = table.Column<int>(nullable: true),
                    Terminationdate = table.Column<DateTime>(nullable: true),
                    TerminatedByUserId = table.Column<int>(nullable: true),
                    Note = table.Column<string>(nullable: true),
                    AuthorizationStatus = table.Column<int>(nullable: true),
                    AuthorizationNote = table.Column<string>(nullable: true),
                    AuthorizedBy = table.Column<string>(nullable: true),
                    AuthorizedDate = table.Column<DateTime>(nullable: true),
                    Guid = table.Column<Guid>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: true),
                    SiteId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TerminatedSubscription", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "testable",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Tony = table.Column<string>(nullable: true),
                    Code = table.Column<int>(nullable: true),
                    Guid = table.Column<Guid>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: true),
                    SiteId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_testable", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UrlHistory",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UrlSegment = table.Column<string>(nullable: true),
                    Guid = table.Column<Guid>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: true),
                    WebpageId = table.Column<int>(nullable: true),
                    SiteId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UrlHistory", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserNotification",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<string>(nullable: true),
                    Message = table.Column<string>(nullable: true),
                    Type = table.Column<int>(nullable: true),
                    Target = table.Column<int>(nullable: true),
                    Read = table.Column<bool>(nullable: true),
                    ClickAction = table.Column<string>(nullable: true),
                    Guid = table.Column<Guid>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: true),
                    RoleId = table.Column<int>(nullable: true),
                    SiteId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserNotification", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserProfileData",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ProfileInfoType = table.Column<string>(maxLength: 255, nullable: false),
                    Guid = table.Column<Guid>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: true),
                    UserId = table.Column<int>(nullable: true),
                    Bio = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserProfileData", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "VettingProtocol",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Diagnosis = table.Column<string>(nullable: true),
                    investigations = table.Column<string>(nullable: true),
                    treatment = table.Column<string>(nullable: true),
                    specialist = table.Column<string>(nullable: true),
                    Guid = table.Column<Guid>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: true),
                    SiteId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VettingProtocol", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WrongProfile",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false),
                    staffprofileid = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WrongProfile", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Zone",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Code = table.Column<string>(nullable: true),
                    Countryid = table.Column<long>(nullable: true),
                    Status = table.Column<bool>(nullable: true),
                    Guid = table.Column<Guid>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: true),
                    SiteId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Zone", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BatchJob",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    discriminator = table.Column<string>(maxLength: 255, nullable: false),
                    Data = table.Column<string>(nullable: true),
                    Tries = table.Column<int>(nullable: true),
                    Status = table.Column<string>(maxLength: 255, nullable: true),
                    Guid = table.Column<Guid>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: true),
                    BatchId = table.Column<int>(nullable: true),
                    SiteId = table.Column<int>(nullable: true),
                    IndexName = table.Column<string>(nullable: true),
                    UrlSegment = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BatchJob", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BatchJob_Batch_BatchId",
                        column: x => x.BatchId,
                        principalTable: "Batch",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "BatchRun",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Status = table.Column<string>(maxLength: 255, nullable: true),
                    Guid = table.Column<Guid>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: true),
                    BatchId = table.Column<int>(nullable: true),
                    SiteId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BatchRun", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BatchRun_Batch_BatchId",
                        column: x => x.BatchId,
                        principalTable: "Batch",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ConnectCareBeneficiary",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    fullname = table.Column<string>(nullable: true),
                    gender = table.Column<string>(nullable: true),
                    country = table.Column<string>(nullable: true),
                    state = table.Column<string>(nullable: true),
                    address = table.Column<string>(nullable: true),
                    email = table.Column<string>(nullable: true),
                    city = table.Column<string>(nullable: true),
                    phonenumber = table.Column<string>(nullable: true),
                    relationship = table.Column<string>(nullable: true),
                    age = table.Column<int>(nullable: true),
                    sponsorid = table.Column<int>(nullable: true),
                    Guid = table.Column<Guid>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: true),
                    SiteId = table.Column<int>(nullable: true),
                    BeneficiaryCat = table.Column<string>(nullable: true),
                    Passport = table.Column<byte[]>(nullable: true),
                    BeneficiaryID = table.Column<string>(nullable: true),
                    firstname = table.Column<string>(nullable: true),
                    dob = table.Column<DateTime>(nullable: true),
                    lastname = table.Column<string>(nullable: true),
                    LGA = table.Column<string>(nullable: true),
                    GuardianPhonenumber = table.Column<string>(nullable: true),
                    GuardianEmail = table.Column<string>(nullable: true),
                    SuggestedProvider = table.Column<string>(nullable: true),
                    suggestedPlan = table.Column<string>(nullable: true),
                    PolicyNumber = table.Column<string>(nullable: true),
                    VerificationStatus = table.Column<bool>(nullable: true),
                    active = table.Column<bool>(nullable: true),
                    Status = table.Column<string>(maxLength: 255, nullable: true),
                    Category = table.Column<string>(nullable: true),
                    addon = table.Column<bool>(nullable: true),
                    Administeredby = table.Column<int>(nullable: true),
                    AdministrationDate = table.Column<DateTime>(nullable: true),
                    ConnectCareSponsorId = table.Column<int>(nullable: true),
                    sponsoridstring = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConnectCareBeneficiary", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ConnectCareBeneficiary_ConnectCareSponsor_ConnectCareSponsorId",
                        column: x => x.ConnectCareSponsorId,
                        principalTable: "ConnectCareSponsor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "FormValue",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Value = table.Column<string>(nullable: true),
                    Key = table.Column<string>(nullable: true),
                    IsFile = table.Column<bool>(nullable: true),
                    Guid = table.Column<Guid>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: true),
                    FormPostingId = table.Column<int>(nullable: true),
                    SiteId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FormValue", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FormValue_FormPosting_FormPostingId",
                        column: x => x.FormPostingId,
                        principalTable: "FormPosting",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "FormListOption",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Value = table.Column<string>(nullable: true),
                    Selected = table.Column<bool>(nullable: true),
                    Guid = table.Column<Guid>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: true),
                    FormPropertyId = table.Column<int>(nullable: true),
                    SiteId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FormListOption", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FormListOption_FormProperty_FormPropertyId",
                        column: x => x.FormPropertyId,
                        principalTable: "FormProperty",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ResizedImage",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Url = table.Column<string>(maxLength: 1000, nullable: true),
                    Guid = table.Column<Guid>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: true),
                    MediaFileId = table.Column<int>(nullable: true),
                    SiteId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ResizedImage", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ResizedImage_MediaFile_MediaFileId",
                        column: x => x.MediaFileId,
                        principalTable: "MediaFile",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "QueuedMessageAttachment",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FileName = table.Column<string>(nullable: true),
                    Guid = table.Column<Guid>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: true),
                    QueuedMessageId = table.Column<int>(nullable: true),
                    SiteId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QueuedMessageAttachment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_QueuedMessageAttachment_QueuedMessage_QueuedMessageId",
                        column: x => x.QueuedMessageId,
                        principalTable: "QueuedMessage",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "RedirectedDomain",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Url = table.Column<string>(nullable: true),
                    Guid = table.Column<Guid>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: true),
                    SiteId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RedirectedDomain", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RedirectedDomain_Site_SiteId",
                        column: x => x.SiteId,
                        principalTable: "Site",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "BatchRunResult",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ExecutionOrder = table.Column<int>(nullable: true),
                    MillisecondsTaken = table.Column<decimal>(nullable: true),
                    Status = table.Column<string>(maxLength: 255, nullable: true),
                    Guid = table.Column<Guid>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: true),
                    BatchRunId = table.Column<int>(nullable: true),
                    BatchJobId = table.Column<int>(nullable: true),
                    SiteId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BatchRunResult", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BatchRunResult_BatchJob_BatchJobId",
                        column: x => x.BatchJobId,
                        principalTable: "BatchJob",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BatchRunResult_BatchRun_BatchRunId",
                        column: x => x.BatchRunId,
                        principalTable: "BatchRun",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BatchJob_BatchId",
                table: "BatchJob",
                column: "BatchId");

            migrationBuilder.CreateIndex(
                name: "IX_BatchRun_BatchId",
                table: "BatchRun",
                column: "BatchId");

            migrationBuilder.CreateIndex(
                name: "IX_BatchRunResult_BatchJobId",
                table: "BatchRunResult",
                column: "BatchJobId");

            migrationBuilder.CreateIndex(
                name: "IX_BatchRunResult_BatchRunId",
                table: "BatchRunResult",
                column: "BatchRunId");

            migrationBuilder.CreateIndex(
                name: "IX_ConnectCareBeneficiary_ConnectCareSponsorId",
                table: "ConnectCareBeneficiary",
                column: "ConnectCareSponsorId");

            migrationBuilder.CreateIndex(
                name: "IX_FormListOption_FormPropertyId",
                table: "FormListOption",
                column: "FormPropertyId");

            migrationBuilder.CreateIndex(
                name: "IX_FormValue_FormPostingId",
                table: "FormValue",
                column: "FormPostingId");

            migrationBuilder.CreateIndex(
                name: "IX_ProviderClaimBK_providerId",
                table: "ProviderClaimBK",
                column: "providerId");

            migrationBuilder.CreateIndex(
                name: "IX_QueuedMessageAttachment_QueuedMessageId",
                table: "QueuedMessageAttachment",
                column: "QueuedMessageId");

            migrationBuilder.CreateIndex(
                name: "IX_RedirectedDomain_SiteId",
                table: "RedirectedDomain",
                column: "SiteId");

            migrationBuilder.CreateIndex(
                name: "IX_ResizedImage_MediaFileId",
                table: "ResizedImage",
                column: "MediaFileId");

            migrationBuilder.AddForeignKey(
                name: "FK_Claim_ClaimBatch_ClaimBatchId",
                table: "Claim",
                column: "ClaimBatchId",
                principalTable: "ClaimBatch",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ClaimBatch_PaymentBatch_paymentbatchId",
                table: "ClaimBatch",
                column: "paymentbatchId",
                principalTable: "PaymentBatch",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ClaimDrug_Claim_ClaimId",
                table: "ClaimDrug",
                column: "ClaimId",
                principalTable: "Claim",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ClaimService_Claim_ClaimId",
                table: "ClaimService",
                column: "ClaimId",
                principalTable: "Claim",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CompanyBranch_Company_companyId",
                table: "CompanyBranch",
                column: "companyId",
                principalTable: "Company",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_IncomingClaims_ClaimBatch_ClaimBatchId",
                table: "IncomingClaims",
                column: "ClaimBatchId",
                principalTable: "ClaimBatch",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ProviderServices_Provider_providerId",
                table: "ProviderServices",
                column: "providerId",
                principalTable: "Provider",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Claim_ClaimBatch_ClaimBatchId",
                table: "Claim");

            migrationBuilder.DropForeignKey(
                name: "FK_ClaimBatch_PaymentBatch_paymentbatchId",
                table: "ClaimBatch");

            migrationBuilder.DropForeignKey(
                name: "FK_ClaimDrug_Claim_ClaimId",
                table: "ClaimDrug");

            migrationBuilder.DropForeignKey(
                name: "FK_ClaimService_Claim_ClaimId",
                table: "ClaimService");

            migrationBuilder.DropForeignKey(
                name: "FK_CompanyBranch_Company_companyId",
                table: "CompanyBranch");

            migrationBuilder.DropForeignKey(
                name: "FK_IncomingClaims_ClaimBatch_ClaimBatchId",
                table: "IncomingClaims");

            migrationBuilder.DropForeignKey(
                name: "FK_ProviderServices_Provider_providerId",
                table: "ProviderServices");

            migrationBuilder.DropTable(
                name: "AdminAllowedRole");

            migrationBuilder.DropTable(
                name: "AdminDisallowedRole");

            migrationBuilder.DropTable(
                name: "AutomaticExpungeStaff");

            migrationBuilder.DropTable(
                name: "BatchRunResult");

            migrationBuilder.DropTable(
                name: "ClaimAnalysisOffline");

            migrationBuilder.DropTable(
                name: "ClaimHistory");

            migrationBuilder.DropTable(
                name: "CompanyAssignee");

            migrationBuilder.DropTable(
                name: "CompanyBenefit");

            migrationBuilder.DropTable(
                name: "CompanyPlan");

            migrationBuilder.DropTable(
                name: "ConnectCareBeneficiary");

            migrationBuilder.DropTable(
                name: "ConnectcarePaymentDetails");

            migrationBuilder.DropTable(
                name: "Country");

            migrationBuilder.DropTable(
                name: "DeletedEnrollee");

            migrationBuilder.DropTable(
                name: "DownloadFile");

            migrationBuilder.DropTable(
                name: "DrugTariff");

            migrationBuilder.DropTable(
                name: "EmailDEST");

            migrationBuilder.DropTable(
                name: "Enrollee");

            migrationBuilder.DropTable(
                name: "EnrolleePreexistingMedicalHistory");

            migrationBuilder.DropTable(
                name: "EnrolleeVerificationCode");

            migrationBuilder.DropTable(
                name: "ExpungedEnrollee");

            migrationBuilder.DropTable(
                name: "Faq");

            migrationBuilder.DropTable(
                name: "FormListOption");

            migrationBuilder.DropTable(
                name: "FormValue");

            migrationBuilder.DropTable(
                name: "Gender");

            migrationBuilder.DropTable(
                name: "Issues");

            migrationBuilder.DropTable(
                name: "Log");

            migrationBuilder.DropTable(
                name: "LuceneFieldBoost");

            migrationBuilder.DropTable(
                name: "MaritalStatus");

            migrationBuilder.DropTable(
                name: "MessageTemplate");

            migrationBuilder.DropTable(
                name: "MobileSignup");

            migrationBuilder.DropTable(
                name: "Notification");

            migrationBuilder.DropTable(
                name: "NotificationTable");

            migrationBuilder.DropTable(
                name: "NovoStaff");

            migrationBuilder.DropTable(
                name: "NovoStaffResponsibility");

            migrationBuilder.DropTable(
                name: "OfflineMessage");

            migrationBuilder.DropTable(
                name: "PageTemplate");

            migrationBuilder.DropTable(
                name: "PendingDependant");

            migrationBuilder.DropTable(
                name: "Plan");

            migrationBuilder.DropTable(
                name: "PlanDefaultBenefit");

            migrationBuilder.DropTable(
                name: "PreExistingMedicalHistoryList");

            migrationBuilder.DropTable(
                name: "ProviderClaimBK");

            migrationBuilder.DropTable(
                name: "Query");

            migrationBuilder.DropTable(
                name: "QueuedMessageAttachment");

            migrationBuilder.DropTable(
                name: "QueuedTask");

            migrationBuilder.DropTable(
                name: "RedirectedDomain");

            migrationBuilder.DropTable(
                name: "ResizedImage");

            migrationBuilder.DropTable(
                name: "ScheduledTask");

            migrationBuilder.DropTable(
                name: "Service");

            migrationBuilder.DropTable(
                name: "ServiceTariff");

            migrationBuilder.DropTable(
                name: "Setting");

            migrationBuilder.DropTable(
                name: "ShortCodeMsg");

            migrationBuilder.DropTable(
                name: "Sms");

            migrationBuilder.DropTable(
                name: "SmsConfig");

            migrationBuilder.DropTable(
                name: "SponsorShipType");

            migrationBuilder.DropTable(
                name: "Staff");

            migrationBuilder.DropTable(
                name: "StaffUploadJob");

            migrationBuilder.DropTable(
                name: "StringResource");

            migrationBuilder.DropTable(
                name: "Subscription");

            migrationBuilder.DropTable(
                name: "Symposium");

            migrationBuilder.DropTable(
                name: "Tag");

            migrationBuilder.DropTable(
                name: "Tariff");

            migrationBuilder.DropTable(
                name: "TariffCategory");

            migrationBuilder.DropTable(
                name: "TaskShit");

            migrationBuilder.DropTable(
                name: "TempEnrollee");

            migrationBuilder.DropTable(
                name: "TerminatedSubscription");

            migrationBuilder.DropTable(
                name: "testable");

            migrationBuilder.DropTable(
                name: "UrlHistory");

            migrationBuilder.DropTable(
                name: "UserNotification");

            migrationBuilder.DropTable(
                name: "UserProfileData");

            migrationBuilder.DropTable(
                name: "VettingProtocol");

            migrationBuilder.DropTable(
                name: "WrongProfile");

            migrationBuilder.DropTable(
                name: "Zone");

            migrationBuilder.DropTable(
                name: "BatchJob");

            migrationBuilder.DropTable(
                name: "BatchRun");

            migrationBuilder.DropTable(
                name: "ConnectCareSponsor");

            migrationBuilder.DropTable(
                name: "FormProperty");

            migrationBuilder.DropTable(
                name: "FormPosting");

            migrationBuilder.DropTable(
                name: "QueuedMessage");

            migrationBuilder.DropTable(
                name: "Site");

            migrationBuilder.DropTable(
                name: "MediaFile");

            migrationBuilder.DropTable(
                name: "Batch");

            migrationBuilder.DropColumn(
                name: "SiteId",
                table: "State");

            migrationBuilder.DropColumn(
                name: "SiteId",
                table: "ProviderServices");

            migrationBuilder.DropColumn(
                name: "SiteId",
                table: "ProviderRating");

            migrationBuilder.DropColumn(
                name: "SiteId",
                table: "ProviderLogin");

            migrationBuilder.DropColumn(
                name: "SiteId",
                table: "ProviderAssignee");

            migrationBuilder.DropColumn(
                name: "SiteId",
                table: "ProviderAccount");

            migrationBuilder.DropColumn(
                name: "SiteId",
                table: "Provider");

            migrationBuilder.DropColumn(
                name: "SiteId",
                table: "PaymentBatch");

            migrationBuilder.DropColumn(
                name: "SiteId",
                table: "Lga");

            migrationBuilder.DropColumn(
                name: "SiteId",
                table: "IncomingClaims");

            migrationBuilder.DropColumn(
                name: "SiteId",
                table: "EnrolleePassport");

            migrationBuilder.DropColumn(
                name: "SiteId",
                table: "CompanySubsidiary");

            migrationBuilder.DropColumn(
                name: "SiteId",
                table: "CompanyBranch");

            migrationBuilder.DropColumn(
                name: "SiteId",
                table: "Company");

            migrationBuilder.DropColumn(
                name: "SiteId",
                table: "ClaimService");

            migrationBuilder.DropColumn(
                name: "SiteId",
                table: "ClaimDrug");

            migrationBuilder.DropColumn(
                name: "SiteId",
                table: "ClaimBatch");

            migrationBuilder.DropColumn(
                name: "SiteId",
                table: "Claim");

            migrationBuilder.DropColumn(
                name: "SiteId",
                table: "BenefitsCategory");

            migrationBuilder.DropColumn(
                name: "SiteId",
                table: "Benefit");

            migrationBuilder.DropColumn(
                name: "SiteId",
                table: "Bank");

            migrationBuilder.DropColumn(
                name: "SiteId",
                table: "AuthorizationRequest");

            migrationBuilder.DropColumn(
                name: "SiteId",
                table: "AuthorizationCode");

            migrationBuilder.AlterColumn<long>(
                name: "Zone",
                table: "State",
                nullable: false,
                oldClrType: typeof(long),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedOn",
                table: "State",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "Status",
                table: "State",
                nullable: false,
                oldClrType: typeof(bool),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ProviderPageId",
                table: "State",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "IsDeleted",
                table: "State",
                nullable: false,
                oldClrType: typeof(bool),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "EnrolleeRegPageId",
                table: "State",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "EnrolleePageId",
                table: "State",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "EnrolleeListPageId",
                table: "State",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "EnrolleeDetailsPageId",
                table: "State",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "DelistedProviderPageId",
                table: "State",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "State",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "providerId",
                table: "ProviderServices",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedOn",
                table: "ProviderServices",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "IsDeleted",
                table: "ProviderServices",
                nullable: false,
                oldClrType: typeof(bool),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "ProviderServices",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "rating",
                table: "ProviderRating",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "providerID",
                table: "ProviderRating",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "enrolleeid",
                table: "ProviderRating",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "dateaccessed",
                table: "ProviderRating",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedOn",
                table: "ProviderRating",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "IsDeleted",
                table: "ProviderRating",
                nullable: false,
                oldClrType: typeof(bool),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "ProviderRating",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "passwordchange",
                table: "ProviderLogin",
                nullable: false,
                oldClrType: typeof(bool),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "lastlogin",
                table: "ProviderLogin",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "active",
                table: "ProviderLogin",
                nullable: false,
                oldClrType: typeof(bool),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedOn",
                table: "ProviderLogin",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ProviderId",
                table: "ProviderLogin",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastClaimSubmited",
                table: "ProviderLogin",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "IsDeleted",
                table: "ProviderLogin",
                nullable: false,
                oldClrType: typeof(bool),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "ProviderLogin",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Userid",
                table: "ProviderAssignee",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedOn",
                table: "ProviderAssignee",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "Status",
                table: "ProviderAssignee",
                nullable: false,
                oldClrType: typeof(bool),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Providerid",
                table: "ProviderAssignee",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "IsDeleted",
                table: "ProviderAssignee",
                nullable: false,
                oldClrType: typeof(bool),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "ProviderAssignee",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "AssignedBy",
                table: "ProviderAssignee",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedOn",
                table: "ProviderAccount",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "Status",
                table: "ProviderAccount",
                nullable: false,
                oldClrType: typeof(bool),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Providerid",
                table: "ProviderAccount",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "IsDeleted",
                table: "ProviderAccount",
                nullable: false,
                oldClrType: typeof(bool),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "DisapprovedBy",
                table: "ProviderAccount",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DisapprovalDate",
                table: "ProviderAccount",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "ProviderAccount",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "BankId",
                table: "ProviderAccount",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "AuthorizedDate",
                table: "ProviderAccount",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "AuthorizedBy",
                table: "ProviderAccount",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "AuthorizationStatus",
                table: "ProviderAccount",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "providerloginId",
                table: "Provider",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "isDelisted",
                table: "Provider",
                nullable: false,
                oldClrType: typeof(bool),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "delisteddate",
                table: "Provider",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "delistedBy",
                table: "Provider",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedOn",
                table: "Provider",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "TariffPageId",
                table: "Provider",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "TariffContentPageId",
                table: "Provider",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "Status",
                table: "Provider",
                nullable: false,
                oldClrType: typeof(bool),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "StateId",
                table: "Provider",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ProvideraccountId",
                table: "Provider",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Provideraccount2Id",
                table: "Provider",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ProviderListPageId",
                table: "Provider",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ProviderApprovalPageId",
                table: "Provider",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<long>(
                name: "Parentid",
                table: "Provider",
                nullable: false,
                oldClrType: typeof(long),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "LgaId",
                table: "Provider",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "IsDeleted",
                table: "Provider",
                nullable: false,
                oldClrType: typeof(bool),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "DisapprovedBy",
                table: "Provider",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DisapprovalDate",
                table: "Provider",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "DelistedProviderPageId",
                table: "Provider",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Provider",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Category",
                table: "Provider",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 255,
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "AuthorizedDate",
                table: "Provider",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "AuthorizedBy",
                table: "Provider",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "AuthorizationStatus",
                table: "Provider",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Assignee",
                table: "Provider",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "terminationdate",
                table: "PaymentBatch",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "terminatedby",
                table: "PaymentBatch",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "status",
                table: "PaymentBatch",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 255,
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "paidby",
                table: "PaymentBatch",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "datepaymentstarted",
                table: "PaymentBatch",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "datepaymentcompleted",
                table: "PaymentBatch",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "createdBy",
                table: "PaymentBatch",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedOn",
                table: "PaymentBatch",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "IsDeleted",
                table: "PaymentBatch",
                nullable: false,
                oldClrType: typeof(bool),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "PaymentBatch",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedOn",
                table: "Lga",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "Status",
                table: "Lga",
                nullable: false,
                oldClrType: typeof(bool),
                oldNullable: true);

            migrationBuilder.AlterColumn<long>(
                name: "State",
                table: "Lga",
                nullable: false,
                oldClrType: typeof(long),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ProviderPageId",
                table: "Lga",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "IsDeleted",
                table: "Lga",
                nullable: false,
                oldClrType: typeof(bool),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "EnrolleeRegPageId",
                table: "Lga",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "EnrolleePageId",
                table: "Lga",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "EnrolleeListPageId",
                table: "Lga",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "EnrolleeDetailsPageId",
                table: "Lga",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "DelistedProviderPageId",
                table: "Lga",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Lga",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "year",
                table: "IncomingClaims",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "transferstatus",
                table: "IncomingClaims",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "transferedTo",
                table: "IncomingClaims",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "totalamount",
                table: "IncomingClaims",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "status",
                table: "IncomingClaims",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 255,
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "receivedBy",
                table: "IncomingClaims",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "providerid",
                table: "IncomingClaims",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "noofencounter",
                table: "IncomingClaims",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "month",
                table: "IncomingClaims",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "fullDateofbill",
                table: "IncomingClaims",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "dateTransferAcknowledged",
                table: "IncomingClaims",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "captureStarted",
                table: "IncomingClaims",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedOn",
                table: "IncomingClaims",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "IsRemoteSubmission",
                table: "IncomingClaims",
                nullable: false,
                oldClrType: typeof(bool),
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "IsDeleted",
                table: "IncomingClaims",
                nullable: false,
                oldClrType: typeof(bool),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateReceived",
                table: "IncomingClaims",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "IncomingClaims",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ClaimBatchId",
                table: "IncomingClaims",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedOn",
                table: "EnrolleePassport",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "IsDeleted",
                table: "EnrolleePassport",
                nullable: false,
                oldClrType: typeof(bool),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Enrolleeid",
                table: "EnrolleePassport",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "EnrolleePassport",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedOn",
                table: "CompanySubsidiary",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ParentcompanyId",
                table: "CompanySubsidiary",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "IsDeleted",
                table: "CompanySubsidiary",
                nullable: false,
                oldClrType: typeof(bool),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "CompanySubsidiary",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CreatedBy",
                table: "CompanySubsidiary",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "companyId",
                table: "CompanyBranch",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedOn",
                table: "CompanyBranch",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Statecode",
                table: "CompanyBranch",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "IsDeleted",
                table: "CompanyBranch",
                nullable: false,
                oldClrType: typeof(bool),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "CompanyBranch",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "isRenewal",
                table: "Company",
                nullable: false,
                oldClrType: typeof(bool),
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "WeboperationMode",
                table: "Company",
                nullable: false,
                oldClrType: typeof(bool),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedOn",
                table: "Company",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "SubsidiaryId",
                table: "Company",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "SubscriptionStatus",
                table: "Company",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "Status",
                table: "Company",
                nullable: false,
                oldClrType: typeof(bool),
                oldNullable: true);

            migrationBuilder.AlterColumn<long>(
                name: "Stateid",
                table: "Company",
                nullable: false,
                oldClrType: typeof(long),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "RegAgeLimit",
                table: "Company",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<long>(
                name: "Parentid",
                table: "Company",
                nullable: false,
                oldClrType: typeof(long),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Logoid",
                table: "Company",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "IsDeleted",
                table: "Company",
                nullable: false,
                oldClrType: typeof(bool),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "DisapprovedBy",
                table: "Company",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DisapprovalDate",
                table: "Company",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Company",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CompanyListPageId",
                table: "Company",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "AuthorizedDate",
                table: "Company",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "AuthorizedBy",
                table: "Company",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "AuthorizationStatus",
                table: "Company",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "status",
                table: "ClaimService",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 255,
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "flagred",
                table: "ClaimService",
                nullable: false,
                oldClrType: typeof(bool),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "costofdrug",
                table: "ClaimService",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "VettedAmount",
                table: "ClaimService",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedOn",
                table: "ClaimService",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ServiceId",
                table: "ClaimService",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "IsDeleted",
                table: "ClaimService",
                nullable: false,
                oldClrType: typeof(bool),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "InitialAmount",
                table: "ClaimService",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "ClaimService",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ClaimId",
                table: "ClaimService",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "status",
                table: "ClaimDrug",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 255,
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "flagred",
                table: "ClaimDrug",
                nullable: false,
                oldClrType: typeof(bool),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "costofdrug",
                table: "ClaimDrug",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "VettedAmount",
                table: "ClaimDrug",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedOn",
                table: "ClaimDrug",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "IsDeleted",
                table: "ClaimDrug",
                nullable: false,
                oldClrType: typeof(bool),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "InitialAmount",
                table: "ClaimDrug",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "DrugId",
                table: "ClaimDrug",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "ClaimDrug",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ClaimId",
                table: "ClaimDrug",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "year",
                table: "ClaimBatch",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "submitedVetbyUser",
                table: "ClaimBatch",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "submitedReviewbyUser",
                table: "ClaimBatch",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "submitedPaymentbyUser",
                table: "ClaimBatch",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "status",
                table: "ClaimBatch",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 255,
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "reviewedBy",
                table: "ClaimBatch",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "reviewDate",
                table: "ClaimBatch",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "paymentmethod",
                table: "ClaimBatch",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 255,
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "paymentdate",
                table: "ClaimBatch",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "paymentbatchId",
                table: "ClaimBatch",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "paymentadvicesent",
                table: "ClaimBatch",
                nullable: false,
                oldClrType: typeof(bool),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "month",
                table: "ClaimBatch",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "markpaidby",
                table: "ClaimBatch",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "isremote",
                table: "ClaimBatch",
                nullable: false,
                oldClrType: typeof(bool),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "datepaymentadvicesent",
                table: "ClaimBatch",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "claimscountfromclient",
                table: "ClaimBatch",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "VetDate",
                table: "ClaimBatch",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedOn",
                table: "ClaimBatch",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "SubmitedForReviewDate",
                table: "ClaimBatch",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "SubmitedForPaymentDate",
                table: "ClaimBatch",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ProviderId",
                table: "ClaimBatch",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "IsDeleted",
                table: "ClaimBatch",
                nullable: false,
                oldClrType: typeof(bool),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "DisapprovedBy",
                table: "ClaimBatch",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DisapprovalDate",
                table: "ClaimBatch",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "ClaimBatch",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Batch",
                table: "ClaimBatch",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 255,
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "AuthorizedDate",
                table: "ClaimBatch",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "AuthorizedBy",
                table: "ClaimBatch",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "AuthorizationStatus",
                table: "ClaimBatch",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 255,
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "AmountPaid",
                table: "ClaimBatch",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "vettedBy",
                table: "Claim",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "status",
                table: "Claim",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 255,
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "specialistSigned",
                table: "Claim",
                nullable: false,
                oldClrType: typeof(bool),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "specialistSignecDate",
                table: "Claim",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "enrolleeSigned",
                table: "Claim",
                nullable: false,
                oldClrType: typeof(bool),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "enrolleeCompanyId",
                table: "Claim",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "capturedBy",
                table: "Claim",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "VettedDate",
                table: "Claim",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedOn",
                table: "Claim",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Tag",
                table: "Claim",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 255,
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "SubmitByProvider",
                table: "Claim",
                nullable: false,
                oldClrType: typeof(bool),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "ServiceDate",
                table: "Claim",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "RevettedBy",
                table: "Claim",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "ReVettedDate",
                table: "Claim",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ProviderId",
                table: "Claim",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "LaboratoryInvestigation",
                table: "Claim",
                nullable: false,
                oldClrType: typeof(bool),
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "IsDeleted",
                table: "Claim",
                nullable: false,
                oldClrType: typeof(bool),
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "Feeding",
                table: "Claim",
                nullable: false,
                oldClrType: typeof(bool),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Enrolleeid",
                table: "Claim",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "EnrolleeSignDate",
                table: "Claim",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "DoctorSigned",
                table: "Claim",
                nullable: false,
                oldClrType: typeof(bool),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DoctorSignecDate",
                table: "Claim",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DischargeDate",
                table: "Claim",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Claim",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ClaimBatchId",
                table: "Claim",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "AllprescibedDrugs",
                table: "Claim",
                nullable: false,
                oldClrType: typeof(bool),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "AdmissionDate",
                table: "Claim",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "Admission",
                table: "Claim",
                nullable: false,
                oldClrType: typeof(bool),
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MyUserId",
                table: "Claim",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "vettedName",
                table: "Claim",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedOn",
                table: "BenefitsCategory",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "Status",
                table: "BenefitsCategory",
                nullable: false,
                oldClrType: typeof(bool),
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "IsDeleted",
                table: "BenefitsCategory",
                nullable: false,
                oldClrType: typeof(bool),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "BenefitsCategory",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedOn",
                table: "Benefit",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "Status",
                table: "Benefit",
                nullable: false,
                oldClrType: typeof(bool),
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "IsDeleted",
                table: "Benefit",
                nullable: false,
                oldClrType: typeof(bool),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Benefit",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Benefitcategory",
                table: "Benefit",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedOn",
                table: "Bank",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "IsDeleted",
                table: "Bank",
                nullable: false,
                oldClrType: typeof(bool),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Bank",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "providerid",
                table: "AuthorizationRequest",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "isnew",
                table: "AuthorizationRequest",
                nullable: false,
                oldClrType: typeof(bool),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedOn",
                table: "AuthorizationRequest",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "IsDeleted",
                table: "AuthorizationRequest",
                nullable: false,
                oldClrType: typeof(bool),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "AuthorizationRequest",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "provider",
                table: "AuthorizationCode",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "isdelivery",
                table: "AuthorizationCode",
                nullable: false,
                oldClrType: typeof(bool),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "generatedby",
                table: "AuthorizationCode",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "enrolleeID",
                table: "AuthorizationCode",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "enrolleeAge",
                table: "AuthorizationCode",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "deliverysmssent",
                table: "AuthorizationCode",
                nullable: false,
                oldClrType: typeof(bool),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "admissionStatus",
                table: "AuthorizationCode",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 255,
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedOn",
                table: "AuthorizationCode",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "Isadmission",
                table: "AuthorizationCode",
                nullable: false,
                oldClrType: typeof(bool),
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "IsNHIS",
                table: "AuthorizationCode",
                nullable: false,
                oldClrType: typeof(bool),
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "IsDeleted",
                table: "AuthorizationCode",
                nullable: false,
                oldClrType: typeof(bool),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DischargeDate",
                table: "AuthorizationCode",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "DaysApprovded",
                table: "AuthorizationCode",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "AuthorizationCode",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Authorizedby",
                table: "AuthorizationCode",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "AdmissionDate",
                table: "AuthorizationCode",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "AcknowledgedByAuthorizer",
                table: "AuthorizationCode",
                nullable: false,
                oldClrType: typeof(bool),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Claim_ClaimBatch_ClaimBatchId",
                table: "Claim",
                column: "ClaimBatchId",
                principalTable: "ClaimBatch",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ClaimBatch_PaymentBatch_paymentbatchId",
                table: "ClaimBatch",
                column: "paymentbatchId",
                principalTable: "PaymentBatch",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ClaimDrug_Claim_ClaimId",
                table: "ClaimDrug",
                column: "ClaimId",
                principalTable: "Claim",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ClaimService_Claim_ClaimId",
                table: "ClaimService",
                column: "ClaimId",
                principalTable: "Claim",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CompanyBranch_Company_companyId",
                table: "CompanyBranch",
                column: "companyId",
                principalTable: "Company",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_IncomingClaims_ClaimBatch_ClaimBatchId",
                table: "IncomingClaims",
                column: "ClaimBatchId",
                principalTable: "ClaimBatch",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProviderServices_Provider_providerId",
                table: "ProviderServices",
                column: "providerId",
                principalTable: "Provider",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
