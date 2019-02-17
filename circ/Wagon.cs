using System.Collections.Generic;

namespace circ
{
    internal class Wagon
    {
        public List<Dier> dieren;

        public int punten;

        public Wagon()
        {
            dieren = new List<Dier>();
        }

        public override string ToString()
        {
            string info = "wagonPunten: " + punten;
            foreach (var dier in dieren)
            {
                info = info + " grootte: " + dier.grootte + " type: " + dier.type + " punten: " + dier.punt + " | ";
            }
            return info;
        }
    }
}