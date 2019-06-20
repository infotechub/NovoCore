using NovoClasses.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace NovoClasses.ViewModel
{
   public class EnrolleeProvider
    {
        public Enrollee Enrollee { get; set; }
        public Provider Provider { get; set; }

      
    }
}
