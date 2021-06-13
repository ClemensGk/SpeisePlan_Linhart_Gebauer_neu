using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpeisePlan_Linhart_Gebauer
{
   
    public partial class frmWochenplan : Form
    {
        internal static frmWochenplan frmwochenplan;
       public frmWochenplan()
        {
            frmwochenplan = this;
            InitializeComponent();
        }

       List<String> Vorspeisen = new List<String>();
       List<String> Hauptspeisen = new List<String>();
        List<String> Nachspeisen = new List<String>();

        private void frmWochenplan_Load(object sender, EventArgs e)
        {
            //for (int i = 0; i < Form1.f1.speisenListe.Count(); i++)
            //{
            //    Random rnd = new Random();
            //    int r = rnd.Next(1, 13);

            //    if (r == Form1.f1.speisenListe[i].SpeiseID && Form1.f1.speisenListe[i].SpeiseID.Equals("V"))
            //    {

            //        txtMoVor.Text = Form1.f1.speisenListe[i].Name;

            //    }
            //}

            Random rnd = new Random();
            

            Vorspeisen.Clear();
            for (int i = 0; i < Form1.f1.speisenListe.Count; i++)
            {
                if (Form1.f1.speisenListe[i].Speiseart.ToString().Equals("V"))
                    Vorspeisen.Add(Form1.f1.speisenListe[i].Name);
            }
            Vorspeisen = Vorspeisen.OrderBy(name => rnd.Next()).ToList();

            Hauptspeisen.Clear();
            for (int i = 0; i < Form1.f1.speisenListe.Count; i++)
            {
                if (Form1.f1.speisenListe[i].Speiseart.ToString().Equals("H"))
                    Hauptspeisen.Add(Form1.f1.speisenListe[i].Name);
            }
            Hauptspeisen = Hauptspeisen.OrderBy(name => rnd.Next()).ToList();

            Nachspeisen.Clear();
            for (int i = 0; i < Form1.f1.speisenListe.Count; i++)
            {
                if (Form1.f1.speisenListe[i].Speiseart.ToString().Equals("N"))
                    Nachspeisen.Add(Form1.f1.speisenListe[i].Name);
            }
            Nachspeisen = Nachspeisen.OrderBy(name => rnd.Next()).ToList();

            txtMoVor.Text = Vorspeisen[0];
            txtDiVor.Text = Vorspeisen[1];
            txtMiVor.Text = Vorspeisen[2];
            txtDoVor.Text = Vorspeisen[3];
            txtFrVor.Text = Vorspeisen[4];

            txtMoHaupt.Text = Hauptspeisen[0];
            txtDiHaupt.Text = Hauptspeisen[1];
            txtMiHaupt.Text = Hauptspeisen[2];
            txtDoHaupt.Text = Hauptspeisen[3];
            txtFrHaupt.Text = Hauptspeisen[4];

            txtMoNach.Text = Nachspeisen[0];
            txtDiNach.Text = Nachspeisen[1];
            txtMiNach.Text = Nachspeisen[2];
            txtDoNach.Text = Nachspeisen[3];
            txtFrNach.Text = Nachspeisen[4];

        }

        private void btnAbbrechen_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnInWordDrucken_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Word.Application wordapp = new Microsoft.Office.Interop.Word.Application();
            if (wordapp == null)
            {
                MessageBox.Show("Es konnte keine Verbindung zu Word hergestellt werden!");
                return;
            }
            wordapp.Visible = true;
            wordapp.Documents.Open(Application.StartupPath + "\\../../../Wochenspeiseplan.docx");

            wordapp.ActiveDocument.FormFields["MoVor"].Result = txtMoVor.Text;
            wordapp.ActiveDocument.FormFields["DiVor"].Result = txtDiVor.Text;
            wordapp.ActiveDocument.FormFields["MiVor"].Result = txtMiVor.Text;
            wordapp.ActiveDocument.FormFields["DoVor"].Result = txtDoVor.Text;
            wordapp.ActiveDocument.FormFields["FrVor"].Result = txtFrVor.Text;

            wordapp.ActiveDocument.FormFields["MoHaupt"].Result = txtMoHaupt.Text;
            wordapp.ActiveDocument.FormFields["DiHaupt"].Result = txtDiHaupt.Text;
            wordapp.ActiveDocument.FormFields["MiHaupt"].Result = txtMiHaupt.Text;
            wordapp.ActiveDocument.FormFields["DoHaupt"].Result = txtDoHaupt.Text;
            wordapp.ActiveDocument.FormFields["FrHaupt"].Result = txtFrHaupt.Text;

            wordapp.ActiveDocument.FormFields["MoNach"].Result = txtMoNach.Text;
            wordapp.ActiveDocument.FormFields["DiNach"].Result = txtDiNach.Text;
            wordapp.ActiveDocument.FormFields["MiNach"].Result = txtMiNach.Text;
            wordapp.ActiveDocument.FormFields["DoNach"].Result = txtDoNach.Text;
            wordapp.ActiveDocument.FormFields["FrNach"].Result = txtFrNach.Text;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
