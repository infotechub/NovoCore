using System;

namespace NovoCore.Models
{
    public class Subsidiary
    {

        public int Id { get; set; }

        public string Subsidaryname { get; set; }
        public string Subsidaryprofile { get; set; }
        public int? CreatedBy { get; set; }
        public Guid Guid { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public bool? IsDeleted { get; set; }
        public string AddedBy { get; set; }

        public int? Companyid { get; set; }
        public Company Company { get; set; }
    }
}