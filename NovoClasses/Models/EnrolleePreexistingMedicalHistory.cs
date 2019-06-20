namespace NovoClasses.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    

    [Table("EnrolleePreexistingMedicalHistory")]
    public class EnrolleePreexistingMedicalHistory
    {
        public int Id { get; set; }

        public int? Pemhid { get; set; }

        public int? Enrolleeid { get; set; }

        public bool? Answeryesno { get; set; }

        public string Answerstring { get; set; }

        public bool? Status { get; set; }

        public Guid Guid { get; set; }

        public DateTime? CreatedOn { get; set; }

        public DateTime? UpdatedOn { get; set; }

        public bool? IsDeleted { get; set; }

        public int? SiteId { get; set; }
    }
}
