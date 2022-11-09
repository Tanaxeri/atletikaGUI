using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atletikaGUI
{
    internal class verAdatok
    {

        readonly string nemzet;
        readonly string nem;
        readonly string versenySzam;
        readonly string versenyzoNev;
        readonly string eredmeny;
        readonly int helyezes;

        public string Nemzet => nemzet;

        public string Nem => nem;

        public string VersenySzam => versenySzam;

        public string VersenyzoNev => versenyzoNev;

        public string Eredmeny => eredmeny;

        public int Helyezes => helyezes;

        public verAdatok(string nemzet, string nem, string versenySzam, string versenyzoNev, string eredmeny, int helyezes)
        {
            this.nemzet = nemzet;
            this.nem = nem;
            this.versenySzam = versenySzam;
            this.versenyzoNev = versenyzoNev;
            this.eredmeny = eredmeny;
            this.helyezes = helyezes;

        }

        public override string ToString()
        {
            return versenySzam;
        }

    }
}
