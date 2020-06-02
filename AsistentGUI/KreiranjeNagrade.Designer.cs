namespace AsistentGUI
{
    partial class KreiranjeNagrade
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
            this.lblOsvojenoMjesto = new System.Windows.Forms.Label();
            this.txtIznosNagrade = new System.Windows.Forms.TextBox();
            this.txtPostotakNagrade = new System.Windows.Forms.TextBox();
            this.txtOsvojenoMjesto = new System.Windows.Forms.TextBox();
            this.txtNazivNagrade = new System.Windows.Forms.TextBox();
            this.lblNazivNagrade = new System.Windows.Forms.Label();
            this.lblIznos = new System.Windows.Forms.Label();
            this.lblPostotakNagrade = new System.Windows.Forms.Label();
            this.lblIli = new System.Windows.Forms.Label();
            this.btnUnesiNagradu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblOsvojenoMjesto
            // 
            this.lblOsvojenoMjesto.AutoSize = true;
            this.lblOsvojenoMjesto.Location = new System.Drawing.Point(154, 51);
            this.lblOsvojenoMjesto.Name = "lblOsvojenoMjesto";
            this.lblOsvojenoMjesto.Size = new System.Drawing.Size(88, 13);
            this.lblOsvojenoMjesto.TabIndex = 0;
            this.lblOsvojenoMjesto.Text = "Osvojeno mjesto:";
            this.lblOsvojenoMjesto.Click += new System.EventHandler(this.lblOsvojenoMjesto_Click);
            // 
            // txtIznosNagrade
            // 
            this.txtIznosNagrade.Location = new System.Drawing.Point(248, 106);
            this.txtIznosNagrade.Name = "txtIznosNagrade";
            this.txtIznosNagrade.Size = new System.Drawing.Size(100, 20);
            this.txtIznosNagrade.TabIndex = 1;
            this.txtIznosNagrade.Text = "0";
            // 
            // txtPostotakNagrade
            // 
            this.txtPostotakNagrade.Location = new System.Drawing.Point(248, 170);
            this.txtPostotakNagrade.Name = "txtPostotakNagrade";
            this.txtPostotakNagrade.Size = new System.Drawing.Size(100, 20);
            this.txtPostotakNagrade.TabIndex = 2;
            this.txtPostotakNagrade.Text = "0";
            // 
            // txtOsvojenoMjesto
            // 
            this.txtOsvojenoMjesto.Location = new System.Drawing.Point(248, 51);
            this.txtOsvojenoMjesto.Name = "txtOsvojenoMjesto";
            this.txtOsvojenoMjesto.Size = new System.Drawing.Size(100, 20);
            this.txtOsvojenoMjesto.TabIndex = 3;
            this.txtOsvojenoMjesto.TextChanged += new System.EventHandler(this.txtOsvojenoMjesto_TextChanged);
            // 
            // txtNazivNagrade
            // 
            this.txtNazivNagrade.Location = new System.Drawing.Point(248, 77);
            this.txtNazivNagrade.Name = "txtNazivNagrade";
            this.txtNazivNagrade.Size = new System.Drawing.Size(100, 20);
            this.txtNazivNagrade.TabIndex = 4;
            // 
            // lblNazivNagrade
            // 
            this.lblNazivNagrade.AutoSize = true;
            this.lblNazivNagrade.Location = new System.Drawing.Point(154, 77);
            this.lblNazivNagrade.Name = "lblNazivNagrade";
            this.lblNazivNagrade.Size = new System.Drawing.Size(81, 13);
            this.lblNazivNagrade.TabIndex = 5;
            this.lblNazivNagrade.Text = "Naziv Nagrade:";
            this.lblNazivNagrade.Click += new System.EventHandler(this.lblNazivNagrade_Click);
            // 
            // lblIznos
            // 
            this.lblIznos.AutoSize = true;
            this.lblIznos.Location = new System.Drawing.Point(154, 106);
            this.lblIznos.Name = "lblIznos";
            this.lblIznos.Size = new System.Drawing.Size(76, 13);
            this.lblIznos.TabIndex = 6;
            this.lblIznos.Text = "IznosNagrade:";
            this.lblIznos.Click += new System.EventHandler(this.lblIznos_Click);
            // 
            // lblPostotakNagrade
            // 
            this.lblPostotakNagrade.AutoSize = true;
            this.lblPostotakNagrade.Location = new System.Drawing.Point(145, 173);
            this.lblPostotakNagrade.Name = "lblPostotakNagrade";
            this.lblPostotakNagrade.Size = new System.Drawing.Size(93, 13);
            this.lblPostotakNagrade.TabIndex = 7;
            this.lblPostotakNagrade.Text = "PostotakNagrade:";
            this.lblPostotakNagrade.Click += new System.EventHandler(this.lblPostotakNagrade_Click);
            // 
            // lblIli
            // 
            this.lblIli.AutoSize = true;
            this.lblIli.Location = new System.Drawing.Point(254, 143);
            this.lblIli.Name = "lblIli";
            this.lblIli.Size = new System.Drawing.Size(14, 13);
            this.lblIli.TabIndex = 8;
            this.lblIli.Text = "Ili";
            // 
            // btnUnesiNagradu
            // 
            this.btnUnesiNagradu.Location = new System.Drawing.Point(205, 216);
            this.btnUnesiNagradu.Name = "btnUnesiNagradu";
            this.btnUnesiNagradu.Size = new System.Drawing.Size(106, 23);
            this.btnUnesiNagradu.TabIndex = 9;
            this.btnUnesiNagradu.Text = "Unesi Nagradu";
            this.btnUnesiNagradu.UseVisualStyleBackColor = true;
            this.btnUnesiNagradu.Click += new System.EventHandler(this.btnUnesiNagradu_Click);
            // 
            // KreiranjeNagrade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnUnesiNagradu);
            this.Controls.Add(this.lblIli);
            this.Controls.Add(this.lblPostotakNagrade);
            this.Controls.Add(this.lblIznos);
            this.Controls.Add(this.lblNazivNagrade);
            this.Controls.Add(this.txtNazivNagrade);
            this.Controls.Add(this.txtOsvojenoMjesto);
            this.Controls.Add(this.txtPostotakNagrade);
            this.Controls.Add(this.txtIznosNagrade);
            this.Controls.Add(this.lblOsvojenoMjesto);
            this.Name = "KreiranjeNagrade";
            this.Text = "KreiranjeNagrade";
            this.Load += new System.EventHandler(this.KreiranjeNagrade_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOsvojenoMjesto;
        private System.Windows.Forms.TextBox txtIznosNagrade;
        private System.Windows.Forms.TextBox txtPostotakNagrade;
        private System.Windows.Forms.TextBox txtOsvojenoMjesto;
        private System.Windows.Forms.TextBox txtNazivNagrade;
        private System.Windows.Forms.Label lblNazivNagrade;
        private System.Windows.Forms.Label lblIznos;
        private System.Windows.Forms.Label lblPostotakNagrade;
        private System.Windows.Forms.Label lblIli;
        private System.Windows.Forms.Button btnUnesiNagradu;
    }
}