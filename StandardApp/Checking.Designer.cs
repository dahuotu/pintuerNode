namespace com.DaHuotu
{
    partial class Checking
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
            this.txtCheckLog = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtCheckLog
            // 
            this.txtCheckLog.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtCheckLog.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCheckLog.CausesValidation = false;
            this.txtCheckLog.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtCheckLog.Location = new System.Drawing.Point(13, 13);
            this.txtCheckLog.Multiline = true;
            this.txtCheckLog.Name = "txtCheckLog";
            this.txtCheckLog.ReadOnly = true;
            this.txtCheckLog.Size = new System.Drawing.Size(479, 74);
            this.txtCheckLog.TabIndex = 0;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(187, 97);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(131, 36);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "退出";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Visible = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Checking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 145);
            this.ControlBox = false;
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.txtCheckLog);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Checking";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "环境检测";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Checking_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCheckLog;
        private System.Windows.Forms.Button btnExit;
    }
}