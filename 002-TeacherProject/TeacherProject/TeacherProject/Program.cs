using TeacherProject.Models;
using TeacherProject.Repos;

Teacher marci = new Teacher
{
    Name = "Matek Marcell",
    BirthDate = new DateTime(1981, 10, 25),
};

Teacher eva = new Teacher("Kiss Éva", new DateTime(1981,11,25));

TeacherRepo teacherRepo = new();
teacherRepo.AddTeacher(marci);
teacherRepo.AddTeacher(eva);


Console.WriteLine(marci);

if (marci.WhoWasBornEarlier(eva))
{
    Console.WriteLine($"{marci.Name} előbb született, mint {eva.Name}");
}
else if (!marci.WhoWasBornEarlier(eva))
{
    Console.WriteLine($"{eva.Name} előbb született, mint {marci.Name}");
}
else
{
    Console.WriteLine("A két tanár egy napon született!");
}