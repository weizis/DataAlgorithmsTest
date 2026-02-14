using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using DataAlgorithms.Models;
using DataAlgorithms.Comparers;
using DataAlgorithms.Sorting;

namespace DataAlgorithmsTest
{
    [TestClass] 
    public class SortingTests
    {
        [TestMethod] 
        public void MergeSort_SortsByLastNameCorrectly()
        {
            var people = new List<Person>
            {
                new Person { LastName = "Petrov", Age = 30 },
                new Person { LastName = "Ivanov", Age = 25 },
                new Person { LastName = "Sidorov", Age = 40 }
            };

            var comparer = new PersonLastNameComparer();

            var result = MergeSort.Sort(people, comparer);

            Assert.AreEqual("Ivanov", result[0].LastName);
            Assert.AreEqual("Petrov", result[1].LastName);
            Assert.AreEqual("Sidorov", result[2].LastName);
        }
        [TestMethod]
        public void MergeSort_EmptyList_ReturnsEmpty()
        {
            var people = new List<Person>();
            var comparer = new PersonLastNameComparer();

            var result = MergeSort.Sort(people, comparer);

            Assert.AreEqual(0, result.Count);
        }

        [TestMethod]
        public void QuickSort_SortsByLastNameCorrectly()
        {
            var people = new List<Person>
            {
                new Person { LastName = "Petrov", Age = 30 },
                new Person { LastName = "Ivanov", Age = 25 },
                new Person { LastName = "Sidorov", Age = 40 }
            };

            var comparer = new PersonLastNameComparer();

            QuickSort.Sort(people, comparer); 

            Assert.AreEqual("Ivanov", people[0].LastName);
            Assert.AreEqual("Petrov", people[1].LastName);
            Assert.AreEqual("Sidorov", people[2].LastName);
        }
        [TestMethod]
        public void QuickSort_OneElement_ListUnchanged()
        {
            var people = new List<Person> { new Person { LastName = "Ivanov", Age = 25 } };
            var comparer = new PersonLastNameComparer();

            QuickSort.Sort(people, comparer);

            Assert.AreEqual(1, people.Count);
            Assert.AreEqual("Ivanov", people[0].LastName);
        }

        [TestMethod]
        public void BubbleSort_SortsByLastNameCorrectly()
        {
            var people = new List<Person>
            {
                new Person { LastName = "Petrov", Age = 30 },
                new Person { LastName = "Ivanov", Age = 25 },
                new Person { LastName = "Sidorov", Age = 40 }
            };

            var comparer = new PersonLastNameComparer();

            BubbleSort.Sort(people, comparer); 

            Assert.AreEqual("Ivanov", people[0].LastName);
            Assert.AreEqual("Petrov", people[1].LastName);
            Assert.AreEqual("Sidorov", people[2].LastName);
        }
        [TestMethod]
        public void BubbleSort_RepeatedLastNames_SortsCorrectly()
        {
            var people = new List<Person>
            {
                new Person { LastName = "Petrov", Age = 30 },
                new Person { LastName = "Petrov", Age = 25 },
                new Person { LastName = "Ivanov", Age = 40 }
            };
            var comparer = new PersonLastNameComparer();

            BubbleSort.Sort(people, comparer);

            Assert.AreEqual("Ivanov", people[0].LastName);
            Assert.AreEqual("Petrov", people[1].LastName);
            Assert.AreEqual("Petrov", people[2].LastName);
        }




    }
}
