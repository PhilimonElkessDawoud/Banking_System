namespace ElMal_ElHaram_BankingSystem
{
    partial class Form2Client
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
            this.Enterid = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.Parentid = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.Passlbl = new System.Windows.Forms.Label();
            this.AccTlbl = new System.Windows.Forms.Label();
            this.Agelbl = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.transfertb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.amount = new System.Windows.Forms.TextBox();
            this.MNamelbl = new System.Windows.Forms.Label();
            this.LNamelbl = new System.Windows.Forms.Label();
            this.Genderlbl = new System.Windows.Forms.Label();
            this.DOBlbl = new System.Windows.Forms.Label();
            this.PNumlbl = new System.Windows.Forms.Label();
            this.Balancelbl = new System.Windows.Forms.Label();
            this.Emaillbl = new System.Windows.Forms.Label();
            this.Addresslbl = new System.Windows.Forms.Label();
            this.Address = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.Label();
            this.PhoneNumber = new System.Windows.Forms.Label();
            this.Balance = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.FNamelbl = new System.Windows.Forms.Label();
            this.Deposit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Transfer = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Withdraw = new System.Windows.Forms.Button();
            this.TransactionsGridView = new System.Windows.Forms.DataGridView();
            this.CertificatesGridView = new System.Windows.Forms.DataGridView();
            this.Logoutbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TransactionsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CertificatesGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // Enterid
            // 
            this.Enterid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Enterid.Location = new System.Drawing.Point(236, 330);
            this.Enterid.Name = "Enterid";
            this.Enterid.Size = new System.Drawing.Size(119, 26);
            this.Enterid.TabIndex = 106;
            this.Enterid.Text = "Enter";
            this.Enterid.UseVisualStyleBackColor = true;
            this.Enterid.Visible = false;
            this.Enterid.Click += new System.EventHandler(this.Enterid_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(89, 359);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(249, 15);
            this.label17.TabIndex = 105;
            this.label17.Text = "Please Enter you Parent ID to proceed Operations";
            this.label17.Visible = false;
            // 
            // Parentid
            // 
            this.Parentid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Parentid.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.Parentid.Location = new System.Drawing.Point(77, 330);
            this.Parentid.Name = "Parentid";
            this.Parentid.Size = new System.Drawing.Size(119, 26);
            this.Parentid.TabIndex = 104;
            this.Parentid.Text = "Parent ID";
            this.Parentid.Visible = false;
            this.Parentid.Enter += new System.EventHandler(this.Parentid_Enter);
            this.Parentid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Parentid_KeyPress);
            this.Parentid.Leave += new System.EventHandler(this.Parentid_Leave);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(11, 210);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(79, 19);
            this.label16.TabIndex = 103;
            this.label16.Text = "Operations:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(11, 12);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(126, 19);
            this.label15.TabIndex = 102;
            this.label15.Text = "Client Informations:";
            // 
            // Passlbl
            // 
            this.Passlbl.AutoSize = true;
            this.Passlbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Passlbl.Location = new System.Drawing.Point(318, 148);
            this.Passlbl.Name = "Passlbl";
            this.Passlbl.Size = new System.Drawing.Size(37, 19);
            this.Passlbl.TabIndex = 96;
            this.Passlbl.Text = "hello";
            // 
            // AccTlbl
            // 
            this.AccTlbl.AutoSize = true;
            this.AccTlbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccTlbl.Location = new System.Drawing.Point(318, 120);
            this.AccTlbl.Name = "AccTlbl";
            this.AccTlbl.Size = new System.Drawing.Size(37, 19);
            this.AccTlbl.TabIndex = 95;
            this.AccTlbl.Text = "hello";
            // 
            // Agelbl
            // 
            this.Agelbl.AutoSize = true;
            this.Agelbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Agelbl.Location = new System.Drawing.Point(125, 176);
            this.Agelbl.Name = "Agelbl";
            this.Agelbl.Size = new System.Drawing.Size(37, 19);
            this.Agelbl.TabIndex = 94;
            this.Agelbl.Text = "hello";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Gray;
            this.label12.Location = new System.Drawing.Point(16, 176);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(37, 19);
            this.label12.TabIndex = 93;
            this.label12.Text = "Age:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Gray;
            this.label11.Location = new System.Drawing.Point(207, 120);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(97, 19);
            this.label11.TabIndex = 92;
            this.label11.Text = "Account Type:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Gray;
            this.label5.Location = new System.Drawing.Point(209, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 19);
            this.label5.TabIndex = 91;
            this.label5.Text = "Password:";
            // 
            // transfertb
            // 
            this.transfertb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transfertb.Location = new System.Drawing.Point(236, 298);
            this.transfertb.Name = "transfertb";
            this.transfertb.Size = new System.Drawing.Size(119, 26);
            this.transfertb.TabIndex = 90;
            this.transfertb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.transfertb_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(202, 305);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 19);
            this.label4.TabIndex = 89;
            this.label4.Text = "To:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 232);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 19);
            this.label3.TabIndex = 88;
            this.label3.Text = "Amount:";
            // 
            // amount
            // 
            this.amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amount.Location = new System.Drawing.Point(77, 232);
            this.amount.Name = "amount";
            this.amount.Size = new System.Drawing.Size(278, 22);
            this.amount.TabIndex = 87;
            // 
            // MNamelbl
            // 
            this.MNamelbl.AutoSize = true;
            this.MNamelbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MNamelbl.Location = new System.Drawing.Point(125, 66);
            this.MNamelbl.Name = "MNamelbl";
            this.MNamelbl.Size = new System.Drawing.Size(37, 19);
            this.MNamelbl.TabIndex = 86;
            this.MNamelbl.Text = "hello";
            // 
            // LNamelbl
            // 
            this.LNamelbl.AutoSize = true;
            this.LNamelbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LNamelbl.Location = new System.Drawing.Point(125, 94);
            this.LNamelbl.Name = "LNamelbl";
            this.LNamelbl.Size = new System.Drawing.Size(37, 19);
            this.LNamelbl.TabIndex = 85;
            this.LNamelbl.Text = "hello";
            // 
            // Genderlbl
            // 
            this.Genderlbl.AutoSize = true;
            this.Genderlbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Genderlbl.Location = new System.Drawing.Point(125, 120);
            this.Genderlbl.Name = "Genderlbl";
            this.Genderlbl.Size = new System.Drawing.Size(37, 19);
            this.Genderlbl.TabIndex = 84;
            this.Genderlbl.Text = "hello";
            // 
            // DOBlbl
            // 
            this.DOBlbl.AutoSize = true;
            this.DOBlbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DOBlbl.Location = new System.Drawing.Point(125, 146);
            this.DOBlbl.Name = "DOBlbl";
            this.DOBlbl.Size = new System.Drawing.Size(37, 19);
            this.DOBlbl.TabIndex = 83;
            this.DOBlbl.Text = "hello";
            // 
            // PNumlbl
            // 
            this.PNumlbl.AutoSize = true;
            this.PNumlbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PNumlbl.Location = new System.Drawing.Point(318, 36);
            this.PNumlbl.Name = "PNumlbl";
            this.PNumlbl.Size = new System.Drawing.Size(37, 19);
            this.PNumlbl.TabIndex = 82;
            this.PNumlbl.Text = "hello";
            // 
            // Balancelbl
            // 
            this.Balancelbl.AutoSize = true;
            this.Balancelbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Balancelbl.Location = new System.Drawing.Point(318, 65);
            this.Balancelbl.Name = "Balancelbl";
            this.Balancelbl.Size = new System.Drawing.Size(37, 19);
            this.Balancelbl.TabIndex = 81;
            this.Balancelbl.Text = "hello";
            // 
            // Emaillbl
            // 
            this.Emaillbl.AutoSize = true;
            this.Emaillbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Emaillbl.Location = new System.Drawing.Point(318, 92);
            this.Emaillbl.Name = "Emaillbl";
            this.Emaillbl.Size = new System.Drawing.Size(37, 19);
            this.Emaillbl.TabIndex = 80;
            this.Emaillbl.Text = "hello";
            // 
            // Addresslbl
            // 
            this.Addresslbl.AutoSize = true;
            this.Addresslbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Addresslbl.Location = new System.Drawing.Point(318, 176);
            this.Addresslbl.Name = "Addresslbl";
            this.Addresslbl.Size = new System.Drawing.Size(37, 19);
            this.Addresslbl.TabIndex = 79;
            this.Addresslbl.Text = "hello";
            // 
            // Address
            // 
            this.Address.AutoSize = true;
            this.Address.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Address.ForeColor = System.Drawing.Color.Gray;
            this.Address.Location = new System.Drawing.Point(209, 176);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(63, 19);
            this.Address.TabIndex = 78;
            this.Address.Text = "Address:";
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email.ForeColor = System.Drawing.Color.Gray;
            this.Email.Location = new System.Drawing.Point(207, 92);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(45, 19);
            this.Email.TabIndex = 75;
            this.Email.Text = "Email:";
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.AutoSize = true;
            this.PhoneNumber.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhoneNumber.ForeColor = System.Drawing.Color.Gray;
            this.PhoneNumber.Location = new System.Drawing.Point(207, 36);
            this.PhoneNumber.Name = "PhoneNumber";
            this.PhoneNumber.Size = new System.Drawing.Size(104, 19);
            this.PhoneNumber.TabIndex = 77;
            this.PhoneNumber.Text = "Phone Number:";
            // 
            // Balance
            // 
            this.Balance.AutoSize = true;
            this.Balance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Balance.ForeColor = System.Drawing.Color.Gray;
            this.Balance.Location = new System.Drawing.Point(207, 64);
            this.Balance.Name = "Balance";
            this.Balance.Size = new System.Drawing.Size(60, 19);
            this.Balance.TabIndex = 76;
            this.Balance.Text = "Balance:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Gray;
            this.label6.Location = new System.Drawing.Point(14, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 19);
            this.label6.TabIndex = 70;
            this.label6.Text = "First Name:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Gray;
            this.label7.Location = new System.Drawing.Point(14, 92);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 19);
            this.label7.TabIndex = 74;
            this.label7.Text = "Last Name:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Gray;
            this.label8.Location = new System.Drawing.Point(14, 148);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 19);
            this.label8.TabIndex = 71;
            this.label8.Text = "Date of Birth:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Gray;
            this.label9.Location = new System.Drawing.Point(14, 64);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 19);
            this.label9.TabIndex = 73;
            this.label9.Text = "Middle Name:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Gray;
            this.label10.Location = new System.Drawing.Point(14, 120);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 19);
            this.label10.TabIndex = 72;
            this.label10.Text = "Gender:";
            // 
            // FNamelbl
            // 
            this.FNamelbl.AutoSize = true;
            this.FNamelbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FNamelbl.Location = new System.Drawing.Point(125, 36);
            this.FNamelbl.Name = "FNamelbl";
            this.FNamelbl.Size = new System.Drawing.Size(37, 19);
            this.FNamelbl.TabIndex = 69;
            this.FNamelbl.Text = "hello";
            // 
            // Deposit
            // 
            this.Deposit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Deposit.Location = new System.Drawing.Point(236, 260);
            this.Deposit.Name = "Deposit";
            this.Deposit.Size = new System.Drawing.Size(119, 29);
            this.Deposit.TabIndex = 64;
            this.Deposit.Text = "Deposit";
            this.Deposit.UseVisualStyleBackColor = true;
            this.Deposit.Click += new System.EventHandler(this.Deposit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(441, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 19);
            this.label1.TabIndex = 67;
            this.label1.Text = "Investment Certificates:";
            // 
            // Transfer
            // 
            this.Transfer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Transfer.Location = new System.Drawing.Point(77, 295);
            this.Transfer.Name = "Transfer";
            this.Transfer.Size = new System.Drawing.Size(119, 29);
            this.Transfer.TabIndex = 63;
            this.Transfer.Text = "Transfer";
            this.Transfer.UseVisualStyleBackColor = true;
            this.Transfer.Click += new System.EventHandler(this.Transfer_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(441, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 19);
            this.label2.TabIndex = 68;
            this.label2.Text = "Transactions:";
            // 
            // Withdraw
            // 
            this.Withdraw.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Withdraw.Location = new System.Drawing.Point(77, 260);
            this.Withdraw.Name = "Withdraw";
            this.Withdraw.Size = new System.Drawing.Size(119, 29);
            this.Withdraw.TabIndex = 62;
            this.Withdraw.Text = "Withdraw";
            this.Withdraw.UseVisualStyleBackColor = true;
            this.Withdraw.Click += new System.EventHandler(this.Withdraw_Click);
            // 
            // TransactionsGridView
            // 
            this.TransactionsGridView.AllowUserToAddRows = false;
            this.TransactionsGridView.AllowUserToDeleteRows = false;
            this.TransactionsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TransactionsGridView.Location = new System.Drawing.Point(445, 232);
            this.TransactionsGridView.Name = "TransactionsGridView";
            this.TransactionsGridView.ReadOnly = true;
            this.TransactionsGridView.Size = new System.Drawing.Size(434, 142);
            this.TransactionsGridView.TabIndex = 66;
            // 
            // CertificatesGridView
            // 
            this.CertificatesGridView.AllowUserToAddRows = false;
            this.CertificatesGridView.AllowUserToDeleteRows = false;
            this.CertificatesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CertificatesGridView.Location = new System.Drawing.Point(445, 36);
            this.CertificatesGridView.Name = "CertificatesGridView";
            this.CertificatesGridView.ReadOnly = true;
            this.CertificatesGridView.Size = new System.Drawing.Size(434, 159);
            this.CertificatesGridView.TabIndex = 65;
            // 
            // Logoutbtn
            // 
            this.Logoutbtn.BackColor = System.Drawing.Color.Red;
            this.Logoutbtn.ForeColor = System.Drawing.Color.White;
            this.Logoutbtn.Location = new System.Drawing.Point(760, 387);
            this.Logoutbtn.Name = "Logoutbtn";
            this.Logoutbtn.Size = new System.Drawing.Size(119, 33);
            this.Logoutbtn.TabIndex = 107;
            this.Logoutbtn.Text = "Log Out";
            this.Logoutbtn.UseVisualStyleBackColor = false;
            this.Logoutbtn.Click += new System.EventHandler(this.Logoutbtn_Click);
            // 
            // Form2Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 432);
            this.Controls.Add(this.Logoutbtn);
            this.Controls.Add(this.Enterid);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.Parentid);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.Passlbl);
            this.Controls.Add(this.AccTlbl);
            this.Controls.Add(this.Agelbl);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.transfertb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.amount);
            this.Controls.Add(this.MNamelbl);
            this.Controls.Add(this.LNamelbl);
            this.Controls.Add(this.Genderlbl);
            this.Controls.Add(this.DOBlbl);
            this.Controls.Add(this.PNumlbl);
            this.Controls.Add(this.Balancelbl);
            this.Controls.Add(this.Emaillbl);
            this.Controls.Add(this.Addresslbl);
            this.Controls.Add(this.Address);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.PhoneNumber);
            this.Controls.Add(this.Balance);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.FNamelbl);
            this.Controls.Add(this.Deposit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Transfer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Withdraw);
            this.Controls.Add(this.TransactionsGridView);
            this.Controls.Add(this.CertificatesGridView);
            this.Name = "Form2Client";
            this.Text = "Form2Client";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2Client_FormClosing);
            this.Load += new System.EventHandler(this.Form2Client_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TransactionsGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CertificatesGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Enterid;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox Parentid;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label Passlbl;
        private System.Windows.Forms.Label AccTlbl;
        private System.Windows.Forms.Label Agelbl;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox transfertb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox amount;
        private System.Windows.Forms.Label MNamelbl;
        private System.Windows.Forms.Label LNamelbl;
        private System.Windows.Forms.Label Genderlbl;
        private System.Windows.Forms.Label DOBlbl;
        private System.Windows.Forms.Label PNumlbl;
        private System.Windows.Forms.Label Balancelbl;
        private System.Windows.Forms.Label Emaillbl;
        private System.Windows.Forms.Label Addresslbl;
        private System.Windows.Forms.Label Address;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.Label PhoneNumber;
        private System.Windows.Forms.Label Balance;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label FNamelbl;
        private System.Windows.Forms.Button Deposit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Transfer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Withdraw;
        private System.Windows.Forms.DataGridView TransactionsGridView;
        private System.Windows.Forms.DataGridView CertificatesGridView;
        private System.Windows.Forms.Button Logoutbtn;
    }
}