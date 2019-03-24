using circ;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Units
{
    [TestClass]
    public class UnitTest1
    {
        private Verdelendier newindelen = new Verdelendier();
        //private Wagon waggie = new Wagon();
        //private Dier dier;

        private Dier grootdiervlees = new Dier("Groot", "Vleeseter", 5);
        private Dier middeldiervlees = new Dier("Middelmatig", "Vleeseter", 3);
        private Dier kleindiervlees = new Dier("Klein", "Vleeseter", 1);

        private Dier grootdierPlant = new Dier("Groot", "Planteter", 5);
        private Dier middeldierPlant = new Dier("Middelmatig", "Planteter", 3);
        private Dier kleindierPlant = new Dier("Klein", "Planteter", 1);
        private indelen indelen = new indelen();
        private List<Dier> totalelist = new List<Dier>();

        [TestInitialize]
        public void Setup()
        {
        }

        // De list met wagons
        //private List<Wagon> newWagon = new List<Wagon>();

        //  lijst met alle dieren

        [TestMethod]
        public void vijfpuntenvlees()
        {
            List<Dier> newDier = new List<Dier>();
            newDier.Add(grootdiervlees);
            var result = grootdiervlees.punt;
            Assert.AreEqual(result, 5);
        }

        [TestMethod]
        public void driepuntenvlees()
        {
            List<Dier> newDier = new List<Dier>();
            newDier.Add(middeldiervlees);
            var result = middeldiervlees.punt;
            Assert.AreEqual(result, 3);
        }

        [TestMethod]
        public void eenpuntenvlees()
        {
            List<Dier> newDier = new List<Dier>();
            newDier.Add(kleindiervlees);
            var result = kleindiervlees.punt;
            Assert.AreEqual(result, 1);
        }

        [TestMethod]
        public void returnfalseomdatvlees5()
        {
            Wagon newwagon = new Wagon();
            newwagon.dieren.Add(grootdiervlees);
            bool indelenvleesvijf = indelen.indelenvandieren(newwagon, grootdiervlees);
            Assert.AreEqual(false, indelenvleesvijf);
        }

        [TestMethod]
        public void returntrueplantgroter()
        {
            Wagon newwagon = new Wagon();
            newwagon.dieren.Add(middeldiervlees);
            newwagon.punten = 3;
            bool indelenplantvijf = indelen.indelenvandieren(newwagon, grootdierPlant);
            Assert.AreEqual(true, indelenplantvijf);
        }

        [TestMethod]
        public void returnfalseplant5vlees5()
        {
            Wagon newwagon = new Wagon();
            newwagon.dieren.Add(grootdiervlees);
            newwagon.punten = 5;
            bool indelenpplant = indelen.indelenvandieren(newwagon, grootdierPlant);
            Assert.AreEqual(false, indelenpplant);
        }

        [TestMethod]
        public void returnfalseplantkleinerv2()
        {
            Wagon newwagon = new Wagon();
            newwagon.dieren.Add(middeldiervlees);
            newwagon.punten = 5;
            bool indelenpplant = indelen.indelenvandieren(newwagon, kleindierPlant);
            Assert.AreEqual(false, indelenpplant);
        }

        [TestMethod]
        public void returnfalseover11()
        {
            Wagon newwagon = new Wagon();
            newwagon.dieren.Add(grootdierPlant);
            newwagon.dieren.Add(grootdierPlant);
            newwagon.punten = 10;
            bool indelenpplant = indelen.indelenvandieren(newwagon, kleindierPlant);
            Assert.AreEqual(false, indelenpplant);
        }
    }
}