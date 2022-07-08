
namespace Gui
{
    partial class Finestra
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTiolo = new System.Windows.Forms.Label();
            this.lblTesto = new System.Windows.Forms.Label();
            this.txtTesto = new System.Windows.Forms.TextBox();
            this.btnInvia = new System.Windows.Forms.Button();
            this.lblRisultato = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTiolo
            // 
            this.lblTiolo.AutoSize = true;
            this.lblTiolo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTiolo.ForeColor = System.Drawing.Color.Fuchsia;
            this.lblTiolo.Location = new System.Drawing.Point(326, 9);
            this.lblTiolo.Name = "lblTiolo";
            this.lblTiolo.Size = new System.Drawing.Size(137, 18);
            this.lblTiolo.TabIndex = 0;
            this.lblTiolo.Text = "Titolo della finestra";
            // 
            // lblTesto
            // 
            this.lblTesto.AutoSize = true;
            this.lblTesto.Location = new System.Drawing.Point(32, 73);
            this.lblTesto.Name = "lblTesto";
            this.lblTesto.Size = new System.Drawing.Size(86, 13);
            this.lblTesto.TabIndex = 1;
            this.lblTesto.Text = "Inserisci un testo";
            // 
            // txtTesto
            // 
            this.txtTesto.Location = new System.Drawing.Point(124, 70);
            this.txtTesto.Name = "txtTesto";
            this.txtTesto.Size = new System.Drawing.Size(310, 20);
            this.txtTesto.TabIndex = 2;
            // 
            // btnInvia
            // 
            this.btnInvia.Location = new System.Drawing.Point(440, 70);
            this.btnInvia.Name = "btnInvia";
            this.btnInvia.Size = new System.Drawing.Size(75, 23);
            this.btnInvia.TabIndex = 3;
            this.btnInvia.Text = "Invia";
            this.btnInvia.UseVisualStyleBackColor = true;
            this.btnInvia.Click += new System.EventHandler(this.btnInvia_Click);
            // 
            // lblRisultato
            // 
            this.lblRisultato.AutoSize = true;
            this.lblRisultato.Location = new System.Drawing.Point(121, 165);
            this.lblRisultato.Name = "lblRisultato";
            this.lblRisultato.Size = new System.Drawing.Size(0, 13);
            this.lblRisultato.TabIndex = 4;
            // 
            // Finestra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 450);
            this.Controls.Add(this.lblRisultato);
            this.Controls.Add(this.btnInvia);
            this.Controls.Add(this.txtTesto);
            this.Controls.Add(this.lblTesto);
            this.Controls.Add(this.lblTiolo);
            this.Name = "Finestra";
            this.Text = "Finestra";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTiolo;
        private System.Windows.Forms.Label lblTesto;
        private System.Windows.Forms.TextBox txtTesto;
        private System.Windows.Forms.Button btnInvia;
        private System.Windows.Forms.Label lblRisultato;
    }
}

