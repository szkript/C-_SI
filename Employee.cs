using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateClass
{
    class Employee : Person
    {
        private string profession;
        Room room;

        public Employee(string name, int birthDate, Gender gender, string profession) : base(name, birthDate, gender)
        {
            this.profession = profession;
        }
    }
}