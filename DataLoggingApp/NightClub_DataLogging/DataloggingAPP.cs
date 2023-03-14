using System;
using System.Configuration;
using System.Data.SqlClient;

namespace NightClub_DataLogging
{

    public partial class DataloggingAPP : Form
    {
        //Instance variables DatabaseOperations:
        #region #initDatabaseOperations
        DatabaseOperations databaseOperations;
        string members = "SELECT * FROM MEMBERS";
        #endregion

        //Instance variables DecodeStringToInt:
        #region #InitDecodeRFIDcode
        DecodeStringToInt decodeStringToInt = new DecodeStringToInt();
        #endregion

        public DataloggingAPP()
        {
            InitializeComponent();
            databaseOperations = new DatabaseOperations(txtMembershipID);
            FillCboCountries();                                          
            FillCboSex();                                                
            FillCboOrientation();
            FillCboMembership();
            databaseOperations.FillDGV(dgvInfo, members);
        }

        void FillCboCountries()
        {
            List<string> ListOfCountries = new List<string>();
            databaseOperations.GetListOfCountries(ListOfCountries);

            foreach (var item in ListOfCountries)
            {
                cboCountry.Items.Add(item);
            }

            cboCountry.SelectedIndex = 160;
        }

        void FillListOfClubs()
        {
            List<string> ListOfClubs = new List<string>();
            databaseOperations.GetListOfClubs(ListOfClubs);

            foreach (var item in ListOfClubs)
            {
                
            }
        }

        void FillCboSex()
        {
            List<string> ListOfGenders = new List<string>();
            ListOfGenders.Add("Male");
            ListOfGenders.Add("Female");

            foreach (var item in ListOfGenders)
            {
                cboSex.Items.Add(item);
            }

            cboSex.SelectedIndex = 0;
        }

        void FillCboOrientation()
        {
            List<string> ListOfOrientation = new List<string>();
            ListOfOrientation.Add("Heterosexual");
            ListOfOrientation.Add("Homosexual");
            ListOfOrientation.Add("Bisexual");

            foreach (var item in ListOfOrientation)
            {
                cboOrientation.Items.Add(item);
            }

            cboOrientation.SelectedIndex = 0;
        }

        void FillCboMembership()
        {
            List<string> ListOfMembership = new List<string>();

            ListOfMembership.Add("Standard");
            ListOfMembership.Add("VIP");

            foreach (var item in ListOfMembership)
            {
                cboMembership.Items.Add(item);
            }
            cboMembership.SelectedIndex = 0;
        }

        public double MembershipPrice(string toConvert)
        {
            double membership_Price = 0;

            if (toConvert == "Standard")
            {
                membership_Price = 500;
            }
            else if (toConvert == "VIP")
            {
                membership_Price = 10000;
            }

            return membership_Price;
        }

        private void btnRegisterNewMember_Click(object sender, EventArgs e)
        {
            string firstName, lastName, orientation, sex, country, tempMem_ID;
            int member_ID, membership_ID;

            tempMem_ID = txtMembershipID.Text;

            firstName = txtFirstName.Text;
            lastName = txtLastName.Text;
            orientation = cboOrientation.Text;
            sex = cboSex.Text;
            member_ID = decodeStringToInt.DecodeRFIDAndReturnID(tempMem_ID);
            country = cboCountry.Text;

            membership_ID = decodeStringToInt.ConvertCBOStringToINT(cboMembership.Text);

            try
            {
                databaseOperations.RegisterMember(firstName, lastName, orientation, sex, country, member_ID, membership_ID);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            databaseOperations.FillDGV(dgvInfo, members);
        }

        private void btnShowRegisteredMembers_Click(object sender, EventArgs e)
        {

            databaseOperations.FillDGV(dgvInfo, members);
        }

        private void btnDeleteMember_Click(object sender, EventArgs e)
        {
            Form FormDeleteMember = new FormDeleteMember();
            FormDeleteMember.Show();
            this.Hide();
        }

        private void btnAutoFillForTesting_Click(object sender, EventArgs e)
        {
            txtFirstName.Text = "AutoFillTestFirst";
            txtLastName.Text = "AutoFillTestLast";
            txtMembershipID.Text = "B20AE61B";
            cboMembership.SelectedIndex = 1;
            cboOrientation.SelectedIndex = 2;
            databaseOperations.FillDGV(dgvInfo, members);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Form formLogin = new FormLogin();
            formLogin.Show();
            this.Hide();
        }
    }
}