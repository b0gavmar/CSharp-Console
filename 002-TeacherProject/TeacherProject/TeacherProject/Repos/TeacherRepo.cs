using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeacherProject.Database;
using TeacherProject.Models;

namespace TeacherProject.Repos
{
    
    public class TeacherRepo : ITeacherRepo
    {

        public List<Teacher> OldestTeacher()
        {
            return TeacherDatabase.Teachers;
        }
    }
}
