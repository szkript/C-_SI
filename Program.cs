using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateClass {
    static class CreateClass {
        static void Main(string[] args) {
            Person person = new Employee("János", 1992, Gender.Male, "Janitor");
            Console.WriteLine(person);

            Console.ReadLine();
        }
    }
}

