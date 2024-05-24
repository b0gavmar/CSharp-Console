using StudentProject;

//Student adel = new Student("Kis Adél", 17);

//de ehhez kell üres konstruktor is, amit alapbol jo ha odarakunk mert miert ne
Student adel = new Student
{
    Name = "Kis Adél",
    Age = 17,
};

Student jani = new Student("Kis János", 17);

//4.a
Console.WriteLine(adel);

//5
if (adel.EqualTo(jani))
{
    Console.WriteLine("Megegyezik a nevük");
}
else
{
    Console.WriteLine("Nem egyezik meg a nevük");
}

//6
if (adel.IsYounger(jani))
{
    Console.WriteLine("Adél fiatalabb Jánosnál");
}
else if (jani.IsYounger(adel))
{
    Console.WriteLine("János fiatalabb Adélnál");
}
else
{
    Console.WriteLine("EgykorúaK");
}