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
    public partial class ModificaStudente : Form
    {
        private Studente studente;
        private StudentiBiz biz;

        public ModificaStudente()
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
                txtMatricola.Enabled = false;

                txtNome.Text = studente.Nome;
                txtCognome.Text = studente.Cognome;
                txtEmail.Text = studente.Email;
                txtClasse.Text = studente.Classe;
            }

        }

        private void btnSalva_Click(object sender, EventArgs e)
        {
            studente.Nome = txtNome.Text;
            studente.Cognome = txtCognome.Text;
            studente.Email = txtEmail.Text;
            studente.Classe = txtClasse.Text;

            biz.Modifica(studente);
            biz.SalvaTuttoEChiudi();
            MessageBox.Show("Studente modificato correttamente");
        }
    }
}
