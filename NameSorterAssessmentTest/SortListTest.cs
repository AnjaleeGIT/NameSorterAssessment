using System;
using System.Collections.Generic;
using Xunit;
using NameSorterAssessment;


namespace NameSorterAssessmentTest
{
    public class SortListTest
    {
        [Fact]
        public void Sort()
        {
            //Arrange
            List<Person> unsortedPeople = new List<Person>();
            unsortedPeople.Add(new Person("Marin", "Alvarez"));
            unsortedPeople.Add(new Person("Adonis", "Julius", "Archer"));
            /*
            unsortedPeople.Add(new Person("Janet", "Parsons"));
            unsortedPeople.Add(new Person("Hunter", "Uriah", "Mathew", "Clarke"));
            unsortedPeople.Add(new Person("Vaughn", "Lewis"));
            unsortedPeople.Add(new Person("Adonis", "Julius", "Archer"));
            unsortedPeople.Add(new Person("Shelby", "Nathan", "Yoder"));
            unsortedPeople.Add(new Person("Marin", "Alvarez"));
            unsortedPeople.Add(new Person("London", "Lindsey"));
            unsortedPeople.Add(new Person("Beau", "Tristan", "Bentley"));
            unsortedPeople.Add(new Person("Leo", "Gardner"));
            unsortedPeople.Add(new Person("Mikayla", "Lopez"));
            unsortedPeople.Add(new Person("Alice", "Lindsey"));
            unsortedPeople.Add(new Person("Frankie", "Conner", "Ritter"));*/


            List<Person> sortedPeople = new List<Person>();
           sortedPeople.Add(new Person("Marin", "Alvarez"));
            sortedPeople.Add(new Person("Adonis", "Julius", "Archer"));
            /*sortedPeople.Add(new Person("Beau", "Tristan", "Bentley"));
            sortedPeople.Add(new Person("Hunter", "Uriah", "Mathew", "Clarke"));
            sortedPeople.Add(new Person("Leo", "Gardner"));
            sortedPeople.Add(new Person("Vaughn", "Lewis"));
            sortedPeople.Add(new Person("Alice", "Lindsey"));
            sortedPeople.Add(new Person("London", "Lindsey"));
            sortedPeople.Add(new Person("Mikayla", "Lopez"));
            sortedPeople.Add(new Person("Janet", "Parsons"));
            sortedPeople.Add(new Person("Frankie", "Conner", "Ritter"));
            sortedPeople.Add(new Person("Shelby", "Nathan", "Yoder"));*/

            //Act

            List<Person> sortedPeopleTest = SortList.SortNames(unsortedPeople);

            //Assert
            //Assert.Equal(sortedPeopleTest, sortedPeople);
            //sortedPeopleTest.Should().BeEquivalentTo(sortedPeople);

        }
    }
}
