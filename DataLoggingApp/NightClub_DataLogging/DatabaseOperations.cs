using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Diagnostics.Metrics;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using static System.Reflection.Metadata.BlobBuilder;
using System.Xml.Linq;

namespace NightClub_DataLogging
{
    internal class DatabaseOperations
    {
        //Class for operations between the DataLogging app and the database

        string nightClubConfig = ConfigurationManager.ConnectionStrings["Project_NightClub"].ConnectionString;
        TextBox txtMembershipID;

        public DatabaseOperations()
        {
            txtMembershipID = new TextBox();
        }

        public DatabaseOperations(TextBox txtMembershipID)
        {
            this.txtMembershipID = txtMembershipID;
        }


        public List<string> GetListOfCountries(List<string> countries)
        {

            SqlConnection conNightClub = new SqlConnection(nightClubConfig);
            string sqlQueryCountries = "SELECT Country FROM COUNTRIES";
            SqlCommand sql = new SqlCommand(sqlQueryCountries, conNightClub);
            conNightClub.Open();
            SqlDataReader dr = sql.ExecuteReader();

            while (dr.Read() == true)
            {
                sqlQueryCountries = dr[0].ToString();
                countries.Add(sqlQueryCountries);
            }

            conNightClub.Close();
            return countries;
        }

        public List<string> GetListOfClubs(List<string> clubs)
        {
            SqlConnection conNightClub = new SqlConnection(nightClubConfig);
            string sqlQueryCountries = "SELECT ClubName FROM CLUBS ORDER BY ClubName ASC";
            SqlCommand sql = new SqlCommand(sqlQueryCountries, conNightClub);
            conNightClub.Open();
            SqlDataReader dr = sql.ExecuteReader();

            while (dr.Read() == true)
            {
                sqlQueryCountries = dr[0].ToString();
                clubs.Add(sqlQueryCountries);
            }
            conNightClub.Close();
            return clubs;
        }

        public void RegisterMember(string firstName, string lastName, string orientation,
                                   string sex, string country, int member_ID, int membership_ID)
        {
            if (member_ID > 5)
            {
                MessageBox.Show("Invalid chip used.\r\nPlease scan again.");
                txtMembershipID.Clear();
                txtMembershipID.Focus();
            }
            else
            {
                try
                {
                    using (SqlConnection conNightClub = new SqlConnection(nightClubConfig))
                    {
                        SqlCommand sql = new SqlCommand("uspRegisterMember", conNightClub);
                        sql.CommandType = CommandType.StoredProcedure;
                        conNightClub.Open();
                        sql.Parameters.Add(new SqlParameter("@membership_ID", membership_ID));
                        sql.Parameters.Add(new SqlParameter("@firstName", firstName));
                        sql.Parameters.Add(new SqlParameter("@lastName", lastName));
                        sql.Parameters.Add(new SqlParameter("@orientation", orientation));
                        sql.Parameters.Add(new SqlParameter("@sex", sex));
                        sql.Parameters.Add(new SqlParameter("@id_Number", member_ID));
                        sql.Parameters.Add(new SqlParameter("country", country));
                        sql.ExecuteNonQuery();
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("User already registered");
                }
            }

        }


        public void DeleteMember(int member_ID)
        {
            try
            {
                SqlConnection conNightClub = new SqlConnection(nightClubConfig);
                SqlCommand sql = new SqlCommand("uspDeleteMember", conNightClub);
                sql.CommandType = CommandType.StoredProcedure;
                conNightClub.Open();

                sql.Parameters.Add(new SqlParameter("id_Number", member_ID));

                sql.ExecuteNonQuery();
                conNightClub.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void FillDGV(DataGridView dgv, string query)
        {
            SqlConnection conNightClub = new SqlConnection(nightClubConfig);
            SqlDataAdapter sda;
            DataTable dt;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            try
            {
                conNightClub.Open();
                sda = new SqlDataAdapter(query, nightClubConfig);
                dt = new DataTable();
                sda.Fill(dt);
                dgv.DataSource = dt;
                conNightClub.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        public bool CheckIfMemberIsRegistered(int member_ID)
        {
            int testID = 0;
            bool checkIfMemReg = false;

            try
            {
                SqlConnection conNightClub = new SqlConnection(nightClubConfig);
                SqlCommand sql = new SqlCommand("uspCheckIfMemberIsRegistered", conNightClub);
                sql.CommandType = CommandType.StoredProcedure;

                sql.Parameters.Add(new SqlParameter("@id_Number", member_ID));

                conNightClub.Open();
                sql.ExecuteNonQuery();

                SqlDataReader dr = sql.ExecuteReader();

                while (dr.Read())
                {
                    testID = Convert.ToInt32(dr[0]);
                }

                conNightClub.Close();

                if (testID == 0)
                {
                    checkIfMemReg = false;
                }
                else
                {
                    checkIfMemReg = true;
                }

                return checkIfMemReg;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Member GetMemberInfoFromDatabase(int memberID)
        {
            string firstName, lastName, orientation, sex, country;
            int membershipID, tempMemberID;

            try
            {
                SqlConnection con = new SqlConnection(nightClubConfig);
                SqlCommand cmd = new SqlCommand("uspGetMemberInfoList", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter("@member_ID", memberID));

                con.Open();
                cmd.ExecuteNonQuery();
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    firstName = (string)dr[0];
                    lastName = (string)dr[1];
                    orientation = (string)dr[2];
                    sex = (string)dr[3];
                    country = (string)dr[4];
                    membershipID = Convert.ToInt32(dr[5]);
                    tempMemberID = Convert.ToInt32(dr[6]);
                    return new Member(firstName, lastName, orientation, sex, country, memberID, membershipID);
                }
                con.Close();
                throw new InvalidOperationException("404: User not found");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }

        public Club GetClubInfo(int club_ID)
        {
            string clubName, city, country;
            int tempClub_ID;

            SqlConnection con = new SqlConnection(nightClubConfig);
            SqlCommand cmd = new SqlCommand("uspGetClubInfo", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add(new SqlParameter("@club_ID", club_ID));

            con.Open();
            cmd.ExecuteNonQuery();
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                tempClub_ID = (int)dr[0];
                clubName = (string)dr[1];
                city = (string)dr[2];
                country = (string)dr[3];
                return new Club(tempClub_ID, clubName, city, country);
            }
            con.Close();
            throw new InvalidOperationException("Club not found");

        }

        public void LogClubEntry(int member_ID, int club_ID)
        {

            try
            {
                using (SqlConnection conNightClub = new SqlConnection(nightClubConfig))
                {
                    SqlCommand sql = new SqlCommand("uspRegisterClubEntry", conNightClub);
                    sql.CommandType = CommandType.StoredProcedure;
                    conNightClub.Open();
                    sql.Parameters.Add(new SqlParameter("@id_Number", member_ID));
                    sql.Parameters.Add(new SqlParameter("@club_ID", club_ID));
                    sql.ExecuteNonQuery();
                    conNightClub.Close();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Club not found");
            }

        }

        public int GetClubID(string clubName)
        {
            int club_ID;

            SqlConnection con = new SqlConnection(nightClubConfig);
            SqlCommand cmd = new SqlCommand("uspGetClubID", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add(new SqlParameter("@clubName", clubName));

            con.Open();
            cmd.ExecuteNonQuery();
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                club_ID = (int)dr[0];
                return club_ID;
            }
            con.Close();
            throw new InvalidOperationException("Club not found.");

        }

        public bool CheckIfMemberIsVIP(int memberID)
        {
            int testID = 1;
            bool checkIfMemIsVIP = false;

            try
            {
                SqlConnection conNightClub = new SqlConnection(nightClubConfig);
                SqlCommand sql = new SqlCommand("uspCheckIfMemberIsVIP", conNightClub);
                sql.CommandType = CommandType.StoredProcedure;

                sql.Parameters.Add(new SqlParameter("@id_Number", memberID));

                conNightClub.Open();
                sql.ExecuteNonQuery();

                SqlDataReader dr = sql.ExecuteReader();

                while (dr.Read())
                {
                    testID = Convert.ToInt32(dr[0]);
                }

                conNightClub.Close();

                if (testID == 1)
                {
                    checkIfMemIsVIP = false;
                }
                else if (testID == 2)
                {
                    checkIfMemIsVIP = true;
                }

                return checkIfMemIsVIP;
            }
            catch (Exception)
            {
                throw;
            }
        }

    }
}
