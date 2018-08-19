﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkoutWeekly.Data
{
    public class WorkoutType
    {
        [Key]
        public int WorkoutTypeID { get; set; }

        [Required]
        public string Type { get; set; }
    }
}
