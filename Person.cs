using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateClass {
    class Person {
        protected string Name;
        protected int BirthDate;
        protected Gender Gender;

        public Person(string Name, int BirthDate, Gender Gender) {
            this.Name = Name;
            this.BirthDate = BirthDate;
            this.Gender = Gender;

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
