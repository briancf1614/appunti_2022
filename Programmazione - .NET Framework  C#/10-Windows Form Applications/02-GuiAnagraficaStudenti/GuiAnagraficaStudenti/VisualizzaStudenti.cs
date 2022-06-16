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
    public partial class VisualizzaStudenti : Form
    {
        private StudentiBiz biz;

        public VisualizzaStudenti()
        {
            InitializeComponent();

            biz = new StudentiBiz();
            lblNumeroStudenti.Text = "Numero di studenti trovati: " + biz.Elenco.Count;
            txtElenco.Text = string.Join("\n",biz.Elenco);
        }
    }
}
