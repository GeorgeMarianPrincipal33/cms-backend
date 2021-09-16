using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CMS.Models
{
    public class Employee
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public string Email { get; set; }

        public int Gender { get; set; }

        [DataType(DataType.Date)]
        public DateTime Birthdate { get; set; }

        public string ProfileImage { get; set; }

    }
}
