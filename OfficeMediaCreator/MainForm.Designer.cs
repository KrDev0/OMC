namespace OfficeMediaCreator
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnDownload = new System.Windows.Forms.Button();
            this.listViewArchivos = new System.Windows.Forms.ListView();
            this.cmbFilter = new System.Windows.Forms.ComboBox();
            this.txtFind = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.btnActivador = new System.Windows.Forms.Button();
            this.btnLang = new System.Windows.Forms.Button();
            this.mnuLang = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuEnglish = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSpanish = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAbout = new System.Windows.Forms.Button();
            this.tooltipInfo = new System.Windows.Forms.ToolTip(this.components);
            this.rdGeneral = new System.Windows.Forms.RadioButton();
            this.rd2019 = new System.Windows.Forms.RadioButton();
            this.rd2016 = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblWindows = new System.Windows.Forms.Label();
            this.lblMedia = new System.Windows.Forms.Label();
            this.lblCreator = new System.Windows.Forms.Label();
            this.lblFiltro = new System.Windows.Forms.Label();
            this.rd2021 = new System.Windows.Forms.RadioButton();
            this.rd2024 = new System.Windows.Forms.RadioButton();
            this.rd365 = new System.Windows.Forms.RadioButton();
            this.mnuLang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnCancel.Location = new System.Drawing.Point(70, 549);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "Close";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnDownload
            // 
            this.btnDownload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDownload.Enabled = false;
            this.btnDownload.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnDownload.Location = new System.Drawing.Point(466, 549);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(142, 23);
            this.btnDownload.TabIndex = 1;
            this.btnDownload.Text = "Download select";
            this.btnDownload.UseVisualStyleBackColor = true;
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // listViewArchivos
            // 
            this.listViewArchivos.Alignment = System.Windows.Forms.ListViewAlignment.Default;
            this.listViewArchivos.AllowColumnReorder = true;
            this.listViewArchivos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewArchivos.BackColor = System.Drawing.Color.White;
            this.listViewArchivos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listViewArchivos.CheckBoxes = true;
            this.listViewArchivos.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.listViewArchivos.GridLines = true;
            this.listViewArchivos.HideSelection = false;
            this.listViewArchivos.Location = new System.Drawing.Point(12, 70);
            this.listViewArchivos.MultiSelect = false;
            this.listViewArchivos.Name = "listViewArchivos";
            this.listViewArchivos.ShowGroups = false;
            this.listViewArchivos.ShowItemToolTips = true;
            this.listViewArchivos.Size = new System.Drawing.Size(596, 473);
            this.listViewArchivos.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listViewArchivos.TabIndex = 1;
            this.listViewArchivos.UseCompatibleStateImageBehavior = false;
            this.listViewArchivos.View = System.Windows.Forms.View.SmallIcon;
            this.listViewArchivos.ColumnWidthChanged += new System.Windows.Forms.ColumnWidthChangedEventHandler(this.listViewArchivos_ColumnWidthChanged);
            this.listViewArchivos.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.listViewArchivos_ItemCheck);
            // 
            // cmbFilter
            // 
            this.cmbFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFilter.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbFilter.FormattingEnabled = true;
            this.cmbFilter.Items.AddRange(new object[] {
            "Edition",
            "Size"});
            this.cmbFilter.Location = new System.Drawing.Point(521, 14);
            this.cmbFilter.Name = "cmbFilter";
            this.cmbFilter.Size = new System.Drawing.Size(87, 21);
            this.cmbFilter.TabIndex = 3;
            this.tooltipInfo.SetToolTip(this.cmbFilter, "Filter by");
            // 
            // txtFind
            // 
            this.txtFind.Location = new System.Drawing.Point(366, 14);
            this.txtFind.Name = "txtFind";
            this.txtFind.Size = new System.Drawing.Size(149, 20);
            this.txtFind.TabIndex = 4;
            this.txtFind.TextChanged += new System.EventHandler(this.txtFind_TextChanged);
            // 
            // lblSearch
            // 
            this.lblSearch.Location = new System.Drawing.Point(269, 17);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(91, 13);
            this.lblSearch.TabIndex = 5;
            this.lblSearch.Text = "Search by:";
            this.lblSearch.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnActivador
            // 
            this.btnActivador.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnActivador.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnActivador.Location = new System.Drawing.Point(326, 549);
            this.btnActivador.Name = "btnActivador";
            this.btnActivador.Size = new System.Drawing.Size(134, 23);
            this.btnActivador.TabIndex = 6;
            this.btnActivador.Text = "Microsoft Activador";
            this.btnActivador.UseVisualStyleBackColor = true;
            this.btnActivador.Visible = false;
            this.btnActivador.Click += new System.EventHandler(this.btnActivador_Click);
            // 
            // btnLang
            // 
            this.btnLang.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLang.ContextMenuStrip = this.mnuLang;
            this.btnLang.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnLang.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(240)))), ((int)(((byte)(250)))));
            this.btnLang.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(230)))), ((int)(((byte)(242)))));
            this.btnLang.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnLang.Font = new System.Drawing.Font("Segoe MDL2 Assets", 12F);
            this.btnLang.ForeColor = System.Drawing.Color.Blue;
            this.btnLang.Location = new System.Drawing.Point(12, 549);
            this.btnLang.Name = "btnLang";
            this.btnLang.Size = new System.Drawing.Size(23, 23);
            this.btnLang.TabIndex = 7;
            this.btnLang.Text = "";
            this.btnLang.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.tooltipInfo.SetToolTip(this.btnLang, "Language");
            this.btnLang.UseVisualStyleBackColor = true;
            this.btnLang.Click += new System.EventHandler(this.btnLang_Click);
            // 
            // mnuLang
            // 
            this.mnuLang.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuEnglish,
            this.mnuSpanish});
            this.mnuLang.Name = "mnuLang";
            this.mnuLang.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.mnuLang.Size = new System.Drawing.Size(116, 48);
            // 
            // mnuEnglish
            // 
            this.mnuEnglish.Name = "mnuEnglish";
            this.mnuEnglish.Size = new System.Drawing.Size(115, 22);
            this.mnuEnglish.Text = "English";
            this.mnuEnglish.Click += new System.EventHandler(this.mnuEnglish_Click);
            // 
            // mnuSpanish
            // 
            this.mnuSpanish.Name = "mnuSpanish";
            this.mnuSpanish.Size = new System.Drawing.Size(115, 22);
            this.mnuSpanish.Text = "Spanish";
            this.mnuSpanish.Click += new System.EventHandler(this.mnuSpanish_Click);
            // 
            // btnAbout
            // 
            this.btnAbout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAbout.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAbout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(240)))), ((int)(((byte)(250)))));
            this.btnAbout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(230)))), ((int)(((byte)(242)))));
            this.btnAbout.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnAbout.Font = new System.Drawing.Font("Segoe MDL2 Assets", 12F);
            this.btnAbout.ForeColor = System.Drawing.Color.Blue;
            this.btnAbout.Location = new System.Drawing.Point(41, 549);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(23, 23);
            this.btnAbout.TabIndex = 8;
            this.btnAbout.Text = "";
            this.btnAbout.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.tooltipInfo.SetToolTip(this.btnAbout, "About");
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // rdGeneral
            // 
            this.rdGeneral.AutoSize = true;
            this.rdGeneral.Checked = true;
            this.rdGeneral.Location = new System.Drawing.Point(277, 42);
            this.rdGeneral.Name = "rdGeneral";
            this.rdGeneral.Size = new System.Drawing.Size(62, 17);
            this.rdGeneral.TabIndex = 9;
            this.rdGeneral.TabStop = true;
            this.rdGeneral.Text = "General";
            this.rdGeneral.UseVisualStyleBackColor = true;
            this.rdGeneral.CheckedChanged += new System.EventHandler(this.rdGeneral_CheckedChanged);
            // 
            // rd2019
            // 
            this.rd2019.AutoSize = true;
            this.rd2019.Location = new System.Drawing.Point(504, 42);
            this.rd2019.Name = "rd2019";
            this.rd2019.Size = new System.Drawing.Size(49, 17);
            this.rd2019.TabIndex = 10;
            this.rd2019.Text = "2019";
            this.rd2019.UseVisualStyleBackColor = true;
            this.rd2019.CheckedChanged += new System.EventHandler(this.rd2019_CheckedChanged);
            // 
            // rd2016
            // 
            this.rd2016.AutoSize = true;
            this.rd2016.Location = new System.Drawing.Point(559, 42);
            this.rd2016.Name = "rd2016";
            this.rd2016.Size = new System.Drawing.Size(49, 17);
            this.rd2016.TabIndex = 11;
            this.rd2016.Text = "2016";
            this.rd2016.UseVisualStyleBackColor = true;
            this.rd2016.CheckedChanged += new System.EventHandler(this.rd2016_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(9, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // lblWindows
            // 
            this.lblWindows.AutoSize = true;
            this.lblWindows.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblWindows.Location = new System.Drawing.Point(76, 7);
            this.lblWindows.Name = "lblWindows";
            this.lblWindows.Size = new System.Drawing.Size(51, 20);
            this.lblWindows.TabIndex = 13;
            this.lblWindows.Text = "Office";
            // 
            // lblMedia
            // 
            this.lblMedia.AutoSize = true;
            this.lblMedia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblMedia.Location = new System.Drawing.Point(76, 27);
            this.lblMedia.Name = "lblMedia";
            this.lblMedia.Size = new System.Drawing.Size(52, 20);
            this.lblMedia.TabIndex = 14;
            this.lblMedia.Text = "Media";
            // 
            // lblCreator
            // 
            this.lblCreator.AutoSize = true;
            this.lblCreator.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblCreator.Location = new System.Drawing.Point(76, 47);
            this.lblCreator.Name = "lblCreator";
            this.lblCreator.Size = new System.Drawing.Size(62, 20);
            this.lblCreator.TabIndex = 15;
            this.lblCreator.Text = "Creator";
            // 
            // lblFiltro
            // 
            this.lblFiltro.Location = new System.Drawing.Point(204, 44);
            this.lblFiltro.Name = "lblFiltro";
            this.lblFiltro.Size = new System.Drawing.Size(67, 13);
            this.lblFiltro.TabIndex = 16;
            this.lblFiltro.Text = "Filter:";
            this.lblFiltro.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // rd2021
            // 
            this.rd2021.AutoSize = true;
            this.rd2021.Location = new System.Drawing.Point(449, 42);
            this.rd2021.Name = "rd2021";
            this.rd2021.Size = new System.Drawing.Size(49, 17);
            this.rd2021.TabIndex = 17;
            this.rd2021.Text = "2021";
            this.rd2021.UseVisualStyleBackColor = true;
            this.rd2021.CheckedChanged += new System.EventHandler(this.rd2021_CheckedChanged);
            // 
            // rd2024
            // 
            this.rd2024.AutoSize = true;
            this.rd2024.Location = new System.Drawing.Point(394, 42);
            this.rd2024.Name = "rd2024";
            this.rd2024.Size = new System.Drawing.Size(49, 17);
            this.rd2024.TabIndex = 18;
            this.rd2024.Text = "2024";
            this.rd2024.UseVisualStyleBackColor = true;
            this.rd2024.CheckedChanged += new System.EventHandler(this.rd2024_CheckedChanged);
            // 
            // rd365
            // 
            this.rd365.AutoSize = true;
            this.rd365.Location = new System.Drawing.Point(345, 42);
            this.rd365.Name = "rd365";
            this.rd365.Size = new System.Drawing.Size(43, 17);
            this.rd365.TabIndex = 19;
            this.rd365.Text = "365";
            this.rd365.UseVisualStyleBackColor = true;
            this.rd365.CheckedChanged += new System.EventHandler(this.rd365_CheckedChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(620, 584);
            this.Controls.Add(this.rd365);
            this.Controls.Add(this.rd2024);
            this.Controls.Add(this.rd2021);
            this.Controls.Add(this.lblFiltro);
            this.Controls.Add(this.lblCreator);
            this.Controls.Add(this.lblMedia);
            this.Controls.Add(this.lblWindows);
            this.Controls.Add(this.rd2016);
            this.Controls.Add(this.rd2019);
            this.Controls.Add(this.rdGeneral);
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.btnLang);
            this.Controls.Add(this.txtFind);
            this.Controls.Add(this.btnActivador);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.cmbFilter);
            this.Controls.Add(this.listViewArchivos);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnDownload);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Catalog : Office Media Creator";
            this.mnuLang.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnDownload;
        private System.Windows.Forms.ListView listViewArchivos;
        private System.Windows.Forms.ComboBox cmbFilter;
        private System.Windows.Forms.TextBox txtFind;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Button btnActivador;
        private System.Windows.Forms.Button btnLang;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.ToolTip tooltipInfo;
        private System.Windows.Forms.ContextMenuStrip mnuLang;
        private System.Windows.Forms.ToolStripMenuItem mnuEnglish;
        private System.Windows.Forms.ToolStripMenuItem mnuSpanish;
        private System.Windows.Forms.RadioButton rdGeneral;
        private System.Windows.Forms.RadioButton rd2019;
        private System.Windows.Forms.RadioButton rd2016;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblWindows;
        private System.Windows.Forms.Label lblMedia;
        private System.Windows.Forms.Label lblCreator;
        private System.Windows.Forms.Label lblFiltro;
        private System.Windows.Forms.RadioButton rd2021;
        private System.Windows.Forms.RadioButton rd2024;
        private System.Windows.Forms.RadioButton rd365;
    }
}