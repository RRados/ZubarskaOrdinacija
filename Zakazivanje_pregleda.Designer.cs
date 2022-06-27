
namespace ZubarskaOrdinacija
{
    partial class Zakazivanje_pregleda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Zakazivanje_pregleda));
            this.Btn_Sacuvaj = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.combo_Lekar = new System.Windows.Forms.ComboBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBx_RazlogDolaska = new System.Windows.Forms.TextBox();
            this.Btn_Otkazi = new System.Windows.Forms.Button();
            this.combo_Pacijent = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // Btn_Sacuvaj
            // 
            this.Btn_Sacuvaj.Location = new System.Drawing.Point(12, 435);
            this.Btn_Sacuvaj.Name = "Btn_Sacuvaj";
            this.Btn_Sacuvaj.Size = new System.Drawing.Size(111, 30);
            this.Btn_Sacuvaj.TabIndex = 0;
            this.Btn_Sacuvaj.Text = "Sacuvaj";
            this.Btn_Sacuvaj.UseVisualStyleBackColor = true;
            this.Btn_Sacuvaj.Click += new System.EventHandler(this.Btn_Sacuvaj_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ime";
            // 
            // combo_Lekar
            // 
            this.combo_Lekar.FormattingEnabled = true;
            this.combo_Lekar.Location = new System.Drawing.Point(81, 126);
            this.combo_Lekar.Name = "combo_Lekar";
            this.combo_Lekar.Size = new System.Drawing.Size(162, 23);
            this.combo_Lekar.TabIndex = 3;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(27, 322);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(233, 21);
            this.dateTimePicker.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Lekar";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Razlog dolaska";
            // 
            // txtBx_RazlogDolaska
            // 
            this.txtBx_RazlogDolaska.Location = new System.Drawing.Point(12, 230);
            this.txtBx_RazlogDolaska.Multiline = true;
            this.txtBx_RazlogDolaska.Name = "txtBx_RazlogDolaska";
            this.txtBx_RazlogDolaska.Size = new System.Drawing.Size(269, 63);
            this.txtBx_RazlogDolaska.TabIndex = 8;
            // 
            // Btn_Otkazi
            // 
            this.Btn_Otkazi.Location = new System.Drawing.Point(170, 435);
            this.Btn_Otkazi.Name = "Btn_Otkazi";
            this.Btn_Otkazi.Size = new System.Drawing.Size(111, 30);
            this.Btn_Otkazi.TabIndex = 12;
            this.Btn_Otkazi.Text = "Otkazi";
            this.Btn_Otkazi.UseVisualStyleBackColor = true;
            this.Btn_Otkazi.Click += new System.EventHandler(this.Btn_Otkazi_Click);
            // 
            // combo_Pacijent
            // 
            this.combo_Pacijent.FormattingEnabled = true;
            this.combo_Pacijent.Location = new System.Drawing.Point(81, 57);
            this.combo_Pacijent.Name = "combo_Pacijent";
            this.combo_Pacijent.Size = new System.Drawing.Size(162, 23);
            this.combo_Pacijent.TabIndex = 13;
            // 
            // Zakazivanje_pregleda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 502);
            this.Controls.Add(this.combo_Pacijent);
            this.Controls.Add(this.Btn_Otkazi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtBx_RazlogDolaska);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.combo_Lekar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Btn_Sacuvaj);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(316, 541);
            this.MinimumSize = new System.Drawing.Size(316, 541);
            this.Name = "Zakazivanje_pregleda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Zakazivanje_pregleda";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Sacuvaj;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox combo_Lekar;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBx_RazlogDolaska;
        private System.Windows.Forms.Button Btn_Otkazi;
        private System.Windows.Forms.ComboBox combo_Pacijent;
    }
}