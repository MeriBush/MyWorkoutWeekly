using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkoutWeekly.Models
{
    public class WorkoutTypeCreate
    {
        [Required]
        [Display(Name ="Exericse Type")]
        public string Type { get; set; }
    }
}
