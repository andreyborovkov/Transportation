using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transportation
{
    [TestFixture]
    class TranspoTest
    {
        [Test]
        public void GetMake()
        {
            //arrange
            Transpo testTranspo = new Transpo();

            //action
            testTranspo.GetMake = "Ford";
            string response = testTranspo.GetMake;
            Assert.That(response, Is.EqualTo("Ford"));
        }

        [Test]
        public void GetModel()
        {
            //arrange
            Transpo testTranspo = new Transpo();

            //action
            testTranspo.GetModel = "Bronco";
            string response = testTranspo.GetModel;
            Assert.That(response, Is.EqualTo("Bronco"));
        }

        [Test]
        public void GetYear()
        {
            //arrange
            Transpo testTranspo = new Transpo();

            //action
            testTranspo.GetYear = "1976";
            string response = testTranspo.GetYear;
            Assert.That(response, Is.EqualTo("1976"));
        }

        [Test]
        public void GetNumWheel()
        {
            //arrange
            Transpo testTranspo = new Transpo();

            //action
            testTranspo.GetNumWheel = "4";
            string response = testTranspo.GetNumWheel;

            //assert
            Assert.That(response, Is.EqualTo("4"));
        }

        [Test]
        public void GetColor()
        {
            //arrange
            Transpo testTranspo = new Transpo();

            //action
            testTranspo.GetColor = "Red";
            string response = testTranspo.GetColor;

            //assert
            Assert.That(response, Is.EqualTo("Red"));
        }

        [Test]
        public void GetEngineSize()
        {
            //arrange
            Transpo testTranspo = new Transpo();

            //action
            testTranspo.GetEngineSize = "351";
            string response = testTranspo.GetEngineSize;

            //assert
            Assert.That(response, Is.EqualTo("351"));
        }

        [Test]
        public void GetMPH()
        {
            //arrange
            Transpo testTranspo = new Transpo();

            //action
            int response = testTranspo.GetMPH(55);

            //assert
            Assert.That(response, Is.EqualTo(55));
        }

        [Test]
        public void GetMPG()
        {
            //arrange
            Transpo testTranspo = new Transpo();

            //action
            int response = testTranspo.GetMPG(55, 11);

            //assert
            Assert.That(response, Is.EqualTo(605));
        }

        [Test]
        public void GetWear()
        {
            //arrange
            Transpo testTranspo = new Transpo();

            //action
            string response = testTranspo.GetWear(0, 0, 0);

            //assert
            Assert.That(response, Is.EqualTo("Invalid Entry"));
        }

        [Test]
        public void GetWear_if_miles_div_heat_is_less_than_50_persent_tread_return_unsafe()
        {
            //arrange
            Transpo testTranspo = new Transpo();

            //action
            string response = testTranspo.GetWear(20, 85, 32);

            //assert
            Assert.That(response, Is.EqualTo("Unsafe"));
        }

        [Test]
        public void GetWear_if_miles_div_heat_is_great_than_50_persent_tread_return_unsafe()
        {
            //arrange
            Transpo testTranspo = new Transpo();

            //action
            string response = testTranspo.GetWear(1500, 85, 32);

            //assert
            Assert.That(response, Is.EqualTo("Safe"));
        }
    }
}
