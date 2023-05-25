using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02._06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student;
            try
            {
                student = new Student(Console.ReadLine(), Console.ReadLine(), Convert.ToInt32(Console.ReadLine()));
                Console.WriteLine(student.ToString());
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
