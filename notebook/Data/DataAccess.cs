using notebook.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;
using notebook.Data;

namespace notebook.Data
{
    internal class DataAccess
    {
        const string DATA_PATH = "ListOfFriends.json";

        public static void Save (ListOfFriends listoffriends)
        {
            string jsonString = JsonSerializer.Serialize (listoffriends.Persons);
            File.WriteAllText(DATA_PATH, jsonString);
            listoffriends.IsDirty = false;
        }

        public static void Load(ListOfFriends listoffriends)
        {
            string jsonString = File.ReadAllText(DATA_PATH);
            var newPersons = JsonSerializer.Deserialize<List<Person>> (jsonString);
            listoffriends.Persons.Clear();
            listoffriends.Persons.AddRange(newPersons);
            listoffriends.IsDirty = false;
        }
    }
}