using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeacherProject
{
    public class Teacher
    {
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }

        public Teacher(string name, DateTime birthDate)
        {
            this.Name = name;
            this.BirthDate = birthDate;
        }

        public Teacher()
        {
            this.Name = "";
            this.BirthDate = DateTime.Now;
        }

        public override string ToString()
        {
            return $"{Name} ({BirthDate.ToString("yyyy/MM/dd")})";
        }
    }
}
