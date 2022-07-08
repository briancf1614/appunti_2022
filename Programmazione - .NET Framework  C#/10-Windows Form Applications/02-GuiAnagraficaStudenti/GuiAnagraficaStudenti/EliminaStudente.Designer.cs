
namespace GuiAnagraficaStudenti
{
    partial class EliminaStudente
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
            this.btnCancella = new System.Windows.Forms.Button();
            this.btnSalva = new System.Windows.Forms.Button();
            this.txtClasse = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCognome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMatricola = new System.Windows.Forms.TextBox();
            this.lblMatricola = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCerca = new System.Windows.Forms.Button();
            this.txtCercaMatricola = new System.Windows.Forms.TextBox();
            this.lblCercaMatricola = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancella
            // 
            this.btnCancella.Location = new System.Drawing.Point(350, 537);
            this.btnCancella.Name = "btnCancella";
            this.btnCancella.Size = new System.Drawing.Size(75, 23);
            this.btnCancella.TabIndex = 37;
            this.btnCancella.Text = "Cancella";
            this.btnCancella.UseVisualStyleBackColor = true;
            // 
            // btnSalva
            // 
            this.btnSalva.Location = new System.Drawing.Point(247, 537);
            this.btnSalva.Name = "btnSalva";
            this.btnSalva.Size = new System.Drawing.Size(75, 23);
            this.btnSalva.TabIndex = 36;
            this.btnSalva.Text = "Salva";
            this.btnSalva.UseVisualStyleBackColor = true;
            this.btnSalva.Click += new System.EventHandler(this.btnSalva_Click);
            // 
            // txtClasse
            // 
            this.txtClasse.Location = new System.Drawing.Point(285, 454);
            this.txtClasse.Name = "txtClasse";
            this.txtClasse.ReadOnly = true;
            this.txtClasse.Size = new System.Drawing.Size(156, 20);
            this.txtClasse.TabIndex = 35;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(225, 457);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 34;
            this.label5.Text = "Classe";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(285, 390);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.ReadOnly = true;
            this.txtEmail.Size = new System.Drawing.Size(156, 20);
            this.txtEmail.TabIndex = 33;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(225, 393);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 32;
            this.label4.Text = "Email";
            // 
            // txtCognome
            // 
            this.txtCognome.Location = new System.Drawing.Point(285, 325);
            this.txtCognome.Name = "txtCognome";
            this.txtCognome.ReadOnly = true;
            this.txtCognome.Size = new System.Drawing.Size(156, 20);
            this.txtCognome.TabIndex = 31;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(225, 328);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "Cognome";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(285, 261);
            this.txtNome.Name = "txtNome";
            this.txtNome.ReadOnly = true;
            this.txtNome.Size = new System.Drawing.Size(156, 20);
            this.txtNome.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(225, 264);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Nome";
            // 
            // txtMatricola
            // 
            this.txtMatricola.Location = new System.Drawing.Point(285, 209);
            this.txtMatricola.Name = "txtMatricola";
            this.txtMatricola.ReadOnly = true;
            this.txtMatricola.Size = new System.Drawing.Size(156, 20);
            this.txtMatricola.TabIndex = 27;
            // 
            // lblMatricola
            // 
            this.lblMatricola.AutoSize = true;
            this.lblMatricola.Location = new System.Drawing.Point(225, 212);
            this.lblMatricola.Name = "lblMatricola";
            this.lblMatricola.Size = new System.Drawing.Size(50, 13);
            this.lblMatricola.TabIndex = 26;
            this.lblMatricola.Text = "Matricola";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCerca);
            this.panel1.Controls.Add(this.txtCercaMatricola);
            this.panel1.Controls.Add(this.lblCercaMatricola);
            this.panel1.Location = new System.Drawing.Point(221, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(359, 108);
            this.panel1.TabIndex = 25;
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
            // txtCercaMatricola
            // 
            this.txtCercaMatricola.Location = new System.Drawing.Point(131, 45);
            this.txtCercaMatricola.Name = "txtCercaMatricola";
            this.txtCercaMatricola.Size = new System.Drawing.Size(100, 20);
            this.txtCercaMatricola.TabIndex = 1;
            // 
            // lblCercaMatricola
            // 
            this.lblCercaMatricola.AutoSize = true;
            this.lblCercaMatricola.Location = new System.Drawing.Point(35, 45);
            this.lblCercaMatricola.Name = "lblCercaMatricola";
            this.lblCercaMatricola.Size = new System.Drawing.Size(90, 13);
            this.lblCercaMatricola.TabIndex = 0;
            this.lblCercaMatricola.Text = "Inserisci matricola";
            // 
            // EliminaStudente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 577);
            this.Controls.Add(this.btnCancella);
            this.Controls.Add(this.btnSalva);
            this.Controls.Add(this.txtClasse);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCognome);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMatricola);
            this.Controls.Add(this.lblMatricola);
            this.Controls.Add(this.panel1);
            this.Name = "EliminaStudente";
            this.Text = "EliminaStudente";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancella;
        private System.Windows.Forms.Button btnSalva;
        private System.Windows.Forms.TextBox txtClasse;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCognome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMatricola;
        private System.Windows.Forms.Label lblMatricola;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCerca;
        private System.Windows.Forms.TextBox txtCercaMatricola;
        private System.Windows.Forms.Label lblCercaMatricola;
    }
}