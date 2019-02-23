using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ObuGrades.Models
{
    public class Grade
    {
        public int ID { get; set; }

        public IdentityUser Teacher { get; set; }

        public IdentityUser Student { get; set; }

        public string Description { get; set; }

        public string Code { get; set; }

        public DateTime DateTime { get; set; }
    }
}
