using System;

namespace NovoCore.Models
{
    public class Staff
    {

        public string CompanyId { get; set; }
        public int CompanySubsidiary { get; set; }
        public string StaffFullname { get; set; }
        public bool HasProfile { get; set; }
        public bool IsExpunged { get; set; }
        public int Profileid { get; set; }
        public int Createdby { get; set; }
        public string StaffId { get; set; }
        public int NewStaffId { get; set; }

        public DateTime? stafflinkDate { get; set; }

        public int stafflinkUSer { get; set; }

        public int StaffJobId { get; set; }


       // public int Planid { get; set; }
        //public Plan Plan { get; set; }
    }
}