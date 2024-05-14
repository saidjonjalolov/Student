//----------------------------------------
// Great Code Team (c) All rights reserved
//---------------------------------------

using Student.Broker.Storeage;
using Student.Model;
using Student.Service;

StudentService studentService = new StudentService();
bool isContinue = true;
do
{
    Console.WriteLine("1. Display Student");
    Console.WriteLine("2. Checkout by letter");
    Console.WriteLine("3. Checkout by name");
    Console.WriteLine("4. Insert Student");
    Console.Write("Enter command: ");
    string command = Console.ReadLine();
    if (command.Contains("1") is true)
    {
        Console.Write("Enter the id: ");
        int id = Convert.ToInt32(Console.ReadLine());
        studentService.DisplayStudent(id);
    }
    if (command.Contains("2") is true)
    {
        Console.Write("Enter the charector: ");
        char letter = Convert.ToChar(Console.ReadLine());
        studentService.CheckoutByLetter(letter);
    }
    if (command.Contains("3") is true)
    {
        Console.Write("Enter the first name: ");
        string studentName = Console.ReadLine();
        studentService.CheckoutByName(studentName);
    }
    if (command.Contains("4") is true)
    {
        StudenT student = new StudenT();
        Console.Write("Enter the id: ");
        student.Id = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the first name: ");
        student.FirstName = Console.ReadLine();
        Console.Write("Enter the last name: ");
        student.LastName = Console.ReadLine();
        Console.Write("Enter the age: ");
        student.Age = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the email: ");
        student.Email = Console.ReadLine();
        studentService.InsertStudent(student);
    }
    Console.Write("Is Continue: ");
    string isCommand = Console.ReadLine();
    if (isCommand.Contains("no") is true)
    {
        isContinue = false;
    }
    else if (isCommand.Contains("yes") is true)
    {
        isContinue = true;
        Console.Clear();
    }
    else
    {
        isContinue = false;
        Console.WriteLine("The command was issued incorrectly.");
    }
} while (isContinue is true);