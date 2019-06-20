namespace NovoClasses.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
   // using NovoCore.Models;
    

    [Table("UserProfileData")]
    public class UserProfileData
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string ProfileInfoType { get; set; }

        public Guid Guid { get; set; }

        public DateTime? CreatedOn { get; set; }

        public DateTime? UpdatedOn { get; set; }

        public bool? IsDeleted { get; set; }

        public int? UserId { get; set; }

        public string Bio { get; set; }

      //  public  ApplicationUser ApplicationUser { get; set; }
    }
}
