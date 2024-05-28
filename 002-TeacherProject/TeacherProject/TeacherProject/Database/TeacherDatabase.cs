using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeacherProject.Models;

namespace TeacherProject.Database
{
    public static class TeacherDatabase
    {
        public static List<Teacher> Teachers = new()
        {
            new Teacher
            {
                Name ="Kis József",
                BirthDate = new DateTime(2000,05,28),
            },
            new Teacher
            {
                Name ="Kis Béla",
                BirthDate = new DateTime(1987,06,27),
            },
            new Teacher
            {
                Name ="Nagy Ferenc",
                BirthDate = new DateTime(1999,10,06),
            },
            new Teacher
            {
                Name ="Hegyi János",
                BirthDate = new DateTime(1988,09,08),
            },
            new Teacher
            {
                Name ="Kis József",
                BirthDate = new DateTime(1980,09,28),
            },
        };
    }
}
