using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace SpeisePlan_Linhart_Gebauer
{
   public class Zutat
    {
        //Objektvariablen
   
        private int menge;
        private string einheit;
        private string bezeichnug;
        private string allergene;


        //Konstruktoren
        public Zutat()
        {

        }
        
        public Zutat(int menge, string einheit, string bezeichnung, string allergene)
        {
       
            this.menge = menge;
            this.einheit = einheit;
            this.bezeichnug = bezeichnung;
            this.allergene = allergene;
        }

        public int Menge
        {
            get { return menge; }
            set { menge = value; }
        }
        public string Einheit
        {
            get { return einheit; }
            set { einheit = value; }
        }
        public string Bezeichnung
        {
            get { return bezeichnug; }
            set { bezeichnug = value; }
        }
        public string Allergene
        {
            get { return allergene; }
            set { allergene = value; }
        }




    }
}
