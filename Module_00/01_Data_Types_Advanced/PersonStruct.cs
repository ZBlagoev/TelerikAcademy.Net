using System;
using System.Collections.Generic;
using System.Text;

namespace _01_Data_Types_Advanced
{
    public struct PersonStruct
    {
        public string Name;
        public int Age;
        public PersonStruct(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }
}
