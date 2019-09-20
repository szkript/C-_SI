using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateClass {


    class Employee : Person {

        public Employee(string Name, int BirthDate, Gender Gender) : base(Name, BirthDate, Gender) {
        }
    }
}
