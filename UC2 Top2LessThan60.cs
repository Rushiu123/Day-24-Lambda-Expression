using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_24_Lambda_Programe
{
    public class PersonDataManagement
    {
        public static void RetrieveTop2Below60(List<Person> list)
        {
            var top2 = list.Where(p => p.Age < 60).OrderBy(p => p.Age).Take(2);
            Console.WriteLine("\nTop 2 Person less than Age 60");
            Program.DisplayPersonDetails(top2);
        }
    }
}
