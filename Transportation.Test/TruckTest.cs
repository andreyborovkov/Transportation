using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transportation
{
    [TestFixture]
    class TruckTest
    {
        [Test]
        public void CreateTruck()
        {
            //arrange
            Truck testTruck = new Truck();

            //action
            testTruck.GetMake = "Ford";
            string response = testTruck.GetMake;

            //assert
            Assert.That(response, Is.EqualTo("Ford"));
        }
    }
}
