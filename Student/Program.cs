//----------------------------------------
// Great Code Team (c) All rights reserved
//---------------------------------------

using Student.Broker.Storeage;
using Student.Service;

StudentService studentService = new StudentService();
Console.WriteLine("Ismni kiriting");
char letter  = Convert.ToChar(Console.ReadLine());
studentService.CheckoutByLetter(letter);