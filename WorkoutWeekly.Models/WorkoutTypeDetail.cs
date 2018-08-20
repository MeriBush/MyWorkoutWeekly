using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkoutWeekly.Models
{
    public class WorkoutTypeDetail
    {
        public int WorkoutTypeId { get; set; }
        public string Type { get; set; }

        [Display(Name ="Created")]
        public DateTimeOffset CreatedUtc { get; set; }

        [Display(Name ="Modified")]
        public DateTimeOffset? ModifiedUtc { get; set; }
        public override string ToString() => $"[{WorkoutTypeId}] {Type}";
    }
}
