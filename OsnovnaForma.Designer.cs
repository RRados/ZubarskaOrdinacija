
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
            this.pacijenti_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.noviPacijent_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lekariToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lekari_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.noviLekar_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.preglediToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sviPreglediToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zakazivanjaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prikaz_Svih_Zakazivanja_TsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zakazivanje_PregledaTsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uputstvoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oAplikacijiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prikazSvihToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.OsveziToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ObrisiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbl_InfoGrid = new System.Windows.Forms.Label();
            this.txtBx_pretraga = new System.Windows.Forms.TextBox();
            this.Btn_pretraga2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_ukupno = new System.Windows.Forms.Label();
            this.menuStrip_ordinacija.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
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
            this.pacijenti_ToolStripMenuItem,
            this.noviPacijent_ToolStripMenuItem});
            this.pacijentiToolStripMenuItem.Name = "pacijentiToolStripMenuItem";
            this.pacijentiToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.pacijentiToolStripMenuItem.Text = "Pacijenti";
            // 
            // pacijenti_ToolStripMenuItem
            // 
            this.pacijenti_ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("pacijenti_ToolStripMenuItem.Image")));
            this.pacijenti_ToolStripMenuItem.Name = "pacijenti_ToolStripMenuItem";
            this.pacijenti_ToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.pacijenti_ToolStripMenuItem.Text = "Pacijenti";
            this.pacijenti_ToolStripMenuItem.Click += new System.EventHandler(this.Osobe_TsMenuItem_Click);
            // 
            // noviPacijent_ToolStripMenuItem
            // 
            this.noviPacijent_ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("noviPacijent_ToolStripMenuItem.Image")));
            this.noviPacijent_ToolStripMenuItem.Name = "noviPacijent_ToolStripMenuItem";
            this.noviPacijent_ToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.noviPacijent_ToolStripMenuItem.Text = "Novi pacijent";
            this.noviPacijent_ToolStripMenuItem.Click += new System.EventHandler(this.Dodavanje_Novog_Pacijenta_MenuItem_Click);
            // 
            // lekariToolStripMenuItem
            // 
            this.lekariToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lekari_ToolStripMenuItem,
            this.noviLekar_ToolStripMenuItem});
            this.lekariToolStripMenuItem.Name = "lekariToolStripMenuItem";
            this.lekariToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.lekariToolStripMenuItem.Text = "Lekari";
            // 
            // lekari_ToolStripMenuItem
            // 
            this.lekari_ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("lekari_ToolStripMenuItem.Image")));
            this.lekari_ToolStripMenuItem.Name = "lekari_ToolStripMenuItem";
            this.lekari_ToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.lekari_ToolStripMenuItem.Text = "Lekari";
            this.lekari_ToolStripMenuItem.Click += new System.EventHandler(this.Osobe_TsMenuItem_Click);
            // 
            // noviLekar_ToolStripMenuItem
            // 
            this.noviLekar_ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("noviLekar_ToolStripMenuItem.Image")));
            this.noviLekar_ToolStripMenuItem.Name = "noviLekar_ToolStripMenuItem";
            this.noviLekar_ToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.noviLekar_ToolStripMenuItem.Text = "Novi lekar";
            this.noviLekar_ToolStripMenuItem.Click += new System.EventHandler(this.Dodavanje_Novog_Lekara_MenuItem_Click);
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
            this.sviPreglediToolStripMenuItem.Click += new System.EventHandler(this.SviPregledi_TsMenuItem_Click);
            // 
            // zakazivanjaToolStripMenuItem
            // 
            this.zakazivanjaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.prikaz_Svih_Zakazivanja_TsMenuItem,
            this.zakazivanje_PregledaTsMenuItem});
            this.zakazivanjaToolStripMenuItem.Name = "zakazivanjaToolStripMenuItem";
            this.zakazivanjaToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.zakazivanjaToolStripMenuItem.Text = "Zakazivanja";
            // 
            // prikaz_Svih_Zakazivanja_TsMenuItem
            // 
            this.prikaz_Svih_Zakazivanja_TsMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("prikaz_Svih_Zakazivanja_TsMenuItem.Image")));
            this.prikaz_Svih_Zakazivanja_TsMenuItem.Name = "prikaz_Svih_Zakazivanja_TsMenuItem";
            this.prikaz_Svih_Zakazivanja_TsMenuItem.Size = new System.Drawing.Size(139, 22);
            this.prikaz_Svih_Zakazivanja_TsMenuItem.Text = "Prikaz svih";
            this.prikaz_Svih_Zakazivanja_TsMenuItem.Click += new System.EventHandler(this.PrikazSvihZakazivanja_TsMenuItem_Click);
            // 
            // zakazivanje_PregledaTsMenuItem
            // 
            this.zakazivanje_PregledaTsMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("zakazivanje_PregledaTsMenuItem.Image")));
            this.zakazivanje_PregledaTsMenuItem.Name = "zakazivanje_PregledaTsMenuItem";
            this.zakazivanje_PregledaTsMenuItem.Size = new System.Drawing.Size(139, 22);
            this.zakazivanje_PregledaTsMenuItem.Text = "Zakazivanje";
            this.zakazivanje_PregledaTsMenuItem.Click += new System.EventHandler(this.Zakazivanje_Novog_Pregleda_TsMenuItem_Click);
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
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AllowUserToResizeColumns = false;
            this.dataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            this.dataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.ContextMenuStrip = this.contextMenuStrip;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView.Location = new System.Drawing.Point(14, 77);
            this.dataGridView.MultiSelect = false;
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(1030, 399);
            this.dataGridView.TabIndex = 6;
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
            this.OsveziToolStripMenuItem.Click += new System.EventHandler(this.Osvezi_TsMenuItem_Click);
            // 
            // ObrisiToolStripMenuItem
            // 
            this.ObrisiToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ObrisiToolStripMenuItem.Image")));
            this.ObrisiToolStripMenuItem.Name = "ObrisiToolStripMenuItem";
            this.ObrisiToolStripMenuItem.Size = new System.Drawing.Size(114, 26);
            this.ObrisiToolStripMenuItem.Text = "Obrisi";
            this.ObrisiToolStripMenuItem.Click += new System.EventHandler(this.Obrisi_TsMenuItem_Click);
            // 
            // lbl_InfoGrid
            // 
            this.lbl_InfoGrid.AutoSize = true;
            this.lbl_InfoGrid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_InfoGrid.Location = new System.Drawing.Point(15, 55);
            this.lbl_InfoGrid.Name = "lbl_InfoGrid";
            this.lbl_InfoGrid.Size = new System.Drawing.Size(145, 15);
            this.lbl_InfoGrid.TabIndex = 7;
            this.lbl_InfoGrid.Text = "Zakazivanja za danas";
            // 
            // txtBx_pretraga
            // 
            this.txtBx_pretraga.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBx_pretraga.Location = new System.Drawing.Point(792, 44);
            this.txtBx_pretraga.Multiline = true;
            this.txtBx_pretraga.Name = "txtBx_pretraga";
            this.txtBx_pretraga.Size = new System.Drawing.Size(135, 26);
            this.txtBx_pretraga.TabIndex = 8;
            // 
            // Btn_pretraga2
            // 
            this.Btn_pretraga2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_pretraga2.Location = new System.Drawing.Point(933, 40);
            this.Btn_pretraga2.Name = "Btn_pretraga2";
            this.Btn_pretraga2.Size = new System.Drawing.Size(111, 30);
            this.Btn_pretraga2.TabIndex = 9;
            this.Btn_pretraga2.Text = "Pretraga";
            this.Btn_pretraga2.UseVisualStyleBackColor = true;
            this.Btn_pretraga2.Click += new System.EventHandler(this.Btn_pretraga_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(15, 478);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "Ukupno: ";
            // 
            // lbl_ukupno
            // 
            this.lbl_ukupno.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_ukupno.AutoSize = true;
            this.lbl_ukupno.Location = new System.Drawing.Point(88, 478);
            this.lbl_ukupno.Name = "lbl_ukupno";
            this.lbl_ukupno.Size = new System.Drawing.Size(0, 15);
            this.lbl_ukupno.TabIndex = 11;
            // 
            // OsnovnaForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1058, 502);
            this.Controls.Add(this.lbl_ukupno);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Btn_pretraga2);
            this.Controls.Add(this.txtBx_pretraga);
            this.Controls.Add(this.lbl_InfoGrid);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.menuStrip_ordinacija);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip_ordinacija;
            this.MinimumSize = new System.Drawing.Size(1074, 541);
            this.Name = "OsnovnaForma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ordinacija";
            this.menuStrip_ordinacija.ResumeLayout(false);
            this.menuStrip_ordinacija.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
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
        private System.Windows.Forms.ToolStripMenuItem noviLekar_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem preglediToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zakazivanjaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sviPreglediToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prikaz_Svih_Zakazivanja_TsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zakazivanje_PregledaTsMenuItem;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label lbl_InfoGrid;
        private System.Windows.Forms.TextBox txtBx_pretraga;
        private System.Windows.Forms.Button Btn_pretraga2;
        private System.Windows.Forms.ToolStripMenuItem noviPacijent_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uputstvoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oAplikacijiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pacijenti_ToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem OsveziToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ObrisiToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_ukupno;
    }
}