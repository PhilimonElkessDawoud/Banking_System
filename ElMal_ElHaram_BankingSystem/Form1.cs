using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ElMal_ElHaram_BankingSystem
{
    public partial class Form1 : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\ElMal_ElHaram_BankingSystem\ElMal_ElHaram_BankingSystem\Persons.mdf;Integrated Security=True");
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Are you sure you want to close the program?", "Exit", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
                Application.Exit();
            else if (dialog == DialogResult.No)
                e.Cancel = true;
        }

        private void Extbtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to Exit?", "Exit", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
                this.Activate();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if(textBox1.Text == "ID")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black;
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "ID";
                textBox1.ForeColor = Color.Gray;
            }
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (textBox2.Text == "Password")
            {
                textBox2.Text = "";
                textBox2.ForeColor = Color.Black;
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                textBox2.Text = "Password";
                textBox2.ForeColor = Color.Gray;
            }
        }

        private void Loginbtn_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            SqlDataReader reader = null;
            cmd.Connection = conn;
            cmd.CommandText = "select * from Clients where ClientID = '" + textBox1.Text + "' and Password = '" + textBox2.Text + "'";
            reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                Form2Client f2 = new Form2Client(textBox1.Text);
                f2.ShowDialog();
                this.Hide();
                reader.Close();
                conn.Close();
            }
            else
            {
                reader.Close();
                SqlCommand cmd1 = new SqlCommand();
                SqlDataReader reader1 = null;
                cmd1.Connection = conn;
                cmd1.CommandText = "select * from Tellers where Id = '" + textBox1.Text + "' and Password = '" + textBox2.Text + "'";
                reader1 = cmd1.ExecuteReader();
                if (reader1.Read())
                {
                    Teller t = new Teller();
                    t.ShowDialog();
                    this.Hide();
                    reader1.Close();
                }
                else
                {
                    MessageBox.Show("Either Id or Password or Both are Invalid!");
                }
            }
            
        }
    }
}
