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
    }
}
