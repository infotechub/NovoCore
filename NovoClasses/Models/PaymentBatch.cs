namespace NovoClasses.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    

    [Table("PaymentBatch")]
    public class PaymentBatch
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PaymentBatch()
        {
            ClaimBatches = new HashSet<ClaimBatch>();
        }

        public int Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public string Note { get; set; }

        [StringLength(255)]
        public string status { get; set; }

        public DateTime? datepaymentstarted { get; set; }

        public DateTime? datepaymentcompleted { get; set; }

        public DateTime? terminationdate { get; set; }

        public int? paidby { get; set; }

        public int? createdBy { get; set; }

        public Guid Guid { get; set; }

        public DateTime? CreatedOn { get; set; }

        public DateTime? UpdatedOn { get; set; }

        public bool? IsDeleted { get; set; }

        public int? SiteId { get; set; }

        public int? terminatedby { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public  ICollection<ClaimBatch> ClaimBatches { get; set; }
    }
}
