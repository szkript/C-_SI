using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateClass
{
    class Employee : Person
    {
        private readonly string _profession;
        private readonly int _salary;
        private Room _room;
        
        public Employee(string name, int birthDate, Gender gender, string profession, int salary, int room) : base(name, birthDate, gender)
        {
            _profession = profession;
            _salary = salary;
            _room = new Room(room);
        }

        public override string ToString()
        {
            return base.ToString() + ", profession: " + _profession
                   + ", Salary: " + _salary.ToString() +_room.ToString();
            
        }
    }
}