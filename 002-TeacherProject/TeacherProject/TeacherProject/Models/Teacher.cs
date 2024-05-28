using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeacherProject.Models
{
    public class Teacher
    {
        public Teacher()
        {
            Name = "";
            BirthDate = DateTime.Now;
        }

        public string Name { get; set; }
        public DateTime BirthDate { get; set; }

        public Teacher(string name, DateTime birthDate)
        {
            Name = name;
            BirthDate = birthDate;
        }

        public override string ToString()
        {
            return $"{Name} ({BirthDate.ToString("yyyy/MM/dd")})";
        }

        
    }
}
