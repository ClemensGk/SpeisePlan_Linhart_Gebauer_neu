using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace SpeisePlan_Linhart_Gebauer
{
    public partial class frmZutatenliste : Form
    {
        internal static frmZutatenliste frmzutatenliste;
        public frmZutatenliste()
        {
            frmzutatenliste = this;
            InitializeComponent();
        }

       internal ListViewItem lvItemZ;
        internal List<Zutat> zutatenListe = new List<Zutat>();
        internal int inde;
        internal XmlSerializer serializerZutaten;


        private void frmZutatenliste_Load(object sender, EventArgs e)
        {
            listView1.FullRowSelect = true;

            zutatenListe = new List<Zutat>();

            //zutatenListe.Add(new Zutat(3, "Stück", "mehl", "c"));

            deserialisierenZutaten();
            einlesenZutatenliste();
        }

        #region Speichern

        internal void serialisierenZutaten()
        {
            try
            {
                serializerZutaten = new XmlSerializer(zutatenListe.GetType());
                FileStream fs = new FileStream(Application.StartupPath + "\\../../../Zutatenliste.xml", FileMode.Create, FileAccess.Write, FileShare.None);
                serializerZutaten.Serialize(fs, zutatenListe);
                fs.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fehler beim Serialisierender der Zutaten: " + ex.Message);
            }

        }

        internal void deserialisierenZutaten()
        {
            try
            {
                serializerZutaten = new XmlSerializer(zutatenListe.GetType());
                FileStream fs = new FileStream(Application.StartupPath + "\\../../../Zutatenliste.xml", FileMode.Open, FileAccess.Read, FileShare.None);
                zutatenListe = (List<Zutat>)serializerZutaten.Deserialize(fs);
                fs.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fehler beim Deserialisierender der Zutaten: " + ex.Message);
            }
        }

        #endregion

        public void einlesenZutatenliste()
        {
            listView1.Items.Clear();
            foreach (Zutat z in zutatenListe)
            {

                lvItemZ = new ListViewItem(z.Menge.ToString()); ;
                lvItemZ.SubItems.Add(z.Einheit);
                lvItemZ.SubItems.Add(z.Bezeichnung);
                lvItemZ.SubItems.Add(z.Allergene);
                listView1.Items.Add(lvItemZ);

            }
            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void zutatHinzufügenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmZutaten frmzutaten = new frmZutaten();
            frmzutaten.Text = "Zutat hinzufügen";
            frmzutaten.ShowDialog();
            einlesenZutatenliste();
        }

        private void zutatBearbeitenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Keine Zutat ausgewählt!");
                return;
            }
            lvItemZ = listView1.SelectedItems[0];
            inde = lvItemZ.Index;
            frmZutaten frmzutaten = new frmZutaten();
            frmzutaten.Text = "Zutat bearbeiten";
            frmzutaten.ShowDialog();
            einlesenZutatenliste();
        }


        private void zutatLöschenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Keine Zutat ausgewählt!");
                return;
            }
            lvItemZ = listView1.SelectedItems[0];
            inde = lvItemZ.Index;
            try
            {
                DialogResult dr =
                  MessageBox.Show("Wollen Sie diese Zutat wirklich löschen?", "Achtung!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dr == DialogResult.Yes)
                {
                    zutatenListe.RemoveAt(inde);

                    einlesenZutatenliste();
                }

            }
            catch
            {
                MessageBox.Show("Keine Zutat ausgewählt!");
            }
        }

        private void frmZutatenliste_FormClosing(object sender, FormClosingEventArgs e)
        {
            serialisierenZutaten();
        }

        private void zutatEinerSpeiseHinzufügenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Bitte wählen Sie eine Zutat aus!", "Achtung!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;

            }

            if(Form1.f1.listView2.SelectedItems.Count == 0)
            {
                MessageBox.Show("Es muss eine Speise vorher ausgewählt sein!", "Achtung!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            
                lvItemZ = listView1.SelectedItems[0];
                foreach (Zutat z in zutatenListe)
                {

                    if (z.Bezeichnung == lvItemZ.SubItems[2].Text)
                    {
                        bool gefunden = false;
                        if (Form1.f1.speiseaktuell.ZutatenListe != null)
                        {
                            foreach (Zutat zu in Form1.f1.speiseaktuell.ZutatenListe)
                            {
                                if (zu.Bezeichnung == z.Bezeichnung)
                                    gefunden = true;
                            }
                        }
                        if (gefunden)
                        {
                            MessageBox.Show("Diese Zutat ist breits in dieser Speise vorhanden!", "Achtung!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            break;
                        }
                        else
                        {
                            Form1.f1.speiseaktuell.ZutatenListe.Add(z); 
                            einlesenSpeiseZutat();
                            break;
                        }
                    }
                this.Close();

                }
            
            
        }

       internal void einlesenSpeiseZutat()
        {

            Form1.f1.listView1.Items.Clear();

            foreach (Zutat t in Form1.f1.speiseaktuell.ZutatenListe)
            {
                lvItemZ = new ListViewItem(t.Menge.ToString());
                lvItemZ.SubItems.Add(t.Einheit);
                lvItemZ.SubItems.Add(t.Bezeichnung);
                lvItemZ.SubItems.Add(t.Allergene);
                

                Form1.f1.listView1.Items.Add(lvItemZ);
            }
            Form1.f1.listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            Form1.f1.listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);


        }

    }
}
