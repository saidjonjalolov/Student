//----------------------------------------
// Great Code Team (c) All rights reserved
//----------------------------------------

using Student.Model;

namespace Student.Broker.Storeage
{
    internal class ListStoreageBroker: IStoreageBroker
    {
        private List<StudenT> StudentsInfo { get; set; } = new List<StudenT>();

        List<StudenT> persons = new List<StudenT>()
        {

            new StudenT()
            {

                Id = 1,
                FirstName = "Saidjon",
                LastName = "Jalolov",
                Age = 14,
                Email = "saidjpn@gmail.com"
            },
            new StudenT()
            {
                Id = 2,
                FirstName = "Saordor",
                LastName = "Jovliyev",
                Age = 14,
                Email = "Sardor14@gmail.com"
            },
        };

        List<StudenT> people = new List<StudenT>()
        {
            new StudenT()
            {
                Id = 4,
                FirstName = "Bexruz",
                LastName = "Ergashev",
                Age = 32,
                Email = "Bexruz10@gmail.com"
            },
            new StudenT()
            {
                Id = 5,
                FirstName = "Ibirohim",
                LastName = "Amirov",
                Age = 13,
                Email = "amirovibirohm@gmail.com"
            },
            new StudenT()
            {
                Id = 6,
                FirstName = "Akbarjon",
                LastName = "Eshpulatov",
                Age = 14,
                Email = "akbarjon2010@gmail.com"
            }
        };

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public StudenT[] GetAllStudent()
        {
            throw new NotImplementedException();
        }

        public StudenT GetStudent(int id)
        {
            throw new NotImplementedException();
        }
    }
}
