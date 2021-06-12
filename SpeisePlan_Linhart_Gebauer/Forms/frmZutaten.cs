using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace SpeisePlan_Linhart_Gebauer
{
    public partial class frmZutaten : Form
    {
        internal static frmZutaten frmzutaten;
        public frmZutaten()
        {
            frmzutaten = this;
            InitializeComponent();
        }

        private void frmZutaten_Load(object sender, EventArgs e)
        {
            if (frmZutaten.frmzutaten.Text.Equals("Zutat bearbeiten"))
        {

                int i = frmZutatenliste.frmzutatenliste.inde;
                txtMenge.Text = frmZutatenliste.frmzutatenliste.zutatenListe[i].Menge.ToString();
                txtEinheit.Text = frmZutatenliste.frmzutatenliste.zutatenListe[i].Einheit;
                txtBezeichnung.Text = frmZutatenliste.frmzutatenliste.zutatenListe[i].Bezeichnung;
                txtAllergene.Text = frmZutatenliste.frmzutatenliste.zutatenListe[i].Allergene;
            }
            
        }

        private void btnSpeichern_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.Text.Equals("Zutat hinzufügen"))
                {
                    Zutat z = new Zutat(Convert.ToInt32(txtMenge.Text), txtEinheit.Text, txtBezeichnung.Text, txtAllergene.Text);
                    frmZutatenliste.frmzutatenliste.zutatenListe.Add(z);
                    txtMenge.Clear();
                    txtEinheit.Clear();
                    txtBezeichnung.Clear();
                    txtAllergene.Clear();
                    this.Close();
                }
                if (this.Text.Equals("Zutat bearbeiten"))
                {
                    int i = frmZutatenliste.frmzutatenliste.inde;
                    frmZutatenliste.frmzutatenliste.zutatenListe[i].Menge = Convert.ToInt32(txtMenge.Text);
                    frmZutatenliste.frmzutatenliste.zutatenListe[i].Einheit = txtEinheit.Text;
                    frmZutatenliste.frmzutatenliste.zutatenListe[i].Bezeichnung = txtBezeichnung.Text;
                    frmZutatenliste.frmzutatenliste.zutatenListe[i].Allergene = txtAllergene.Text;

                    this.Close();
                }
            }
            catch
            {
                MessageBox.Show("Es muss alles ausgefüllt werden!");
            }

            frmZutatenliste.frmzutatenliste.einlesenZutatenliste();
        }

        private void btnAbbrechen_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
