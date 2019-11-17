using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateClass {
    class Person {
        private string Name { get; set; }
        private DateTime BirthDate { get; set; }
        private readonly Gender _gender;

        protected Person(string name, DateTime birthDate, Gender gender) {
            Name = name;
            BirthDate = birthDate;
            _gender = gender;
        }

        public Person(string name, DateTime birthDate)
        {
            Name = name;
            BirthDate = birthDate;
        }

        public override string ToString() {
            return $"{Name} , birth year: {BirthDate}, gender: {_gender}";
        }
    }
    enum Gender {
        Male,
        Female
    }
}
