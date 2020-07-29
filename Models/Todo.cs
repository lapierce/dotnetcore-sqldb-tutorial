using System.Runtime.CompilerServices;
using System;
using System.ComponentModel.DataAnnotations;

namespace DotNetCoreSqlDb.Models
{
    public class Todo
    {
        public int ID { get; set; }
        public string Description { get; set; }
        [Display(Name = "Priority Due")] 
        public ePriority Priority { get; set; }

  
        public bool Started { get; set; }


        [Display(Name = "Created Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime CreatedDate { get; set; }
    }
     public enum ePriority
     { High, 
     Medium,
     Low}
}

