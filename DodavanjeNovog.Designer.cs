
namespace ZubarskaOrdinacija
{
    partial class DodavanjeNovog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DodavanjeNovog));
            this.label1 = new System.Windows.Forms.Label();
            this.txtBx_ime = new System.Windows.Forms.TextBox();
            this.btn_Sacuvaj = new System.Windows.Forms.Button();
            this.btn_Otkazi = new System.Windows.Forms.Button();
            this.txtBx_prezime = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBx_email = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.maskedTextBox_telefon = new System.Windows.Forms.MaskedTextBox();
            this.combo_grad = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ime";
            // 
            // txtBx_ime
            // 
            this.txtBx_ime.Location = new System.Drawing.Point(122, 52);
            this.txtBx_ime.Name = "txtBx_ime";
            this.txtBx_ime.Size = new System.Drawing.Size(139, 21);
            this.txtBx_ime.TabIndex = 1;
            // 
            // btn_Sacuvaj
            // 
            this.btn_Sacuvaj.Location = new System.Drawing.Point(36, 380);
            this.btn_Sacuvaj.Name = "btn_Sacuvaj";
            this.btn_Sacuvaj.Size = new System.Drawing.Size(111, 30);
            this.btn_Sacuvaj.TabIndex = 6;
            this.btn_Sacuvaj.Text = "Sacuvaj";
            this.btn_Sacuvaj.UseVisualStyleBackColor = true;
            this.btn_Sacuvaj.Click += new System.EventHandler(this.btn_Sacuvaj_Click);
            // 
            // btn_Otkazi
            // 
            this.btn_Otkazi.Location = new System.Drawing.Point(171, 380);
            this.btn_Otkazi.Name = "btn_Otkazi";
            this.btn_Otkazi.Size = new System.Drawing.Size(111, 30);
            this.btn_Otkazi.TabIndex = 7;
            this.btn_Otkazi.Text = "Otkazi";
            this.btn_Otkazi.UseVisualStyleBackColor = true;
            this.btn_Otkazi.Click += new System.EventHandler(this.btn_Otkazi_Click);
            // 
            // txtBx_prezime
            // 
            this.txtBx_prezime.Location = new System.Drawing.Point(122, 112);
            this.txtBx_prezime.Name = "txtBx_prezime";
            this.txtBx_prezime.Size = new System.Drawing.Size(139, 21);
            this.txtBx_prezime.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Prezime";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Telefon";
            // 
            // txtBx_email
            // 
            this.txtBx_email.Location = new System.Drawing.Point(122, 236);
            this.txtBx_email.Name = "txtBx_email";
            this.txtBx_email.Size = new System.Drawing.Size(139, 21);
            this.txtBx_email.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 239);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(49, 300);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Grad";
            // 
            // maskedTextBox_telefon
            // 
            this.maskedTextBox_telefon.Location = new System.Drawing.Point(122, 174);
            this.maskedTextBox_telefon.Name = "maskedTextBox_telefon";
            this.maskedTextBox_telefon.Size = new System.Drawing.Size(139, 21);
            this.maskedTextBox_telefon.TabIndex = 3;
            // 
            // combo_grad
            // 
            this.combo_grad.FormattingEnabled = true;
            this.combo_grad.ItemHeight = 15;
            this.combo_grad.Location = new System.Drawing.Point(122, 297);
            this.combo_grad.Name = "combo_grad";
            this.combo_grad.Size = new System.Drawing.Size(139, 23);
            this.combo_grad.TabIndex = 16;
            // 
            // DodavanjeNovog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 454);
            this.Controls.Add(this.combo_grad);
            this.Controls.Add(this.maskedTextBox_telefon);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtBx_email);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBx_prezime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_Otkazi);
            this.Controls.Add(this.btn_Sacuvaj);
            this.Controls.Add(this.txtBx_ime);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(343, 493);
            this.MinimumSize = new System.Drawing.Size(343, 493);
            this.Name = "DodavanjeNovog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DodavanjeNovog";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBx_ime;
        private System.Windows.Forms.Button btn_Sacuvaj;
        private System.Windows.Forms.Button btn_Otkazi;
        private System.Windows.Forms.TextBox txtBx_prezime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBx_email;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_telefon;
        private System.Windows.Forms.ComboBox combo_grad;
    }
}