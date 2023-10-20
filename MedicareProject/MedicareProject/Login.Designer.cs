
namespace MedicareProject
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.label1 = new System.Windows.Forms.Label();
            this.logingroupBox = new System.Windows.Forms.GroupBox();
            this.submitbutton = new System.Windows.Forms.Button();
            this.showpasswordcheckbox = new System.Windows.Forms.CheckBox();
            this.logpasswordtextbox = new System.Windows.Forms.TextBox();
            this.logusertextbox = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.logingroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(64, 301);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "The heart of your healthcare";
            // 
            // logingroupBox
            // 
            this.logingroupBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.logingroupBox.Controls.Add(this.panel1);
            this.logingroupBox.Controls.Add(this.submitbutton);
            this.logingroupBox.Controls.Add(this.showpasswordcheckbox);
            this.logingroupBox.Controls.Add(this.logpasswordtextbox);
            this.logingroupBox.Controls.Add(this.logusertextbox);
            this.logingroupBox.Controls.Add(this.password);
            this.logingroupBox.Controls.Add(this.username);
            this.logingroupBox.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logingroupBox.Location = new System.Drawing.Point(354, -6);
            this.logingroupBox.Name = "logingroupBox";
            this.logingroupBox.Size = new System.Drawing.Size(417, 402);
            this.logingroupBox.TabIndex = 2;
            this.logingroupBox.TabStop = false;
            this.logingroupBox.Text = "Login into your account";
            this.logingroupBox.Enter += new System.EventHandler(this.logingroupBox_Enter);
            // 
            // submitbutton
            // 
            this.submitbutton.BackColor = System.Drawing.Color.Silver;
            this.submitbutton.Location = new System.Drawing.Point(139, 291);
            this.submitbutton.Name = "submitbutton";
            this.submitbutton.Size = new System.Drawing.Size(149, 34);
            this.submitbutton.TabIndex = 5;
            this.submitbutton.Text = "submit";
            this.submitbutton.UseVisualStyleBackColor = false;
            this.submitbutton.Click += new System.EventHandler(this.submitbutton_Click);
            // 
            // showpasswordcheckbox
            // 
            this.showpasswordcheckbox.AutoSize = true;
            this.showpasswordcheckbox.Location = new System.Drawing.Point(122, 243);
            this.showpasswordcheckbox.Name = "showpasswordcheckbox";
            this.showpasswordcheckbox.Size = new System.Drawing.Size(187, 28);
            this.showpasswordcheckbox.TabIndex = 4;
            this.showpasswordcheckbox.Text = "show password";
            this.showpasswordcheckbox.UseVisualStyleBackColor = true;
            this.showpasswordcheckbox.CheckedChanged += new System.EventHandler(this.showpasswordcheckbox_CheckedChanged);
            // 
            // logpasswordtextbox
            // 
            this.logpasswordtextbox.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logpasswordtextbox.Location = new System.Drawing.Point(184, 182);
            this.logpasswordtextbox.Name = "logpasswordtextbox";
            this.logpasswordtextbox.Size = new System.Drawing.Size(203, 39);
            this.logpasswordtextbox.TabIndex = 3;
            this.logpasswordtextbox.UseSystemPasswordChar = true;
            this.logpasswordtextbox.Leave += new System.EventHandler(this.logpasswordtextbox_Leave);
            // 
            // logusertextbox
            // 
            this.logusertextbox.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logusertextbox.Location = new System.Drawing.Point(184, 116);
            this.logusertextbox.Name = "logusertextbox";
            this.logusertextbox.Size = new System.Drawing.Size(203, 39);
            this.logusertextbox.TabIndex = 2;
            this.logusertextbox.Leave += new System.EventHandler(this.logusertextbox_Leave);
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.Location = new System.Drawing.Point(51, 182);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(123, 33);
            this.password.TabIndex = 1;
            this.password.Text = "password";
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.Location = new System.Drawing.Point(51, 116);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(127, 33);
            this.username.TabIndex = 0;
            this.username.Text = "username";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, -6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(358, 402);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(24, 51);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(4, 300);
            this.panel1.TabIndex = 3;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 403);
            this.Controls.Add(this.logingroupBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.logingroupBox.ResumeLayout(false);
            this.logingroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox logingroupBox;
        private System.Windows.Forms.Button submitbutton;
        private System.Windows.Forms.CheckBox showpasswordcheckbox;
        private System.Windows.Forms.TextBox logpasswordtextbox;
        private System.Windows.Forms.TextBox logusertextbox;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.Label username;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.Panel panel1;
    }
}