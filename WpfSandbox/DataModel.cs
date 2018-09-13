using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfSandbox
{
    public class DataModel
    {
        private List<Person> people;

        public DataModel()
        {
            this.people = new List<Person>();

            this.people.Add(new Person() {
                ID = 1,
                FirstName = "Bart",
                LastName = "Simpson",
                DateOfBirth = new DateTime(1990, 1, 2) });

            this.people.Add(new Person() {
                ID = 2,
                FirstName = "Lisa",
                LastName = "Simpson",
                DateOfBirth = new DateTime(1994, 3, 22)
            });

            this.people.Add(new Person() {
                ID = 3,
                FirstName = "Maggie",
                LastName = "Simpson",
                DateOfBirth = new DateTime(1998, 4, 5)
            });
        }

        public List<Person> People
        {
            get
            {
                return this.people;
            }
        }
    }
}
