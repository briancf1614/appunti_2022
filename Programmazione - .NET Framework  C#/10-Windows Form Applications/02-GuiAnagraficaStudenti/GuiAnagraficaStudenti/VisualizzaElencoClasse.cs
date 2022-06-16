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
    public partial class VisualizzaElencoClasse : Form
    {
        private StudentiBiz biz;
        public VisualizzaElencoClasse()
        {
            InitializeComponent();
            biz = new StudentiBiz();
        }

        private void btnCerca_Click(object sender, EventArgs e)
        {
            string classe = txtCercaClasse.Text;

            List<Studente> lista = biz.ElencoPerClasse(classe);

            lblNumeroStudenti.Text = "Studenti trovati: " + lista.Count;
                
            if(lista.Count!=0)
            {
                txtElenco.Text = string.Join("\n", lista);
            }            
        }
    }
}
