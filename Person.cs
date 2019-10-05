using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateClass {
    class Person {
        private string Name { get; set; }
        private int BirthDate { get; set; }
        private readonly Gender _gender;

        protected Person(string name, int birthDate, Gender gender) {
            this.Name = name;
            this.BirthDate = birthDate;
            this._gender = gender;

        }

        public override string ToString() {
            return Name.ToString() + " , birth year: " + BirthDate.ToString() + ", gender: " + _gender.ToString();
        }
    }
    enum Gender {
        Male,
        Female
    }
}
