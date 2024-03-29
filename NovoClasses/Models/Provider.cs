namespace NovoClasses.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    

    [Table("Provider")]
    public class Provider
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Provider()
        {
            ProviderClaimBKs = new HashSet<ProviderClaimBK>();
            ProviderServices1 = new HashSet<ProviderService>();
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public string Code { get; set; }

        public string SubCode { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }

        public string Phone2 { get; set; }

        public string Website { get; set; }

        public string Address { get; set; }

        public int? Assignee { get; set; }

        public string Providergpscordinate { get; set; }

        public string Providerservices { get; set; }

        public string Providerplans { get; set; }

        public string CreatedBy { get; set; }

        public int? AuthorizationStatus { get; set; }

        public string AuthorizationNote { get; set; }

        public string DisapprovalNote { get; set; }

        public int? AuthorizedBy { get; set; }

        public int? DisapprovedBy { get; set; }

        public DateTime? AuthorizedDate { get; set; }

        public DateTime? DisapprovalDate { get; set; }

        public long? Parentid { get; set; }

        public bool? Status { get; set; }

        public Guid Guid { get; set; }

        public DateTime? CreatedOn { get; set; }

        public DateTime? UpdatedOn { get; set; }

        public bool? IsDeleted { get; set; }

        public int? StateId { get; set; }

        public int? LgaId { get; set; }

        public int? ProvideraccountId { get; set; }

        public int? SiteId { get; set; }

        public int? ProviderListPageId { get; set; }

        public int? ProviderApprovalPageId { get; set; }

        public string DeletionNote { get; set; }

        public int? TariffPageId { get; set; }

        public int? TariffContentPageId { get; set; }

        public string ProviderTariffs { get; set; }

        public string Area { get; set; }

        public int? Provideraccount2Id { get; set; }

        public string PaymentEmail1 { get; set; }

        public string PaymentEmail2 { get; set; }

        public int? providerloginId { get; set; }

        [StringLength(255)]
        public string Category { get; set; }

        public bool? isDelisted { get; set; }

        public string DelistNote { get; set; }

        public DateTime? delisteddate { get; set; }

        public int? delistedBy { get; set; }

        public int? DelistedProviderPageId { get; set; }

        public string CompanyConsession { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public  ICollection<ProviderClaimBK> ProviderClaimBKs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public  ICollection<ProviderService> ProviderServices1 { get; set; }
    }
}
