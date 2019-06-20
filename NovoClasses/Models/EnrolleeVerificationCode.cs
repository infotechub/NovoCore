namespace NovoClasses.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    

    [Table("EnrolleeVerificationCode")]
    public class EnrolleeVerificationCode
    {
        public int Id { get; set; }

        public int? EnrolleeId { get; set; }

        [StringLength(255)]
        public string Status { get; set; }

        public string VerificationCode { get; set; }

        public DateTime? EncounterDate { get; set; }

        public DateTime? DateAuthenticated { get; set; }

        public DateTime? DateExpired { get; set; }

        public int? Channel { get; set; }

        public string RequestPhoneNumber { get; set; }

        public int? CreatedBy { get; set; }

        public int? VisitPurpose { get; set; }

        public int? ProviderId { get; set; }

        public string Note { get; set; }

        public Guid Guid { get; set; }

        public DateTime? CreatedOn { get; set; }

        public DateTime? UpdatedOn { get; set; }

        public bool? IsDeleted { get; set; }

        public int? SiteId { get; set; }

        public int? AuthChannel { get; set; }

        public bool? Pickedup { get; set; }

        public int? PickedUpById { get; set; }

        public bool? AttendedTo { get; set; }

        public DateTime? DateAttendedTo { get; set; }

        public string ServiceAccessed { get; set; }

        public bool? AuthorizationCodeGiven { get; set; }

        public string AuthorizationCode { get; set; }

        public int? AuthorizedByUserId { get; set; }

        public DateTime? DateAuthorized { get; set; }

        public string AgentNote { get; set; }

        public bool? PostSMSSent { get; set; }

        [StringLength(255)]
        public string visittype { get; set; }
    }
}
