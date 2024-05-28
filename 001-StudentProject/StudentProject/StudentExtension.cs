using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace StudentProject
{
    public static class StudentExtension
    {
        //static,static,this
        //az extension azert jo mert nem lesz benne a kod minden legenerált objektumban ==> jo
        public static bool IsYounger (this Student student, Student other)
        {
            return student.Age < other.Age;
        }
    }
}
