namespace NovoClasses.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    

    [Table("ClaimHistory")]
    public class ClaimHistory
    {
        public int Id { get; set; }

        public string PROVIDER { get; set; }

        public string LOCATION { get; set; }

        public string CLIENTNAME { get; set; }

        public string COMPANY { get; set; }

        public string POLICYNUMBER { get; set; }

        public string HEALTHPLAN { get; set; }

        public DateTime? ENCOUNTERDATE { get; set; }

        public DateTime? DATERECEIVED { get; set; }

        public string DIAGNOSIS { get; set; }

        public string CLASS { get; set; }

        public decimal? AMOUNTSUBMITTED { get; set; }

        public decimal? AMOUNTPROCESSED { get; set; }

        public string TREATMENT { get; set; }

        public Guid Guid { get; set; }

        public DateTime? CreatedOn { get; set; }

        public DateTime? UpdatedOn { get; set; }

        public bool? IsDeleted { get; set; }

        public int? SiteId { get; set; }

        public int? PROVIDERID { get; set; }

        public int? SerialNo { get; set; }
    }
}
