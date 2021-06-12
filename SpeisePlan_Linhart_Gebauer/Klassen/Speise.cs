using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;


namespace SpeisePlan_Linhart_Gebauer

{
    public class Speise
    {
       //Objektvariablen
        private int speiseID;
        private string name;
        private int preis;
        private char speiseart;
        private string bildpfad;


        //Klassenvariablen
        private static int autonum = 1;

        //Konstruktoren
        public Speise()
        {
            speiseID = autonum;
            autonum++;
        }

        public Speise(int speiseID, string name, int preis, char speiseart, string bildpfad)
        {
            this.speiseID = autonum;
            autonum++;
            this.name = name;
            this.preis = preis;
            this.speiseart = speiseart;
            this.bildpfad = bildpfad;
        }

        public int SpeiseID { get; set; }
        public string Name { get; set; }
        public int Preis { get; set; }
        public char Speiseart { get; set; }
        public string Bildpfad { get; set; }

        public static int Autonum
        {
            get { return autonum; }
            set { autonum = value; }
        }


        public override string ToString()
        {
            return speiseID + ";" + name + ";" + preis + ";" + speiseart + ";" + bildpfad;
        }
    }
}
