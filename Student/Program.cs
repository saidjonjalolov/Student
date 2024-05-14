//----------------------------------------
// Great Code Team (c) All rights reserved
//---------------------------------------

using Student.Broker.Storeage;
using Student.Service;

StudentService studentService = new StudentService();
Console.Write("Id ni kiriting: ");
int id  = Convert.ToChar(Console.ReadLine());
studentService.DisplayStudent(id);