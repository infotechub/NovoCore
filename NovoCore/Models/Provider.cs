using System;
using System.Collections.Generic;

namespace NovoCore.Models
{
    public class Provider
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string SubCode { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Phone2 { get; set; }
        public string Website { get; set; }
        public string Address { get; set; }
        public string Providergpscordinate { get; set; }
        public string Providerservices { get; set; }
        public string Providerplans { get; set; }
        public string CreatedBy { get; set; }
        public string AuthorizationStatus { get; set; }
        public string AuthorizationNote { get; set; }
        public string DisapprovalNote { get; set; }
        public string AuthorizedBy { get; set; }
        public string DisapprovedBy { get; set; }
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

        public int? SiteId { get; set; }
        public string ProviderTariffs { get; set; }
        public string Area { get; set; }
        public int? Provideraccount2Id { get; set; }
        public string PaymentEmail1 { get; set; }
        public string PaymentEmail2 { get; set; }
        public string Category { get; set; }
        public bool? IsDelisted { get; set; }
        public string DelistNote { get; set; }
        public DateTime? Delisteddate { get; set; }
        public string DelistedBy { get; set; }
        public int? DelistedProviderPageId { get; set; }
        public string CompanyConsession { get; set; }




        public ProviderAssignee ProviderAssignee { get; set; }  
        public ProviderRating ProviderRating { get; set; }
        public Lga Lga { get; set; }
        public State State { get; set; }
        public virtual ICollection<ProviderServices> ProviderServices { get; set; }
    }
}