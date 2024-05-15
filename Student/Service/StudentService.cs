//----------------------------------------
// Great Code Team (c) All rights reserved
//----------------------------------------

using Student.Broker.Logging;
using Student.Broker.Storeage;
using Student.Model;

namespace Student.Service
{
    internal class StudentService: IStudentService
    {
        private readonly ILoggingBroker loggingBroker;
        private readonly IStoreageBroker storeageBroker;
        public StudentService()
        {
            this.loggingBroker = new LoggingBroker();
            this.storeageBroker = new ListStoreageBroker();
        }

        public List<StudenT> CheckoutByLetter(char letter)
        {
            return letter.ToString() is null
                ? InvalidCheckoutByLetter()
                : ValidationCheckoutByLetter(letter);
        }
        
        public StudenT CheckoutByName(string firstName)
        {
            return firstName is null
                ? InvalidCheckoutByName()
                : ValidationAndCheckoutByName(firstName);
        }

        public DemoStudent DisplayStudent(int id)
        {
            return id is 0
             ? InvalidDisplayStudent()
             : ValidationAndDisplayStudent(id);
        }

        public StudenT InsertStudent(StudenT student)
        {
            return student is null
             ? InsertStudentInvalid()
             : ValidationAndInsertStudent(student);
        }

        private DemoStudent ValidationAndDisplayStudent(int id)
        {
            var studentInfo = this.storeageBroker.PrintNameAndEmail(id);
            if (studentInfo.FirstName is not null)
            {
                this.loggingBroker.LogInformation($"FirstName: {studentInfo.FirstName}\n" +
                    $"Email: {studentInfo.Email}");
                return studentInfo;
            }
            else
            {
                this.loggingBroker.LogError("No information found.");
                return new DemoStudent();
            }
        }

        private DemoStudent InvalidDisplayStudent()
        {
            this.loggingBroker.LogError("Invalid Id.");
            return new DemoStudent();
        }
        
        private StudenT ValidationAndInsertStudent(StudenT student)
        {
            if(student.Id is 0
                || String.IsNullOrWhiteSpace(student.FirstName)
                || String.IsNullOrWhiteSpace(student.LastName)
                || student.Age is 0
                || String.IsNullOrWhiteSpace(student.Email))
            {
                this.loggingBroker.LogError("Invalid student information.");
                return new StudenT();
            }
            else
            {
                var studentInformation = this.storeageBroker.AddStudent(student);
                if(studentInformation.Email is not null)
                {
                    this.loggingBroker.LogInformation("Succssesfull.");
                }
                else
                {
                    this.loggingBroker.LogError("Not Added.");
                }
                return studentInformation;
            }
        }

        private List<StudenT> ValidationCheckoutByLetter(char letter)
        {
                      List<StudenT> studenInfo = this.storeageBroker.FindStudentByLetter(letter);
            if(studenInfo.Count is not 0)
            {
                foreach (var student in studenInfo)
                {
                    this.loggingBroker.LogInformation($"Id: {student.Id}\n" +
                            $"FirstName: {student.FirstName}\nLastName: {student.LastName}\n" +
                            $"Age: {student.Age}\nEmail: {student.Email}");
                }
            }

            else
            {
                this.loggingBroker.LogError("The user for the entered letter does not exist.");
            }
            return studenInfo;
        }
        
        private StudenT InsertStudentInvalid()
        {
            this.loggingBroker.LogError("Student info is null.");
            return new StudenT();
        }

        private StudenT InvalidCheckoutByName()
        {
            this.loggingBroker.LogError("The firstname is invalid.");
            return new StudenT();
        }

        private List<StudenT> InvalidCheckoutByLetter()
        {
            this.loggingBroker.LogError("Not Found.");
            return new List<StudenT>();
        }

        private StudenT ValidationAndCheckoutByName(string firstName)
        {
            if (String.IsNullOrWhiteSpace(firstName))
            {
                this.loggingBroker.LogError("The information is not fully formed.");
                return new StudenT();
            }
            else
            {
                var studentInfo = this.storeageBroker.FindStudentByName(firstName);
                if (studentInfo.Email is not null)
                {
                    this.loggingBroker.LogInformation($"Reference found.\nId: {studentInfo.Id}\n" +
                        $"FirstName: {studentInfo.FirstName}\nLastName: {studentInfo.LastName}\n" +
                        $"Age: {studentInfo.Age}\nEmail: {studentInfo.Email}");
                }
                else
                {
                    this.loggingBroker.LogError("Not Found.");
                }

                return studentInfo;
            }
        }
    }
}
