namespace ElMal_ElHaram_BankingSystem
{
    partial class Teller
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
            this.Searchbtn = new System.Windows.Forms.Button();
            this.Addbtn = new System.Windows.Forms.Button();
            this.Removebtn = new System.Windows.Forms.Button();
            this.LogOutbtn = new System.Windows.Forms.Button();
            this.Checkbtn = new System.Windows.Forms.Button();
            this.IDtextb = new System.Windows.Forms.TextBox();
            this.LName = new System.Windows.Forms.TextBox();
            this.MName = new System.Windows.Forms.TextBox();
            this.FName = new System.Windows.Forms.TextBox();
            this.ClientsGridView = new System.Windows.Forms.DataGridView();
            this.backbtn = new System.Windows.Forms.Button();
            this.addint = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ClientsGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // Searchbtn
            // 
            this.Searchbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Searchbtn.Location = new System.Drawing.Point(560, 13);
            this.Searchbtn.Name = "Searchbtn";
            this.Searchbtn.Size = new System.Drawing.Size(131, 27);
            this.Searchbtn.TabIndex = 3;
            this.Searchbtn.Text = "Search";
            this.Searchbtn.UseVisualStyleBackColor = true;
            this.Searchbtn.Click += new System.EventHandler(this.Searchbtn_Click);
            // 
            // Addbtn
            // 
            this.Addbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Addbtn.Location = new System.Drawing.Point(12, 580);
            this.Addbtn.Name = "Addbtn";
            this.Addbtn.Size = new System.Drawing.Size(131, 32);
            this.Addbtn.TabIndex = 4;
            this.Addbtn.Text = "Add Client";
            this.Addbtn.UseVisualStyleBackColor = true;
            this.Addbtn.Click += new System.EventHandler(this.Addbtn_Click);
            // 
            // Removebtn
            // 
            this.Removebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Removebtn.Location = new System.Drawing.Point(149, 580);
            this.Removebtn.Name = "Removebtn";
            this.Removebtn.Size = new System.Drawing.Size(131, 32);
            this.Removebtn.TabIndex = 5;
            this.Removebtn.Text = "Remove Client";
            this.Removebtn.UseVisualStyleBackColor = true;
            this.Removebtn.Click += new System.EventHandler(this.Removebtn_Click);
            // 
            // LogOutbtn
            // 
            this.LogOutbtn.BackColor = System.Drawing.Color.Red;
            this.LogOutbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogOutbtn.ForeColor = System.Drawing.Color.White;
            this.LogOutbtn.Location = new System.Drawing.Point(1106, 580);
            this.LogOutbtn.Name = "LogOutbtn";
            this.LogOutbtn.Size = new System.Drawing.Size(113, 41);
            this.LogOutbtn.TabIndex = 6;
            this.LogOutbtn.Text = "Log Out";
            this.LogOutbtn.UseVisualStyleBackColor = false;
            this.LogOutbtn.Click += new System.EventHandler(this.LogOutbtn_Click);
            // 
            // Checkbtn
            // 
            this.Checkbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Checkbtn.Location = new System.Drawing.Point(286, 580);
            this.Checkbtn.Name = "Checkbtn";
            this.Checkbtn.Size = new System.Drawing.Size(131, 32);
            this.Checkbtn.TabIndex = 7;
            this.Checkbtn.Text = "Check Client";
            this.Checkbtn.UseVisualStyleBackColor = true;
            this.Checkbtn.Click += new System.EventHandler(this.Checkbtn_Click);
            // 
            // IDtextb
            // 
            this.IDtextb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDtextb.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.IDtextb.Location = new System.Drawing.Point(423, 13);
            this.IDtextb.Name = "IDtextb";
            this.IDtextb.Size = new System.Drawing.Size(131, 26);
            this.IDtextb.TabIndex = 9;
            this.IDtextb.Text = "ID";
            this.IDtextb.Enter += new System.EventHandler(this.IDtextb_Enter);
            this.IDtextb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IDtextb_KeyPress);
            this.IDtextb.Leave += new System.EventHandler(this.IDtextb_Leave);
            // 
            // LName
            // 
            this.LName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LName.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.LName.Location = new System.Drawing.Point(286, 13);
            this.LName.Name = "LName";
            this.LName.Size = new System.Drawing.Size(131, 26);
            this.LName.TabIndex = 10;
            this.LName.Text = "Last Name";
            this.LName.Enter += new System.EventHandler(this.LName_Enter);
            this.LName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.LName_KeyPress);
            this.LName.Leave += new System.EventHandler(this.LName_Leave);
            // 
            // MName
            // 
            this.MName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MName.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.MName.Location = new System.Drawing.Point(149, 13);
            this.MName.Name = "MName";
            this.MName.Size = new System.Drawing.Size(131, 26);
            this.MName.TabIndex = 11;
            this.MName.Text = "Middle Name";
            this.MName.Enter += new System.EventHandler(this.MName_Enter);
            this.MName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MName_KeyPress);
            this.MName.Leave += new System.EventHandler(this.MName_Leave);
            // 
            // FName
            // 
            this.FName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FName.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.FName.Location = new System.Drawing.Point(12, 13);
            this.FName.Name = "FName";
            this.FName.Size = new System.Drawing.Size(131, 26);
            this.FName.TabIndex = 12;
            this.FName.Text = "First Name";
            this.FName.Enter += new System.EventHandler(this.FName_Enter);
            this.FName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FName_KeyPress);
            this.FName.Leave += new System.EventHandler(this.FName_Leave);
            // 
            // ClientsGridView
            // 
            this.ClientsGridView.AllowUserToAddRows = false;
            this.ClientsGridView.AllowUserToDeleteRows = false;
            this.ClientsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ClientsGridView.Location = new System.Drawing.Point(12, 45);
            this.ClientsGridView.Name = "ClientsGridView";
            this.ClientsGridView.ReadOnly = true;
            this.ClientsGridView.Size = new System.Drawing.Size(1207, 529);
            this.ClientsGridView.TabIndex = 13;
            // 
            // backbtn
            // 
            this.backbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backbtn.Location = new System.Drawing.Point(697, 13);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(131, 26);
            this.backbtn.TabIndex = 14;
            this.backbtn.Text = "Back";
            this.backbtn.UseVisualStyleBackColor = true;
            this.backbtn.Visible = false;
            this.backbtn.Click += new System.EventHandler(this.backbtn_Click);
            // 
            // addint
            // 
            this.addint.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addint.Location = new System.Drawing.Point(423, 580);
            this.addint.Name = "addint";
            this.addint.Size = new System.Drawing.Size(131, 32);
            this.addint.TabIndex = 15;
            this.addint.Text = "Add Interest";
            this.addint.UseVisualStyleBackColor = true;
            this.addint.Click += new System.EventHandler(this.addint_Click);
            // 
            // Teller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1231, 624);
            this.Controls.Add(this.addint);
            this.Controls.Add(this.backbtn);
            this.Controls.Add(this.ClientsGridView);
            this.Controls.Add(this.FName);
            this.Controls.Add(this.MName);
            this.Controls.Add(this.LName);
            this.Controls.Add(this.IDtextb);
            this.Controls.Add(this.Checkbtn);
            this.Controls.Add(this.LogOutbtn);
            this.Controls.Add(this.Removebtn);
            this.Controls.Add(this.Addbtn);
            this.Controls.Add(this.Searchbtn);
            this.Name = "Teller";
            this.Text = "Teller";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Teller_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.ClientsGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Searchbtn;
        private System.Windows.Forms.Button Addbtn;
        private System.Windows.Forms.Button Removebtn;
        private System.Windows.Forms.Button LogOutbtn;
        private System.Windows.Forms.Button Checkbtn;
        private System.Windows.Forms.TextBox IDtextb;
        private System.Windows.Forms.TextBox LName;
        private System.Windows.Forms.TextBox MName;
        private System.Windows.Forms.TextBox FName;
        private System.Windows.Forms.DataGridView ClientsGridView;
        private System.Windows.Forms.Button backbtn;
        private System.Windows.Forms.Button addint;
    }
}