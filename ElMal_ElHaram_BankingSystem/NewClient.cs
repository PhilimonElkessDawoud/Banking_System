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
    public partial class NewClient : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\ElMal_ElHaram_BankingSystem\ElMal_ElHaram_BankingSystem\Persons.mdf;Integrated Security=True");

        char gender;
        public NewClient()
        {
            InitializeComponent();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            if(FirstName_C.Text == "")
            {
                MessageBox.Show("Enter First Name!");
                FirstName_C.Focus();
            }
            else if (MiddleName_C.Text == "")
            {
                MessageBox.Show("Enter Middle Name!");
                MiddleName_C.Focus();
            }
            else if (LastName_C.Text == "")
            {
                MessageBox.Show("Enter Last Name!");
                LastName_C.Focus();
            }
            else if (!Male.Checked && !Female.Checked)
            {
                MessageBox.Show("Specify your gender!");
            }
            else if (Birthday.Text == "Day")
            {
                MessageBox.Show("Enter your day of birth!");
                Birthday.Focus();
            }
            else if(Convert.ToInt16(Birthday.Text) > 31 || Convert.ToInt16(Birthday.Text) < 1)
            {
                MessageBox.Show("Stop playing! Enter your day of birth!");
                Birthday.Focus();
            }
            else if (Birthmonth.Text == "Month")
            {
                MessageBox.Show("Enter your month of birth!");
                Birthmonth.Focus();
            }
            else if (Birthmonth.Text != "January" && Birthmonth.Text != "February" && Birthmonth.Text != "Mars" && Birthmonth.Text != "April" &&
                Birthmonth.Text != "May" && Birthmonth.Text != "June" && Birthmonth.Text != "July" && Birthmonth.Text != "August" &&
                Birthmonth.Text != "September" && Birthmonth.Text != "October" && Birthmonth.Text != "November" && Birthmonth.Text != "December")
            {
                MessageBox.Show("Enter a valid month of birth!");
                Birthmonth.Focus();
            }
            else if (Birthyear.Text == "Year")
            {
                MessageBox.Show("Enter your year of birth!");
                Birthyear.Focus();
            }
            else if (Convert.ToInt16(Birthyear.Text) < 1900)
            {
                MessageBox.Show("Liar! Enter ur real year of birth!");
                Birthyear.Focus();
            }
            else if (Phone_C.Text == "")
            {
                MessageBox.Show("Enter your phone number!");
                Phone_C.Focus();
            }
            else if (Balane_C.Text == "")
            {
                MessageBox.Show("Enter your balance!");
                Balane_C.Focus();
            }
            else if (Email_C.Text == "")
            {
                MessageBox.Show("Enter your Email!");
                Email_C.Focus();
            }
            else if (Addres_C.Text == "")
            {
                MessageBox.Show("Enter your Address!");
                Addres_C.Focus();
            }
            else
            {
                int x;
                string id;
                SqlCommand cmd = new SqlCommand();
                SqlDataReader reader = null;
                cmd.Connection = conn;
                cmd.CommandText = "Select Top(1) ClientID from Clients order by ClientID desc";
                conn.Open();
                reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    x = Convert.ToInt32(reader.GetValue(0)) + 1;
                    id = x.ToString("D8");
                }
                else
                    id = "00000000";
                reader.Close();

                int mon = 0;
                switch (Birthmonth.Text)
                {
                    case "January":mon = 1; break;

                    case "February":mon = 2; break;

                    case "Mars":mon = 3; break;

                    case "April":mon = 4; break;

                    case "May":mon = 5; break;

                    case "June":mon = 6; break;

                    case "July": mon = 7; break;

                    case "August": mon = 8; break;

                    case "September":mon = 9; break;

                    case "October":mon = 10; break;

                    case "November":mon = 11; break;

                    case "December":mon = 12; break;
                }

                SqlCommand cmd1 = new SqlCommand();

                SqlCommand cmd2 = conn.CreateCommand();
                cmd2.CommandType = CommandType.Text;
                cmd2.Connection = conn;

                int age = DateTime.Now.Year - Convert.ToInt16(Birthyear.Text);
                if (age <= 21)
                {                   
                    cmd1.CommandText = "Select * from Clients where Middle_Name = '" + MiddleName_C.Text + "' and Last_Name = '" + LastName_C.Text + "'";
                    cmd1.Connection = conn;
                    SqlDataReader reader1 = cmd1.ExecuteReader();

                    if (reader1.Read())
                    {
                        reader1.Close();
                        Minor m = new Minor(id, FirstName_C.Text, MiddleName_C.Text, LastName_C.Text, Convert.ToInt16(Birthyear.Text),

                           mon, Convert.ToInt16(Birthday.Text), Email_C.Text, Phone_C.Text, Addres_C.Text, gender,

                           Convert.ToDecimal(Balane_C.Text));

                        cmd2.CommandText = "insert into [Clients] (ClientID, First_Name, Middle_Name, Last_Name, Birthdate, Age, Email, Phone, Address, " +

                            "Gender, Balance, AccountType, Password) values('" + m.ClientID + "', '" + m.FirstName + "','" + m.MiddleName + "', '" + m.LastName + "'," +

                            "'" + m.Birthdate + "', '" + age + "', '" + m.Email + "', '" + m.PhoneNumber + "', '" + m.Address + "', '" + m.Gender + "', " +

                            "'" + m.Balance + "', '" + m.AccountType + "', '" + m.Password + "')";

                        cmd2.ExecuteNonQuery();

                        FirstName_C.Text = "";
                        MiddleName_C.Text = "";
                        LastName_C.Text = "";
                        Male.Checked = false;
                        Female.Checked = false;
                        Birthday.Text = "Day";
                        Birthday.ForeColor = Color.Gray;
                        Birthmonth.Text = "Month";
                        Birthmonth.ForeColor = Color.Gray;
                        Birthyear.Text = "Year";
                        Birthyear.ForeColor = Color.Gray;
                        Phone_C.Text = "";
                        Balane_C.Text = "";
                        Email_C.Text = "";
                        Addres_C.Text = "";

                        MessageBox.Show("Client added Successfully!");

                    }
                    else
                    {
                        reader1.Close();
                        MessageBox.Show("A minor must have a registered parent in the Banking System");
                    }
                }
                else if(Convert.ToDecimal(Balane_C.Text) >= 1000000.0m)
                {
                    Premium p = new Premium(id, FirstName_C.Text, MiddleName_C.Text, LastName_C.Text, Convert.ToInt16(Birthyear.Text),

                       mon, Convert.ToInt16(Birthday.Text), Email_C.Text, Phone_C.Text, Addres_C.Text, gender,

                       Convert.ToDecimal(Balane_C.Text));

                    cmd2.CommandText = "insert into [Clients] (ClientID, First_Name, Middle_Name, Last_Name, Birthdate, Age, Email, Phone, Address, " +

                           "Gender, Balance, AccountType, Password) values('" + p.ClientID + "', '" + p.FirstName + "','" + p.MiddleName + "', '" + p.LastName + "'," +

                           "'" + p.Birthdate + "', '" + age + "', '" + p.Email + "', '" + p.PhoneNumber + "', '" + p.Address + "', '" + p.Gender + "', " +

                           "'" + p.Balance + "', '" + p.AccountType + "', '" + p.Password + "')";

                    cmd2.ExecuteNonQuery();

                    FirstName_C.Text = "";
                    MiddleName_C.Text = "";
                    LastName_C.Text = "";
                    Male.Checked = false;
                    Female.Checked = false;
                    Birthday.Text = "Day";
                    Birthday.ForeColor = Color.Gray;
                    Birthmonth.Text = "Month";
                    Birthmonth.ForeColor = Color.Gray;
                    Birthyear.Text = "Year";
                    Birthyear.ForeColor = Color.Gray;
                    Phone_C.Text = "";
                    Balane_C.Text = "";
                    Email_C.Text = "";
                    Addres_C.Text = "";

                    MessageBox.Show("Client added Successfully!");

                }
                else
                {
                    Client c = new Client(id, FirstName_C.Text, MiddleName_C.Text, LastName_C.Text, Convert.ToInt16(Birthyear.Text),

                       mon, Convert.ToInt16(Birthday.Text), Email_C.Text, Phone_C.Text, Addres_C.Text, gender,

                       Convert.ToDecimal(Balane_C.Text));

                    cmd2.CommandText = "insert into [Clients] (ClientID, First_Name, Middle_Name, Last_Name, Birthdate, Age, Email, Phone, Address, " +

                           "Gender, Balance, AccountType, Password) values('" + c.ClientID + "', '" + c.FirstName + "','" + c.MiddleName + "', '" + c.LastName + "'," +

                           "'" + c.Birthdate + "', '" + age + "', '" + c.Email + "', '" + c.PhoneNumber + "', '" + c.Address + "', '" + c.Gender + "', " +

                           "'" + c.Balance + "', '" + c.AccountType + "', '" + c.Password + "')";

                    cmd2.ExecuteNonQuery();

                    FirstName_C.Text = "";
                    MiddleName_C.Text = "";
                    LastName_C.Text = "";
                    Male.Checked = false;
                    Female.Checked = false;
                    Birthday.Text = "Day";
                    Birthday.ForeColor = Color.Gray;
                    Birthmonth.Text = "Month";
                    Birthmonth.ForeColor = Color.Gray;
                    Birthyear.Text = "Year";
                    Birthyear.ForeColor = Color.Gray;
                    Phone_C.Text = "";
                    Balane_C.Text = "";
                    Email_C.Text = "";
                    Addres_C.Text = "";

                    string p = "Your password is" + c.Password;

                    MessageBox.Show("Client added Successfully!");
                    MessageBox.Show(p);
                }
                conn.Close();

                Teller.t.display_data();
            }
        }

        private void FirstName_C_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
                e.Handled = true;
        }

        private void MiddleName_C_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
                e.Handled = true;
        }

        private void LastName_C_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
                e.Handled = true;
        }

        private void Phone_C_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void Balane_C_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
                e.Handled = true;
        }

        private void Birthday_Enter(object sender, EventArgs e)
        {
            if (Birthday.Text == "Day")
                Birthday.Text = "";
            Birthday.ForeColor = Color.Black;
        }


        private void Birthyear_Enter(object sender, EventArgs e)
        {
            if (Birthyear.Text == "Year")
                Birthyear.Text = "";
            Birthyear.ForeColor = Color.Black;
        }

        private void Birthmonth_Enter(object sender, EventArgs e)
        {
            if (Birthmonth.Text == "Month")
                Birthmonth.Text = "";
            Birthmonth.ForeColor = Color.Black;
        }

        private void Male_CheckedChanged(object sender, EventArgs e)
        {
            gender = 'M';
        }

        private void Female_CheckedChanged(object sender, EventArgs e)
        {
            gender = 'F';
        }

        private void Birthday_Leave(object sender, EventArgs e)
        {
            if(Birthday.Text == "")
            {
                Birthday.Text = "Day";
                Birthday.ForeColor = Color.Gray;
            }
        }

        private void Birthmonth_Leave(object sender, EventArgs e)
        {
            if (Birthmonth.Text == "")
            {
                Birthmonth.Text = "Month";
                Birthmonth.ForeColor = Color.Gray;
            }
        }

        private void Birthyear_Leave(object sender, EventArgs e)
        {
            if (Birthyear.Text == "")
            {
                Birthyear.Text = "Year";
                Birthyear.ForeColor = Color.Gray;
            }
        }

        private void Birthday_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void Birthyear_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }
    }
}
