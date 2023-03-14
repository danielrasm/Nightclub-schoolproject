namespace NightClub_DataLogging
{
    partial class DataloggingAPP
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnRegisterNewMember = new System.Windows.Forms.Button();
            this.dgvInfo = new System.Windows.Forms.DataGridView();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblOrientation = new System.Windows.Forms.Label();
            this.cboOrientation = new System.Windows.Forms.ComboBox();
            this.cboSex = new System.Windows.Forms.ComboBox();
            this.lblSex = new System.Windows.Forms.Label();
            this.cboCountry = new System.Windows.Forms.ComboBox();
            this.lblCountry = new System.Windows.Forms.Label();
            this.txtMembershipID = new System.Windows.Forms.TextBox();
            this.lblMemberID = new System.Windows.Forms.Label();
            this.btnShowRegisteredMembers = new System.Windows.Forms.Button();
            this.cboMembership = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDeleteMember = new System.Windows.Forms.Button();
            this.btnAutoFillForTesting = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRegisterNewMember
            // 
            this.btnRegisterNewMember.BackColor = System.Drawing.Color.Lime;
            this.btnRegisterNewMember.Location = new System.Drawing.Point(12, 437);
            this.btnRegisterNewMember.Name = "btnRegisterNewMember";
            this.btnRegisterNewMember.Size = new System.Drawing.Size(271, 38);
            this.btnRegisterNewMember.TabIndex = 0;
            this.btnRegisterNewMember.Text = "Register new member";
            this.btnRegisterNewMember.UseVisualStyleBackColor = false;
            this.btnRegisterNewMember.Click += new System.EventHandler(this.btnRegisterNewMember_Click);
            // 
            // dgvInfo
            // 
            this.dgvInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInfo.Location = new System.Drawing.Point(477, 60);
            this.dgvInfo.Name = "dgvInfo";
            this.dgvInfo.RowTemplate.Height = 25;
            this.dgvInfo.Size = new System.Drawing.Size(707, 426);
            this.dgvInfo.TabIndex = 4;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(76, 78);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(142, 23);
            this.txtFirstName.TabIndex = 5;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(76, 129);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(142, 23);
            this.txtLastName.TabIndex = 6;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(116, 60);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(64, 15);
            this.lblFirstName.TabIndex = 7;
            this.lblFirstName.Text = "First Name";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(117, 111);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(63, 15);
            this.lblLastName.TabIndex = 8;
            this.lblLastName.Text = "Last Name";
            // 
            // lblOrientation
            // 
            this.lblOrientation.AutoSize = true;
            this.lblOrientation.Location = new System.Drawing.Point(115, 213);
            this.lblOrientation.Name = "lblOrientation";
            this.lblOrientation.Size = new System.Drawing.Size(67, 15);
            this.lblOrientation.TabIndex = 9;
            this.lblOrientation.Text = "Orientation";
            // 
            // cboOrientation
            // 
            this.cboOrientation.FormattingEnabled = true;
            this.cboOrientation.Location = new System.Drawing.Point(76, 231);
            this.cboOrientation.Name = "cboOrientation";
            this.cboOrientation.Size = new System.Drawing.Size(142, 23);
            this.cboOrientation.TabIndex = 10;
            // 
            // cboSex
            // 
            this.cboSex.FormattingEnabled = true;
            this.cboSex.Location = new System.Drawing.Point(76, 180);
            this.cboSex.Name = "cboSex";
            this.cboSex.Size = new System.Drawing.Size(142, 23);
            this.cboSex.TabIndex = 11;
            // 
            // lblSex
            // 
            this.lblSex.AutoSize = true;
            this.lblSex.Location = new System.Drawing.Point(136, 162);
            this.lblSex.Name = "lblSex";
            this.lblSex.Size = new System.Drawing.Size(25, 15);
            this.lblSex.TabIndex = 12;
            this.lblSex.Text = "Sex";
            // 
            // cboCountry
            // 
            this.cboCountry.FormattingEnabled = true;
            this.cboCountry.Location = new System.Drawing.Point(46, 282);
            this.cboCountry.Name = "cboCountry";
            this.cboCountry.Size = new System.Drawing.Size(203, 23);
            this.cboCountry.TabIndex = 13;
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Location = new System.Drawing.Point(123, 264);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(50, 15);
            this.lblCountry.TabIndex = 14;
            this.lblCountry.Text = "Country";
            // 
            // txtMembershipID
            // 
            this.txtMembershipID.Location = new System.Drawing.Point(76, 398);
            this.txtMembershipID.Name = "txtMembershipID";
            this.txtMembershipID.Size = new System.Drawing.Size(142, 23);
            this.txtMembershipID.TabIndex = 15;
            // 
            // lblMemberID
            // 
            this.lblMemberID.AutoSize = true;
            this.lblMemberID.Location = new System.Drawing.Point(76, 380);
            this.lblMemberID.Name = "lblMemberID";
            this.lblMemberID.Size = new System.Drawing.Size(127, 15);
            this.lblMemberID.TabIndex = 16;
            this.lblMemberID.Text = "Member ID (scan chip)";
            // 
            // btnShowRegisteredMembers
            // 
            this.btnShowRegisteredMembers.Location = new System.Drawing.Point(477, 12);
            this.btnShowRegisteredMembers.Name = "btnShowRegisteredMembers";
            this.btnShowRegisteredMembers.Size = new System.Drawing.Size(122, 38);
            this.btnShowRegisteredMembers.TabIndex = 17;
            this.btnShowRegisteredMembers.Text = "Show members";
            this.btnShowRegisteredMembers.UseVisualStyleBackColor = true;
            this.btnShowRegisteredMembers.Click += new System.EventHandler(this.btnShowRegisteredMembers_Click);
            // 
            // cboMembership
            // 
            this.cboMembership.FormattingEnabled = true;
            this.cboMembership.Location = new System.Drawing.Point(76, 341);
            this.cboMembership.Name = "cboMembership";
            this.cboMembership.Size = new System.Drawing.Size(142, 23);
            this.cboMembership.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(108, 323);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 15);
            this.label1.TabIndex = 19;
            this.label1.Text = "Membership";
            // 
            // btnDeleteMember
            // 
            this.btnDeleteMember.Location = new System.Drawing.Point(645, 12);
            this.btnDeleteMember.Name = "btnDeleteMember";
            this.btnDeleteMember.Size = new System.Drawing.Size(122, 38);
            this.btnDeleteMember.TabIndex = 20;
            this.btnDeleteMember.Text = "Delete member";
            this.btnDeleteMember.UseVisualStyleBackColor = true;
            this.btnDeleteMember.Click += new System.EventHandler(this.btnDeleteMember_Click);
            // 
            // btnAutoFillForTesting
            // 
            this.btnAutoFillForTesting.Location = new System.Drawing.Point(357, 437);
            this.btnAutoFillForTesting.Name = "btnAutoFillForTesting";
            this.btnAutoFillForTesting.Size = new System.Drawing.Size(105, 38);
            this.btnAutoFillForTesting.TabIndex = 21;
            this.btnAutoFillForTesting.Text = "Auto fill (testing purposes)";
            this.btnAutoFillForTesting.UseVisualStyleBackColor = true;
            this.btnAutoFillForTesting.Click += new System.EventHandler(this.btnAutoFillForTesting_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Blue;
            this.btnLogin.Location = new System.Drawing.Point(320, 78);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(142, 34);
            this.btnLogin.TabIndex = 22;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(337, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 15);
            this.label2.TabIndex = 23;
            this.label2.Text = "Already a member? ";
            // 
            // DataloggingAPP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1185, 487);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.btnAutoFillForTesting);
            this.Controls.Add(this.btnDeleteMember);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboMembership);
            this.Controls.Add(this.btnShowRegisteredMembers);
            this.Controls.Add(this.txtMembershipID);
            this.Controls.Add(this.lblCountry);
            this.Controls.Add(this.cboCountry);
            this.Controls.Add(this.lblSex);
            this.Controls.Add(this.cboSex);
            this.Controls.Add(this.cboOrientation);
            this.Controls.Add(this.lblOrientation);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.dgvInfo);
            this.Controls.Add(this.btnRegisterNewMember);
            this.Controls.Add(this.lblMemberID);
            this.Name = "DataloggingAPP";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnRegisterNewMember;
        private DataGridView dgvInfo;
        private TextBox txtFirstName;
        private TextBox txtLastName;
        private Label lblFirstName;
        private Label lblLastName;
        private Label lblOrientation;
        private ComboBox cboOrientation;
        private ComboBox cboSex;
        private Label lblSex;
        private ComboBox cboCountry;
        private Label lblCountry;
        private TextBox txtMembershipID;
        private Label lblMemberID;
        private Button btnShowRegisteredMembers;
        private ComboBox cboMembership;
        private Label label1;
        private Button btnDeleteMember;
        private Button btnAutoFillForTesting;
        private Button btnLogin;
        private Label label2;
    }
}