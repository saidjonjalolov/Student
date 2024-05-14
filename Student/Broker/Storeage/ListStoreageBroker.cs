//----------------------------------------
// Great Code Team (c) All rights reserved
//----------------------------------------

using Student.Model;

namespace Student.Broker.Storeage
{
    internal class ListStoreageBroker: IStoreageBroker
    {
        private List<StudenT> students = new List<StudenT>();
        public ListStoreageBroker()
        {
            this.students.Add(new StudenT()
            {
                Id = 1,
                FirstName = "Saidjon",
                LastName = "Jalolov",
                Age = 14,
                Email = "Saidjon@gmail.com"
            });
            this.students.Add(new StudenT()
            {
                Id = 2,
                FirstName = "Baxtiyor",
                LastName = "Ruziyev",
                Age = 27,
                Email = "Ruziyev@gmail.com"
            });
            this.students.Add(new StudenT()
            {
                Id = 3,
                FirstName = "Asilbek",
                LastName = "Abduvohidov",
                Age = 27,
                Email = "Abduvohidov@gmail.com"
            });
            this.students.Add(new StudenT()
            {
                Id = 4,
                FirstName = "Donyor",
                LastName = "Homidov",
                Age = 27,
                Email = "Homidov@gmail.com"
            });
            this.students.Add(new StudenT()
            {
                Id = 5,
                FirstName = "Shoxrux",
                LastName = "Abduvaliyev",
                Age = 27,
                Email = "Abduvaliyev@gmail.com"
            });
        }

        public StudenT AddStudent(StudenT student)
        {
            foreach (StudenT studentItem in this.students)
            {
                if (studentItem.Id == student.Id
                    && studentItem.Email == student.Email)
                {
                    return new StudenT();
                }
            }

            this.students.Add(student);
            return student;
        }

        public StudenT FindStudentByName(string firstName)
        {
            foreach (StudenT studentItem in this.students)
            {
                if (studentItem.FirstName == firstName)
                {
                    return studentItem;
                }
            }
            return new StudenT();
        }

        public List<StudenT> FindStudentByLetter(char letter)
        {
            List<StudenT> studentNew = new List<StudenT>();
            foreach (StudenT studentItem in this.students)
            {
                if (studentItem.FirstName.Contains(letter))
                {
                    studentNew.Add(studentItem);
                }
            }
            return studentNew;
        }

        public DemoStudent PrintNameAndEmail(int id)
        {
            foreach (StudenT studentItem in this.students)
            {
                if (studentItem.Id == id)
                {
                    var studentInfo = new DemoStudent()
                    {
                        FirstName = studentItem.FirstName,
                        Email = studentItem.Email
                    };
                    return studentInfo;
                }
            }
            return new DemoStudent();
        }
    }
}
