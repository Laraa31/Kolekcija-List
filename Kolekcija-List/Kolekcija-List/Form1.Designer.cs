namespace Kolekcija_List
{
    partial class Form1
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
            this.btnUnos = new System.Windows.Forms.Button();
            this.txtboxIme = new System.Windows.Forms.TextBox();
            this.txtBoxPrezime = new System.Windows.Forms.TextBox();
            this.comboBoxRazred = new System.Windows.Forms.ComboBox();
            this.lblIme = new System.Windows.Forms.Label();
            this.lblPrezime = new System.Windows.Forms.Label();
            this.lblRazred = new System.Windows.Forms.Label();
            this.btnPregled = new System.Windows.Forms.Button();
            this.btnObrada = new System.Windows.Forms.Button();
            this.rtBoxIspis = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnUnos
            // 
            this.btnUnos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnUnos.Location = new System.Drawing.Point(85, 155);
            this.btnUnos.Name = "btnUnos";
            this.btnUnos.Size = new System.Drawing.Size(146, 49);
            this.btnUnos.TabIndex = 0;
            this.btnUnos.Text = "Unos";
            this.btnUnos.UseVisualStyleBackColor = true;
            this.btnUnos.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtboxIme
            // 
            this.txtboxIme.Location = new System.Drawing.Point(133, 39);
            this.txtboxIme.Name = "txtboxIme";
            this.txtboxIme.Size = new System.Drawing.Size(121, 22);
            this.txtboxIme.TabIndex = 1;
            // 
            // txtBoxPrezime
            // 
            this.txtBoxPrezime.Location = new System.Drawing.Point(133, 81);
            this.txtBoxPrezime.Name = "txtBoxPrezime";
            this.txtBoxPrezime.Size = new System.Drawing.Size(121, 22);
            this.txtBoxPrezime.TabIndex = 2;
            // 
            // comboBoxRazred
            // 
            this.comboBoxRazred.FormattingEnabled = true;
            this.comboBoxRazred.Items.AddRange(new object[] {
            "1.",
            "2.",
            "3.",
            "4."});
            this.comboBoxRazred.Location = new System.Drawing.Point(133, 125);
            this.comboBoxRazred.Name = "comboBoxRazred";
            this.comboBoxRazred.Size = new System.Drawing.Size(121, 24);
            this.comboBoxRazred.TabIndex = 3;
            // 
            // lblIme
            // 
            this.lblIme.AutoSize = true;
            this.lblIme.Location = new System.Drawing.Point(39, 43);
            this.lblIme.Name = "lblIme";
            this.lblIme.Size = new System.Drawing.Size(32, 16);
            this.lblIme.TabIndex = 4;
            this.lblIme.Text = "Ime:";
            this.lblIme.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblPrezime
            // 
            this.lblPrezime.AutoSize = true;
            this.lblPrezime.Location = new System.Drawing.Point(37, 84);
            this.lblPrezime.Name = "lblPrezime";
            this.lblPrezime.Size = new System.Drawing.Size(59, 16);
            this.lblPrezime.TabIndex = 5;
            this.lblPrezime.Text = "Prezime:";
            // 
            // lblRazred
            // 
            this.lblRazred.AutoSize = true;
            this.lblRazred.Location = new System.Drawing.Point(42, 125);
            this.lblRazred.Name = "lblRazred";
            this.lblRazred.Size = new System.Drawing.Size(54, 16);
            this.lblRazred.TabIndex = 6;
            this.lblRazred.Text = "Razred:";
            // 
            // btnPregled
            // 
            this.btnPregled.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPregled.Location = new System.Drawing.Point(1, 211);
            this.btnPregled.Name = "btnPregled";
            this.btnPregled.Size = new System.Drawing.Size(137, 50);
            this.btnPregled.TabIndex = 7;
            this.btnPregled.Text = "Pregled";
            this.btnPregled.UseVisualStyleBackColor = true;
            this.btnPregled.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnObrada
            // 
            this.btnObrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnObrada.Location = new System.Drawing.Point(170, 210);
            this.btnObrada.Name = "btnObrada";
            this.btnObrada.Size = new System.Drawing.Size(123, 51);
            this.btnObrada.TabIndex = 8;
            this.btnObrada.Text = "Obrada";
            this.btnObrada.UseVisualStyleBackColor = true;
            this.btnObrada.Click += new System.EventHandler(this.btnObrada_Click);
            // 
            // rtBoxIspis
            // 
            this.rtBoxIspis.Location = new System.Drawing.Point(318, 39);
            this.rtBoxIspis.Name = "rtBoxIspis";
            this.rtBoxIspis.Size = new System.Drawing.Size(361, 222);
            this.rtBoxIspis.TabIndex = 9;
            this.rtBoxIspis.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 288);
            this.Controls.Add(this.rtBoxIspis);
            this.Controls.Add(this.btnObrada);
            this.Controls.Add(this.btnPregled);
            this.Controls.Add(this.lblRazred);
            this.Controls.Add(this.lblPrezime);
            this.Controls.Add(this.lblIme);
            this.Controls.Add(this.comboBoxRazred);
            this.Controls.Add(this.txtBoxPrezime);
            this.Controls.Add(this.txtboxIme);
            this.Controls.Add(this.btnUnos);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUnos;
        private System.Windows.Forms.TextBox txtboxIme;
        private System.Windows.Forms.TextBox txtBoxPrezime;
        private System.Windows.Forms.ComboBox comboBoxRazred;
        private System.Windows.Forms.Label lblIme;
        private System.Windows.Forms.Label lblPrezime;
        private System.Windows.Forms.Label lblRazred;
        private System.Windows.Forms.Button btnPregled;
        private System.Windows.Forms.Button btnObrada;
        private System.Windows.Forms.RichTextBox rtBoxIspis;
    }
}

