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
    public partial class Teller : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\ElMal_ElHaram_BankingSystem\ElMal_ElHaram_BankingSystem\Persons.mdf;Integrated Security=True");

        public static Teller t = new Teller();
        NewClient addc = new NewClient();
        Form1 f1 = new Form1();
        public void display_data()
        {
            if(conn.State == ConnectionState.Closed)
            {
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from Clients";
                cmd.ExecuteNonQuery();
                DataTable dta = new DataTable();
                SqlDataAdapter dataadp = new SqlDataAdapter(cmd);
                dataadp.Fill(dta);
                ClientsGridView.DataSource = dta;
                conn.Close();
            }
            else
            {
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from Clients";
                cmd.ExecuteNonQuery();
                DataTable dta = new DataTable();
                SqlDataAdapter dataadp = new SqlDataAdapter(cmd);
                dataadp.Fill(dta);
                ClientsGridView.DataSource = dta;
                conn.Close();
            }
        }
        public Teller()
        {
            InitializeComponent();

            t = this;

            display_data();
        }

        private void Addbtn_Click(object sender, EventArgs e)
        {
            addc.Show();
        }

        private void LogOutbtn_Click(object sender, EventArgs e)
        {
            this.Close();
            f1.Show();
        }
        private void FName_Enter(object sender, EventArgs e)
        {
            if (FName.Text == "First Name")
            {
                FName.Text = "";
                FName.ForeColor = Color.Black;
            }
        }
        private void FName_Leave(object sender, EventArgs e)
        {
            if (FName.Text == "")
            {
                FName.Text = "First Name";
                FName.ForeColor = Color.Gray;
            }
        }
        private void MName_Enter(object sender, EventArgs e)
        {
            if (MName.Text == "Middle Name")
            {
                MName.Text = "";
                MName.ForeColor = Color.Black;
            }
        }

        private void MName_Leave(object sender, EventArgs e)
        {
            if (MName.Text == "")
            {
                MName.Text = "Middle Name";
                MName.ForeColor = Color.Gray;
            }
        }

        private void LName_Enter(object sender, EventArgs e)
        {
            if(LName.Text == "Last Name")
            {
                LName.Text = "";
                LName.ForeColor = Color.Black;
            }
        }

        private void LName_Leave(object sender, EventArgs e)
        {
            if (LName.Text == "")
            {
                LName.Text = "Last Name";
                LName.ForeColor = Color.Gray;
            }
        }

        private void IDtextb_Enter(object sender, EventArgs e)
        {
            if(IDtextb.Text == "ID")
            {
                IDtextb.Text = "";
                IDtextb.ForeColor = Color.Black;
            }
        }

        private void IDtextb_Leave(object sender, EventArgs e)
        {
            if( IDtextb.Text == "")
            {
                IDtextb.Text = "ID";
                IDtextb.ForeColor = Color.Gray;
            }
        }

        private void Searchbtn_Click(object sender, EventArgs e)
        {
            if(FName.Text == "First Name" && MName.Text == "Middle Name" && LName.Text == "Last Name" && IDtextb.Text == "ID")
            {
                MessageBox.Show("Please enter at least one parameter to look for!");
                FName.Focus();
            }
            else if(FName.Text == "First Name" && MName.Text == "Middle Name" && LName.Text == "Last Name" && IDtextb.Text != "ID")
            {
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from Clients where ClientID like '%" + IDtextb.Text + "%'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                ClientsGridView.DataSource = dt;
                conn.Close();
                FName.Text = "First Name";
                FName.ForeColor = Color.Gray;
                MName.Text = "Middle Name";
                MName.ForeColor = Color.Gray;
                LName.Text = "Last Name";
                LName.ForeColor = Color.Gray;
                IDtextb.Text = "ID";
                IDtextb.ForeColor = Color.Gray;
                backbtn.Visible = true;
            }
            else if (FName.Text != "First Name" && MName.Text == "Middle Name" && LName.Text == "Last Name" && IDtextb.Text == "ID")
            {
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from Clients where First_Name like '%" + FName.Text + "%'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                ClientsGridView.DataSource = dt;
                conn.Close();
                FName.Text = "First Name";
                FName.ForeColor = Color.Gray;
                MName.Text = "Middle Name";
                MName.ForeColor = Color.Gray;
                LName.Text = "Last Name";
                LName.ForeColor = Color.Gray;
                IDtextb.Text = "ID";
                IDtextb.ForeColor = Color.Gray;
                backbtn.Visible = true;
            }
            else if (FName.Text == "First Name" && MName.Text != "Middle Name" && LName.Text == "Last Name" && IDtextb.Text == "ID")
            {
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from Clients where Middle_Name like '%" + MName.Text + "%'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                ClientsGridView.DataSource = dt;
                conn.Close();
                FName.Text = "First Name";
                FName.ForeColor = Color.Gray;
                MName.Text = "Middle Name";
                MName.ForeColor = Color.Gray;
                LName.Text = "Last Name";
                LName.ForeColor = Color.Gray;
                IDtextb.Text = "ID";
                IDtextb.ForeColor = Color.Gray;
                backbtn.Visible = true;
            }
            else if (FName.Text == "First Name" && MName.Text == "Middle Name" && LName.Text != "Last Name" && IDtextb.Text == "ID")
            {
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from Clients where Last_Name like '%" + LName.Text + "%'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                ClientsGridView.DataSource = dt;
                conn.Close();
                FName.Text = "First Name";
                FName.ForeColor = Color.Gray;
                MName.Text = "Middle Name";
                MName.ForeColor = Color.Gray;
                LName.Text = "Last Name";
                LName.ForeColor = Color.Gray;
                IDtextb.Text = "ID";
                IDtextb.ForeColor = Color.Gray;
                backbtn.Visible = true;
            }
            else if (FName.Text != "First Name" && MName.Text != "Middle Name" && LName.Text == "Last Name" && IDtextb.Text == "ID")
            {
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from Clients where First_Name like '%" + FName.Text + "%' and Middle_Name like '%" + MName.Text + "%'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                ClientsGridView.DataSource = dt;
                conn.Close();
                FName.Text = "First Name";
                FName.ForeColor = Color.Gray;
                MName.Text = "Middle Name";
                MName.ForeColor = Color.Gray;
                LName.Text = "Last Name";
                LName.ForeColor = Color.Gray;
                IDtextb.Text = "ID";
                IDtextb.ForeColor = Color.Gray;
                backbtn.Visible = true;
            }
            else if (FName.Text != "First Name" && MName.Text == "Middle Name" && LName.Text != "Last Name" && IDtextb.Text == "ID")
            {
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from Clients where First_Name like '%" + FName.Text + "%' and Last_Name like '%" + LName.Text + "%'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                ClientsGridView.DataSource = dt;
                conn.Close();
                FName.Text = "First Name";
                FName.ForeColor = Color.Gray;
                MName.Text = "Middle Name";
                MName.ForeColor = Color.Gray;
                LName.Text = "Last Name";
                LName.ForeColor = Color.Gray;
                IDtextb.Text = "ID";
                IDtextb.ForeColor = Color.Gray;
                backbtn.Visible = true;
            }
            else if (FName.Text == "First Name" && MName.Text != "Middle Name" && LName.Text != "Last Name" && IDtextb.Text == "ID")
            {
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from Clients where Middle_Name like '%" + MName.Text + "%' and Last_Name like '%" + LName.Text + "%'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                ClientsGridView.DataSource = dt;
                conn.Close();
                FName.Text = "First Name";
                FName.ForeColor = Color.Gray;
                MName.Text = "Middle Name";
                MName.ForeColor = Color.Gray;
                LName.Text = "Last Name";
                LName.ForeColor = Color.Gray;
                IDtextb.Text = "ID";
                IDtextb.ForeColor = Color.Gray;
                backbtn.Visible = true;
            }
            else if (FName.Text != "First Name" && MName.Text == "Middle Name" && LName.Text == "Last Name" && IDtextb.Text != "ID")
            {
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from Clients where First_Name like '%" + FName.Text + "%' and ClientID like '%" + IDtextb.Text + "%'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                ClientsGridView.DataSource = dt;
                conn.Close();
                FName.Text = "First Name";
                FName.ForeColor = Color.Gray;
                MName.Text = "Middle Name";
                MName.ForeColor = Color.Gray;
                LName.Text = "Last Name";
                LName.ForeColor = Color.Gray;
                IDtextb.Text = "ID";
                IDtextb.ForeColor = Color.Gray;
                backbtn.Visible = true;
            }
            else if (FName.Text == "First Name" && MName.Text != "Middle Name" && LName.Text == "Last Name" && IDtextb.Text != "ID")
            {
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from Clients where Middle_Name like '%" + MName.Text + "%' and ClientID like '%" + IDtextb.Text + "%'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                ClientsGridView.DataSource = dt;
                conn.Close();
                FName.Text = "First Name";
                FName.ForeColor = Color.Gray;
                MName.Text = "Middle Name";
                MName.ForeColor = Color.Gray;
                LName.Text = "Last Name";
                LName.ForeColor = Color.Gray;
                IDtextb.Text = "ID";
                IDtextb.ForeColor = Color.Gray;
                backbtn.Visible = true;
            }
            else if (FName.Text == "First Name" && MName.Text == "Middle Name" && LName.Text != "Last Name" && IDtextb.Text != "ID")
            {
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from Clients where Last_Name like '%" + LName.Text + "%' and ClientID like '%" + IDtextb.Text + "%'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                ClientsGridView.DataSource = dt;
                conn.Close();
                FName.Text = "First Name";
                FName.ForeColor = Color.Gray;
                MName.Text = "Middle Name";
                MName.ForeColor = Color.Gray;
                LName.Text = "Last Name";
                LName.ForeColor = Color.Gray;
                IDtextb.Text = "ID";
                IDtextb.ForeColor = Color.Gray;
                backbtn.Visible = true;
            }
            else if (FName.Text != "First Name" && MName.Text != "Middle Name" && LName.Text == "Last Name" && IDtextb.Text != "ID")
            {
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from Clients where First_Name like '%" + FName.Text + "%' and Middle_Name like '%" + MName.Text + "%'" +
                    "and ClientID like '%" + IDtextb.Text + "%'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                ClientsGridView.DataSource = dt;
                conn.Close();
                FName.Text = "First Name";
                FName.ForeColor = Color.Gray;
                MName.Text = "Middle Name";
                MName.ForeColor = Color.Gray;
                LName.Text = "Last Name";
                LName.ForeColor = Color.Gray;
                IDtextb.Text = "ID";
                IDtextb.ForeColor = Color.Gray;
                backbtn.Visible = true;
            }
            else if (FName.Text != "First Name" && MName.Text == "Middle Name" && LName.Text != "Last Name" && IDtextb.Text != "ID")
            {
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from Clients where First_Name like '%" + FName.Text + "%' and Last_Name like '%" + LName.Text + "%'" +
                    "and ClientID like '%" + IDtextb.Text + "%'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                ClientsGridView.DataSource = dt;
                conn.Close();
                FName.Text = "First Name";
                FName.ForeColor = Color.Gray;
                MName.Text = "Middle Name";
                MName.ForeColor = Color.Gray;
                LName.Text = "Last Name";
                LName.ForeColor = Color.Gray;
                IDtextb.Text = "ID";
                IDtextb.ForeColor = Color.Gray;
                backbtn.Visible = true;
            }
            else if (FName.Text == "First Name" && MName.Text != "Middle Name" && LName.Text != "Last Name" && IDtextb.Text != "ID")
            {
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from Clients where Middle_Name like '%" + MName.Text + "%' and Last_Name like '%" + LName.Text + "%'" +
                    "and ClientID like '%" + IDtextb.Text + "%'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                ClientsGridView.DataSource = dt;
                conn.Close();
                FName.Text = "First Name";
                FName.ForeColor = Color.Gray;
                MName.Text = "Middle Name";
                MName.ForeColor = Color.Gray;
                LName.Text = "Last Name";
                LName.ForeColor = Color.Gray;
                IDtextb.Text = "ID";
                IDtextb.ForeColor = Color.Gray;
                backbtn.Visible = true;
            }
            else if (FName.Text != "First Name" && MName.Text != "Middle Name" && LName.Text != "Last Name" && IDtextb.Text == "ID")
            {
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from Clients where First_Name like '%" + FName.Text + "%' and Middle_Name like '%" + MName.Text + "%'" +
                    " and Last_Name like '%" + LName.Text + "%'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                ClientsGridView.DataSource = dt;
                conn.Close();
                FName.Text = "First Name";
                FName.ForeColor = Color.Gray;
                MName.Text = "Middle Name";
                MName.ForeColor = Color.Gray;
                LName.Text = "Last Name";
                LName.ForeColor = Color.Gray;
                IDtextb.Text = "ID";
                IDtextb.ForeColor = Color.Gray;
                backbtn.Visible = true;
            }
            else if (FName.Text != "First Name" && MName.Text != "Middle Name" && LName.Text != "Last Name" && IDtextb.Text != "ID")
            {
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from Clients where First_Name like '%" + FName.Text + "%' and Middle_Name like '%" + MName.Text + "%'" +
                    " and Last_Name like '%" + LName.Text + "%' and ClientID like '%" + IDtextb.Text + "%'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                ClientsGridView.DataSource = dt;
                conn.Close();
                FName.Text = "First Name";
                FName.ForeColor = Color.Gray;
                MName.Text = "Middle Name";
                MName.ForeColor = Color.Gray;
                LName.Text = "Last Name";
                LName.ForeColor = Color.Gray;
                IDtextb.Text = "ID";
                IDtextb.ForeColor = Color.Gray;
                backbtn.Visible = true;
            }
            else
            {
                MessageBox.Show("Unexpected Error!");
            }

        }

        private void Removebtn_Click(object sender, EventArgs e)
        {
            if (IDtextb.Text == "ID")
            {
                MessageBox.Show("Please Enter the ID of the client you want to remove!");
            }
            else
            {
                if (MessageBox.Show("Are you sure you want to Remove this client?", "Exit", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    conn.Open();
                    SqlCommand cmd = conn.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "delete from Clients where ClientID = '" + IDtextb.Text + "'";
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    IDtextb.Text = "ID";
                    IDtextb.ForeColor = Color.Gray;
                    display_data();
                    MessageBox.Show("Data deleted successfully!");
                }
                else
                    this.Activate();
            }
        }
        private void Teller_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Are you sure you want to close the program?", "Exit", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
                Application.Exit();
            else if (dialog == DialogResult.No)
                e.Cancel = true;
        }

        private void Checkbtn_Click(object sender, EventArgs e)
        {
            if (IDtextb.Text == "ID")
                MessageBox.Show("Please Enter Client ID");
            else
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from Clients where ClientID like '%" + IDtextb.Text + "%'";
                cmd.Connection = conn;
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    reader.Close();
                    Form2 f2 = new Form2(IDtextb.Text);
                    f2.Show();
                    IDtextb.Text = "ID";
                    IDtextb.ForeColor= Color.Gray;
                }
                else
                    MessageBox.Show("There is no Client that matches this ID.\n Please make sure that you entered a valid ID");
            }
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            display_data();

            backbtn.Visible = false;
        }

        private void IDtextb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void LName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
                e.Handled = true;
        }

        private void MName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
                e.Handled = true;
        }

        private void FName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
                e.Handled = true;
        }

        private void addint_Click(object sender, EventArgs e)
        {
            conn.Open(); 
            SqlCommand cmd = new SqlCommand();
            SqlDataReader reader = null;
            cmd.Connection = conn;
            cmd.CommandText = "select * from Clients where AccountType = '" + "Premium" + "'";
            reader = cmd.ExecuteReader();

            List<string> iddd = new List<string>();
            List<decimal> balance = new List<decimal>();

            while (reader.Read())
            {
                iddd.Add(reader.GetValue(0).ToString());
                balance.Add(Convert.ToDecimal(reader.GetValue(10)));
            }
            reader.Close();

            Premium p = new Premium();
            int i = 0;
            foreach(string id in iddd)
            {
                decimal bb = p.AddInterestToSavingsAccount(balance[i]);

                SqlCommand cmd1 = conn.CreateCommand();
                cmd1.CommandType = CommandType.Text;
                cmd1.CommandText = "update Clients set Balance = '" + bb + "' where ClientID = '" + id + "'";
                cmd1.ExecuteNonQuery();

                i++;
            }

            SqlCommand cmd2 = new SqlCommand();
            SqlDataReader reader2 = null;
            cmd2.Connection = conn;
            cmd2.CommandText = "select * from Clients where AccountType = '" + "Poor" + "'";
            reader2 = cmd2.ExecuteReader();

            List<string> iddd2 = new List<string>();
            List<decimal> balance2 = new List<decimal>();

            while (reader2.Read())
            {
                iddd2.Add(reader2.GetValue(0).ToString());
                balance2.Add(Convert.ToDecimal(reader2.GetValue(10)));
            }
            reader2.Close();

            Client c = new Client();
            i = 0;
            foreach (string id in iddd2)
            {
                decimal bb = c.AddInterestToSavingsAccount(balance2[i]);

                SqlCommand cmd1 = conn.CreateCommand();
                cmd1.CommandType = CommandType.Text;
                cmd1.CommandText = "update Clients set Balance = '" + bb + "' where ClientID = '" + id + "'";
                cmd1.ExecuteNonQuery();

                i++;
            }

            SqlCommand cmd3 = new SqlCommand();
            SqlDataReader reader3 = null;
            cmd3.Connection = conn;
            cmd3.CommandText = "select * from Clients where AccountType = '" + "Minor" + "'";
            reader3 = cmd3.ExecuteReader();

            List<string> iddd3 = new List<string>();
            List<decimal> balance3 = new List<decimal>();

            while (reader3.Read())
            {
                iddd3.Add(reader3.GetValue(0).ToString());
                balance3.Add(Convert.ToDecimal(reader3.GetValue(10)));
            }
            reader3.Close();

            i = 0;
            foreach (string id in iddd3)
            {
                decimal bb = c.AddInterestToSavingsAccount(balance3[i]);

                SqlCommand cmd1 = conn.CreateCommand();
                cmd1.CommandType = CommandType.Text;
                cmd1.CommandText = "update Clients set Balance = '" + bb + "' where ClientID = '" + id + "'";
                cmd1.ExecuteNonQuery();

                i++;
            }

            SqlCommand cmd4 = new SqlCommand();
            SqlDataReader reader4 = null;
            cmd4.Connection = conn;
            cmd4.CommandText = "select * from InvestmentCertificates where Type = '" + "Premium" + "' and YearsNum = '" + 1 + "'";
            reader4 = cmd4.ExecuteReader();

            List<int> iddd4 = new List<int>();
            List<decimal> balance4 = new List<decimal>();

            while (reader4.Read())
            {
                iddd4.Add(Convert.ToInt16(reader4.GetValue(0)));
                balance4.Add(Convert.ToDecimal(reader4.GetValue(1)));
            }
            reader4.Close();

            InvestmentCertificatePremium ip = new InvestmentCertificatePremium();
            i = 0;
            foreach (int id in iddd4)
            {
                decimal bb = ip.AddInterest1(balance4[i]);

                SqlCommand cmd1 = conn.CreateCommand();
                cmd1.CommandType = CommandType.Text;
                cmd1.CommandText = "update InvestmentCertificates set Amount = '" + bb + "' where Id = '" + id + "'";
                cmd1.ExecuteNonQuery();

                i++;
            }

            SqlCommand cmd5 = new SqlCommand();
            SqlDataReader reader5 = null;
            cmd5.Connection = conn;
            cmd5.CommandText = "select * from InvestmentCertificates where Type = '" + "Premium" + "' and YearsNum = '" + 2 + "'";
            reader5 = cmd5.ExecuteReader();

            List<int> iddd5 = new List<int>();
            List<decimal> balance5 = new List<decimal>();

            while (reader5.Read())
            {
                iddd5.Add(Convert.ToInt16(reader5.GetValue(0)));
                balance5.Add(Convert.ToDecimal(reader5.GetValue(1)));
            }
            reader5.Close();

            i = 0;
            foreach (int id in iddd5)
            {
                decimal bb = ip.AddInterest2(balance5[i]);

                SqlCommand cmd1 = conn.CreateCommand();
                cmd1.CommandType = CommandType.Text;
                cmd1.CommandText = "update InvestmentCertificates set Amount = '" + bb + "' where Id = '" + id + "'";
                cmd1.ExecuteNonQuery();

                i++;
            }
            SqlCommand cmd6 = new SqlCommand();
            SqlDataReader reader6 = null;
            cmd6.Connection = conn;
            cmd6.CommandText = "select * from InvestmentCertificates where Type = '" + "Premium" + "' and YearsNum = '" + 3 + "'";
            reader6 = cmd6.ExecuteReader();

            List<int> iddd6 = new List<int>();
            List<decimal> balance6 = new List<decimal>();

            while (reader6.Read())
            {
                iddd6.Add(Convert.ToInt16(reader6.GetValue(0)));
                balance6.Add(Convert.ToDecimal(reader6.GetValue(1)));
            }
            reader6.Close();

            i = 0;
            foreach (int id in iddd6)
            {
                decimal bb = ip.AddInterest3(balance6[i]);

                SqlCommand cmd1 = conn.CreateCommand();
                cmd1.CommandType = CommandType.Text;
                cmd1.CommandText = "update InvestmentCertificates set Amount = '" + bb + "' where Id = '" + id + "'";
                cmd1.ExecuteNonQuery();

                i++;
            }

            SqlCommand cmd8 = new SqlCommand();
            SqlDataReader reader8 = null;
            cmd8.Connection = conn;
            cmd8.CommandText = "select * from InvestmentCertificates where Type = '" + "Poor" + "' and YearsNum = '" + 1 + "'";
            reader8 = cmd8.ExecuteReader();

            List<int> iddd8 = new List<int>();
            List<decimal> balance8 = new List<decimal>();

            while (reader8.Read())
            {
                iddd8.Add(Convert.ToInt16(reader8.GetValue(0)));
                balance8.Add(Convert.ToDecimal(reader8.GetValue(1)));
            }
            reader8.Close();

            InvestmentCertificatePoor ipr = new InvestmentCertificatePoor();
            i = 0;
            foreach (int id in iddd8)
            {
                decimal bb = ipr.AddInterest1(balance8[i]);

                SqlCommand cmd1 = conn.CreateCommand();
                cmd1.CommandType = CommandType.Text;
                cmd1.CommandText = "update InvestmentCertificates set Amount = '" + bb + "' where Id = '" + id + "'";
                cmd1.ExecuteNonQuery();

                i++;
            }
            SqlCommand cmd9 = new SqlCommand();
            SqlDataReader reader9 = null;
            cmd9.Connection = conn;
            cmd9.CommandText = "select * from InvestmentCertificates where Type = '" + "Poor" + "' and YearsNum = '" + 2 + "'";
            reader9 = cmd9.ExecuteReader();

            List<int> iddd9 = new List<int>();
            List<decimal> balance9 = new List<decimal>();

            while (reader9.Read())
            {
                iddd9.Add(Convert.ToInt16(reader9.GetValue(0)));
                balance9.Add(Convert.ToDecimal(reader9.GetValue(1)));
            }
            reader9.Close();

            i = 0;
            foreach (int id in iddd9)
            {
                decimal bb = ipr.AddInterest2(balance9[i]);

                SqlCommand cmd1 = conn.CreateCommand();
                cmd1.CommandType = CommandType.Text;
                cmd1.CommandText = "update InvestmentCertificates set Amount = '" + bb + "' where Id = '" + id + "'";
                cmd1.ExecuteNonQuery();

                i++;
            }
            SqlCommand cmd10 = new SqlCommand();
            SqlDataReader reader10 = null;
            cmd10.Connection = conn;
            cmd10.CommandText = "select * from InvestmentCertificates where Type = '" + "Poor" + "' and YearsNum = '" + 3 + "'";
            reader10 = cmd10.ExecuteReader();

            List<int> iddd10 = new List<int>();
            List<decimal> balance10 = new List<decimal>();

            while (reader10.Read())
            {
                iddd10.Add(Convert.ToInt16(reader10.GetValue(0)));
                balance10.Add(Convert.ToDecimal(reader10.GetValue(1)));
            }
            reader10.Close();

            i = 0;
            foreach (int id in iddd10)
            {
                decimal bb = ipr.AddInterest3(balance10[i]);

                SqlCommand cmd1 = conn.CreateCommand();
                cmd1.CommandType = CommandType.Text;
                cmd1.CommandText = "update InvestmentCertificates set Amount = '" + bb + "' where Id = '" + id + "'";
                cmd1.ExecuteNonQuery();

                i++;
            }
            SqlCommand cmd11 = new SqlCommand();
            SqlDataReader reader11 = null;
            cmd11.Connection = conn;
            cmd11.CommandText = "select * from InvestmentCertificates where Type = '" + "Minor" + "' and YearsNum = '" + 1 + "'";
            reader11 = cmd11.ExecuteReader();

            List<int> iddd11 = new List<int>();
            List<decimal> balance11 = new List<decimal>();

            while (reader11.Read())
            {
                iddd11.Add(Convert.ToInt16(reader11.GetValue(0)));
                balance11.Add(Convert.ToDecimal(reader11.GetValue(1)));
            }
            reader11.Close();

            i = 0;
            foreach (int id in iddd11)
            {
                decimal bb = ipr.AddInterest1(balance11[i]);

                SqlCommand cmd1 = conn.CreateCommand();
                cmd1.CommandType = CommandType.Text;
                cmd1.CommandText = "update InvestmentCertificates set Amount = '" + bb + "' where Id = '" + id + "'";
                cmd1.ExecuteNonQuery();

                i++;
            }
            SqlCommand cmd12 = new SqlCommand();
            SqlDataReader reader12 = null;
            cmd12.Connection = conn;
            cmd12.CommandText = "select * from InvestmentCertificates where Type = '" + "Minor" + "' and YearsNum = '" + 2 + "'";
            reader12 = cmd12.ExecuteReader();

            List<int> iddd12 = new List<int>();
            List<decimal> balance12 = new List<decimal>();

            while (reader12.Read())
            {
                iddd12.Add(Convert.ToInt16(reader12.GetValue(0)));
                balance12.Add(Convert.ToDecimal(reader12.GetValue(1)));
            }
            reader12.Close();

            i = 0;
            foreach (int id in iddd12)
            {
                decimal bb = ipr.AddInterest2(balance12[i]);

                SqlCommand cmd1 = conn.CreateCommand();
                cmd1.CommandType = CommandType.Text;
                cmd1.CommandText = "update InvestmentCertificates set Amount = '" + bb + "' where Id = '" + id + "'";
                cmd1.ExecuteNonQuery();

                i++;
            }
            SqlCommand cmd13 = new SqlCommand();
            SqlDataReader reader13 = null;
            cmd13.Connection = conn;
            cmd13.CommandText = "select * from InvestmentCertificates where Type = '" + "Minor" + "' and YearsNum = '" + 3 + "'";
            reader13 = cmd13.ExecuteReader();

            List<int> iddd13 = new List<int>();
            List<decimal> balance13 = new List<decimal>();

            while (reader13.Read())
            {
                iddd13.Add(Convert.ToInt16(reader13.GetValue(0)));
                balance13.Add(Convert.ToDecimal(reader13.GetValue(1)));
            }
            reader13.Close();

            i = 0;
            foreach (int id in iddd13)
            {
                decimal bb = ipr.AddInterest3(balance13[i]);

                SqlCommand cmd1 = conn.CreateCommand();
                cmd1.CommandType = CommandType.Text;
                cmd1.CommandText = "update InvestmentCertificates set Amount = '" + bb + "' where Id = '" + id + "'";
                cmd1.ExecuteNonQuery();

                i++;
            }
            conn.Close();
            display_data();
        }
    }
}
