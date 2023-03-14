namespace NightClub_DataLogging
{
    partial class FormDeleteMember
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
            this.btnBackToMenu = new System.Windows.Forms.Button();
            this.dgvShowAllMembers = new System.Windows.Forms.DataGridView();
            this.txtID_Number = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDeleteMemberBTN = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowAllMembers)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBackToMenu
            // 
            this.btnBackToMenu.Location = new System.Drawing.Point(12, 12);
            this.btnBackToMenu.Name = "btnBackToMenu";
            this.btnBackToMenu.Size = new System.Drawing.Size(118, 31);
            this.btnBackToMenu.TabIndex = 0;
            this.btnBackToMenu.Text = "Back to main";
            this.btnBackToMenu.UseVisualStyleBackColor = true;
            this.btnBackToMenu.Click += new System.EventHandler(this.btnBackToMenu_Click);
            // 
            // dgvShowAllMembers
            // 
            this.dgvShowAllMembers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShowAllMembers.Location = new System.Drawing.Point(232, 12);
            this.dgvShowAllMembers.Name = "dgvShowAllMembers";
            this.dgvShowAllMembers.RowTemplate.Height = 25;
            this.dgvShowAllMembers.Size = new System.Drawing.Size(722, 426);
            this.dgvShowAllMembers.TabIndex = 1;
            // 
            // txtID_Number
            // 
            this.txtID_Number.Location = new System.Drawing.Point(12, 336);
            this.txtID_Number.Name = "txtID_Number";
            this.txtID_Number.Size = new System.Drawing.Size(132, 23);
            this.txtID_Number.TabIndex = 2;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Segoe UI Emoji", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.richTextBox1.Location = new System.Drawing.Point(12, 101);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(60, 139);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "ID 1: \nID 2: \nID 3:\nID 4:\nID 5:";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.Green;
            this.textBox2.Location = new System.Drawing.Point(81, 101);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(49, 23);
            this.textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.Black;
            this.textBox3.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBox3.Location = new System.Drawing.Point(81, 130);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(49, 23);
            this.textBox3.TabIndex = 5;
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.Red;
            this.textBox4.Location = new System.Drawing.Point(81, 188);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(49, 23);
            this.textBox4.TabIndex = 7;
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.Color.Blue;
            this.textBox5.Location = new System.Drawing.Point(81, 159);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(49, 23);
            this.textBox5.TabIndex = 6;
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.Color.Yellow;
            this.textBox6.Location = new System.Drawing.Point(81, 217);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(49, 23);
            this.textBox6.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 318);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "ID of member to delete:";
            // 
            // btnDeleteMemberBTN
            // 
            this.btnDeleteMemberBTN.Location = new System.Drawing.Point(12, 365);
            this.btnDeleteMemberBTN.Name = "btnDeleteMemberBTN";
            this.btnDeleteMemberBTN.Size = new System.Drawing.Size(132, 35);
            this.btnDeleteMemberBTN.TabIndex = 10;
            this.btnDeleteMemberBTN.Text = "Delete member";
            this.btnDeleteMemberBTN.UseVisualStyleBackColor = true;
            this.btnDeleteMemberBTN.Click += new System.EventHandler(this.btnDeleteMemberBTN_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(136, 12);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(90, 31);
            this.btnRefresh.TabIndex = 11;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // FormDeleteMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 450);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnDeleteMemberBTN);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.txtID_Number);
            this.Controls.Add(this.dgvShowAllMembers);
            this.Controls.Add(this.btnBackToMenu);
            this.Name = "FormDeleteMember";
            this.Text = "FormDeleteMember";
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowAllMembers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnBackToMenu;
        private DataGridView dgvShowAllMembers;
        private TextBox txtID_Number;
        private RichTextBox richTextBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private Label label1;
        private Button btnDeleteMemberBTN;
        private Button btnRefresh;
    }
}