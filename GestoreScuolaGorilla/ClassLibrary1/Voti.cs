namespace ClassLibrary1
{
    public class Voti
    {
        protected List<double> voto;

        string materia;

        public Voti()
        {
            voto = new List<double>();
            materia = "";
        }

        public Voti (string materia, double voto)
        {
            this.materia = materia;
            this.voto = new List<double>();
            this.voto.Add(voto);
        }

        public string Materia
        {
            get
            {
                return materia;
            }
            set
            {
                materia = value;
            }
        }

        public List<double> Voto
        {
            get
            {
                return voto;
            }
            set
            {
                voto = value;
            }
        }

        public void add(double v)
        {
            voto.Add(v);
        }
    }
}