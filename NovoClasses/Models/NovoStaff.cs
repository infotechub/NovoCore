namespace NovoClasses.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    

    [Table("NovoStaff")]
    public class NovoStaff
    {
        public int Id { get; set; }

        public string Staff_Name { get; set; }

        public string Staff_No { get; set; }

        public string Role { get; set; }

        public string Grade { get; set; }

        public string Job_Desc { get; set; }

        public DateTime? DOB { get; set; }

        public int? LineManager { get; set; }

        public string Staff_Email { get; set; }

        public Guid Guid { get; set; }

        public DateTime? CreatedOn { get; set; }

        public DateTime? UpdatedOn { get; set; }

        public bool? IsDeleted { get; set; }

        public int? SiteId { get; set; }
    }
}
