
using System;

namespace CoffeeShopManagement
{
    partial class formLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formLogin));
            this.panLogin = new System.Windows.Forms.Panel();
            this.bttExit = new System.Windows.Forms.Button();
            this.bttLogin = new System.Windows.Forms.Button();
            this.pibLogin = new System.Windows.Forms.PictureBox();
            this.panPassword = new System.Windows.Forms.Panel();
            this.labPassWord = new System.Windows.Forms.Label();
            this.txbPassWord = new System.Windows.Forms.TextBox();
            this.panUserName = new System.Windows.Forms.Panel();
            this.labUserName = new System.Windows.Forms.Label();
            this.txbUserName = new System.Windows.Forms.TextBox();
            this.panLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pibLogin)).BeginInit();
            this.panPassword.SuspendLayout();
            this.panUserName.SuspendLayout();
            this.SuspendLayout();
            // 
            // panLogin
            // 
            this.panLogin.AllowDrop = true;
            this.panLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panLogin.BackColor = System.Drawing.SystemColors.Control;
            this.panLogin.Controls.Add(this.bttExit);
            this.panLogin.Controls.Add(this.bttLogin);
            this.panLogin.Controls.Add(this.pibLogin);
            this.panLogin.Controls.Add(this.panPassword);
            this.panLogin.Controls.Add(this.panUserName);
            this.panLogin.Location = new System.Drawing.Point(12, 12);
            this.panLogin.Name = "panLogin";
            this.panLogin.Size = new System.Drawing.Size(308, 348);
            this.panLogin.TabIndex = 0;
            // 
            // bttExit
            // 
            this.bttExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bttExit.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttExit.Location = new System.Drawing.Point(155, 80);
            this.bttExit.Name = "bttExit";
            this.bttExit.Size = new System.Drawing.Size(150, 29);
            this.bttExit.TabIndex = 4;
            this.bttExit.Text = "Thoát";
            this.bttExit.UseVisualStyleBackColor = true;
            this.bttExit.Click += new System.EventHandler(this.bttExit_Click);
            // 
            // bttLogin
            // 
            this.bttLogin.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttLogin.Location = new System.Drawing.Point(3, 80);
            this.bttLogin.Name = "bttLogin";
            this.bttLogin.Size = new System.Drawing.Size(150, 29);
            this.bttLogin.TabIndex = 3;
            this.bttLogin.Text = "Đăng nhập";
            this.bttLogin.UseVisualStyleBackColor = true;
            this.bttLogin.Click += new System.EventHandler(this.bttLogin_Click);
            // 
            // pibLogin
            // 
            this.pibLogin.Image = ((System.Drawing.Image)(resources.GetObject("pibLogin.Image")));
            this.pibLogin.Location = new System.Drawing.Point(3, 115);
            this.pibLogin.Name = "pibLogin";
            this.pibLogin.Size = new System.Drawing.Size(302, 229);
            this.pibLogin.TabIndex = 3;
            this.pibLogin.TabStop = false;
            // 
            // panPassword
            // 
            this.panPassword.Controls.Add(this.labPassWord);
            this.panPassword.Controls.Add(this.txbPassWord);
            this.panPassword.Location = new System.Drawing.Point(3, 41);
            this.panPassword.Name = "panPassword";
            this.panPassword.Size = new System.Drawing.Size(302, 33);
            this.panPassword.TabIndex = 2;
            // 
            // labPassWord
            // 
            this.labPassWord.AutoSize = true;
            this.labPassWord.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labPassWord.Location = new System.Drawing.Point(3, 4);
            this.labPassWord.Name = "labPassWord";
            this.labPassWord.Size = new System.Drawing.Size(86, 19);
            this.labPassWord.TabIndex = 1;
            this.labPassWord.Text = "Mật khẩu:";
            // 
            // txbPassWord
            // 
            this.txbPassWord.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPassWord.Location = new System.Drawing.Point(152, 3);
            this.txbPassWord.Name = "txbPassWord";
            this.txbPassWord.Size = new System.Drawing.Size(147, 26);
            this.txbPassWord.TabIndex = 2;
            this.txbPassWord.UseSystemPasswordChar = true;
            // 
            // panUserName
            // 
            this.panUserName.Controls.Add(this.labUserName);
            this.panUserName.Controls.Add(this.txbUserName);
            this.panUserName.Location = new System.Drawing.Point(3, 3);
            this.panUserName.Name = "panUserName";
            this.panUserName.Size = new System.Drawing.Size(302, 32);
            this.panUserName.TabIndex = 0;
            // 
            // labUserName
            // 
            this.labUserName.AutoSize = true;
            this.labUserName.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labUserName.Location = new System.Drawing.Point(3, 4);
            this.labUserName.Name = "labUserName";
            this.labUserName.Size = new System.Drawing.Size(132, 19);
            this.labUserName.TabIndex = 1;
            this.labUserName.Text = "Tên đăng nhập:";
            // 
            // txbUserName
            // 
            this.txbUserName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbUserName.Location = new System.Drawing.Point(152, 3);
            this.txbUserName.Name = "txbUserName";
            this.txbUserName.Size = new System.Drawing.Size(147, 26);
            this.txbUserName.TabIndex = 1;
            // 
            // formLogin
            // 
            this.AcceptButton = this.bttLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.bttExit;
            this.ClientSize = new System.Drawing.Size(332, 372);
            this.Controls.Add(this.panLogin);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "formLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            this.panLogin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pibLogin)).EndInit();
            this.panPassword.ResumeLayout(false);
            this.panPassword.PerformLayout();
            this.panUserName.ResumeLayout(false);
            this.panUserName.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panLogin;
        private System.Windows.Forms.Panel panPassword;
        private System.Windows.Forms.Label labPassWord;
        private System.Windows.Forms.TextBox txbPassWord;
        private System.Windows.Forms.Panel panUserName;
        private System.Windows.Forms.Label labUserName;
        private System.Windows.Forms.TextBox txbUserName;
        private System.Windows.Forms.Button bttLogin;
        private System.Windows.Forms.PictureBox pibLogin;
        private System.Windows.Forms.Button bttExit;
    }
}

