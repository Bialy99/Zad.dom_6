using System.Reflection.Metadata;
using Zad.dom_6;

namespace Zad.dom.dzien7.Test
{
    public class Tests
    {
        [Test]
        public void Test1()
        {
            //arrange
            Employee employee1 = new Employee("Andrzej", "Wielki", "18 lat");


            //act
            employee1.AddScore(5);
            employee1.AddScore(6);
            employee1.AddScore(-11);

            //assert
            Assert.AreEqual(0, employee1.Result);
        }
    }
}