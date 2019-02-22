using System.Collections.Generic;

namespace circ
{
    internal class indelen
    {
        public void Verwijdervlees(List<Dier> newDier)
        {
            //  verwijder alle vleeseters uit de list
            newDier.RemoveAll(dier => dier.type == "Vleeseter");
        }

        public bool regelswagon(Wagon wagons, Dier dieren)
        {
            // kijken of het in de wagon past
            if (wagons.punten == 10 || wagons.punten + dieren.punt > 10)
            {
                return false;
            }
            //  het indeel proces van de dieren + 
            // eerst checken voor vlees en daarna de grootte
            foreach (var dierwag in wagons.dieren)
            {
                // vlees 5 nieuwe wagon
                if (dierwag.type == "Vleeseter" && dierwag.grootte == "Groot")
                {
                    return false;
                }
                //vleeseter eet hem op
                else if (dierwag.type == "Vleeseter" && dieren.grootte == "Klein")
                {
                    return false;
                }
                else if (dieren.grootte == "Groot" && dierwag.type == "Vleeseter" && dierwag.grootte == "Middelmatig")
                {
                    return true;
                }
                else if (dieren.grootte == "Groot" && dierwag.type == "Vleeseter" && dierwag.grootte == "Klein")
                {
                    return true;
                }
                else if (dieren.grootte == "Middelmatig" && dierwag.type == "Vleeseter" && dierwag.grootte == "Klein")
                {
                    return true;
                }
                if (dieren.type == dierwag.type)
                {
                    return true;
                }
            }

            return false;
        }
    }
}