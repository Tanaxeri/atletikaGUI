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
        readonly int versenySzam;
        readonly string versenyzoNev;
        readonly double eredmeny;
        readonly int helyezes;

        public string Nemzet => nemzet;

        public string Nem => nem;

        public int VersenySzam => versenySzam;

        public string VersenyzoNev => versenyzoNev;

        public double Eredmeny => eredmeny;

        public int Helyezes => helyezes;

        public verAdatok(string nemzet, string nem, int versenySzam, string versenyzoNev, double eredmeny, int helyezes)
        {
            this.nemzet = nemzet;
            this.nem = nem;
            this.versenySzam = versenySzam;
            this.versenyzoNev = versenyzoNev;
            this.eredmeny = eredmeny;
            this.helyezes = helyezes;

        }



    }
}
