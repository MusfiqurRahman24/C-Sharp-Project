
namespace MedicareProject
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.pharmacyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userQueriesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.availmedicines = new System.Windows.Forms.Label();
            this.type = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.price = new System.Windows.Forms.Label();
            this.image = new System.Windows.Forms.Label();
            this.idtextbox = new System.Windows.Forms.TextBox();
            this.nametextbox = new System.Windows.Forms.TextBox();
            this.pricetextbox = new System.Windows.Forms.TextBox();
            this.browse = new System.Windows.Forms.Button();
            this.insert = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.reset = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idlabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.DarkRed;
            this.menuStrip1.Font = new System.Drawing.Font("Elephant", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pharmacyToolStripMenuItem,
            this.userQueriesToolStripMenuItem,
            this.logoutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(3, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(753, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // pharmacyToolStripMenuItem
            // 
            this.pharmacyToolStripMenuItem.Font = new System.Drawing.Font("Elephant", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pharmacyToolStripMenuItem.Name = "pharmacyToolStripMenuItem";
            this.pharmacyToolStripMenuItem.Size = new System.Drawing.Size(132, 31);
            this.pharmacyToolStripMenuItem.Text = "Pharmacy";
            // 
            // userQueriesToolStripMenuItem
            // 
            this.userQueriesToolStripMenuItem.Font = new System.Drawing.Font("Elephant", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userQueriesToolStripMenuItem.Name = "userQueriesToolStripMenuItem";
            this.userQueriesToolStripMenuItem.Size = new System.Drawing.Size(162, 31);
            this.userQueriesToolStripMenuItem.Text = "User Queries";
            this.userQueriesToolStripMenuItem.Click += new System.EventHandler(this.userQueriesToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Font = new System.Drawing.Font("Elephant", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(98, 31);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // availmedicines
            // 
            this.availmedicines.AutoSize = true;
            this.availmedicines.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.availmedicines.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.availmedicines.Location = new System.Drawing.Point(477, 13);
            this.availmedicines.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.availmedicines.Name = "availmedicines";
            this.availmedicines.Size = new System.Drawing.Size(242, 32);
            this.availmedicines.TabIndex = 1;
            this.availmedicines.Text = "Available Medicines";
            // 
            // type
            // 
            this.type.AutoSize = true;
            this.type.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.type.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.type.Location = new System.Drawing.Point(3, 48);
            this.type.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.type.Name = "type";
            this.type.Size = new System.Drawing.Size(55, 22);
            this.type.TabIndex = 2;
            this.type.Text = "Type";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.name.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.Location = new System.Drawing.Point(2, 84);
            this.name.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(63, 22);
            this.name.TabIndex = 3;
            this.name.Text = "Name";
            // 
            // price
            // 
            this.price.AutoSize = true;
            this.price.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.price.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.price.Location = new System.Drawing.Point(3, 121);
            this.price.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(58, 22);
            this.price.TabIndex = 4;
            this.price.Text = "Price";
            // 
            // image
            // 
            this.image.AutoSize = true;
            this.image.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.image.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.image.Location = new System.Drawing.Point(3, 163);
            this.image.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.image.Name = "image";
            this.image.Size = new System.Drawing.Size(67, 22);
            this.image.TabIndex = 5;
            this.image.Text = "Image";
            // 
            // idtextbox
            // 
            this.idtextbox.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idtextbox.Location = new System.Drawing.Point(84, 48);
            this.idtextbox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.idtextbox.Multiline = true;
            this.idtextbox.Name = "idtextbox";
            this.idtextbox.Size = new System.Drawing.Size(295, 22);
            this.idtextbox.TabIndex = 6;
            // 
            // nametextbox
            // 
            this.nametextbox.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nametextbox.Location = new System.Drawing.Point(84, 121);
            this.nametextbox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.nametextbox.Multiline = true;
            this.nametextbox.Name = "nametextbox";
            this.nametextbox.Size = new System.Drawing.Size(295, 22);
            this.nametextbox.TabIndex = 7;
            this.nametextbox.TextChanged += new System.EventHandler(this.nametextbox_TextChanged);
            // 
            // pricetextbox
            // 
            this.pricetextbox.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pricetextbox.Location = new System.Drawing.Point(84, 84);
            this.pricetextbox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pricetextbox.Multiline = true;
            this.pricetextbox.Name = "pricetextbox";
            this.pricetextbox.Size = new System.Drawing.Size(295, 22);
            this.pricetextbox.TabIndex = 8;
            this.pricetextbox.TextChanged += new System.EventHandler(this.pricetextbox_TextChanged);
            // 
            // browse
            // 
            this.browse.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.browse.Location = new System.Drawing.Point(281, 234);
            this.browse.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.browse.Name = "browse";
            this.browse.Size = new System.Drawing.Size(85, 35);
            this.browse.TabIndex = 10;
            this.browse.Text = "browse";
            this.browse.UseVisualStyleBackColor = true;
            this.browse.Click += new System.EventHandler(this.browse_Click);
            // 
            // insert
            // 
            this.insert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.insert.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insert.Location = new System.Drawing.Point(11, 276);
            this.insert.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.insert.Name = "insert";
            this.insert.Size = new System.Drawing.Size(84, 40);
            this.insert.TabIndex = 11;
            this.insert.Text = "Insert";
            this.insert.UseVisualStyleBackColor = false;
            this.insert.Click += new System.EventHandler(this.insert_Click);
            // 
            // update
            // 
            this.update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.update.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update.Location = new System.Drawing.Point(108, 276);
            this.update.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(78, 40);
            this.update.TabIndex = 12;
            this.update.Text = "Update";
            this.update.UseVisualStyleBackColor = false;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // delete
            // 
            this.delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.delete.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete.Location = new System.Drawing.Point(292, 275);
            this.delete.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(87, 40);
            this.delete.TabIndex = 13;
            this.delete.Text = "Delete";
            this.delete.UseVisualStyleBackColor = false;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // reset
            // 
            this.reset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.reset.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reset.Location = new System.Drawing.Point(201, 275);
            this.reset.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(87, 40);
            this.reset.TabIndex = 14;
            this.reset.Text = "Reset";
            this.reset.UseVisualStyleBackColor = false;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.dataGridView1.Location = new System.Drawing.Point(459, 48);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(269, 246);
            this.dataGridView1.TabIndex = 15;
            this.dataGridView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseDoubleClick);
            // 
            // idlabel
            // 
            this.idlabel.AutoSize = true;
            this.idlabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.idlabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idlabel.Location = new System.Drawing.Point(3, 9);
            this.idlabel.Name = "idlabel";
            this.idlabel.Size = new System.Drawing.Size(30, 22);
            this.idlabel.TabIndex = 16;
            this.idlabel.Text = "ID";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(84, 9);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(141, 22);
            this.textBox1.TabIndex = 17;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(84, 163);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(193, 106);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.idlabel);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.availmedicines);
            this.panel1.Controls.Add(this.delete);
            this.panel1.Controls.Add(this.reset);
            this.panel1.Controls.Add(this.type);
            this.panel1.Controls.Add(this.idtextbox);
            this.panel1.Controls.Add(this.update);
            this.panel1.Controls.Add(this.name);
            this.panel1.Controls.Add(this.insert);
            this.panel1.Controls.Add(this.pricetextbox);
            this.panel1.Controls.Add(this.browse);
            this.panel1.Controls.Add(this.price);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.nametextbox);
            this.panel1.Controls.Add(this.image);
            this.panel1.Location = new System.Drawing.Point(0, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(753, 343);
            this.panel1.TabIndex = 18;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(753, 364);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Dashboard_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem pharmacyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userQueriesToolStripMenuItem;
        private System.Windows.Forms.Label availmedicines;
        private System.Windows.Forms.Label type;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label price;
        private System.Windows.Forms.Label image;
        private System.Windows.Forms.TextBox idtextbox;
        private System.Windows.Forms.TextBox nametextbox;
        private System.Windows.Forms.TextBox pricetextbox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button browse;
        private System.Windows.Forms.Button insert;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label idlabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
    }
}