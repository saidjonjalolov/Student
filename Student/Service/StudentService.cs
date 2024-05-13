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

        private List<StudenT> InvalidCheckoutByLetter()
        {
            throw new NotImplementedException();
        }

        private List<StudenT> ValidationCheckoutByLetter(char letter)
        {
            if (String.IsNullOrWhiteSpace(letter.ToString()))
            {
                this.loggingBroker.LogError("The reference is not valid.");
                return new List<StudenT>();
            }
            else
            {
                var studenInfo = this.storeageBroker.FindStudentByLetter(letter);
            }
        }

        public StudenT CheckoutByName(string firstName)
        {
            return firstName is null
                ? InvalidCheckoutByName()
                : ValidationAndCheckoutByName(firstName);
        }

        private StudenT InvalidCheckoutByName()
        {
            this.loggingBroker.LogError("The firstname is invalid.");
            return new StudenT();
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

        public Print DisplayStudent(int id)
        {
            return id is 0


        }

        public StudenT InsertStudent(StudenT student)
        {
            throw new NotImplementedException();
        }

        public bool Check(StudenT student)
        {
            throw new NotImplementedException();
        }
    }
}
