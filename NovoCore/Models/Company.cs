﻿using System;
using System.Collections.Generic;

namespace NovoCore.Models
{
    public class Company
    {
        public Company()
        {
            CompanyBranch = new HashSet<CompanyBranch>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public long? Parentid { get; set; }
        public string Email { get; set; }
        public string Website { get; set; }
        public string PhoneNumber { get; set; }
        public string Description { get; set; }
        public string CreatedBy { get; set; }
        public int? Logoid { get; set; }
        public int? SubscriptionStatus { get; set; }
        public string Plans { get; set; }
        public int? AuthorizationStatus { get; set; }
        public string AuthorizationNote { get; set; }
        public string DisapprovalNote { get; set; }
        public int? AuthorizedBy { get; set; }
        public int? DisapprovedBy { get; set; }
        public DateTime? AuthorizedDate { get; set; }
        public DateTime? DisapprovalDate { get; set; }
        public string DeletionNote { get; set; }
        public Guid Guid { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public bool? IsDeleted { get; set; }
        public bool? Status { get; set; }
        public string LogoLink { get; set; }
        public string RegCode { get; set; }
        public int? RegAgeLimit { get; set; }
        public bool? IsRenewal { get; set; }
        public string AddedBy { get; set; }



        
        public Subsidiary Subsidiary { get; set; }
        public State State { get; set; }
        public virtual ICollection<CompanyBranch> CompanyBranch { get; set; }

    }
}