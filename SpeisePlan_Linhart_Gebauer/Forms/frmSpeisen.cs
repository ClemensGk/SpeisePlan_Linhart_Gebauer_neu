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
    public partial class frmSpeisen : Form
    {
        internal static frmSpeisen frmspeisen;
        public frmSpeisen()
        {
            frmspeisen = this;
            InitializeComponent();
        }

        internal string bildpfad;

        private void frmSpeisen_Load(object sender, EventArgs e)
        {
            if (this.Text.Equals("Speise hinzufügen"))
            {
                bildpfad = Application.StartupPath + "\\img\\default.jpg";
                picBox.Image = Image.FromFile(bildpfad);
                txtBildpfad.Text = bildpfad;
            }
        }

        private void btnAbbrechen_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSpeichern_Click(object sender, EventArgs e)
        {
            try
            { 
            if (this.Text.Equals("Speise hinzufügen"))
            {
                Speise s = new Speise();
                s.SpeiseID = Convert.ToInt32(txtSpeiseID.Text);
                s.Name = txtName.Text;
                s.Preis = Convert.ToInt16(txtPreis.Text);
                s.Speiseart = Convert.ToChar(comboBox1.Text);   
                s.Bildpfad = txtBildpfad.Text;
                
                Form1.f1.speisenListe.Add(s);
            }
            else
            {
                foreach (Speise s in Form1.f1.speisenListe)
                {
                    if (s.SpeiseID == Convert.ToInt32(txtSpeiseID.Text))
                    {
                        s.SpeiseID = Convert.ToInt32(txtSpeiseID.Text);
                        s.Name = txtName.Text;
                        s.Preis = Convert.ToInt16(txtPreis.Text);
                        s.Speiseart = Convert.ToChar(comboBox1.Text);
                        s.Bildpfad = txtBildpfad.Text;
                        break;
                    }
                }
            }
        }
            catch
            {
                MessageBox.Show("Es muss alles ausgefüllt werden!");
                return;
            }
            this.Close();

        }

        private void picBox_DoubleClick(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            try
            {
                ofd.Filter = "Image File (*.jpg; *.jpeg; *.gif; *.bmp; *.png)|*.jpg; *jpeg; *.gif; *.bmp; *.png|All Files (*.*)|*.*";
                ofd.InitialDirectory = "C://Users//admin//Pictures";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    picBox.Image = new Bitmap(ofd.FileName);
                    bildpfad = ofd.FileName;
                    txtBildpfad.Text = bildpfad;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
