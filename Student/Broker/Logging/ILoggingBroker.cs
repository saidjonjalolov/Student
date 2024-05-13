//----------------------------------------
// Great Code Team (c) All rights reserved
//----------------------------------------

namespace Student.Broker.Logging
{
    internal interface ILoggingBroker
    {
        void LogInformation(string message);
        void LogError(string message);
    }
}
