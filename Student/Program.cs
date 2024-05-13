//----------------------------------------
// Great Code Team (c) All rights reserved
//---------------------------------------


List<Student> students = new List<Student>()
{
    new Student()
    {
        Id = 1,
        FirstName = "Elmurod",
        LastName = "Salomov",
        Age = 27,
        Email = "Salomov@gmail.com"
    },
    new Student()
    {
        Id = 2,
        FirstName = "Baxtiyor",
        LastName = "Ruziyev",
        Age = 27,
        Email = "Ruziyev@gmail.com"
    },
    new Student()
    {
        Id = 3,
        FirstName = "Asilbek",
        LastName = "Abduvohidov",
        Age = 27,
        Email = "Abduvohidov@gmail.com"
    },
    new Student()
    {
        Id = 4,
        FirstName = "Donyor",
        LastName = "Homidov",
        Age = 27,
        Email = "Homidov@gmail.com"
    },
    new Student()
    {
        Id = 5,
        FirstName = "Shoxrux",
        LastName = "Abduvaliyev",
        Age = 27,
        Email = "Abduvaliyev@gmail.com"
    }
};

Console.WriteLine("1. Student First Name and Emails");
Console.WriteLine("2. Students with 'a' in First Name");
Console.WriteLine("3. Look for the student in the database");
Console.WriteLine("4. Adding student information to the database");
Console.Write("Enter command: ");
string command = Console.ReadLine();

if (command.Contains("1") is true)
{
    students.ForEach(a => Console.WriteLine($"{a.FirstName}\n{a.Email}"));
}

if (command.Contains("2") is true)
{
    Console.WriteLine("Students with 'a' in First Name:");
    foreach (Student student in students)
    {
        if (student.FirstName.ToLower().Contains("a"))
        {
            Console.WriteLine(student.FirstName);
        }
    }
}

if (command.Contains("3") is true)
{
    Console.WriteLine("Enter student first name: ");
    string name = Console.ReadLine();
    Student student1 = students.FirstOrDefault(s => s.FirstName.ToLower() == name.ToLower());

    if (student1 != null)
    {
        Console.WriteLine($"Student foun - Id: {student1.Id}, First Name: {student1.FirstName}, Last Name: {student1.LastName}, Age: {student1.Age}, Email: {student1.Email}");
    }
    else
    {
        Console.WriteLine("Not Found");
    }
}

if (command.Contains("4") is true)
{
    Console.Write("First Name: ");
    string newFirstName = Console.ReadLine();
    Console.Write("Last Name: ");
    string newLastName = Console.ReadLine();
    Console.Write("Age: ");
    int newAge = Convert.ToInt32(Console.ReadLine());
    Console.Write("Email: ");
    string newEmail = Console.ReadLine();

    Student student2 = new Student()
    {
        FirstName = newFirstName,
        LastName = newLastName,
        Age = newAge,
        Email = newEmail
    };

    bool studentExists = false;
    foreach (var student in students)
    {
        if (student.FirstName.ToLower().Contains(newFirstName.ToLower()) is true)
        {
            studentExists = true;
            break;
        }
    }
    if (studentExists)
    {
        Console.WriteLine("Not Added");
    }
    else
    {
        students.Add(student2);
        Console.WriteLine("New student added successfully");
    }