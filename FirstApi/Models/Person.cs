using System.ComponentModel.DataAnnotations;


using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata.Ecma335;
using FirstApi.Controllers;

namespace FirstApi.Model
{
    public class Person
    {
        [Required] 
        public string Aadhar { get; set; }
        [MaxLength(100)]
        public string Name { get; set; }

        [Range(18, 110)]

        public int Age { get; set; }

        [EmailAddress]
        public string Email { get; set; }
    }

    public class PersonOperations
    {
        private static List<Person> _people = new List<Person>();
        private static object found;
        private static object updatedPerson;

        public static List<Person> GetPeople()
        {
            if (_people.Count == 0)
            {
                _people.Add(new Person() { Aadhar = "AA34567891234567", Age = 25, Email = "meena@gmail.com", Name = "Meena" });
                _people.Add(new Person() { Aadhar = "BB34567891234567", Age = 24, Email = "eena@gmail.com", Name = "Eena" });
                _people.Add(new Person() { Aadhar = "CC34567891234567", Age = 27, Email = "reena@gmail.com", Name = "Reena" });
            }
            return _people;
        }

        public static List<Person> getages(int pstartage, int pendage)
        {
            return GetPeople().Where(P => (P.Age < pendage) && P.Age > pstartage).ToList();
        }

        internal static Person Search(string pAadhar)
        {
            return GetPeople().Where(p => p.Aadhar == pAadhar).FirstOrDefault();
        }

        internal static void CreateNew(Person p)
        {
            GetPeople();
            _people.Add(p);
        }
        public static bool Update(string pAadhar, Person updatedPerson)
        {
            var found = GetPeople().Where(p => p.Aadhar == p.Aadhar).FirstOrDefault();
            if (found != null)
            {
                found.Email = updatedPerson.Email;
                found.Name = updatedPerson.Name;
                found.Age = updatedPerson.Age;


                return true;
            }
            else
                throw new Exception("No such record");
        }

        internal static bool Delete(string pAadhar)
        {
            var found = GetPeople().Where(p => p.Aadhar == pAadhar).FirstOrDefault();
            if (found != null)
            {
                GetPeople().Remove(found);
                return true;
            }
            else
                throw new Exception("No such record");
        }

        internal static void Update(string pAadhar, PersonController updatedPerson)
        {
            throw new NotImplementedException();
        }
    }
}

