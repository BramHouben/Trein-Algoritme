using System.Collections.Generic;
using System.Windows.Forms;

namespace circ
{
    public partial class Verdelendier : Form
    {
        //  nieuwe class indelen
        private indelen indel = new indelen();
        // De list met wagons
        private List<Wagon> newWagon = new List<Wagon>();
        //  lijst met alle dieren
        private List<Dier> newDier = new List<Dier>();

        //aanmaken nieuwe wagon
        private Wagon Nieuwewagon()
        {
            Wagon wagon = new Wagon();
            wagon.punten = 0;
            return wagon;
        }

        public Verdelendier()
        {
            InitializeComponent();
        }

        private void Btninvoer_Click(object sender, System.EventArgs e)
        {
            //  wijs grootte toe
            int puntdier;
            if (cbGrootte.Text == "Groot")
            {
                puntdier = 5;
            }
            else if (cbGrootte.Text == "Middelmatig")
            {
                puntdier = 3;
            }
            else
            {
                puntdier = 1;
            }
            // nieuw dier
            Dier Toevoegendier = new Dier(cbGrootte.Text, cbSoort.Text, puntdier);
            lbDier.Items.Add(Toevoegendier.type + "   " + Toevoegendier.grootte);
            newDier.Add(Toevoegendier);
        }

        private void btnIndelen_Click(object sender, System.EventArgs e)
        {
            //  alles leegmaken en nieuwe indeling
            lbResult.Items.Clear();
            newWagon.Clear();
            vleeseterinwagon();
        }

        private void vleeseterinwagon()
        {
            //  loop door de lijst van dieren en verdeel de vleeseters
            for (int i = 0; i < newDier.Count; i++)
            {
                if (newDier[i].type == "Vleeseter")
                {
                    Wagon wagon = Nieuwewagon();
                    wagon.dieren.Add(newDier[i]);
                    wagon.punten = wagon.punten + newDier[i].punt;
                    newWagon.Add(wagon);
                }
            }
            // alle vleeseters verwijderen
            indel.Verwijdervlees(newDier);
            indelenrest();
        }

        public void indelenrest()
        {
            //  ga door de verschillende grotes heen
            string[] groottes = new string[] { "Klein", "Middelmatig", "Groot" };
            foreach (var grootte in groottes)
            {
                // kijk bij elk dier van plannetes
                foreach (var dier in newDier)
                {
                    if (dier.grootte == grootte)
                    {
                        for (int i = 0; i < newWagon.Count; i++)
                        {
                            // als het dier erin mag
                            if (indel.regelswagon(newWagon[i], dier) == true)
                            {
                                newWagon[i].dieren.Add(dier);
                                newWagon[i].punten = newWagon[i].punten + dier.punt;
                                break;
                            }
                            // nieuwe wagon als het moet
                            if (i == newWagon.Count - 1)
                            {
                                Wagon wagon = new Wagon();
                                wagon.punten = wagon.punten + dier.punt;
                                wagon.dieren.Add(dier);
                                newWagon.Add(wagon);
                                break;
                            }
                        }
                    }
                }
            }
            resultaat();
        }

        private void resultaat()
        {
            foreach (var wagon in newWagon)
            {
                lbResult.Items.Add(wagon.ToString());
            }
        }
    }
}