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
    public partial class FormLogin : Form
    {
        //Instance variables DecodeStringToInt:
        #region #InitDecodeRFIDcode
        DecodeStringToInt decodeStringToInt = new DecodeStringToInt();
        #endregion

        //Instance variables DatabaseOperations:
        #region #initDatabaseOperations
        DatabaseOperations databaseOperations = new DatabaseOperations();
        #endregion

        public FormLogin()
        {
            InitializeComponent();
            txtLoginRFID.Focus();
        }

        private void btnBackToMenu_Click(object sender, EventArgs e)
        {
            Form DataloggingApp = new DataloggingAPP();
            DataloggingApp.Show();
            this.Close();
        }

        public int ReadMemberIDFromTextBox(string id)
        {
            string tempMem_ID;
            int MemberID;

            tempMem_ID = txtLoginRFID.Text;
            MemberID = decodeStringToInt.DecodeRFIDAndReturnID(tempMem_ID);
            
            return MemberID;
        }

        private void txtLoginRFID_KeyDown(object sender, KeyEventArgs e)
        {
            int memberID;
            bool memberTest = false;
            memberID = 0;

            if (e.KeyCode == Keys.Enter)
            {
                memberID = ReadMemberIDFromTextBox(txtLoginRFID.Text);
                memberTest = databaseOperations.CheckIfMemberIsRegistered(memberID);

                if (memberTest == false)
                {
                    txtLoginRFID.BackColor = Color.Red;
                    MessageBox.Show("404: User not found");
                    txtLoginRFID.Clear();
                    txtLoginRFID.BackColor = Color.White;
                }
                else
                {
                    Form formMemberArea = new FormMemberArea(memberID);
                    formMemberArea.Show();
                    this.Close();
                }
            }
        }
    }
}
