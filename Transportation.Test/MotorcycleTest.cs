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
    class MotorcycleTest
    {
        [Test]
        public void CreateMotorcycle()
        {
            Cycle testCycle = new Cycle();

            testCycle.GetMake = "BMW";
            string response = testCycle.GetMake;

            Assert.That(response, Is.EqualTo("BMW"));
        }

        [Test]
        public void GetTreadCycle()
        {
            Cycle testCycle = new Cycle();

            string response = testCycle.GetWear(20, 85, 32);

            Assert.That(response, Is.EqualTo("BMW"));
        }
    }
}
