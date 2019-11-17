using System;

namespace CreateClass
{
    class Employee : Person, ICloneable
    {
        private readonly string _profession;
        private readonly int _salary;
        private Room _room;

        public Employee(string name, DateTime birthDate, Gender gender, int salary, int room, string profession) : base(name, birthDate, gender)
        {
            _profession = profession;
            _salary = salary;
            _room = new Room(room);
        }

        public Employee(string name, DateTime birthDate, int salary, string profession) : base(name, birthDate)
        {
            _profession = profession;
            _salary = salary;
        }

        public object Clone()
        {
            Employee newEmployee = (Employee)this.MemberwiseClone();
            newEmployee.Room = new Room(Room.Number);
            return newEmployee;
        }

        public Room Room { get; internal set; }

        public override string ToString()
        {
            return base.ToString() + ", profession: " + _profession
                   + ", Salary: " + _salary.ToString() + _room.ToString();

        }

    }
}