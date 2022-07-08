
namespace GuiAnagraficaStudenti
{
    partial class VisualizzaElencoClasse
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCerca = new System.Windows.Forms.Button();
            this.txtCercaClasse = new System.Windows.Forms.TextBox();
            this.lblCercaMatricola = new System.Windows.Forms.Label();
            this.lblNumeroStudenti = new System.Windows.Forms.Label();
            this.txtElenco = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCerca);
            this.panel1.Controls.Add(this.txtCercaClasse);
            this.panel1.Controls.Add(this.lblCercaMatricola);
            this.panel1.Location = new System.Drawing.Point(58, 42);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(359, 108);
            this.panel1.TabIndex = 1;
            // 
            // btnCerca
            // 
            this.btnCerca.Location = new System.Drawing.Point(258, 43);
            this.btnCerca.Name = "btnCerca";
            this.btnCerca.Size = new System.Drawing.Size(75, 23);
            this.btnCerca.TabIndex = 2;
            this.btnCerca.Text = "Cerca";
            this.btnCerca.UseVisualStyleBackColor = true;
            this.btnCerca.Click += new System.EventHandler(this.btnCerca_Click);
            // 
            // txtCercaClasse
            // 
            this.txtCercaClasse.Location = new System.Drawing.Point(131, 45);
            this.txtCercaClasse.Name = "txtCercaClasse";
            this.txtCercaClasse.Size = new System.Drawing.Size(100, 20);
            this.txtCercaClasse.TabIndex = 1;
            // 
            // lblCercaMatricola
            // 
            this.lblCercaMatricola.AutoSize = true;
            this.lblCercaMatricola.Location = new System.Drawing.Point(35, 45);
            this.lblCercaMatricola.Name = "lblCercaMatricola";
            this.lblCercaMatricola.Size = new System.Drawing.Size(79, 13);
            this.lblCercaMatricola.TabIndex = 0;
            this.lblCercaMatricola.Text = "Inserisci Classe";
            // 
            // lblNumeroStudenti
            // 
            this.lblNumeroStudenti.AutoSize = true;
            this.lblNumeroStudenti.Location = new System.Drawing.Point(62, 172);
            this.lblNumeroStudenti.Name = "lblNumeroStudenti";
            this.lblNumeroStudenti.Size = new System.Drawing.Size(135, 13);
            this.lblNumeroStudenti.TabIndex = 4;
            this.lblNumeroStudenti.Text = "Numero di elementi trovati: ";
            // 
            // txtElenco
            // 
            this.txtElenco.Location = new System.Drawing.Point(58, 188);
            this.txtElenco.Multiline = true;
            this.txtElenco.Name = "txtElenco";
            this.txtElenco.ReadOnly = true;
            this.txtElenco.Size = new System.Drawing.Size(664, 384);
            this.txtElenco.TabIndex = 3;
            // 
            // VisualizzaElencoClasse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 630);
            this.Controls.Add(this.lblNumeroStudenti);
            this.Controls.Add(this.txtElenco);
            this.Controls.Add(this.panel1);
            this.Name = "VisualizzaElencoClasse";
            this.Text = "VisualizzaElencoClasse";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCerca;
        private System.Windows.Forms.TextBox txtCercaClasse;
        private System.Windows.Forms.Label lblCercaMatricola;
        private System.Windows.Forms.Label lblNumeroStudenti;
        private System.Windows.Forms.TextBox txtElenco;
    }
}