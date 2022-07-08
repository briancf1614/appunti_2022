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
    public partial class EliminaStudente : Form
    {
        private Studente studente;
        private StudentiBiz biz;

        public EliminaStudente()
        {
            InitializeComponent();

            biz = new StudentiBiz();
        }

        private void btnCerca_Click(object sender, EventArgs e)
        {
            int matricola = Convert.ToInt32(txtCercaMatricola.Text);

            studente = biz.CercaPerMatricola(matricola);

            if (studente is null)
            {
                MessageBox.Show("Studente non trovato");
            }
            else
            {
                txtMatricola.Text = studente.Matricola.ToString();
                txtNome.Text = studente.Nome;
                txtCognome.Text = studente.Cognome;
                txtEmail.Text = studente.Email;
                txtClasse.Text = studente.Classe;
            }
        }

        private void btnSalva_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Eliminare lo studente scelto?", "Elimina studente", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (result == DialogResult.Yes)
            {
                if (biz.Elimina(studente))
                {
                    biz.SalvaTuttoEChiudi();
                    MessageBox.Show("Operazione eseguita con successo", "Elimina studente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Operazione fallita", "Elimina studente", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
