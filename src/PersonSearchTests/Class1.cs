using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using PeopleSearch.Controllers;
using PeopleSearch.Models;
using PeopleSearch.ViewModels;
using Xunit;

namespace PersonSearchTests
{
    public class Class1
    {
        // I couldn't figure out how to get unit testing working.

        private PersonContext context;

        public Class1()
        {
            DbContextOptionsBuilder builder = new DbContextOptionsBuilder();
            builder.UseInMemoryDatabase();
            context = new PersonContext(builder.Options);
        }

        [Fact]
        public void Test1()
        {
            PeopleController controller = new PeopleController(context);
            controller.Search(new PersonSearchRequest { searchString = "bono", slow = false });
            //Person person = new Person
            //{
            //    ID = 0,
            //    Name = "Foo Bar",
            //    Address = "Some address\r\n23423 wef.",
            //    Age = 234,
            //    Interests = "wefwe,a wefaw ef,aw ef awef ,aw ef ",
            //    Picture = "aPicture.jpg"
            //};

            //using (var context = new PersonContext(CreateNewContextOptions()))
            //{
            //    context.Database.Migrate();
            //    context.People.Add(person);
            //    context.SaveChanges();

            //Assert.True(peopleController.ModelState.IsValid);

            //IActionResult result = peopleController.Search(new PersonSearchRequest
            //{
            //    searchString = "foo",
            //    slow = false
            //});

            //Assert.True(result.ToString().Contains("bar"));
        }
    }
}
