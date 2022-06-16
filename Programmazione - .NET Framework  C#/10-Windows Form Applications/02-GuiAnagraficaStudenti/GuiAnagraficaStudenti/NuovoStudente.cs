using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuiAnagraficaStudenti
{
    public partial class NuovoStudente : Form
    {
        string path = @"C:\files\Studenti.csv";
        public NuovoStudente()
        {
            InitializeComponent();
        }

        private void btnSalva_Click(object sender, EventArgs e)
        {
            var biz = new StudentiBiz();

            var s = new Studente
            {
                Matricola = Convert.ToInt32(txtMatricola.Text),
                Nome = txtNome.Text,
                Cognome = txtCognome.Text,
                Email = txtEmail.Text,
                Classe = txtClasse.Text
            };

            biz.Nuovo(s);

            biz.SalvaTuttoEChiudi();
            MessageBox.Show(this, "Operazione riuscita correttamente"
                , "Messaggio", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnCancella_Click(object sender, EventArgs e)
        {

        }
    }
}
