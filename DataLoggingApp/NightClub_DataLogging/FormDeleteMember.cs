using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NightClub_DataLogging
{
    public partial class FormDeleteMember : Form
    {
        //Instance variables DatabaseOperations:
        #region #initDatabaseOperations
        DatabaseOperations databaseOperations = new DatabaseOperations();
        string members = "SELECT * FROM MEMBERS";
        #endregion

        public FormDeleteMember()
        {
            InitializeComponent();
            databaseOperations.FillDGV(dgvShowAllMembers, members);
        }

        private void btnBackToMenu_Click(object sender, EventArgs e)
        {
            Form DataloggingApp = new DataloggingAPP();
            DataloggingApp.Show();
            this.Close();
        }

        private void btnDeleteMemberBTN_Click(object sender, EventArgs e)
        {
            int ID_Number = 0;
            try
            {
                ID_Number = Convert.ToInt32(txtID_Number.Text);
                databaseOperations.DeleteMember(ID_Number);

                databaseOperations.FillDGV(dgvShowAllMembers, members);
                txtID_Number.Clear();
            }
            catch (Exception)
            {
                MessageBox.Show("Type ID-number in box before you press delete.");   
            }
            
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            databaseOperations.FillDGV(dgvShowAllMembers, members);
        }
    }
}
