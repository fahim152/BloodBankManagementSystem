namespace UserInterfaces
{
    partial class AdminPanel
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
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.optionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registerStaffChemistToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showBloodInventoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.emailSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.donorNameBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.staffNameBox = new System.Windows.Forms.TextBox();
            this.DonorUpdate = new System.Windows.Forms.Button();
            this.DonorDelete = new System.Windows.Forms.Button();
            this.EmployeeUpdate = new System.Windows.Forms.Button();
            this.EmployeeDelete = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(502, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "You are logged in as Admin";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionToolStripMenuItem,
            this.settingsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // optionToolStripMenuItem
            // 
            this.optionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registerStaffChemistToolStripMenuItem,
            this.showBloodInventoryToolStripMenuItem,
            this.logoutToolStripMenuItem});
            this.optionToolStripMenuItem.Name = "optionToolStripMenuItem";
            this.optionToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.optionToolStripMenuItem.Text = "Option";
            // 
            // registerStaffChemistToolStripMenuItem
            // 
            this.registerStaffChemistToolStripMenuItem.Name = "registerStaffChemistToolStripMenuItem";
            this.registerStaffChemistToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.registerStaffChemistToolStripMenuItem.Text = "Register Staff/Chemist";
            this.registerStaffChemistToolStripMenuItem.Click += new System.EventHandler(this.registerStaffChemistToolStripMenuItem_Click);
            // 
            // showBloodInventoryToolStripMenuItem
            // 
            this.showBloodInventoryToolStripMenuItem.Name = "showBloodInventoryToolStripMenuItem";
            this.showBloodInventoryToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.showBloodInventoryToolStripMenuItem.Text = "Show Blood Inventory";
            this.showBloodInventoryToolStripMenuItem.Click += new System.EventHandler(this.showBloodInventoryToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.emailSettingsToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // emailSettingsToolStripMenuItem
            // 
            this.emailSettingsToolStripMenuItem.Name = "emailSettingsToolStripMenuItem";
            this.emailSettingsToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.emailSettingsToolStripMenuItem.Text = "Email Settings";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 191);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(369, 358);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(410, 191);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(362, 358);
            this.dataGridView2.TabIndex = 3;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // donorNameBox
            // 
            this.donorNameBox.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.donorNameBox.Location = new System.Drawing.Point(187, 157);
            this.donorNameBox.Multiline = true;
            this.donorNameBox.Name = "donorNameBox";
            this.donorNameBox.Size = new System.Drawing.Size(194, 25);
            this.donorNameBox.TabIndex = 4;
            this.donorNameBox.TextChanged += new System.EventHandler(this.donorNameBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(60, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 28);
            this.label2.TabIndex = 6;
            this.label2.Text = "Search Donor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(423, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 28);
            this.label4.TabIndex = 11;
            this.label4.Text = "Search Employee";
            // 
            // staffNameBox
            // 
            this.staffNameBox.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staffNameBox.Location = new System.Drawing.Point(576, 157);
            this.staffNameBox.Multiline = true;
            this.staffNameBox.Name = "staffNameBox";
            this.staffNameBox.Size = new System.Drawing.Size(196, 25);
            this.staffNameBox.TabIndex = 10;
            this.staffNameBox.TextChanged += new System.EventHandler(this.staffNameBox_TextChanged);
            // 
            // DonorUpdate
            // 
            this.DonorUpdate.Location = new System.Drawing.Point(12, 109);
            this.DonorUpdate.Name = "DonorUpdate";
            this.DonorUpdate.Size = new System.Drawing.Size(106, 32);
            this.DonorUpdate.TabIndex = 12;
            this.DonorUpdate.Text = "Update Donor";
            this.DonorUpdate.UseVisualStyleBackColor = true;
            this.DonorUpdate.Click += new System.EventHandler(this.DonorUpdate_Click);
            // 
            // DonorDelete
            // 
            this.DonorDelete.Location = new System.Drawing.Point(275, 109);
            this.DonorDelete.Name = "DonorDelete";
            this.DonorDelete.Size = new System.Drawing.Size(106, 32);
            this.DonorDelete.TabIndex = 13;
            this.DonorDelete.Text = "Delete Donor";
            this.DonorDelete.UseVisualStyleBackColor = true;
            this.DonorDelete.Click += new System.EventHandler(this.DonorDelete_Click);
            // 
            // EmployeeUpdate
            // 
            this.EmployeeUpdate.Location = new System.Drawing.Point(410, 109);
            this.EmployeeUpdate.Name = "EmployeeUpdate";
            this.EmployeeUpdate.Size = new System.Drawing.Size(106, 32);
            this.EmployeeUpdate.TabIndex = 14;
            this.EmployeeUpdate.Text = "Update Employee";
            this.EmployeeUpdate.UseVisualStyleBackColor = true;
            this.EmployeeUpdate.Click += new System.EventHandler(this.EmployeeUpdate_Click);
            // 
            // EmployeeDelete
            // 
            this.EmployeeDelete.Location = new System.Drawing.Point(666, 109);
            this.EmployeeDelete.Name = "EmployeeDelete";
            this.EmployeeDelete.Size = new System.Drawing.Size(106, 32);
            this.EmployeeDelete.TabIndex = 15;
            this.EmployeeDelete.Text = "Delete Employee";
            this.EmployeeDelete.UseVisualStyleBackColor = true;
            this.EmployeeDelete.Click += new System.EventHandler(this.EmployeeDelete_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Handwriting", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(152, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(477, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "Select  a donor or employee to Update and Delete";
            // 
            // AdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.EmployeeDelete);
            this.Controls.Add(this.EmployeeUpdate);
            this.Controls.Add(this.DonorDelete);
            this.Controls.Add(this.DonorUpdate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.staffNameBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.donorNameBox);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AdminPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminPanel";
            this.Load += new System.EventHandler(this.AdminPanel_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem optionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registerStaffChemistToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TextBox donorNameBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox staffNameBox;
        private System.Windows.Forms.Button DonorUpdate;
        private System.Windows.Forms.Button DonorDelete;
        private System.Windows.Forms.Button EmployeeUpdate;
        private System.Windows.Forms.Button EmployeeDelete;
        private System.Windows.Forms.ToolStripMenuItem showBloodInventoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem emailSettingsToolStripMenuItem;
        private System.Windows.Forms.Label label3;
    }
}