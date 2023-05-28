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
            Persons = new List<Person>();
        }

        public List<Person> Persons { get; set; }

        internal List<Person> SearchFriends(string line)
        {
            List<Person> result = new List<Person>();
            var text = line.ToLower();
            foreach (Person person in Persons)
            {
                if (person.LastName.ToLower().IndexOf(text) > -1 ||
                person.Name.ToLower().IndexOf(text) > -1 ||
                person.Surname.ToLower().IndexOf(text) > -1 ||
                person.PlaceOfWorkOrStudy.ToLower().IndexOf(text) > -1 || 
                person.Position.ToLower().IndexOf(text) > -1 || 
                person.Acquaintance.ToLower().IndexOf(text) > -1)
                {
                    result.Add(person);
                }
            }
            return result;
        }
    }
}
