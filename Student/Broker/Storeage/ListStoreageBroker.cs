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
                FirstName = "Elmurod",
                LastName = "Salomov",
                Age = 27,
                Email = "Salomov@gmail.com"
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
            throw new NotImplementedException();
        }

        public bool CheckoutStudent(StudenT student)
        {
            throw new NotImplementedException();
        }
        public bool LetterCheckout(string firstName)
        {
            throw new NotImplementedException();
        }

        public Print PrintNameAndEmail(int id)
        {
            foreach (StudenT studentItem in this.students)
            {
                if (studentItem.Id == id)
                {
                    var studentInfo = new Print()
                    {
                        FirstName = studentItem.FirstName,
                        Email = studentItem.Email
                    };
                    return studentInfo;
                }
            }
            return new Print();
        }
    }
}
