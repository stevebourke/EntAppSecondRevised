﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace EntAppSecond.Pages.Models
{
    public class Student
    {

        [Required]
        public string StudentID { get; set; } = "";

        [Required]
        public string FirstName { get; set; } = "";

        [Required]
        public string LastName { get; set; } = "";

        public Student()
        {

        }

    }
}
