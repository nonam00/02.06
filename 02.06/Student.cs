using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02._06
{
    internal class Student
    {
        private string first_name;
        private string last_name;
        private int age;

        public Student(string firstName, string lastName, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }

        public override string ToString()
        {
            return($"First name: {FirstName}\nLast name: {LastName}\nAge: {Age}\n\n");
        }

        public string FirstName
        {
            set
            {
                if(value == "")
                    throw new Exception("Argument is empty");
                else
                    first_name = value;
            }
            get { return first_name; }
        }
        public string LastName
        {
            set
            {
                if (value == "")
                    throw new Exception("Argument is empty");
                else
                    last_name = value;
            }
            get { return last_name; }
        }
        public int Age
        {
            set
            {
                if (value < 14)
                    throw new Exception("Age is lower than 14");
                else
                    age = value;
            }
            get { return age; }
        }
        
    }
}
