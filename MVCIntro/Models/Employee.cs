﻿using System.ComponentModel.DataAnnotations;

namespace MVCIntro.Models
{
    public class Employee
    {
        
        public int Id { get; set; }
        [StringLength(20)]
        public string Name { get; set; }
        public int Salary { get; set; }

        public string Department { get; set; }
    }
}
