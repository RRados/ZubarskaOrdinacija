
namespace ZubarskaOrdinacija
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
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.btn_Rez = new System.Windows.Forms.Button();
            this.btn_Zakazi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(12, 12);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(373, 252);
            this.dataGridView.TabIndex = 0;
            // 
            // btn_Rez
            // 
            this.btn_Rez.Location = new System.Drawing.Point(12, 307);
            this.btn_Rez.Name = "btn_Rez";
            this.btn_Rez.Size = new System.Drawing.Size(103, 30);
            this.btn_Rez.TabIndex = 1;
            this.btn_Rez.Text = "Rezevacije";
            this.btn_Rez.UseVisualStyleBackColor = true;
            // 
            // btn_Zakazi
            // 
            this.btn_Zakazi.Location = new System.Drawing.Point(286, 307);
            this.btn_Zakazi.Name = "btn_Zakazi";
            this.btn_Zakazi.Size = new System.Drawing.Size(99, 30);
            this.btn_Zakazi.TabIndex = 2;
            this.btn_Zakazi.Text = "Zakazivanje";
            this.btn_Zakazi.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 369);
            this.Controls.Add(this.btn_Zakazi);
            this.Controls.Add(this.btn_Rez);
            this.Controls.Add(this.dataGridView);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Zubarska Ordinacija";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button btn_Rez;
        private System.Windows.Forms.Button btn_Zakazi;
    }
}

