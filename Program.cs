using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_24_Lambda_Programe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Person Data Management..!");
            List<Person> listOfPerson = new List<Person>();
            //UC1 - Creating Person Class and Adding Data
            AddingPersonDetails(listOfPerson);
            //UC2 - 
            PersonDataManagement.RetrieveTop2Below60(listOfPerson);
            //UC3
            PersonDataManagement.AgeBetween13to18(listOfPerson);
            //UC4
            PersonDataManagement.AverageAge(listOfPerson);
            //UC5
            PersonDataManagement.NameCheck(listOfPerson, "Rushi");
            //UC6
            PersonDataManagement.SkipLessThan60(listOfPerson);
            //UC7
            PersonDataManagement.RemoveName(listOfPerson, "Russhi");
            Console.ReadLine();
        }
        public static void AddingPersonDetails(List<Person> list)
        {
            list.Add(new Person() { SSN = 1, Name = "Rushi", Address = "Bangalore", Age = 25 });
            list.Add(new Person() { SSN = 2, Name = "Raj", Address = "Hosur", Age = 12 });
            list.Add(new Person() { SSN = 3, Name = "Vishnu", Address = "Vellore", Age = 14 });
            list.Add(new Person() { SSN = 4, Name = "Ram", Address = "Mumbai", Age = 30 });
            list.Add(new Person() { SSN = 5, Name = "Aniket", Address = "Pune", Age = 56 });
            list.Add(new Person() { SSN = 6, Name = "Manish", Address = "Jodhpur", Age = 70 });
            list.Add(new Person() { SSN = 7, Name = "Yavesh", Address = "Jaipur", Age = 63 });
            DisplayPersonDetails(list);
        }

        public static void DisplayPersonDetails(IEnumerable<Person> list)
        {
            foreach (Person person in list)
            {
                Console.WriteLine(person);
            }
        }
    }
}
