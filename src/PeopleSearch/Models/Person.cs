using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace PeopleSearch.Models
{
    public class PersonContext: DbContext
    {
        public DbSet<Person> People { get; set; }

        public PersonContext() { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Filename=../../../Database/PeopleSearch.db");
        }
    }

    public class TestPersonContext : DbContext
    {
        public DbSet<Person> People { get; set; }

        public TestPersonContext(DbContextOptions options) : base(options) { }
    }

    public class Person
    {
        public int ID { get; set; }
        [StringLength(128, MinimumLength = 1)]
        [Required]
        public string Name { get; set; }
        [DataType(DataType.MultilineText)]
        [Required]
        public string Address { get; set; }
        [RegularExpression(@"^[1-9][0-9]*$")]
        public int Age { get; set; }
        [RegularExpression(@"^[\w+\,\s*]{1,}$")]
        [Required]
        public string Interests { get; set; }
        [DataType(DataType.ImageUrl)]
        [Required]
        [Display(Name = "Image URL")]
        public string Picture { get; set; }
    }
}
