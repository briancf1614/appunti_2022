using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gui
{
    public partial class Finestra : Form
    {
        public Finestra()
        {
            InitializeComponent();
        }

        private void btnInvia_Click(object sender, EventArgs e)
        {
            string testo = "Hai inserito il seguente testo: " + txtTesto.Text;
            
            MessageBox.Show(this,testo,"Messaggio",MessageBoxButtons.OKCancel,MessageBoxIcon.Information);
            
            lblRisultato.Text = testo;


        }
    }
}
