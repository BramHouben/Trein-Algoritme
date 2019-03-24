namespace circ
{
    public class Dier
    {
        public string grootte;
        public string type;
        public int punt;

        public Dier(string grootte, string type, int punt)
        {
            this.grootte = grootte;
            this.type = type;
            this.punt = punt;
        }

        public override string ToString()
        {
            string info = "type: " + type + " grootte: " + grootte;

            return info;
        }
    }
}