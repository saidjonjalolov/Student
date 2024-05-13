//----------------------------------------
// Great Code Team (c) All rights reserved
//----------------------------------------

using Student.Broker.Logging;
using Student.Broker.Storeage;
using Student.Model;


namespace Student.Service
{
    internal class StudentService
    {
        private readonly ILoggingBroker loggingBroker;
        private readonly IStoreageBroker storeageBroker;
        public StudentService()
        {
            this.loggingBroker = new LoggingBroker();
            this.storeageBroker = new ListStoreageBroker();
        }

        public bool Check(Student student)
        {
            throw new NotImplementedException();
        }
    }
}
