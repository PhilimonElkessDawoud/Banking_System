using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElMal_ElHaram_BankingSystem
{
    internal class Client
    {
        private string clientid;
        private string firstname;
        private string middlename;
        private string lastname;
        private DateTime birthdate;
        private string email;
        private string password;
        private string phonenumber;
        private string address;
        private char gender;
        private decimal balance; // helloo 
        protected string accounttype;

        static Random random = new Random();
        public Client() {}
        public Client(string clientid, string firstname, string middlename, string lastname, int birthyear, int birthmonth, int birthday, string email,
            
            string phonenumber, string address, char gender, decimal balance)


        {
            this.clientid = clientid;
            this.firstname = firstname;
            this.middlename = middlename;
            this.lastname = lastname;
            this.birthdate = new DateTime(birthyear,birthmonth,birthday);
            this.email = email;
            this.password = GeneratePassword();
            this.phonenumber = phonenumber;
            this.address = address;
            this.gender = gender;
            this.balance = balance;
            this.accounttype = "Poor";
        }
        public string ClientID
        {
            get { return clientid; }
        }
        public string FirstName
        {
            set { firstname = value; }
            get { return firstname; }
        }
        public string MiddleName
        {
            set { middlename = value; }
            get { return middlename; }
        }
        public string LastName
        {
            set { lastname = value; }
            get { return lastname; }
        }
        public DateTime Birthdate
        {
            set { birthdate = value; }
            get { return birthdate; }
        }
        public string Email
        {
            set { email = value; }
            get { return email; }
        }
        public string Password
        {
            set { password = GeneratePassword(); }
            get { return password; }
        }
        public string PhoneNumber
        {
            set { phonenumber = value; }
            get { return phonenumber; }
        }
        public string Address
        {
            set { address = value; }
            get { return address; }
        }
        public char Gender
        {
            set { gender = value; }
            get { return gender; }
        }
        public decimal Balance
        {
            set { balance = value; }
            get { return balance; }
        }
        public string AccountType 
        { 
            set { accounttype = value; }
            get { return accounttype; } 
        }
        public static string GeneratePassword()
        {
            string p = "";

            for (int i = 0; i < 10; i++)
            {
                int x = random.Next(1, 5);

                if (x == 1)
                {
                    p += Convert.ToString(random.Next(0, 10));
                }
                else if (x == 2)
                {
                    p += char.ConvertFromUtf32(random.Next(65, 91));
                }
                else if (x == 3)
                {
                    p += char.ConvertFromUtf32(random.Next(97, 123));
                }
                else if (x == 4)
                {
                    p += char.ConvertFromUtf32(random.Next(33, 48));
                }
            }

            return p;
        }
        public virtual decimal AddInterestToSavingsAccount(decimal balance)
        {
            return balance + 0.06m * balance;
        }
    }
    internal class Premium : Client
    {
        public Premium() {}
        public Premium(string clientid, string firstname, string middlename, string lastname, int birthyear, int birthmonth, int birthday, string email, string phonenumber,
            string address, char gender, decimal balance)

            : base(clientid, firstname, middlename, lastname, birthyear, birthmonth, birthday, email, phonenumber,address,gender, balance)

        {
            this.accounttype = "Premium";
        }

        public sealed override decimal AddInterestToSavingsAccount(decimal balance)
        {
            return balance + (0.09m * balance);
        }
    }
    internal class Minor : Client
    {
        public Minor() {}
        public Minor(string clientid, string firstname, string middlename, string lastname, int birthyear, int birthmonth, int birthday, string email,
            string phonenumber, string address, char gender, decimal balance)

            : base(clientid, firstname, middlename, lastname, birthyear, birthmonth, birthday, email, phonenumber, address, gender, balance)

        {
            this.accounttype = "Minor";
        }
    }
}
