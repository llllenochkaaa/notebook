using notebook.Models;
using System;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace notebook
{
    public class Validator
    {
        public static bool ValidateLastName(string lastName)
        {
            return !string.IsNullOrWhiteSpace(lastName) && lastName.Length <= 50 && !lastName.Any(char.IsDigit);
        }

        public static bool ValidateName(string name)
        {
            return !string.IsNullOrWhiteSpace(name) && name.Length <= 50 && !name.Any(char.IsDigit);
        }

        public static bool ValidateSurname(string surname)
        {
            return !string.IsNullOrWhiteSpace(surname) && surname.Length <= 50 && !surname.Any(char.IsDigit);
        }

        public static bool ValidatePlaceOfWorkOrStudy(string placeOfWorkOrStudy)
        {
            return !string.IsNullOrWhiteSpace(placeOfWorkOrStudy) && placeOfWorkOrStudy.Length <= 100;
        }

        public static bool ValidatePosition(string position)
        {
            return !string.IsNullOrWhiteSpace(position) && position.Length <= 100;
        }

        public static bool ValidateAcquaintance(string acquaintance)
        {
            return !string.IsNullOrWhiteSpace(acquaintance) && acquaintance.Length <= 100;
        }

        public static bool ValidateAddress(string address)
        {
            return !string.IsNullOrWhiteSpace(address) && address.Length <= 100;
        }

        public static bool ValidateDateOfBirth(string dateOfBirthString)
        {
            string[] formats = { "dd/MM/yy", "dd/MM/yyyy" };
            DateTime dateOfBirth;

            if (DateTime.TryParseExact(dateOfBirthString, formats, CultureInfo.InvariantCulture, DateTimeStyles.None, out dateOfBirth))
            {
                DateTime currentDate = DateTime.Today;
                DateTime minimumDate = new DateTime(1900, 1, 1);

                if (dateOfBirth <= currentDate && dateOfBirth >= minimumDate)
                {
                    return true;
                }
            }

            return false;
        }

        public static bool ValidatePhoneNumber(string phoneNumber)
        {
            Regex regex = new Regex(@"^\+380\d{9}$");
            return regex.IsMatch(phoneNumber);
        }

        public static bool ValidateNotEmpty(string fieldValue)
        {
            return !string.IsNullOrEmpty(fieldValue) && fieldValue.Length > 2;
        }

        public static bool ValidateExistingPerson(ListOfFriends listoffriends, Person person)
        {
            int totalFields = 8;

            int matchingFields = listoffriends.Persons.Count(p =>
                p.LastName == person.LastName &&
                p.Name == person.Name &&
                p.Surname == person.Surname &&
                p.DateOfBirth == person.DateOfBirth &&
                p.Address == person.Address &&
                p.PlaceOfWorkOrStudy == person.PlaceOfWorkOrStudy &&
                p.Position == person.Position &&
                p.Acquaintance == person.Acquaintance);

            if (matchingFields == totalFields)
            {
                MessageBox.Show("This friend already exists in the list. Change the data before adding.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        public static bool ValidateUniquePhoneNumber(ListOfFriends listoffriends, Person person)
        {
            if (listoffriends.Persons.Any(p => p.PhoneNumber == person.PhoneNumber && !p.Equals(person)))
            {
                MessageBox.Show("A friend with the same phone number already exists in the list. Change the data before adding.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }
    }
}