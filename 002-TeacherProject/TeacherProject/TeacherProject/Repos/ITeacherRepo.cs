using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeacherProject.Models;

namespace TeacherProject.Repos
{
    public interface ITeacherRepo
    {
        public List<Teacher> OldestTeacher();
    }
}
