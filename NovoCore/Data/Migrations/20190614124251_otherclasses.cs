using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NovoCore.Data.Migrations
{
    public partial class otherclasses : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Subsidiary_Company_Companyid",
                table: "Subsidiary");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Subsidiary",
                table: "Subsidiary");

            migrationBuilder.RenameTable(
                name: "Subsidiary",
                newName: "CompanySubsidiary");

            migrationBuilder.RenameIndex(
                name: "IX_Subsidiary_Companyid",
                table: "CompanySubsidiary",
                newName: "IX_CompanySubsidiary_Companyid");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CompanySubsidiary",
                table: "CompanySubsidiary",
                column: "Id");

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
                name: "ProviderAccount",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Bankaccountname = table.Column<string>(nullable: true),
                    Bankaccountnum = table.Column<string>(nullable: true),
                    Bankbranch = table.Column<string>(nullable: true),
                    Note = table.Column<string>(nullable: true),
                    Status = table.Column<bool>(nullable: true),
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
                    AddedBy = table.Column<string>(nullable: true),
                    BankId = table.Column<int>(nullable: false),
                    Providerid = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProviderAccount", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProviderAccount_Bank_BankId",
                        column: x => x.BankId,
                        principalTable: "Bank",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProviderAccount_Provider_Providerid",
                        column: x => x.Providerid,
                        principalTable: "Provider",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ProviderLogin",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Password = table.Column<string>(nullable: true),
                    Passwordchange = table.Column<bool>(nullable: true),
                    Browserid = table.Column<string>(nullable: true),
                    LastloginId = table.Column<string>(nullable: true),
                    Lastlogin = table.Column<DateTime>(nullable: true),
                    Active = table.Column<bool>(nullable: true),
                    LastClaimSubmited = table.Column<DateTime>(nullable: true),
                    Guid = table.Column<Guid>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: true),
                    ProviderId = table.Column<int>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Altemail = table.Column<string>(nullable: true),
                    Altemail2 = table.Column<string>(nullable: true),
                    Altemail3 = table.Column<string>(nullable: true),
                    AddedBy = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProviderLogin", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProviderLogin_Provider_ProviderId",
                        column: x => x.ProviderId,
                        principalTable: "Provider",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProviderAccount_BankId",
                table: "ProviderAccount",
                column: "BankId");

            migrationBuilder.CreateIndex(
                name: "IX_ProviderAccount_Providerid",
                table: "ProviderAccount",
                column: "Providerid");

            migrationBuilder.CreateIndex(
                name: "IX_ProviderLogin_ProviderId",
                table: "ProviderLogin",
                column: "ProviderId");

            migrationBuilder.AddForeignKey(
                name: "FK_CompanySubsidiary_Company_Companyid",
                table: "CompanySubsidiary",
                column: "Companyid",
                principalTable: "Company",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CompanySubsidiary_Company_Companyid",
                table: "CompanySubsidiary");

            migrationBuilder.DropTable(
                name: "FacilitiesAllowed");

            migrationBuilder.DropTable(
                name: "ProviderAccount");

            migrationBuilder.DropTable(
                name: "ProviderLogin");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CompanySubsidiary",
                table: "CompanySubsidiary");

            migrationBuilder.RenameTable(
                name: "CompanySubsidiary",
                newName: "Subsidiary");

            migrationBuilder.RenameIndex(
                name: "IX_CompanySubsidiary_Companyid",
                table: "Subsidiary",
                newName: "IX_Subsidiary_Companyid");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Subsidiary",
                table: "Subsidiary",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Subsidiary_Company_Companyid",
                table: "Subsidiary",
                column: "Companyid",
                principalTable: "Company",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
