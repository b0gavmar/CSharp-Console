using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace StudentProject
{
    public class Student
    {
        public Student(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public Student()
        {
            Name = "";
            Age=0;
        }

        public string Name { get; set; }
        public int Age { get; set; }
        
        public  bool EqualTo(Student other)
        {
            return this.Name == other.Name && this.Age == other.Age;
        }

        public override string ToString()
        {
            return $"{Name} ({Age} éves)";
        }
    }
}
