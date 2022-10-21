using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main()
        {
            Person person = new Person("Petar" , 20);

            Person person1 = new Person("George" , 18);

            Person person2 = new Person();
            person2.Name = "Jose";
            person2.Age = 43;
        }
    }
}
