using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoMaster
{
    public class FilmInfo
    {
        public int ID_Film { get; set; }
        public string Naziv { get; set; }
        public DateTime Datum_izdavanja { get; set; }
        public int Trajanje { get; set; }
        public string Redatelj { get; set; }
        public string DobnoOgranicenje { get; set; }
        public string Zanr { get; set; }
        public double ProsjecnaOcjena { get; set; }

        public string Adresa_url { get; set; }
    }

}
