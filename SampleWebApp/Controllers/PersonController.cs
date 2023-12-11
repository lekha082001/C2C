using Microsoft.AspNetCore.Mvc;
using SampleWebApp.Models;

namespace SampleWebApp.Controllers
{
    public class PersonController : Controller
    {
        [HttpGet("/people")]
        public IActionResult GetPeople(PersonOperations personOperations)
        
        {
            //get the model class & do something
            var people = PersonOperations.GetPeople();

            //display a view
            return ViewComponent("PeopleList", people);
        }
        public IActionResult GetPersonalDetail(string pAadhar)
        {
            //call model class method
            var found = PersonOperations.Search(pAadhar);
            //return the view matching person object
            return View("Search", found);
        }
        public IActionResult GetPeopleWithinAge(int startage, int endAge)
        {
            //write a new function in PersonOperations class
            //use view templates: List
            //create the view
            //return the view
            var found2 = PersonOperations.getages(startage, endAge);
            return View("search", found2);
            
        }
        [HttpGet("/create")]
        public IActionResult Create() 
        {
            return View("Create", new Person());
        }
        [HttpPost("/create")]
        public IActionResult Create([FromForm] Person p)
        {
            //call model method from personOperations
            PersonOperations.CreateNew(p);
            return View("PeopleList", PersonOperations.GetPeople());
        }
        [HttpGet("/edit/{pAadhar}")]
        public IActionResult Edit(string pAadhar)
        {
            var found = PersonOperations.Search(pAadhar);
            return View("Edit", found);
        }
        [HttpPost("/edit/{pAadhar}")]
        public IActionResult Edit(string pAadhar, [FromForm] Person p)
        {
            var found = PersonOperations.Search(p.Aadhar);
            found.Email = p.Email;
            found.Age = p.Age;
            found.Name = p.Name;
            return View("PeopleList", PersonOperations.GetPeople());
        }
    }
}
