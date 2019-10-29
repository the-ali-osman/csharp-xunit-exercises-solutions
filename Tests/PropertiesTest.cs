using CSharpUnitTestExercises;
using System.Linq;
using System.Collections.Generic;
using Xunit;

namespace Tests
{
    public class PropertiesTest
    {
        // Setup the link to the class
        Properties exercise = new Properties();

        [Fact(DisplayName = "Get the first names of people")]
        public void FirstNames()
        {
            var people = new List<Person> {
                new Person() { firstName = "Joe", lastName = "Bloggs" },
                new Person() { firstName = "Jill", lastName = "Dash" },
                new Person() { firstName = "Arthur", lastName = "Dent" },
                new Person() { firstName = "Selina", lastName = "Kyle" }
            };

            Assert.Equal(new[] { "Joe", "Jill", "Arthur", "Selina" }, exercise.firstNames(people));
        }

        [Fact(DisplayName = "Get the full names of people")]
        public void FullNames()
        {
            var people = new List<Person> {
                new Person() { firstName = "Joe", lastName = "Bloggs" },
                new Person() { firstName = "Jill", lastName = "Dash" },
                new Person() { firstName = "Arthur", lastName = "Dent" },
                new Person() { firstName = "Selina", lastName = "Kyle" }
            };

            Assert.Equal(new[] { "Joe Bloggs", "Jill Dash", "Arthur Dent", "Selina Kyle" }, exercise.fullNames(people));
        }

        [Fact(DisplayName = "Make all names upper case")]
        public void UpperCaseNames()
        {
            var person = new Person() { firstName = "Joe", lastName = "Bloggs" };
            exercise.upperCaseNames(person);
            Assert.Equal("JOE", person.firstName);
            Assert.Equal("BLOGGS", person.lastName);
        }

        [Fact(DisplayName = "Create a list of people from full names")]
        public void CreatePeopleListFromFullNames()
        {
            var names = new[] { "Joe Bloggs", "Jill Dash", "Arthur Dent", "Selina Kyle" };

            var people = exercise.createPeople(names);

            Assert.True(people.All(p => p is Person));
            Assert.Equal(names.Length, people.Count);
            Assert.NotEmpty(people.Where(p => p.firstName == "Joe" && p.lastName == "Bloggs"));
            Assert.NotEmpty(people.Where(p => p.firstName == "Selina" && p.lastName == "Kyle"));
        }

        [Fact(DisplayName = "Get the heights of people")]
        public void Heights()
        {
            var people = new List<Person> {
                new Person() { firstName = "Joe", lastName = "Bloggs", height = 185 },
                new Person() { firstName = "Jill", lastName = "Dash", height = 176 },
                new Person() { firstName = "Arthur", lastName = "Dent" , height = 163},
                new Person() { firstName = "Selina", lastName = "Kyle", height =  170}
            };

            Assert.Equal(new[] { 185, 176, 163, 170 }, exercise.heights(people));
        }
    }
}