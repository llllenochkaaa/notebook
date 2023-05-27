﻿using notebook.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace notebook
{
    public class Validator
    {
        public static bool ValidateFullName(string fullName)
        {
            return !string.IsNullOrWhiteSpace(fullName) && fullName.Length <= 50;
        }

        public static bool ValidateAddress(string address)
        {
            return !string.IsNullOrWhiteSpace(address) && address.Length <= 100;
        }

        public static bool ValidateDateOfBirth(string dateOfBirthString)
        {
            string[] formats = { "dd/MM/yy", "dd/MM/yyyy" };
            DateTime dateOfBirth;
            return DateTime.TryParseExact(dateOfBirthString, formats, CultureInfo.InvariantCulture, DateTimeStyles.None, out dateOfBirth);
        }

        public static bool ValidatePhoneNumber(string phoneNumber)
        {
            Regex regex = new Regex(@"^\+380\d{9}$");
            return regex.IsMatch(phoneNumber);
        }

        public static bool ValidatePlaceOfWorkOrStudy(string placeOfWorkOrStudy)
        {
            return !string.IsNullOrWhiteSpace(placeOfWorkOrStudy) && placeOfWorkOrStudy.Length <= 100;
        }

        public static bool ValidatePosition(string position)
        {
            return !string.IsNullOrWhiteSpace(position) && position.Length <= 50;
        }

        public static bool ValidateAcquaintance(string acquaintance)
        {
            return !string.IsNullOrWhiteSpace(acquaintance) && acquaintance.Length <= 100;
        }

        public static bool ValidateNotEmpty(string fieldValue)
        {
            return !string.IsNullOrEmpty(fieldValue);
        }

        public static bool ValidateExistingPerson(ListOfFriends listoffriends, Person person)
        {
            if (listoffriends.Persons.Any(p => p.FullName == person.FullName
                && p.DateOfBirth == person.DateOfBirth && p.Address == person.Address
                && p.PlaceOfWorkOrStudy == person.PlaceOfWorkOrStudy
                && p.Acquaintance == person.Acquaintance && !p.Equals(person)))
            {
                MessageBox.Show("This friend already exists in the list. Change the data before adding.");
                return false;
            }

            return true;
        }

        public static bool ValidateUniquePhoneNumber(ListOfFriends listoffriends, Person person)
        {
            if (listoffriends.Persons.Any(p => p.PhoneNumber == person.PhoneNumber && !p.Equals(person)))
            {
                MessageBox.Show("A friend with the same phone number already exists in the list. Change the data before adding.");
                return false;
            }

            return true;
        }
    }
}
