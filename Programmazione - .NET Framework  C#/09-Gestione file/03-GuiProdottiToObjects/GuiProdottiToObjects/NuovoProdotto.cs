using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuiProdottiToObjects
{
    public partial class NuovoProdotto : Form
    {
        string path = @"c:\files\prodotti.dat";

        public NuovoProdotto()
        {
            InitializeComponent();
        }

        private void btnSalva_Click(object sender, EventArgs e)
        {
            int codice = Convert.ToInt32(txtCodice.Text);
            string nome = txtNome.Text;
            string descrizione = txtDescrizione.Text;
            double prezzo = Convert.ToDouble(txtPrezzo.Text);
            int giacenza = Convert.ToInt32(txtGiacenza.Text);

            if (giacenza < 0) {
                MessageBox.Show(this, "La giacenza non può essere un numero negativo", "Messaggio", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var p = new Prodotto { Codice = codice, Nome = nome, Descrizione = descrizione, Prezzo = prezzo, Giacenza = giacenza };

            List<Prodotto> lista = MyLibrary.LeggiOggetti(path);
            lista.Add(p);
            MyLibrary.ScriviOggetti(path, lista);

            MessageBox.Show(this, p.ToString(), "Messaggio", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
