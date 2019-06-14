using System;
using System.ComponentModel.DataAnnotations;

namespace NovoCore.Models
{
    public class EnrolleePassport
    {
        [Key]
        public int Id { get; set; }
        public byte[] Imgraw { get; set; }
        public string Name { get; set; }
        public int? Enrolleeid { get; set; }
        public string Enrolleepolicyno { get; set; }
        public Guid Guid { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public bool? IsDeleted { get; set; }
        public int? SiteId { get; set; }


        public Enrollee Enrollee { get; set; }
    }
}