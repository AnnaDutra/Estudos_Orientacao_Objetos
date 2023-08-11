using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes.Farmacia
{
    public class Remedio
    {
        public string Nome;
        public string Fabricante;
        public double Ml;

        public void DiminuirMl(double mlTomada)
        {
            Ml = Ml - mlTomada;
        }

        public string ObterNomeEFabricante()
        {
            return Nome + " " + Fabricante;
        }
    }
}
