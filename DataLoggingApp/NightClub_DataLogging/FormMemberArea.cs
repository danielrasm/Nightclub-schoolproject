using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NightClub_DataLogging
{
    public partial class FormMemberArea : Form
    {
        //Instance variables DatabaseOperations:
        #region #InitDatabaseOperations
        DatabaseOperations databaseOperations = new DatabaseOperations();
        #endregion

        //Instance variables Club:
        #region #InitClub
        Club club = new Club();
        #endregion

        Member member = new Member();

        public int memberID;

        public FormMemberArea(int memberID)
        {
            InitializeComponent();
            this.memberID = memberID;
            databaseOperations.FillDGV(
                dgvMemberArea,
                $@"
                    SELECT [ENTRY].TimeOfEntry AS [Previous entries], CLUBS.ClubName AS [Nightclub]
                    FROM [ENTRY] INNER JOIN CLUBS
                    ON [ENTRY].Club_ID = CLUBS.Club_ID
                    WHERE ID_Number = {memberID}
                    ORDER BY ClubName ASC
                  "
                );
            LblWelcomeToMemberArea();
        }

        private void LblWelcomeToMemberArea()
        {
            string name;
            Member memberName = databaseOperations.GetMemberInfoFromDatabase(memberID);
            name = memberName.FirstName;

            lblWelcomeToMemberArea.Text = $"Welcome, {name}";
        }


        private async Task BtnColorChange(Button button, Color color, string text)
        {
            var oldColor = button.BackColor;
            var oldText = button.Text;
            var delay = 2000;

            button.BackColor = color;
            button.Text = text;
            await Task.Delay(delay);

            button.BackColor = oldColor;
            button.Text = oldText;
        }

        private void AccessDenied(Button button)
        {
            _ = BtnColorChange(button, Color.Red, "Access Denied");
        }

        private void AccessGranted(Button button)
        {
            _ = BtnColorChange(button, Color.Green, "Access Granted");
        }

        private void btnBackToMenu_Click(object sender, EventArgs e)
        {
            Form DataloggingApp = new DataloggingAPP();
            DataloggingApp.Show();
            this.Close();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Form Login = new FormLogin();
            Login.Show();
            this.Close();
        }


        private void btnEnterFabric_Click(object sender, EventArgs e)
        {
            string clubName = "Fabric";
            int club_ID = databaseOperations.GetClubID(clubName);

            databaseOperations.LogClubEntry(memberID, club_ID);
            AccessGranted(btnEnterFabric);
            databaseOperations.FillDGV(
                dgvMemberArea,
                $@"
                    SELECT [ENTRY].TimeOfEntry AS [Previous entries], CLUBS.ClubName AS [Nightclub]
                    FROM [ENTRY] INNER JOIN CLUBS
                    ON [ENTRY].Club_ID = CLUBS.Club_ID
                    WHERE ID_Number = {memberID} AND [ENTRY].Club_ID = {club_ID}
                    ORDER BY CLUBS.ClubName ASC
                  "
                  );
        }

        private void btnEnterBerghain_Click(object sender, EventArgs e)
        {
            string clubName = "Berghain";
            string orientation;
            string[] validOrientationForBerghain = new string[] { "Bisexual", "Homosexual" };

            Member memberOrientation = databaseOperations.GetMemberInfoFromDatabase(memberID);
            orientation = memberOrientation.Orientation.Trim();

            int club_ID = databaseOperations.GetClubID(clubName);

            if (validOrientationForBerghain.Contains(orientation))
            {
                databaseOperations.LogClubEntry(memberID, club_ID);

                AccessGranted(btnEnterBerghain);
                databaseOperations.FillDGV(
                    dgvMemberArea,
                    $@"
                    SELECT [ENTRY].TimeOfEntry AS [Previous entries], CLUBS.ClubName AS [Nightclub]
                    FROM [ENTRY] INNER JOIN CLUBS
                    ON [ENTRY].Club_ID = CLUBS.Club_ID
                    WHERE ID_Number = {memberID} AND [ENTRY].Club_ID = {club_ID}
                    ORDER BY CLUBS.ClubName ASC
                  "
                      );
            }
            else
            {
                AccessDenied(btnEnterBerghain);
            }
        }

        private void btnEnterParadiseClub_Click(object sender, EventArgs e)
        {
            string clubName = "Paradise Club";
            int club_ID = databaseOperations.GetClubID(clubName);

            if (databaseOperations.CheckIfMemberIsVIP(memberID) == true)
            {
                databaseOperations.LogClubEntry(memberID, club_ID);
                AccessGranted(btnEnterParadiseClub);
                databaseOperations.FillDGV(
                    dgvMemberArea,
                    $@"
                    SELECT [ENTRY].TimeOfEntry AS [Previous entries], CLUBS.ClubName AS [Nightclub]
                    FROM [ENTRY] INNER JOIN CLUBS
                    ON [ENTRY].Club_ID = CLUBS.Club_ID
                    WHERE ID_Number = {memberID} AND [ENTRY].Club_ID = {club_ID}
                    ORDER BY CLUBS.ClubName ASC
                  "
                      );
            }
            else
            {
                AccessDenied(btnEnterParadiseClub);
            }

        }

        private void btnEnterLaSacre_Click(object sender, EventArgs e)
        {
            string clubName = "Le Sacrè";
            int club_ID = databaseOperations.GetClubID(clubName);

            databaseOperations.LogClubEntry(memberID, club_ID);
            AccessGranted(btnEnterLaSacre);
            databaseOperations.FillDGV(
                dgvMemberArea,
                $@"
                    SELECT [ENTRY].TimeOfEntry AS [Previous entries], CLUBS.ClubName AS [Nightclub]
                    FROM [ENTRY] INNER JOIN CLUBS
                    ON [ENTRY].Club_ID = CLUBS.Club_ID
                    WHERE ID_Number = {memberID} AND [ENTRY].Club_ID = {club_ID}
                    ORDER BY CLUBS.ClubName ASC
                  "
                  );
        }

        private void btnEnterCasablanca_Click(object sender, EventArgs e)
        {
            string clubName = "Casablanca";
            int club_ID = databaseOperations.GetClubID(clubName);

            databaseOperations.LogClubEntry(memberID, club_ID);
            AccessGranted(btnEnterCasablanca);
            databaseOperations.FillDGV(
                dgvMemberArea,
                $@"
                    SELECT [ENTRY].TimeOfEntry AS [Previous entries], CLUBS.ClubName AS [Nightclub]
                    FROM [ENTRY] INNER JOIN CLUBS
                    ON [ENTRY].Club_ID = CLUBS.Club_ID
                    WHERE ID_Number = {memberID} AND [ENTRY].Club_ID = {club_ID}
                    ORDER BY CLUBS.ClubName ASC
                  "
                  );
        }

        private void btnShowAllClubEntries_Click(object sender, EventArgs e)
        {

            databaseOperations.FillDGV(
                dgvMemberArea,
                $@"
                    SELECT [ENTRY].TimeOfEntry AS [Previous entries], CLUBS.ClubName AS [Nightclub]
                    FROM [ENTRY] INNER JOIN CLUBS
                    ON [ENTRY].Club_ID = CLUBS.Club_ID
                    WHERE ID_Number = {memberID}
                    ORDER BY ClubName ASC
                  "
                );
        }


    }
}
