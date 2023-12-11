using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpLib
{
    public enum Gender
    {
        Male, Female
    }
    //private: No sharing outside the class
    //public: Can share everything outside the class, project
    //protected: Access available only to inherited class (family)
    //internal: share allowed only inside the project
    public class Person
    {
        public Person()
        {
            
        }
        public Person(string pAadhar) : this()
        {
            this.Aadhar = pAadhar;
        }
        //calling one contructor from another
        public Person(string pAadhar, string pMobile) : this(pAadhar)
        {
            this.MobileNumber = pMobile;
        }
        public string Name { get; set; }
        public string Aadhar { get; set; }
        public string Email { get; set; }
        public Gender PersonGender { get; set; }
        public string Address { get; set; }
        public string MobileNumber { get; set; }
        public DateTime DOB { get; set; }

        public string Eat() {
            return $"{this.Name} eats breakfast, lunch, dinner"; 
        }

        public string Sleep() {
            return $"{this.Name} sleeps 8hrs a day";
        }

        public virtual string Work() {
            return $"{this.Name}works for 4hrs, relaxes for 8hrs";
        }
        protected string TaxDetails { get; set; }
    }
}
