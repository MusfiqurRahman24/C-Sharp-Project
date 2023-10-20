
namespace MedicareProject
{
    partial class Buyer_Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Buyer_Login));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.submitbutton = new System.Windows.Forms.Button();
            this.checkbox = new System.Windows.Forms.CheckBox();
            this.textbox2 = new System.Windows.Forms.TextBox();
            this.textbox1 = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(34, 24);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(320, 124);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label1.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(375, 93);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(505, 41);
            this.label1.TabIndex = 2;
            this.label1.Text = "The heart of your healthcare";
            // 
            // groupBox
            // 
            this.groupBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox.Controls.Add(this.submitbutton);
            this.groupBox.Controls.Add(this.checkbox);
            this.groupBox.Controls.Add(this.textbox2);
            this.groupBox.Controls.Add(this.textbox1);
            this.groupBox.Controls.Add(this.password);
            this.groupBox.Controls.Add(this.username);
            this.groupBox.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox.Location = new System.Drawing.Point(13, 174);
            this.groupBox.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox.Name = "groupBox";
            this.groupBox.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox.Size = new System.Drawing.Size(881, 393);
            this.groupBox.TabIndex = 3;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Login into your account";
            // 
            // submitbutton
            // 
            this.submitbutton.BackColor = System.Drawing.SystemColors.HotTrack;
            this.submitbutton.Location = new System.Drawing.Point(327, 305);
            this.submitbutton.Margin = new System.Windows.Forms.Padding(4);
            this.submitbutton.Name = "submitbutton";
            this.submitbutton.Size = new System.Drawing.Size(199, 42);
            this.submitbutton.TabIndex = 5;
            this.submitbutton.Text = "submit";
            this.submitbutton.UseVisualStyleBackColor = false;
            this.submitbutton.Click += new System.EventHandler(this.submitbutton_Click);
            // 
            // checkbox
            // 
            this.checkbox.AutoSize = true;
            this.checkbox.Location = new System.Drawing.Point(313, 231);
            this.checkbox.Margin = new System.Windows.Forms.Padding(4);
            this.checkbox.Name = "checkbox";
            this.checkbox.Size = new System.Drawing.Size(243, 36);
            this.checkbox.TabIndex = 4;
            this.checkbox.Text = "show password";
            this.checkbox.UseVisualStyleBackColor = true;
            this.checkbox.CheckedChanged += new System.EventHandler(this.checkbox_CheckedChanged);
            // 
            // textbox2
            // 
            this.textbox2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox2.Location = new System.Drawing.Point(313, 159);
            this.textbox2.Margin = new System.Windows.Forms.Padding(4);
            this.textbox2.Name = "textbox2";
            this.textbox2.Size = new System.Drawing.Size(419, 47);
            this.textbox2.TabIndex = 3;
            this.textbox2.UseSystemPasswordChar = true;
            this.textbox2.Leave += new System.EventHandler(this.textbox2_Leave);
            // 
            // textbox1
            // 
            this.textbox1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox1.Location = new System.Drawing.Point(313, 87);
            this.textbox1.Margin = new System.Windows.Forms.Padding(4);
            this.textbox1.Name = "textbox1";
            this.textbox1.Size = new System.Drawing.Size(419, 47);
            this.textbox1.TabIndex = 2;
            this.textbox1.Leave += new System.EventHandler(this.textbox1_Leave);
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Font = new System.Drawing.Font("Arial Rounded MT Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.Location = new System.Drawing.Point(59, 159);
            this.password.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(195, 43);
            this.password.TabIndex = 1;
            this.password.Text = "password";
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.Font = new System.Drawing.Font("Arial Rounded MT Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.Location = new System.Drawing.Point(57, 90);
            this.username.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(198, 43);
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
            // Buyer_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 594);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Buyer_Login";
            this.Text = "Buyer_Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Button submitbutton;
        private System.Windows.Forms.CheckBox checkbox;
        private System.Windows.Forms.TextBox textbox2;
        private System.Windows.Forms.TextBox textbox1;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.Label username;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
    }
}