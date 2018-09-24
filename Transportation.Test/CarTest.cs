using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Transportation;

namespace Transportation.Test
{
    [TestFixture]
    class CarTest
    {
        [Test]
        public void CreateMotorcycle()
        {
            Car testCycle = new Car();

            testCycle.GetMake = "BMW";
            string response = testCycle.GetMake;

            Assert.That(response, Is.EqualTo("BMW"));
        }
    }
}
