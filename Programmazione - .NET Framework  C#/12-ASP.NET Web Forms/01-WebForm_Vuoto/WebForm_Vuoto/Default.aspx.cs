using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebForm_Vuoto
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            hlk.BackColor = System.Drawing.Color.Tomato;
        }

        protected void btnInvia_Click(object sender, EventArgs e)
        {
            string testo = "Hai inserito: "+txtTesto.Text;

            lblRisultato.Text = testo;
        }
    }
}