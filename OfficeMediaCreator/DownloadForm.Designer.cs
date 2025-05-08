using WMC;

namespace OfficeMediaCreator
{
    partial class DownloadForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DownloadForm));
            this.btnCancel = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.lblDownSpeed = new System.Windows.Forms.Label();
            this.lblVelocidad = new System.Windows.Forms.Label();
            this.lblDown = new System.Windows.Forms.Label();
            this.lblProgreso = new System.Windows.Forms.Label();
            this.lblDescargado = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.btnPause = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.lblVersion = new System.Windows.Forms.Label();
            this.lblDev = new System.Windows.Forms.Label();
            this.lblSize = new System.Windows.Forms.Label();
            this.lblwinver = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblDownload = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnCancel.Location = new System.Drawing.Point(12, 549);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "Cancel ";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(6, 59);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(460, 23);
            this.progressBar1.TabIndex = 1;
            // 
            // lblDownSpeed
            // 
            this.lblDownSpeed.Location = new System.Drawing.Point(6, 16);
            this.lblDownSpeed.Name = "lblDownSpeed";
            this.lblDownSpeed.Size = new System.Drawing.Size(128, 13);
            this.lblDownSpeed.TabIndex = 3;
            this.lblDownSpeed.Text = "Download speed:";
            this.lblDownSpeed.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblVelocidad
            // 
            this.lblVelocidad.AutoSize = true;
            this.lblVelocidad.Location = new System.Drawing.Point(125, 16);
            this.lblVelocidad.Name = "lblVelocidad";
            this.lblVelocidad.Size = new System.Drawing.Size(0, 13);
            this.lblVelocidad.TabIndex = 4;
            // 
            // lblDown
            // 
            this.lblDown.Location = new System.Drawing.Point(6, 39);
            this.lblDown.Name = "lblDown";
            this.lblDown.Size = new System.Drawing.Size(118, 13);
            this.lblDown.TabIndex = 6;
            this.lblDown.Text = "Downloaded:";
            this.lblDown.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblProgreso
            // 
            this.lblProgreso.Location = new System.Drawing.Point(335, 87);
            this.lblProgreso.Name = "lblProgreso";
            this.lblProgreso.Size = new System.Drawing.Size(123, 13);
            this.lblProgreso.TabIndex = 7;
            this.lblProgreso.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblDescargado
            // 
            this.lblDescargado.Location = new System.Drawing.Point(115, 39);
            this.lblDescargado.Name = "lblDescargado";
            this.lblDescargado.Size = new System.Drawing.Size(351, 13);
            this.lblDescargado.TabIndex = 8;
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "IMG Files|*.img";
            this.saveFileDialog1.Title = "Save file";
            // 
            // btnPause
            // 
            this.btnPause.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnPause.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnPause.Location = new System.Drawing.Point(409, 549);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(75, 23);
            this.btnPause.TabIndex = 9;
            this.btnPause.Text = "Pause";
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Visible = false;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblName.Location = new System.Drawing.Point(12, 12);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(76, 26);
            this.lblName.TabIndex = 11;
            this.lblName.Text = "NAME";
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblVersion.Location = new System.Drawing.Point(12, 47);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(42, 13);
            this.lblVersion.TabIndex = 12;
            this.lblVersion.Text = "Version";
            // 
            // lblDev
            // 
            this.lblDev.AutoSize = true;
            this.lblDev.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblDev.Location = new System.Drawing.Point(12, 65);
            this.lblDev.Name = "lblDev";
            this.lblDev.Size = new System.Drawing.Size(25, 13);
            this.lblDev.TabIndex = 13;
            this.lblDev.Text = "dev";
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblSize.Location = new System.Drawing.Point(12, 83);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(25, 13);
            this.lblSize.TabIndex = 14;
            this.lblSize.Text = "size";
            // 
            // lblwinver
            // 
            this.lblwinver.AutoSize = true;
            this.lblwinver.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblwinver.Location = new System.Drawing.Point(12, 101);
            this.lblwinver.Name = "lblwinver";
            this.lblwinver.Size = new System.Drawing.Size(38, 13);
            this.lblwinver.TabIndex = 15;
            this.lblwinver.Text = "winver";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblVelocidad);
            this.groupBox1.Controls.Add(this.lblDescargado);
            this.groupBox1.Controls.Add(this.lblProgreso);
            this.groupBox1.Controls.Add(this.lblDownSpeed);
            this.groupBox1.Controls.Add(this.progressBar1);
            this.groupBox1.Controls.Add(this.lblDown);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox1.Location = new System.Drawing.Point(12, 125);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(472, 112);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            // 
            // lblDownload
            // 
            this.lblDownload.Location = new System.Drawing.Point(12, 240);
            this.lblDownload.Name = "lblDownload";
            this.lblDownload.Size = new System.Drawing.Size(472, 22);
            this.lblDownload.TabIndex = 17;
            this.lblDownload.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DownloadForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(496, 584);
            this.Controls.Add(this.lblDownload);
            this.Controls.Add(this.lblwinver);
            this.Controls.Add(this.lblSize);
            this.Controls.Add(this.lblDev);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "DownloadForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Download :  Office Media Creator";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DownloadForm_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label lblDownSpeed;
        private System.Windows.Forms.Label lblVelocidad;
        private System.Windows.Forms.Label lblDown;
        private System.Windows.Forms.Label lblProgreso;
        private System.Windows.Forms.Label lblDescargado;
        private System.Windows.Forms.Button btnPause;
        public System.Windows.Forms.Label lblName;
        public System.Windows.Forms.Label lblVersion;
        public System.Windows.Forms.Label lblDev;
        public System.Windows.Forms.Label lblSize;
        public System.Windows.Forms.Label lblwinver;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblDownload;
        public System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}