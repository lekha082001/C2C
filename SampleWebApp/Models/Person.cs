using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;

namespace SampleWebApp.Models
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

        internal static Person Search(string pAadhar)
        {
            return GetPeople().Where(p=>p.Aadhar== pAadhar).FirstOrDefault();
        }

        public static List<Person> GetPeople()
        {
            if(_people.Count == 0)
            {
                _people.Add(new Person() { Aadhar = "AABBCCLL7823hy67", Age = 22, Email = "abc@kpmg.com", Name = "Ajay" });
                _people.Add(new Person() { Aadhar = "AABLIHLL7823hy67", Age = 24, Email = "defkpmg.com", Name = "Abhi" });
                _people.Add(new Person() { Aadhar = "AABBCCLLZGA$hy67", Age = 26, Email = "ghi@kpmg.com", Name = "Nanditha" });
            }
            return _people;
            

        }
        public static List<Person> getages(int pstartage, int pendage)
        {
            return GetPeople().Where(p => (p.Age < pendage) && (p.Age > pstartage)).ToList();
        }

        internal static void CreateNew(Person p)
        {
            GetPeople();
            _people.Add(p);
        }
    }
}
