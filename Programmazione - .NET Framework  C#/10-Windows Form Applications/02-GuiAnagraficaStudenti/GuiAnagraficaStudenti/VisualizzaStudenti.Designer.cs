
namespace GuiAnagraficaStudenti
{
    partial class VisualizzaStudenti
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitolo = new System.Windows.Forms.Label();
            this.txtElenco = new System.Windows.Forms.TextBox();
            this.lblNumeroStudenti = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitolo
            // 
            this.lblTitolo.AutoSize = true;
            this.lblTitolo.Location = new System.Drawing.Point(342, 11);
            this.lblTitolo.Name = "lblTitolo";
            this.lblTitolo.Size = new System.Drawing.Size(82, 13);
            this.lblTitolo.TabIndex = 0;
            this.lblTitolo.Text = "Elenco Studenti";
            // 
            // txtElenco
            // 
            this.txtElenco.Location = new System.Drawing.Point(49, 92);
            this.txtElenco.Multiline = true;
            this.txtElenco.Name = "txtElenco";
            this.txtElenco.ReadOnly = true;
            this.txtElenco.Size = new System.Drawing.Size(664, 446);
            this.txtElenco.TabIndex = 1;
            // 
            // lblNumeroStudenti
            // 
            this.lblNumeroStudenti.AutoSize = true;
            this.lblNumeroStudenti.Location = new System.Drawing.Point(53, 76);
            this.lblNumeroStudenti.Name = "lblNumeroStudenti";
            this.lblNumeroStudenti.Size = new System.Drawing.Size(135, 13);
            this.lblNumeroStudenti.TabIndex = 2;
            this.lblNumeroStudenti.Text = "Numero di elementi trovati: ";
            // 
            // VisualizzaStudenti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 616);
            this.Controls.Add(this.lblNumeroStudenti);
            this.Controls.Add(this.txtElenco);
            this.Controls.Add(this.lblTitolo);
            this.Name = "VisualizzaStudenti";
            this.Text = "VisualizzaStudenti";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitolo;
        private System.Windows.Forms.TextBox txtElenco;
        private System.Windows.Forms.Label lblNumeroStudenti;
    }
}