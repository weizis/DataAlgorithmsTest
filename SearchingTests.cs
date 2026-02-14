using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using DataAlgorithms.Models;
using DataAlgorithms.Comparers;
using DataAlgorithms.Searching;

namespace DataAlgorithmsTest
{
    [TestClass]
    public class SearchingTests
    {
        [TestMethod]
        public void BinarySearch_FindsCorrectIndex()
        {
            var people = new List<Person>
            {
                new Person { LastName = "Ivanov", Age = 25 },
                new Person { LastName = "Petrov", Age = 30 },
                new Person { LastName = "Sidorov", Age = 40 }
            };

            var comparer = new PersonLastNameComparer();
            var personToFind = new Person { LastName = "Petrov" };

            int index = BinarySearch.Search(people, personToFind, comparer);

            Assert.AreEqual(1, index); 
        }
        [TestMethod]
        public void BinarySearch_ElementNotFound_ReturnsMinusOne()
        {
            var people = new List<Person>
            {
                new Person { LastName = "Ivanov", Age = 25 },
                new Person { LastName = "Petrov", Age = 30 }
            };
            var comparer = new PersonLastNameComparer();
            var personToFind = new Person { LastName = "Sidorov" };

            int index = BinarySearch.Search(people, personToFind, comparer);

            Assert.AreEqual(-1, index);
        }

        [TestMethod]
        public void LinearSearch_FindsCorrectIndex()
        {
            var people = new List<Person>
            {
                new Person { LastName = "Ivanov", Age = 25 },
                new Person { LastName = "Petrov", Age = 30 },
                new Person { LastName = "Sidorov", Age = 40 }
            };

            int index = LinearSearch.Search(people, p => p.LastName == "Sidorov");

            Assert.AreEqual(2, index); 
        }
        [TestMethod]
        public void LinearSearch_EmptyList_ReturnsMinusOne()
        {
            var people = new List<Person>();

            int index = LinearSearch.Search(people, p => p.LastName == "Ivanov");

            Assert.AreEqual(-1, index);
        }

    }
}
