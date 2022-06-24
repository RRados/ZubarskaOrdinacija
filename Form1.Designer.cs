
using System;
using System.Windows.Forms;

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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.OsveziToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ObrisiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_Pregledi = new System.Windows.Forms.Button();
            this.btn_Zakazi = new System.Windows.Forms.Button();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.noviToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lekarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pacijentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uputstvoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oAplikacijiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txt_Bx_Pretraga = new System.Windows.Forms.TextBox();
            this.btn_Pretraga = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.contextMenuStrip.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AllowUserToResizeColumns = false;
            this.dataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView.ContextMenuStrip = this.contextMenuStrip;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.Location = new System.Drawing.Point(0, 24);
            this.dataGridView.MultiSelect = false;
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(684, 372);
            this.dataGridView.TabIndex = 0;
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OsveziToolStripMenuItem,
            this.ObrisiToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.contextMenuStrip.Size = new System.Drawing.Size(115, 56);
            this.contextMenuStrip.Text = "Obrisi";
            // 
            // OsveziToolStripMenuItem
            // 
            this.OsveziToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.OsveziToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("OsveziToolStripMenuItem.Image")));
            this.OsveziToolStripMenuItem.Name = "OsveziToolStripMenuItem";
            this.OsveziToolStripMenuItem.Size = new System.Drawing.Size(114, 26);
            this.OsveziToolStripMenuItem.Text = "Osvezi";
            this.OsveziToolStripMenuItem.Click += new System.EventHandler(this.OsveziToolStripMenuItem_Click);
            // 
            // ObrisiToolStripMenuItem
            // 
            this.ObrisiToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ObrisiToolStripMenuItem.Image")));
            this.ObrisiToolStripMenuItem.Name = "ObrisiToolStripMenuItem";
            this.ObrisiToolStripMenuItem.Size = new System.Drawing.Size(114, 26);
            this.ObrisiToolStripMenuItem.Text = "Obrisi";
            this.ObrisiToolStripMenuItem.Click += new System.EventHandler(this.ObrisiToolStripMenuItem_Click);
            // 
            // btn_Pregledi
            // 
            this.btn_Pregledi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_Pregledi.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_Pregledi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_Pregledi.Location = new System.Drawing.Point(14, 331);
            this.btn_Pregledi.Name = "btn_Pregledi";
            this.btn_Pregledi.Size = new System.Drawing.Size(120, 32);
            this.btn_Pregledi.TabIndex = 1;
            this.btn_Pregledi.Text = "Pregledi";
            this.btn_Pregledi.UseVisualStyleBackColor = true;
            // 
            // btn_Zakazi
            // 
            this.btn_Zakazi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_Zakazi.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_Zakazi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_Zakazi.Location = new System.Drawing.Point(170, 331);
            this.btn_Zakazi.Name = "btn_Zakazi";
            this.btn_Zakazi.Size = new System.Drawing.Size(115, 32);
            this.btn_Zakazi.TabIndex = 2;
            this.btn_Zakazi.Text = "Zakazivanje";
            this.btn_Zakazi.UseVisualStyleBackColor = true;
            // 
            // menuStrip
            // 
            this.menuStrip.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip.Size = new System.Drawing.Size(684, 24);
            this.menuStrip.TabIndex = 3;
            this.menuStrip.Text = "menuStrip1";
            // 
            // toolStripMenuItem
            // 
            this.toolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.noviToolStripMenuItem});
            this.toolStripMenuItem.Name = "toolStripMenuItem";
            this.toolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.toolStripMenuItem.Text = "Meni";
            // 
            // noviToolStripMenuItem
            // 
            this.noviToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lekarToolStripMenuItem,
            this.pacijentToolStripMenuItem});
            this.noviToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("noviToolStripMenuItem.Image")));
            this.noviToolStripMenuItem.Name = "noviToolStripMenuItem";
            this.noviToolStripMenuItem.Size = new System.Drawing.Size(102, 26);
            this.noviToolStripMenuItem.Text = "Novi";
            // 
            // lekarToolStripMenuItem
            // 
            this.lekarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("lekarToolStripMenuItem.Image")));
            this.lekarToolStripMenuItem.Name = "lekarToolStripMenuItem";
            this.lekarToolStripMenuItem.Size = new System.Drawing.Size(122, 26);
            this.lekarToolStripMenuItem.Text = "Lekar";
            this.lekarToolStripMenuItem.Click += new System.EventHandler(this.lekarToolStripMenuItem_Click);
            // 
            // pacijentToolStripMenuItem
            // 
            this.pacijentToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("pacijentToolStripMenuItem.Image")));
            this.pacijentToolStripMenuItem.Name = "pacijentToolStripMenuItem";
            this.pacijentToolStripMenuItem.Size = new System.Drawing.Size(122, 26);
            this.pacijentToolStripMenuItem.Text = "Pacijent";
            this.pacijentToolStripMenuItem.Click += new System.EventHandler(this.pacijentToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uputstvoToolStripMenuItem,
            this.oAplikacijiToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.helpToolStripMenuItem.Text = "Pomoc";
            // 
            // uputstvoToolStripMenuItem
            // 
            this.uputstvoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("uputstvoToolStripMenuItem.Image")));
            this.uputstvoToolStripMenuItem.Name = "uputstvoToolStripMenuItem";
            this.uputstvoToolStripMenuItem.Size = new System.Drawing.Size(162, 26);
            this.uputstvoToolStripMenuItem.Text = "Uputstvo za rad";
            // 
            // oAplikacijiToolStripMenuItem
            // 
            this.oAplikacijiToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("oAplikacijiToolStripMenuItem.Image")));
            this.oAplikacijiToolStripMenuItem.Name = "oAplikacijiToolStripMenuItem";
            this.oAplikacijiToolStripMenuItem.Size = new System.Drawing.Size(162, 26);
            this.oAplikacijiToolStripMenuItem.Text = "O aplikaciji";
            // 
            // txt_Bx_Pretraga
            // 
            this.txt_Bx_Pretraga.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txt_Bx_Pretraga.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txt_Bx_Pretraga.Location = new System.Drawing.Point(355, 337);
            this.txt_Bx_Pretraga.Multiline = true;
            this.txt_Bx_Pretraga.Name = "txt_Bx_Pretraga";
            this.txt_Bx_Pretraga.Size = new System.Drawing.Size(136, 24);
            this.txt_Bx_Pretraga.TabIndex = 6;
            // 
            // btn_Pretraga
            // 
            this.btn_Pretraga.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_Pretraga.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_Pretraga.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btn_Pretraga.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btn_Pretraga.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_Pretraga.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_Pretraga.Location = new System.Drawing.Point(498, 331);
            this.btn_Pretraga.Name = "btn_Pretraga";
            this.btn_Pretraga.Size = new System.Drawing.Size(120, 32);
            this.btn_Pretraga.TabIndex = 8;
            this.btn_Pretraga.Tag = "P";
            this.btn_Pretraga.Text = "Pretraga";
            this.btn_Pretraga.UseVisualStyleBackColor = true;
            this.btn_Pretraga.Click += new System.EventHandler(this.Btn_Pretraga_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 396);
            this.Controls.Add(this.btn_Pretraga);
            this.Controls.Add(this.txt_Bx_Pretraga);
            this.Controls.Add(this.btn_Zakazi);
            this.Controls.Add(this.btn_Pregledi);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.menuStrip);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.MinimumSize = new System.Drawing.Size(700, 435);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Zubarska Ordinacija";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.contextMenuStrip.ResumeLayout(false);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button btn_Pregledi;
        private System.Windows.Forms.Button btn_Zakazi;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem noviToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lekarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pacijentToolStripMenuItem;
        private System.Windows.Forms.TextBox txt_Bx_Pretraga;
        private System.Windows.Forms.Button btn_Pretraga;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem OsveziToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ObrisiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uputstvoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oAplikacijiToolStripMenuItem;
    }
}

