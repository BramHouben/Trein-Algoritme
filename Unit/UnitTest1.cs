using circ;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Unit
{
    [TestClass]
    public class UnitTest1
    {
        private Verdelendier newindelen = new Verdelendier();
        private Wagon waggie = new Wagon();
        //private Dier dier;

        private Dier grootdiervlees = new Dier("Groot", "Vleeseter", 5);
        private Dier middeldiervlees = new Dier("Middelmatig", "Vleester", 3);
        private Dier kleindiervlees = new Dier("Klein", "Vleester", 1);

        private Dier grootdierPlant = new Dier("Groot", "Planteneter", 5);
        private Dier middeldierPlant = new Dier("Middelmatig", "Planteneter", 3);
        private Dier kleindierPlant = new Dier("Klein", "Planteneter", 1);
        private indelen indelen = new indelen();
        private List<Dier> totalelist = new List<Dier>();

        [TestInitialize]
        public void Setup()
        {
        }

        // De list met wagons
        private List<Wagon> newWagon = new List<Wagon>();

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
        public void indelendier()
        {
            totalelist.Add(grootdierPlant);
            totalelist.Add(kleindierPlant);
            totalelist.Add(middeldierPlant);

            totalelist.Add(grootdiervlees);
            totalelist.Add(middeldiervlees);
            totalelist.Add(kleindiervlees);
            var result = totalelist.Count;
            Assert.AreEqual(result, 18);
        }



        //[TestMethod]
        //public void tweedelen()
        //{
        //    totalelist.Add(grootdiervlees);
        //    totalelist.Add(grootdiervlees);

        //    indelen.indelenvandieren(waggie, dier);
        //    var result = wagonlist.Count;
        //    Assert.AreEqual(result, 2);
        //}
    }
}