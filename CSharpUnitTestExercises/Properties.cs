using System.Collections.Generic;
using System.Linq;

namespace CSharpUnitTestExercises
{
    /// This class will help to give you an overview of getters, setters and type checking
    public class Properties
    {
        /*  Return a list containing just the first names of the people in the given list
         *  The names should be in the same order as the original list
         */
        public IEnumerable<string> firstNames(List<Person> people)
        {
            return people.Select(person => person.firstName);
        }

        /*  Return a list containing the full names of the people in the given list
         *  The names should be in the same order as the original list
         *  In this case, note the fullName property is read-only because only a getter method is defined
         */
        public IEnumerable<string> fullNames(List<Person> people)
        {
            return people.Select(person => person.getFullName);
        }

        /*  Modify the "Person.firstName" and "Person.lastName"
         *  values of the given "Person" by making all letters upper case
         *  Note: System.Strings has a built in method to convert a string to upper case
         */
        public void upperCaseNames(Person person)
        {
            person.firstName = person.firstName.ToUpper();
            person.lastName = person.lastName.ToUpper();
        }

        /*  Create a list of "Person" objects with the given full names.
         *  You will need to split each full name yourself, delimiting with a space.
         */
        public List<Person> createPeople(string[] names)
        {
            List<Person> results = new List<Person>();
            foreach (string name in names)
            {
                string[] parts = name.Split(' ');
                Person person = new Person();
                person.firstName = parts[0];
                person.lastName = parts[1];
                results.Add(person);
            }
            return results;
        }

        /* 
         *  Return a list containing the heights of the people in the given list.
         *  The heights should be in the same order as the original list of "Person" objects
         *  Note: In this case, "Person.height" is a field, not a property, due to the lack
         *  of getters and setters
         */
        public IEnumerable<int> heights(List<Person> people)
        {
            return people.Select(person => person.height);
        }
    }

    public class Person
    {
        public int height;
        public string firstName { get; set; }
        public string lastName { get; set; }

        public string getFullName
        {
            get { return string.Format("{0} {1}", firstName, lastName); }
        }
    }
}







