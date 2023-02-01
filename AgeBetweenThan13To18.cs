using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_24_Lambda_Programe
{
    public class PersonDataManagement
    {
        //UC2- TOP 2 Records based on Age
        public static void RetrieveTop2Below60(List<Person> list)
        {
            var top2 = list.Where(p => p.Age < 60).OrderBy(p => p.Age).Take(2);
            Console.WriteLine("\nTop 2 Person less than Age 60");
            Program.DisplayPersonDetails(top2);
        }

        public static void AgeBetween13to18(List<Person> list)
        {
            var teenage = list.Where(p => p.Age > 13 && p.Age < 18);
            Console.WriteLine("\nRecord found Betwwen Age 13 to 18");
            Program.DisplayPersonDetails(teenage);
        }
    }
}
