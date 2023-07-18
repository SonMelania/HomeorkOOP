using temaweek4;

/*Book carteNr1 = new Book("mumu", " jiji", 2023);

//Console.WriteLine($"{carteNr1.Title} {carteNr1.Author}, {carteNr1.Year}");


carteNr1.SetTitle("gugu");
carteNr1.SetAuthor("koko");
carteNr1.SetYear(1982);
//Console.WriteLine($"{carteNr1.Title} {carteNr1.Author}, {carteNr1.Year}");
Console.WriteLine(carteNr1.GetYaer());
Console.WriteLine(carteNr1.GetAuthor());
Console.WriteLine(carteNr1.GetTitle());
*/

/*
Product produs1 = new Product("rosi ", "50RON ", 20);


Console.WriteLine($"{produs1.Name}, {produs1.Price},{produs1.Quantity} ");

produs1.StetName("paine");
produs1.SetSetPrice("10ron");
produs1.SetQuantity(10);

Console.WriteLine(produs1.GetName());
Console.WriteLine(produs1.GetPrice());
Console.WriteLine(produs1.GetQuantity());*/
/*
Animal animal1= new Animal("Max","caine", "Lup", 2, "negru", 17, true);


animal1.SetName("GuGu");
animal1.SetAge(10);
animal1.SetBreed("Doberman");
animal1.SetColor("alb");
animal1.SetSpecies("peste");
animal1.SetIsSpayedOrNeutered(false);


Console.WriteLine($"{animal1.GetName()}, {animal1.GetColor()}, {animal1.GetBreed()}, {animal1.GetIsSpayedOrNeutered()}");*/


/*Calculator calcule = new Calculator();

Console.WriteLine( calcule.Add(2,4) );
Console.WriteLine( calcule.Square(5) );
Console.WriteLine( calcule.Power(7,3) );*/

/*University univesitatea1 = new University("My University");
Faculty facultatea1 = new Faculty("Petru", "Maior", 12587,new List<string> { "matematica", "romana" });
Faculty facultatea2 = new Faculty("George", "Popescu", 12587,new List<string> { "chimie", "istorie" });
Student student1= new Student("Jon", "Doe", 123456, 3.8);
Student student2 = new Student("Jane", "Smith", 6789321, 3.6);

univesitatea1.AddStudent(student1);
univesitatea1.AddStudent(student2);
univesitatea1.AddFaculty(facultatea1);
univesitatea1.AddFaculty(facultatea2);

Console.WriteLine(univesitatea1.GetStudentCount());
Console.WriteLine(univesitatea1.GetFacultyCount());*/

College college1 = new College()
{
    Name="Petru Maior",
    city="Tg MUres"
};

//college.Name = "mimi";
//college.city = "lolo";

Console.WriteLine(college1.Name);


Students student1 = new Students("Sonica",new DateTime(2016,2,15), new DateTime(2024,5,28), college1, new DateTime(1982,11,11));
Students student2 = new Students("Codarea", new DateTime(2019, 2, 15), new DateTime(2023, 5, 28), college1, new DateTime(1980, 11, 11));

//student1.Print();
Profesor prof1 = new Profesor("Stan Ioan", "MEdicina", "Chimie", new List<Students> { student1, student2 });

prof1.Display();












