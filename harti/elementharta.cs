using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace harti
{
    public class elementharta
    {
        public float longitudine;
        public float latitudine;
        public string denumire;
        public string pathimagine ;
        public string tip;

        public elementharta(float lat, float longi, string den, string pathimg, string ptip)
        {
            longitudine = longi;
            latitudine = lat;
            denumire = den;
            pathimagine = pathimg;
            tip = ptip;
        }
    }
}
