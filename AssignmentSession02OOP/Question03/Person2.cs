using AssignmentSession02OOP.question01;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentSession02OOP.Question03
{
    public class Person2
    {
        public string? Name { get; set; }
        public int Age { get; set; }
       public static Person2 FindOldest(Person2[] people)
        {
            Person2 oldest = people[0];

            for (int i = 0; i < people.Length; i++)
            {
                if (people[i].Age > oldest.Age)
                    oldest = people[i];

            }
            return oldest;
        }
    }
}
