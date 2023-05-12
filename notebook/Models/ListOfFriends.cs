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
        public ListOfFriends() 
        { 

        }
        public List<Person> Persons { get; set; }

        public void List()
        {
            Persons = new List<Person>();
            //for (int i = 0; i < n; i++)
            //{
            //    var person = new Person
            //    {
            //        FullName = "FullName" + i,
            //        DateOfBirth = "DateOfBirth" + i,
            //        Address = "Address" + i,
            //        PhoneNumber = "PhoneNumber" + i,
            //        PlaceOfWorkOrStudy = "PlaceOfWorkOrStudy" + i,
            //        Position = "Position" + i,
            //        Acquaintance = "Acquaintance" + i
            //    };
            //    Persons.Add(person);
            //}
        }
    }
}
