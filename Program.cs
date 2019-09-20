using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateClass {
    class CreateClass {
        static void Main(string[] args) {
            Person person = new Person("János", 1992, Gender.Male);
            Console.WriteLine(person);

            Console.ReadLine();
        }
    }
}

