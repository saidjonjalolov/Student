﻿//----------------------------------------
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

        public Print DisplayStudent(int id)
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

        public bool Check(StudenT student)
        {
            throw new NotImplementedException();
        }

        private Print ValidationAndDisplayStudent(int id)
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
                return new Print();
            }
        }

        private Print InvalidDisplayStudent()
        {
            this.loggingBroker.LogError("Invalid Id.");
            return new Print();
        }
        private StudenT ValidationAndInsertStudent(StudenT student)
        {
            if (student.Id is 0
                || String.IsNullOrWhiteSpace(student.FirstName)
                || String.IsNullOrWhiteSpace(student.LastName))
            {
                this.loggingBroker.LogError("Invalid student information.");
                return new StudenT();
            }
            else
            {
                var studentInformation = this.storeageBroker.AddStudent(student);
                if (studentInformation is null)
                {
                    this.loggingBroker.LogError("Not Added.");
                }
                else
                {
                    this.loggingBroker.LogInformation("Secssesfull.");
                }
                return studentInformation;
            }
        }

        private List<StudenT> ValidationCheckoutByLetter(char letter)
        {
            List<StudenT> studenInfo = this.storeageBroker.FindStudentByLetter(letter);
            foreach (var student in studenInfo)
            {
                if (student.FirstName.Contains(letter.ToString()))
                {
                    this.loggingBroker.LogInformation($"Id: {student.Id}\n" +
                            $"FirstName: {student.FirstName}\nLastName: {student.LastName}\n" +
                            $"Age: {student.Age}\nEmail: {student.Email}");
                    return studenInfo;
                }
                else
                {
                    if (!student.FirstName.Contains(letter.ToString()))
                    {
                        this.loggingBroker.LogError("The reference is not valid.");
                        return studenInfo;
                    }
                }
            }
            return new List<StudenT>();
        }
        private StudenT InsertStudentInvalid()
        {
            this.loggingBroker.LogError("Student info is null.");
            return new Student();
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
                if (studentInfo is not null)
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
