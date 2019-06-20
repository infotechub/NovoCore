namespace NovoClasses.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    

    [Table("DownloadFile")]
    public class DownloadFile
    {
        public int Id { get; set; }

        public string fileName { get; set; }

        public string filelink { get; set; }

        public int? filestaus { get; set; }

        public int? createdby { get; set; }

        public int? downloadedBy { get; set; }

        public int? downloadCount { get; set; }

        public Guid Guid { get; set; }

        public DateTime? CreatedOn { get; set; }

        public DateTime? UpdatedOn { get; set; }

        public bool? IsDeleted { get; set; }

        public int? SiteId { get; set; }

        public int? DownloadFilesPageId { get; set; }
    }
}
