using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeacherProject.Models
{
    public static class TeacherExtension
    {
        public static bool WhoWasBornEarlier(this Teacher teacher1, Teacher teacher2)
        {
            return teacher1.BirthDate < teacher2.BirthDate;
        }
    }
}
