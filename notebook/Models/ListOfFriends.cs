using DocuSign.eSign.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace notebook.Models
{
    public class ListOfFriends
    {

        public bool IsDirty { get; set; }

        public ListOfFriends() 
        { 

        }

        public List<Person> Persons { get; set; }

        public void GenTestData(int n)
        {
            Persons = new List<Person>();
            for (int i = 0; i < n; i++)
            {
                var person = new Person
                {
                    FullName = "FullName" + i,
                    DateOfBirth = "DateOfBirth" + i,
                    Address = "Address" + i,
                    PhoneNumber = "PhoneNumber" + i,
                    PlaceOfWorkOrStudy = "PlaceOfWorkOrStudy" + i,
                    Position = "Position" + i,
                    Acquaintance = "Acquaintance" + i
                };
                Persons.Add(person);
            }
            IsDirty = true;
        }

        internal List<Person> SearchFriends(string line)
        {
            List<Person> result = new List<Person>();
            var text = line.ToLower();
            foreach (Person person in Persons)
            {
                if (person.FullName.ToLower().IndexOf(text) > -1 || person.PlaceOfWorkOrStudy.ToLower().IndexOf(text) > -1 || person.Position.ToLower().IndexOf(text) > -1 || person.Acquaintance.ToLower().IndexOf(text) > -1)
                {
                    result.Add(person);
                }
            }
            return result;
        }
    }
}
