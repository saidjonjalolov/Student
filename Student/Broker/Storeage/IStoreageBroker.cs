//----------------------------------------
// Great Code Team (c) All rights reserved
//----------------------------------------

using Student.Model;

namespace Student.Broker.Storeage
{
    internal interface IStoreageBroker
    {
        bool Delete(int id);
        StudenT[] GetAllStudent();
        StudenT GetStudent(int id);
    }
}
