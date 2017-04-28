namespace UserInterfaces
{
    partial class DonorRegistration
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
            this.DonorName = new System.Windows.Forms.TextBox();
            this.DonorAddress = new System.Windows.Forms.TextBox();
            this.DonorPhone = new System.Windows.Forms.TextBox();
            this.DonorEmail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.DonorBloodGroup = new System.Windows.Forms.ComboBox();
            this.DonorWeight = new System.Windows.Forms.TextBox();
            this.label99 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.DonorGender = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.DonorRegister = new System.Windows.Forms.Button();
            this.DonorAge = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.DonorID = new System.Windows.Forms.TextBox();
            this.BackButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DonorName
            // 
            this.DonorName.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DonorName.Location = new System.Drawing.Point(147, 160);
            this.DonorName.Name = "DonorName";
            this.DonorName.Size = new System.Drawing.Size(143, 23);
            this.DonorName.TabIndex = 0;
            this.DonorName.TextChanged += new System.EventHandler(this.DonorName_TextChanged);
            // 
            // DonorAddress
            // 
            this.DonorAddress.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DonorAddress.Location = new System.Drawing.Point(147, 211);
            this.DonorAddress.Name = "DonorAddress";
            this.DonorAddress.Size = new System.Drawing.Size(143, 23);
            this.DonorAddress.TabIndex = 1;
            // 
            // DonorPhone
            // 
            this.DonorPhone.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DonorPhone.Location = new System.Drawing.Point(147, 387);
            this.DonorPhone.Name = "DonorPhone";
            this.DonorPhone.Size = new System.Drawing.Size(143, 23);
            this.DonorPhone.TabIndex = 2;
            // 
            // DonorEmail
            // 
            this.DonorEmail.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DonorEmail.Location = new System.Drawing.Point(147, 445);
            this.DonorEmail.Name = "DonorEmail";
            this.DonorEmail.Size = new System.Drawing.Size(143, 23);
            this.DonorEmail.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(56, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(56, 219);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Address";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(57, 387);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "Phone";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(56, 445);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 15);
            this.label6.TabIndex = 13;
            this.label6.Text = "Email";
            // 
            // DonorBloodGroup
            // 
            this.DonorBloodGroup.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DonorBloodGroup.FormattingEnabled = true;
            this.DonorBloodGroup.Location = new System.Drawing.Point(487, 109);
            this.DonorBloodGroup.Name = "DonorBloodGroup";
            this.DonorBloodGroup.Size = new System.Drawing.Size(121, 23);
            this.DonorBloodGroup.TabIndex = 14;
            this.DonorBloodGroup.SelectedIndexChanged += new System.EventHandler(this.comboBoxBlooadgroup_SelectedIndexChanged);
            // 
            // DonorWeight
            // 
            this.DonorWeight.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DonorWeight.Location = new System.Drawing.Point(487, 160);
            this.DonorWeight.Name = "DonorWeight";
            this.DonorWeight.Size = new System.Drawing.Size(73, 23);
            this.DonorWeight.TabIndex = 15;
            // 
            // label99
            // 
            this.label99.AutoSize = true;
            this.label99.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label99.Location = new System.Drawing.Point(395, 168);
            this.label99.Name = "label99";
            this.label99.Size = new System.Drawing.Size(53, 15);
            this.label99.TabIndex = 16;
            this.label99.Text = "Weight";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(395, 117);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 15);
            this.label8.TabIndex = 17;
            this.label8.Text = "Blood Group";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(274, 32);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(250, 23);
            this.label9.TabIndex = 18;
            this.label9.Text = "Donor Registration Panel";
            // 
            // DonorGender
            // 
            this.DonorGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DonorGender.FormattingEnabled = true;
            this.DonorGender.Location = new System.Drawing.Point(147, 323);
            this.DonorGender.Name = "DonorGender";
            this.DonorGender.Size = new System.Drawing.Size(121, 21);
            this.DonorGender.TabIndex = 19;
            this.DonorGender.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(56, 331);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 15);
            this.label4.TabIndex = 20;
            this.label4.Text = "Gender";
            // 
            // DonorRegister
            // 
            this.DonorRegister.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.DonorRegister.Location = new System.Drawing.Point(320, 480);
            this.DonorRegister.Name = "DonorRegister";
            this.DonorRegister.Size = new System.Drawing.Size(137, 34);
            this.DonorRegister.TabIndex = 21;
            this.DonorRegister.Text = "Register Donor";
            this.DonorRegister.UseVisualStyleBackColor = false;
            this.DonorRegister.Click += new System.EventHandler(this.DonorRegister_Click);
            // 
            // DonorAge
            // 
            this.DonorAge.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DonorAge.Location = new System.Drawing.Point(147, 266);
            this.DonorAge.Name = "DonorAge";
            this.DonorAge.Size = new System.Drawing.Size(143, 23);
            this.DonorAge.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(57, 269);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 15);
            this.label3.TabIndex = 23;
            this.label3.Text = "Age";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(56, 114);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(22, 15);
            this.label7.TabIndex = 24;
            this.label7.Text = "ID";
            // 
            // DonorID
            // 
            this.DonorID.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DonorID.Location = new System.Drawing.Point(147, 114);
            this.DonorID.Name = "DonorID";
            this.DonorID.Size = new System.Drawing.Size(143, 23);
            this.DonorID.TabIndex = 25;
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(59, 32);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(85, 32);
            this.BackButton.TabIndex = 26;
            this.BackButton.Text = "Back to Profile";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // DonorRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.DonorID);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DonorAge);
            this.Controls.Add(this.DonorRegister);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DonorGender);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label99);
            this.Controls.Add(this.DonorWeight);
            this.Controls.Add(this.DonorBloodGroup);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DonorEmail);
            this.Controls.Add(this.DonorPhone);
            this.Controls.Add(this.DonorAddress);
            this.Controls.Add(this.DonorName);
            this.Name = "DonorRegistration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DonorRegistration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox DonorName;
        private System.Windows.Forms.TextBox DonorAddress;
        private System.Windows.Forms.TextBox DonorPhone;
        private System.Windows.Forms.TextBox DonorEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox DonorBloodGroup;
        private System.Windows.Forms.TextBox DonorWeight;
        private System.Windows.Forms.Label label99;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox DonorGender;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button DonorRegister;
        private System.Windows.Forms.TextBox DonorAge;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox DonorID;
        private System.Windows.Forms.Button BackButton;
    }
}