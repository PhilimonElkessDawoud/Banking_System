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
    public partial class Form2 : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\ElMal_ElHaram_BankingSystem\ElMal_ElHaram_BankingSystem\Persons.mdf;Integrated Security=True");

        string id;

        public void display_data_Certificates(string idd)
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from InvestmentCertificates where ClientID like '%" + idd + "%'";
                cmd.ExecuteNonQuery();
                DataTable dta = new DataTable();
                SqlDataAdapter dataadp = new SqlDataAdapter(cmd);
                dataadp.Fill(dta);
                CertificatesGridView.DataSource = dta;
                conn.Close();
            }
            else
            {
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from InvestmentCertificates where ClientID like '%" + idd + "%'";
                cmd.ExecuteNonQuery();
                DataTable dta = new DataTable();
                SqlDataAdapter dataadp = new SqlDataAdapter(cmd);
                dataadp.Fill(dta);
                CertificatesGridView.DataSource = dta;
                conn.Close();
            }

        }
        public void display_data_Transactions(string idd)
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from Tr where ClientID like '%" + idd + "%'";
                cmd.ExecuteNonQuery();
                DataTable dta = new DataTable();
                SqlDataAdapter dataadp = new SqlDataAdapter(cmd);
                dataadp.Fill(dta);
                TransactionsGridView.DataSource = dta;
                conn.Close();
            }
            else
            {
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from Tr where ClientID like '%" + idd + "%'";
                cmd.ExecuteNonQuery();
                DataTable dta = new DataTable();
                SqlDataAdapter dataadp = new SqlDataAdapter(cmd);
                dataadp.Fill(dta);
                TransactionsGridView.DataSource = dta;
                conn.Close();
            }

        }
        public Form2(string idteller)
        {
            InitializeComponent();

            id = idteller;
        }

        private void LogOutbtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to Log Out?", "Log Out", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Form1 f1 = new Form1();
                f1.Show();
                this.Hide();
            }
            else
                this.Activate();
        }

        /*private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Are you sure you want to close the program?", "Exit", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
                Application.Exit();
            else if (dialog == DialogResult.No)
                e.Cancel = true;
        }*/

        private void Form2_Load(object sender, EventArgs e)
        {
            display_data_Certificates(id);
            display_data_Transactions(id);

            SqlCommand cmd1 = new SqlCommand();
            SqlDataReader reader = null;
            cmd1.Connection = conn;
            cmd1.CommandText = "Select * from Clients where ClientID like '%" + id + "%'";
            conn.Open();
            reader = cmd1.ExecuteReader();
            if (reader.Read())
            {
                FNamelbl.Text = reader.GetValue(1).ToString();
                MNamelbl.Text = reader.GetValue(2).ToString();
                LNamelbl.Text = reader.GetValue(3).ToString();
                DOBlbl.Text = ((DateTime)reader.GetValue(4)).ToString("d");
                Agelbl.Text = reader.GetValue(5).ToString();
                Emaillbl.Text = reader.GetValue(6).ToString();
                PNumlbl.Text = reader.GetValue(7).ToString();
                Addresslbl.Text = reader.GetValue(8).ToString();
                Genderlbl.Text = reader.GetValue(9).ToString();
                Balancelbl.Text = reader.GetValue(10).ToString();
                AccTlbl.Text = reader.GetValue(12).ToString();
                Passlbl.Text = reader.GetValue(13).ToString();
                if (Convert.ToInt16(Agelbl.Text) < 18)
                {
                    Withdraw.Enabled = false;
                    Deposit.Enabled = false;
                    Transfer.Enabled = false;
                    Parentid.Visible = true;
                    label17.Visible = true;
                    Enterid.Visible = true;
                }
                else if (Convert.ToInt16(Agelbl.Text) < 21)
                {
                    Withdraw.Enabled = false;
                    Transfer.Enabled = false;
                    Parentid.Visible = true;
                    label17.Visible = true;
                    Enterid.Visible = true;
                }
            }
            else
                MessageBox.Show("Error: Client Not Found!");
            reader.Close();
            conn.Close();
        }

        private void Withdraw_Click(object sender, EventArgs e)
        {
            if (amount.Text == "")
                MessageBox.Show("Please Enter the amount desired to withdraw!");
            else if (Convert.ToDecimal(amount.Text) > Convert.ToDecimal(Balancelbl.Text))
            {
                MessageBox.Show("You don't have that much money, Poor!");
            }
            else
            {
                decimal newbalance = Convert.ToDecimal(Balancelbl.Text) - Convert.ToDecimal(amount.Text);
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "update Clients set Balance = '" + newbalance + "' where ClientID = '" + id + "'";
                cmd.ExecuteNonQuery();
                conn.Close();
                Balancelbl.Text = newbalance.ToString();
                

                string tr = Withdraw.Text + ": " + amount.Text;
                conn.Open();
                SqlCommand cmd5 = conn.CreateCommand();
                cmd5.CommandType = CommandType.Text;
                cmd5.CommandText = "insert into Tr (Transactionn, DOT, ClientID) values('" + tr + "', '" + DateTime.Now + "', '" + id + "')";
                cmd5.ExecuteNonQuery();
                conn.Close();
                display_data_Transactions(id);

                amount.Text = "";
                MessageBox.Show("Transaction executed successfully!");
                Teller.t.display_data();
            }
        }

        private void Parentid_Enter(object sender, EventArgs e)
        {
            if (Parentid.Text == "Parent ID")
            {
                Parentid.Text = "";
                Parentid.ForeColor = Color.Black;
            }
        }

        private void Parentid_Leave(object sender, EventArgs e)
        {
            if (Parentid.Text == "")
            {
                Parentid.Text = "Parent ID";
                Parentid.ForeColor = Color.Gray;
            }
        }

        private void Enterid_Click(object sender, EventArgs e)
        {
            SqlCommand cmd1 = new SqlCommand();
            SqlDataReader reader = null;
            cmd1.Connection = conn;
            cmd1.CommandText = "Select * from Clients where ClientID like '%" + Parentid.Text + "%'";
            conn.Open();
            reader = cmd1.ExecuteReader();
            if (reader.Read())
            {
                if ((string)reader.GetValue(2) == MNamelbl.Text && (string)reader.GetValue(3) == LNamelbl.Text)
                {
                    Withdraw.Enabled = true;
                    Deposit.Enabled = true;
                    Transfer.Enabled = true;
                    Parentid.Text = "Parent ID";
                    Parentid.ForeColor = Color.Gray;
                }
                else
                    MessageBox.Show("Sorry that is not your parent");
            }
            else
            {
                MessageBox.Show("Please Enter a Valid ID!");
            }

            reader.Close();
            conn.Close();
        }

        private void Deposit_Click(object sender, EventArgs e)
        {
            if (amount.Text == "")
                MessageBox.Show("Please Enter the amount desired to deposit!");
            else
            {
                decimal newbalance = Convert.ToDecimal(Balancelbl.Text) + Convert.ToDecimal(amount.Text);
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "update Clients set Balance = '" + newbalance + "' where ClientID = '" + id + "'";
                cmd.ExecuteNonQuery();
                conn.Close();

                string tr = Deposit.Text + ": " + Convert.ToString(amount.Text);

                conn.Open();
                SqlCommand cmd5 = conn.CreateCommand();
                cmd5.CommandType = CommandType.Text;
                cmd5.CommandText = "insert into Tr (Transactionn, DOT, ClientID) values('" + tr + "', '" + DateTime.Now + "', '" + id + "')";
                cmd5.ExecuteNonQuery();
                conn.Close();
                display_data_Transactions(id);

                Balancelbl.Text = newbalance.ToString();
                amount.Text = "";
                MessageBox.Show("Transaction executed successfully!");
                Teller.t.display_data();
            }
        }

        private void amount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void Transfer_Click(object sender, EventArgs e)
        {
            if (amount.Text == "")
                MessageBox.Show("Please Enter the amount desired to transfer!");
            else if (transfertb.Text == "")
            {
                MessageBox.Show("Please enter the id of the client you want to transfer to!");
            }
            else if (Convert.ToDecimal(amount.Text) > Convert.ToDecimal(Balancelbl.Text))
            {
                MessageBox.Show("You don't have that much money, Poor!");
            }
            else
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from Clients where ClientID like '%" + transfertb.Text + "%'";
                cmd.Connection = conn;
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    decimal newbalance = Convert.ToDecimal(Balancelbl.Text) - Convert.ToDecimal(amount.Text);

                    decimal newbalance2 = Convert.ToDecimal(reader.GetValue(10)) + Convert.ToDecimal(amount.Text);

                    reader.Close();

                    SqlCommand cmd2 = conn.CreateCommand();
                    cmd2.CommandType = CommandType.Text;
                    cmd2.CommandText = "update Clients set Balance = '" + newbalance + "' where ClientID = '" + id + "'";
                    cmd2.ExecuteNonQuery();
                    SqlCommand cmd3 = conn.CreateCommand();
                    cmd3.CommandType = CommandType.Text;
                    cmd3.CommandText = "update Clients set Balance = '" + newbalance2 + "' where ClientID = '" + transfertb.Text + "'";
                    cmd3.ExecuteNonQuery();
                    conn.Close();
                    Balancelbl.Text = newbalance.ToString();
                    

                    string tr = Transfer.Text + ": " + Convert.ToString(amount.Text) + "To:" + transfertb.Text;

                    conn.Open();
                    SqlCommand cmd5 = conn.CreateCommand();
                    cmd5.CommandType = CommandType.Text;
                    cmd5.CommandText = "insert into Tr (Transactionn, DOT, ClientID) values('" + tr + "', '" + DateTime.Now + "', '" + id + "')";
                    cmd5.ExecuteNonQuery();
                    conn.Close();
                    display_data_Transactions(id);

                    amount.Text = "";
                    transfertb.Text = "";
                    MessageBox.Show("Transaction executed successfully!");
                    Teller.t.display_data();
                }
                else
                {
                    MessageBox.Show("There is no Client that matches this ID.\n Please make sure that you entered a valid ID");
                    conn.Close();
                }


            }
        }

        private void transfertb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void Parentid_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void year1_Click(object sender, EventArgs e)
        {
            if (amount.Text == "")
            {
                MessageBox.Show("Please Enter an amount");
            }
            else
            {
                int x;
                SqlCommand cmd = new SqlCommand();
                SqlDataReader reader = null;
                cmd.Connection = conn;
                cmd.CommandText = "Select Top(1) Id from InvestmentCertificates order by Id desc";
                conn.Open();
                reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    x = (int)reader.GetValue(0) + 1;
                }
                else
                    x = 0;
                reader.Close();
                conn.Close();
                //MessageBox.Show(x.ToString());

                conn.Open();
                SqlCommand cmd5 = conn.CreateCommand();
                cmd5.CommandType = CommandType.Text;
                cmd5.CommandText = "insert into InvestmentCertificates (Id, Amount, StartingDate, YearsNum, ExpiryDate, ClientID, Type) " +
                    "values('" + x + "', '" + Convert.ToDecimal(amount.Text) + "', '" + DateTime.Now + "', '" + 1 + "', '" + DateTime.Now.AddYears(1) + "'," +
                    "'" + id + "', '" + AccTlbl.Text + "')";
                cmd5.ExecuteNonQuery();
                conn.Close();

                string tr = $"{amount.Text} Has been added to a 1 years certificate";
                amount.Text = "";
                display_data_Certificates(id);
                
                conn.Open();

                SqlCommand cmd3 = conn.CreateCommand();
                cmd3.CommandType = CommandType.Text;
                cmd3.CommandText = "insert into Tr (Transactionn, DOT, ClientID) values('" + tr + "', '" + DateTime.Now + "', '" + id + "')";
                cmd3.ExecuteNonQuery();
                conn.Close();
                display_data_Transactions(id);
                MessageBox.Show("Certificate added Successfully!");

            }
        }

        private void year2_Click(object sender, EventArgs e)
        {
            if (amount.Text == "")
            {
                MessageBox.Show("Please Enter an amount");
            }
            else
            {
                int x;
                SqlCommand cmd = new SqlCommand();
                SqlDataReader reader = null;
                cmd.Connection = conn;
                cmd.CommandText = "Select Top(1) Id from InvestmentCertificates order by Id desc";
                conn.Open();
                reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    x = (int)reader.GetValue(0) + 1;
                }
                else
                    x = 0;
                reader.Close();
                conn.Close();
                //MessageBox.Show(x.ToString());

                conn.Open();
                SqlCommand cmd5 = conn.CreateCommand();
                cmd5.CommandType = CommandType.Text;
                cmd5.CommandText = "insert into InvestmentCertificates (Id, Amount, StartingDate, YearsNum, ExpiryDate, ClientID, Type) " +
                    "values('" + x + "', '" + Convert.ToDecimal(amount.Text) + "', '" + DateTime.Now + "', '" + 2 + "', '" + DateTime.Now.AddYears(2) + "'," +
                    "'" + id + "', '" + AccTlbl.Text + "')";
                cmd5.ExecuteNonQuery();
                conn.Close();
                

                string tr = Convert.ToString(amount.Text) + " Has been added to a 2 years certificate";
                amount.Text = "";
                display_data_Certificates(id);
                
                conn.Open();
                SqlCommand cmd3 = conn.CreateCommand();
                cmd3.CommandType = CommandType.Text;
                cmd3.CommandText = "insert into Tr (Transactionn, DOT, ClientID) values('" + tr + "', '" + DateTime.Now + "', '" + id + "')";
                cmd3.ExecuteNonQuery();
                conn.Close();
                display_data_Transactions(id);
                MessageBox.Show("Certificate added Successfully!");
            }
        }

        private void year3_Click(object sender, EventArgs e)
        {
            if (amount.Text == "")
            {
                MessageBox.Show("Please Enter an amount");
            }
            else
            {
                int x;
                SqlCommand cmd = new SqlCommand();
                SqlDataReader reader = null;
                cmd.Connection = conn;
                cmd.CommandText = "Select Top(1) Id from InvestmentCertificates order by Id desc";
                conn.Open();
                reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    x = (int)reader.GetValue(0) + 1;
                }
                else
                    x = 0;
                reader.Close();
                conn.Close();
                //MessageBox.Show(x.ToString());

                conn.Open();
                SqlCommand cmd5 = conn.CreateCommand();
                cmd5.CommandType = CommandType.Text;
                cmd5.CommandText = "insert into InvestmentCertificates (Id, Amount, StartingDate, YearsNum, ExpiryDate, ClientID, Type) " +
                    "values('" + x + "', '" + Convert.ToDecimal(amount.Text) + "', '" + DateTime.Now + "', '" + 3 + "', '" + DateTime.Now.AddYears(3) + "'," +
                    "'" + id + "', '" + AccTlbl.Text + "')";
                cmd5.ExecuteNonQuery();
                conn.Close();
                

                string tr = Convert.ToString(amount.Text) + " Has been added to a 3 years certificate";
                amount.Text = "";
                display_data_Certificates(id);
                

                conn.Open();
                SqlCommand cmd3 = conn.CreateCommand();
                cmd3.CommandType = CommandType.Text;
                cmd3.CommandText = "insert into Tr (Transactionn, DOT, ClientID) values('" + tr + "', '" + DateTime.Now + "', '" + id + "')";
                cmd3.ExecuteNonQuery();
                conn.Close();
                display_data_Transactions(id); 
                MessageBox.Show("Certificate added Successfully!");
            }
        }

        private void breakbtn_Click(object sender, EventArgs e)
        {
            if(certid.Text == "Certificate ID")
            {
                MessageBox.Show("Please Enter the Id of the certificate you want to break!");
            }
            else
            {
                decimal z = 0m;
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from InvestmentCertificates where Id = '" + Convert.ToInt16(certid.Text) + "'";
                cmd.Connection = conn;
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    z = Convert.ToDecimal(Balancelbl.Text) + (decimal)reader.GetValue(1);

                    reader.Close();
                    //conn.Open();
                    SqlCommand cmd8 = conn.CreateCommand();
                    cmd8.CommandType = CommandType.Text;
                    cmd8.CommandText = "delete from InvestmentCertificates where Id = '" + Convert.ToInt16(certid.Text) + "'";
                    cmd8.ExecuteNonQuery();
                    conn.Close();
                    display_data_Certificates(id);

                    conn.Open();
                    SqlCommand cmd9 = conn.CreateCommand();
                    cmd9.CommandType = CommandType.Text;
                    cmd9.CommandText = "update Clients set Balance = '" + z +"' where ClientID = '" + id +"'";
                    Balancelbl.Text = z.ToString();
                    cmd9.ExecuteNonQuery();
                    conn.Close();
                    certid.Text = "Certificate ID";
                    certid.ForeColor = Color.Gray;
                    Teller.t.display_data();

                    string tr = breakbtn.Text + ": " + certid.Text ;

                    conn.Open();
                    SqlCommand cmd5 = conn.CreateCommand();
                    cmd5.CommandType = CommandType.Text;
                    cmd5.CommandText = "insert into Tr (Transactionn, DOT, ClientID) values('" + tr + "', '" + DateTime.Now + "', '" + id + "')";
                    cmd5.ExecuteNonQuery();
                    conn.Close();
                    display_data_Transactions(id);
                } 
            }
        }

        private void certid_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void certid_Enter(object sender, EventArgs e)
        {
            if(certid.Text == "Certificate ID")
            {
                certid.Text = "";
                certid.ForeColor = Color.Black;
            }
        }

        private void certid_Leave(object sender, EventArgs e)
        {
            if (certid.Text == "")
            {
                certid.Text = "Certificate ID";
                certid.ForeColor = Color.Gray;
            }
        }
    }
}
