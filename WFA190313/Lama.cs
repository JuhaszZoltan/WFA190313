using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA190313
{
    public class Lama
    {
        public string Nev { get; set; }
        public int SzulEv { get; set; }
        public string Iz { get; set; }

        public Lama(string sor)
        {
            var t = sor.Split(';');
            this.Nev = t[0];
            this.SzulEv = int.Parse(t[1]);
            this.Iz = t[2];
        }
    }
}
