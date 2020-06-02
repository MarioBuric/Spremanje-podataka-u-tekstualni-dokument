namespace AsistentGUI
{
    partial class KreiranjeTima
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
            this.lblImeTima = new System.Windows.Forms.Label();
            this.lblDodajNovogIgraca = new System.Windows.Forms.Label();
            this.lblNoviIgrac = new System.Windows.Forms.Label();
            this.lblIme = new System.Windows.Forms.Label();
            this.lblPrezime = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblIgrac = new System.Windows.Forms.Label();
            this.txtImeTima = new System.Windows.Forms.TextBox();
            this.cmbNoviIgrac = new System.Windows.Forms.ComboBox();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblBrojTelefona = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnDodajIgrac = new System.Windows.Forms.Button();
            this.lstIgraca = new System.Windows.Forms.ListBox();
            this.btnIzbrisi = new System.Windows.Forms.Button();
            this.btnUredi = new System.Windows.Forms.Button();
            this.btnKreirajTim = new System.Windows.Forms.Button();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblImeTima
            // 
            this.lblImeTima.AutoSize = true;
            this.lblImeTima.Location = new System.Drawing.Point(140, 22);
            this.lblImeTima.Name = "lblImeTima";
            this.lblImeTima.Size = new System.Drawing.Size(53, 13);
            this.lblImeTima.TabIndex = 0;
            this.lblImeTima.Text = "Ime Tima:";
            this.lblImeTima.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblDodajNovogIgraca
            // 
            this.lblDodajNovogIgraca.AutoSize = true;
            this.lblDodajNovogIgraca.Location = new System.Drawing.Point(140, 53);
            this.lblDodajNovogIgraca.Name = "lblDodajNovogIgraca";
            this.lblDodajNovogIgraca.Size = new System.Drawing.Size(103, 13);
            this.lblDodajNovogIgraca.TabIndex = 1;
            this.lblDodajNovogIgraca.Text = "Dodaj novog igrača:";
            this.lblDodajNovogIgraca.Click += new System.EventHandler(this.lblDodajNovogIgraca_Click);
            // 
            // lblNoviIgrac
            // 
            this.lblNoviIgrac.AutoSize = true;
            this.lblNoviIgrac.Location = new System.Drawing.Point(130, 145);
            this.lblNoviIgrac.Name = "lblNoviIgrac";
            this.lblNoviIgrac.Size = new System.Drawing.Size(58, 13);
            this.lblNoviIgrac.TabIndex = 2;
            this.lblNoviIgrac.Text = "Novi igrač:";
            this.lblNoviIgrac.Click += new System.EventHandler(this.lblNoviIgrac_Click);
            // 
            // lblIme
            // 
            this.lblIme.AutoSize = true;
            this.lblIme.Location = new System.Drawing.Point(130, 181);
            this.lblIme.Name = "lblIme";
            this.lblIme.Size = new System.Drawing.Size(27, 13);
            this.lblIme.TabIndex = 3;
            this.lblIme.Text = "Ime:";
            this.lblIme.Click += new System.EventHandler(this.lblIme_Click);
            // 
            // lblPrezime
            // 
            this.lblPrezime.AutoSize = true;
            this.lblPrezime.Location = new System.Drawing.Point(130, 218);
            this.lblPrezime.Name = "lblPrezime";
            this.lblPrezime.Size = new System.Drawing.Size(47, 13);
            this.lblPrezime.TabIndex = 4;
            this.lblPrezime.Text = "Prezime:";
            this.lblPrezime.Click += new System.EventHandler(this.lblPrezime_Click);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(130, 252);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(35, 13);
            this.lblEmail.TabIndex = 5;
            this.lblEmail.Text = "Email:";
            // 
            // lblIgrac
            // 
            this.lblIgrac.AutoSize = true;
            this.lblIgrac.Location = new System.Drawing.Point(471, 123);
            this.lblIgrac.Name = "lblIgrac";
            this.lblIgrac.Size = new System.Drawing.Size(36, 13);
            this.lblIgrac.TabIndex = 6;
            this.lblIgrac.Text = "Igrači:";
            // 
            // txtImeTima
            // 
            this.txtImeTima.Location = new System.Drawing.Point(249, 19);
            this.txtImeTima.Name = "txtImeTima";
            this.txtImeTima.Size = new System.Drawing.Size(121, 20);
            this.txtImeTima.TabIndex = 7;
            this.txtImeTima.TextChanged += new System.EventHandler(this.txtImeTima_TextChanged);
            // 
            // cmbNoviIgrac
            // 
            this.cmbNoviIgrac.FormattingEnabled = true;
            this.cmbNoviIgrac.Location = new System.Drawing.Point(249, 50);
            this.cmbNoviIgrac.Name = "cmbNoviIgrac";
            this.cmbNoviIgrac.Size = new System.Drawing.Size(121, 21);
            this.cmbNoviIgrac.TabIndex = 9;
            this.cmbNoviIgrac.SelectedIndexChanged += new System.EventHandler(this.cmbNoviIgrac_SelectedIndexChanged);
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(206, 90);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(75, 23);
            this.btnDodaj.TabIndex = 10;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // txtPrezime
            // 
            this.txtPrezime.Location = new System.Drawing.Point(206, 211);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(100, 20);
            this.txtPrezime.TabIndex = 11;
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(206, 174);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(100, 20);
            this.txtIme.TabIndex = 12;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(206, 249);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(100, 20);
            this.txtEmail.TabIndex = 13;
            // 
            // lblBrojTelefona
            // 
            this.lblBrojTelefona.AutoSize = true;
            this.lblBrojTelefona.Location = new System.Drawing.Point(124, 291);
            this.lblBrojTelefona.Name = "lblBrojTelefona";
            this.lblBrojTelefona.Size = new System.Drawing.Size(69, 13);
            this.lblBrojTelefona.TabIndex = 14;
            this.lblBrojTelefona.Text = "Broj telefona:";
            this.lblBrojTelefona.Click += new System.EventHandler(this.lblBrojTelefona_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(206, 288);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 15;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnDodajIgrac
            // 
            this.btnDodajIgrac.Location = new System.Drawing.Point(188, 322);
            this.btnDodajIgrac.Name = "btnDodajIgrac";
            this.btnDodajIgrac.Size = new System.Drawing.Size(75, 23);
            this.btnDodajIgrac.TabIndex = 16;
            this.btnDodajIgrac.Text = "Dodaj";
            this.btnDodajIgrac.UseVisualStyleBackColor = true;
            this.btnDodajIgrac.Click += new System.EventHandler(this.btnDodajIgrac_Click);
            // 
            // lstIgraca
            // 
            this.lstIgraca.FormattingEnabled = true;
            this.lstIgraca.Location = new System.Drawing.Point(513, 123);
            this.lstIgraca.Name = "lstIgraca";
            this.lstIgraca.Size = new System.Drawing.Size(120, 95);
            this.lstIgraca.TabIndex = 17;
            // 
            // btnIzbrisi
            // 
            this.btnIzbrisi.Location = new System.Drawing.Point(673, 135);
            this.btnIzbrisi.Name = "btnIzbrisi";
            this.btnIzbrisi.Size = new System.Drawing.Size(75, 23);
            this.btnIzbrisi.TabIndex = 18;
            this.btnIzbrisi.Text = "Izbriši";
            this.btnIzbrisi.UseVisualStyleBackColor = true;
            // 
            // btnUredi
            // 
            this.btnUredi.Location = new System.Drawing.Point(673, 181);
            this.btnUredi.Name = "btnUredi";
            this.btnUredi.Size = new System.Drawing.Size(75, 23);
            this.btnUredi.TabIndex = 19;
            this.btnUredi.Text = "Uredi";
            this.btnUredi.UseVisualStyleBackColor = true;
            // 
            // btnKreirajTim
            // 
            this.btnKreirajTim.Location = new System.Drawing.Point(601, 252);
            this.btnKreirajTim.Name = "btnKreirajTim";
            this.btnKreirajTim.Size = new System.Drawing.Size(75, 23);
            this.btnKreirajTim.TabIndex = 20;
            this.btnKreirajTim.Text = "Kreiraj Tim";
            this.btnKreirajTim.UseVisualStyleBackColor = true;
            // 
            // btnOdustani
            // 
            this.btnOdustani.Location = new System.Drawing.Point(352, 371);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(75, 23);
            this.btnOdustani.TabIndex = 21;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            // 
            // KreiranjeTima
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.btnKreirajTim);
            this.Controls.Add(this.btnUredi);
            this.Controls.Add(this.btnIzbrisi);
            this.Controls.Add(this.lstIgraca);
            this.Controls.Add(this.btnDodajIgrac);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblBrojTelefona);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtIme);
            this.Controls.Add(this.txtPrezime);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.cmbNoviIgrac);
            this.Controls.Add(this.txtImeTima);
            this.Controls.Add(this.lblIgrac);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblPrezime);
            this.Controls.Add(this.lblIme);
            this.Controls.Add(this.lblNoviIgrac);
            this.Controls.Add(this.lblDodajNovogIgraca);
            this.Controls.Add(this.lblImeTima);
            this.Name = "KreiranjeTima";
            this.Text = "KreiranjeTima";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblImeTima;
        private System.Windows.Forms.Label lblDodajNovogIgraca;
        private System.Windows.Forms.Label lblNoviIgrac;
        private System.Windows.Forms.Label lblIme;
        private System.Windows.Forms.Label lblPrezime;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblIgrac;
        private System.Windows.Forms.TextBox txtImeTima;
        private System.Windows.Forms.ComboBox cmbNoviIgrac;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblBrojTelefona;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnDodajIgrac;
        private System.Windows.Forms.ListBox lstIgraca;
        private System.Windows.Forms.Button btnIzbrisi;
        private System.Windows.Forms.Button btnUredi;
        private System.Windows.Forms.Button btnKreirajTim;
        private System.Windows.Forms.Button btnOdustani;
    }
}