
namespace ZubarskaOrdinacija
{
    partial class OsnovnaForma
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OsnovnaForma));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip_ordinacija = new System.Windows.Forms.MenuStrip();
            this.pacijentiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.noviPacijentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pacijenti_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lekariToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lekari_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodavanjeNovogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.preglediToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sviPreglediToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zakazivanjaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prikazSvihToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.dodavanjeNovogToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uputstvoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oAplikacijiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prikazSvihToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.OsveziToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ObrisiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBx_pretraga = new System.Windows.Forms.TextBox();
            this.Btn_pretraga2 = new System.Windows.Forms.Button();
            this.menuStrip_ordinacija.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip_ordinacija
            // 
            this.menuStrip_ordinacija.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.menuStrip_ordinacija.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pacijentiToolStripMenuItem,
            this.lekariToolStripMenuItem,
            this.preglediToolStripMenuItem,
            this.zakazivanjaToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip_ordinacija.Location = new System.Drawing.Point(0, 0);
            this.menuStrip_ordinacija.Name = "menuStrip_ordinacija";
            this.menuStrip_ordinacija.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip_ordinacija.Size = new System.Drawing.Size(1058, 24);
            this.menuStrip_ordinacija.TabIndex = 5;
            this.menuStrip_ordinacija.Text = "menuStrip1";
            // 
            // pacijentiToolStripMenuItem
            // 
            this.pacijentiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.noviPacijentToolStripMenuItem,
            this.pacijenti_ToolStripMenuItem});
            this.pacijentiToolStripMenuItem.Name = "pacijentiToolStripMenuItem";
            this.pacijentiToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.pacijentiToolStripMenuItem.Text = "Pacijenti";
            // 
            // noviPacijentToolStripMenuItem
            // 
            this.noviPacijentToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("noviPacijentToolStripMenuItem.Image")));
            this.noviPacijentToolStripMenuItem.Name = "noviPacijentToolStripMenuItem";
            this.noviPacijentToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.noviPacijentToolStripMenuItem.Text = "Novi pacijent";
            this.noviPacijentToolStripMenuItem.Click += new System.EventHandler(this.noviPacijentToolStripMenuItem_Click);
            // 
            // pacijenti_ToolStripMenuItem
            // 
            this.pacijenti_ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("pacijenti_ToolStripMenuItem.Image")));
            this.pacijenti_ToolStripMenuItem.Name = "pacijenti_ToolStripMenuItem";
            this.pacijenti_ToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.pacijenti_ToolStripMenuItem.Text = "Pacijenti";
            this.pacijenti_ToolStripMenuItem.Click += new System.EventHandler(this.osobe_ToolStripMenuItem_Click);
            // 
            // lekariToolStripMenuItem
            // 
            this.lekariToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lekari_ToolStripMenuItem,
            this.dodavanjeNovogToolStripMenuItem});
            this.lekariToolStripMenuItem.Name = "lekariToolStripMenuItem";
            this.lekariToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.lekariToolStripMenuItem.Text = "Lekari";
            // 
            // lekari_ToolStripMenuItem
            // 
            this.lekari_ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("lekari_ToolStripMenuItem.Image")));
            this.lekari_ToolStripMenuItem.Name = "lekari_ToolStripMenuItem";
            this.lekari_ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.lekari_ToolStripMenuItem.Text = "Lekari";
            this.lekari_ToolStripMenuItem.Click += new System.EventHandler(this.osobe_ToolStripMenuItem_Click);
            // 
            // dodavanjeNovogToolStripMenuItem
            // 
            this.dodavanjeNovogToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("dodavanjeNovogToolStripMenuItem.Image")));
            this.dodavanjeNovogToolStripMenuItem.Name = "dodavanjeNovogToolStripMenuItem";
            this.dodavanjeNovogToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.dodavanjeNovogToolStripMenuItem.Text = "Novi lekar";
            this.dodavanjeNovogToolStripMenuItem.Click += new System.EventHandler(this.dodavanjeNovogToolStripMenuItem_Click);
            // 
            // preglediToolStripMenuItem
            // 
            this.preglediToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sviPreglediToolStripMenuItem});
            this.preglediToolStripMenuItem.Name = "preglediToolStripMenuItem";
            this.preglediToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.preglediToolStripMenuItem.Text = "Pregledi";
            // 
            // sviPreglediToolStripMenuItem
            // 
            this.sviPreglediToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("sviPreglediToolStripMenuItem.Image")));
            this.sviPreglediToolStripMenuItem.Name = "sviPreglediToolStripMenuItem";
            this.sviPreglediToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.sviPreglediToolStripMenuItem.Text = "Svi pregledi";
            // 
            // zakazivanjaToolStripMenuItem
            // 
            this.zakazivanjaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.prikazSvihToolStripMenuItem1,
            this.dodavanjeNovogToolStripMenuItem1});
            this.zakazivanjaToolStripMenuItem.Name = "zakazivanjaToolStripMenuItem";
            this.zakazivanjaToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.zakazivanjaToolStripMenuItem.Text = "Zakazivanja";
            // 
            // prikazSvihToolStripMenuItem1
            // 
            this.prikazSvihToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("prikazSvihToolStripMenuItem1.Image")));
            this.prikazSvihToolStripMenuItem1.Name = "prikazSvihToolStripMenuItem1";
            this.prikazSvihToolStripMenuItem1.Size = new System.Drawing.Size(139, 22);
            this.prikazSvihToolStripMenuItem1.Text = "Prikaz svih";
            // 
            // dodavanjeNovogToolStripMenuItem1
            // 
            this.dodavanjeNovogToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("dodavanjeNovogToolStripMenuItem1.Image")));
            this.dodavanjeNovogToolStripMenuItem1.Name = "dodavanjeNovogToolStripMenuItem1";
            this.dodavanjeNovogToolStripMenuItem1.Size = new System.Drawing.Size(139, 22);
            this.dodavanjeNovogToolStripMenuItem1.Text = "Zakazivanje";
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
            this.uputstvoToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.uputstvoToolStripMenuItem.Text = "Uputstvo za rad";
            // 
            // oAplikacijiToolStripMenuItem
            // 
            this.oAplikacijiToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("oAplikacijiToolStripMenuItem.Image")));
            this.oAplikacijiToolStripMenuItem.Name = "oAplikacijiToolStripMenuItem";
            this.oAplikacijiToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.oAplikacijiToolStripMenuItem.Text = "O aplikaciji";
            // 
            // prikazSvihToolStripMenuItem
            // 
            this.prikazSvihToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("prikazSvihToolStripMenuItem.Image")));
            this.prikazSvihToolStripMenuItem.Name = "prikazSvihToolStripMenuItem";
            this.prikazSvihToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.prikazSvihToolStripMenuItem.Text = "Prikaz svih";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.Location = new System.Drawing.Point(14, 77);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1030, 361);
            this.dataGridView1.TabIndex = 6;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Zakazivanja za danas";
            // 
            // txtBx_pretraga
            // 
            this.txtBx_pretraga.Location = new System.Drawing.Point(811, 45);
            this.txtBx_pretraga.Multiline = true;
            this.txtBx_pretraga.Name = "txtBx_pretraga";
            this.txtBx_pretraga.Size = new System.Drawing.Size(116, 26);
            this.txtBx_pretraga.TabIndex = 8;
            // 
            // Btn_pretraga2
            // 
            this.Btn_pretraga2.Location = new System.Drawing.Point(933, 40);
            this.Btn_pretraga2.Name = "Btn_pretraga2";
            this.Btn_pretraga2.Size = new System.Drawing.Size(111, 30);
            this.Btn_pretraga2.TabIndex = 9;
            this.Btn_pretraga2.Text = "Pretraga";
            this.Btn_pretraga2.UseVisualStyleBackColor = true;
            this.Btn_pretraga2.Click += new System.EventHandler(this.Btn_pretraga_Click);
            // 
            // OsnovnaForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1058, 502);
            this.Controls.Add(this.Btn_pretraga2);
            this.Controls.Add(this.txtBx_pretraga);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip_ordinacija);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.MainMenuStrip = this.menuStrip_ordinacija;
            this.Name = "OsnovnaForma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ordinacija";
            this.menuStrip_ordinacija.ResumeLayout(false);
            this.menuStrip_ordinacija.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip_ordinacija;
        private System.Windows.Forms.ToolStripMenuItem pacijentiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prikazSvihToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lekariToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lekari_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodavanjeNovogToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem preglediToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zakazivanjaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sviPreglediToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prikazSvihToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem dodavanjeNovogToolStripMenuItem1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBx_pretraga;
        private System.Windows.Forms.Button Btn_pretraga2;
        private System.Windows.Forms.ToolStripMenuItem noviPacijentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uputstvoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oAplikacijiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pacijenti_ToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem OsveziToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ObrisiToolStripMenuItem;
    }
}