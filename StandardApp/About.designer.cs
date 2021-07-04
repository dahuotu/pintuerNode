namespace com.DaHuotu
{
    partial class frmAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAbout));
            this.labSoftName = new System.Windows.Forms.Label();
            this.linkSite = new System.Windows.Forms.LinkLabel();
            this.btnClose = new System.Windows.Forms.Button();
            this.labVsion = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.linkLabelAbout = new System.Windows.Forms.LinkLabel();
            this.labCopyright = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labSoftName
            // 
            this.labSoftName.AutoSize = true;
            this.labSoftName.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labSoftName.Location = new System.Drawing.Point(95, 27);
            this.labSoftName.Name = "labSoftName";
            this.labSoftName.Size = new System.Drawing.Size(0, 12);
            this.labSoftName.TabIndex = 0;
            // 
            // linkSite
            // 
            this.linkSite.AutoSize = true;
            this.linkSite.Location = new System.Drawing.Point(22, 116);
            this.linkSite.Name = "linkSite";
            this.linkSite.Size = new System.Drawing.Size(53, 12);
            this.linkSite.TabIndex = 1;
            this.linkSite.TabStop = true;
            this.linkSite.Text = "官方网址";
            this.linkSite.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkSite_LinkClicked);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(245, 134);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "关闭";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // labVsion
            // 
            this.labVsion.AutoSize = true;
            this.labVsion.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labVsion.Location = new System.Drawing.Point(95, 56);
            this.labVsion.Name = "labVsion";
            this.labVsion.Size = new System.Drawing.Size(0, 12);
            this.labVsion.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::com.DaHuotu.Properties.Resources.ImageIco;
            this.pictureBox1.Location = new System.Drawing.Point(12, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(73, 73);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // linkLabelAbout
            // 
            this.linkLabelAbout.AutoSize = true;
            this.linkLabelAbout.Location = new System.Drawing.Point(22, 145);
            this.linkLabelAbout.Name = "linkLabelAbout";
            this.linkLabelAbout.Size = new System.Drawing.Size(53, 12);
            this.linkLabelAbout.TabIndex = 5;
            this.linkLabelAbout.TabStop = true;
            this.linkLabelAbout.Text = "意见反馈";
            this.linkLabelAbout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelAbout_LinkClicked);
            // 
            // labCopyright
            // 
            this.labCopyright.AutoSize = true;
            this.labCopyright.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labCopyright.Location = new System.Drawing.Point(95, 85);
            this.labCopyright.Name = "labCopyright";
            this.labCopyright.Size = new System.Drawing.Size(167, 12);
            this.labCopyright.TabIndex = 6;
            this.labCopyright.Text = "Copyright(C) 2020 by 大火兔";
            // 
            // frmAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 174);
            this.Controls.Add(this.labCopyright);
            this.Controls.Add(this.linkLabelAbout);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labVsion);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.linkSite);
            this.Controls.Add(this.labSoftName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(348, 213);
            this.MinimizeBox = false;
            this.Name = "frmAbout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "关于";
            this.Load += new System.EventHandler(this.frmAbout_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labSoftName;
        private System.Windows.Forms.LinkLabel linkSite;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label labVsion;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel linkLabelAbout;
        private System.Windows.Forms.Label labCopyright;
    }
}