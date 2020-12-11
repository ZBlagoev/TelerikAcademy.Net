using System;
using System.Collections.Generic;
using System.Text;

namespace _01_Data_Types_Advanced
{
    class PersonObject
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public PersonObject(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }
}
