using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateClass {
    class Person {
        private string Name { get; set; }
        private int BirthDate { get; set; }
        private Gender Gender;

        protected Person(string name, int birthDate, Gender gender) {
            this.Name = name;
            this.BirthDate = birthDate;
            this.Gender = gender;

        }

        public override string ToString() {
            return Name.ToString() + " , birth year: " + BirthDate.ToString() + ", gender: " + Gender.ToString();
        }
    }
    enum Gender {
        Male,
        Female
    }
}
