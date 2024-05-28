using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeacherProject.Database;
using TeacherProject.Models;

namespace TeacherProject.Repos
{
    
    public class TeacherRepo
    {

        List<Teacher> teachers = new List<Teacher>();

        public TeacherRepo()
        {
            teachers = new List<Teacher>();
        }

        public TeacherRepo(List<Teacher> teacherList)
        {
            teachers = teacherList;
        }

        public List<Teacher> FindAll()
        {
            return teachers;
        }

        public void AddTeacher(Teacher teacher1)
        {
            teachers.Add(teacher1);
        }

        public string OldestTeacher()
        {
            if (!FindAll().Any())
            {
                return string.Empty;
            }
            else
            {
                DateTime minDate = FindAll().Select(teacher => teacher.BirthDate).Min();
                Teacher? teacher = FindAll().Where(teacher => teacher.BirthDate == minDate).FirstOrDefault();
                return teacher is null ? string.Empty : teacher.Name;
            }
        }
    }
}
