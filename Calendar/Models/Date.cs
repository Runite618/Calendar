using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Calendar.Models
{
    public class Date
    {
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }

        [Key]
        public string Event { get; set; }
    }
}