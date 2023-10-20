using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using System.IO;

namespace MedicareProject
{
    public partial class AddMedicine : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["sq"].ConnectionString;

        public AddMedicine()
        {
            InitializeComponent();
            BindGridView();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Select Image";
            ofd.Filter = "All Files *.* | *.*";
            ofd.ShowDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(ofd.FileName);
            }
        }
        private object SavePhoto()
        {
            MemoryStream ms = new MemoryStream();
            pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
            return ms.GetBuffer();
        }

        void BindGridView()
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "SELECT * FROM smedicines";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable data = new DataTable();
            sda.Fill(data);
            dataGridView1.DataSource = data;

            DataGridViewImageColumn dgv = new DataGridViewImageColumn();
            dgv = (DataGridViewImageColumn)dataGridView1.Columns[4];
            dgv.ImageLayout = DataGridViewImageCellLayout.Stretch;


            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.RowTemplate.Height = 50;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "INSERT INTO SMEDICINES VALUES(@mid,@type,@name,@price,@image)";
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            cmd.Parameters.AddWithValue("@mid", textBox1.Text);
            cmd.Parameters.AddWithValue("@type", textBox2.Text);
            cmd.Parameters.AddWithValue("@name", textBox3.Text);
            cmd.Parameters.AddWithValue("@price", textBox4.Text);
            cmd.Parameters.AddWithValue("@image", SavePhoto());

            int a = cmd.ExecuteNonQuery();
            if (a > 0)
            {
                MessageBox.Show("Medicines Inserted Successfully", "Succeed!");
                BindGridView();
                ResetControl();
                con.Close();

            }
            else
            {
                MessageBox.Show("There's some problem", "Error!");
            }
        }
        void ResetControl()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            pictureBox1.Image = Properties.Resources.up;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ResetControl();
        }
    }
}
