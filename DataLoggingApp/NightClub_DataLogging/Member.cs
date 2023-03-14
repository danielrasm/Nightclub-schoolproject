using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NightClub_DataLogging
{
    internal class Member
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Orientation { get; set; }
        public string Sex { get; set; }
        public string Country { get; set; }
        public int Membership_ID { get; set; }
        public int Member_ID { get; set; }
        public int TimesEnteredClubFabric { get; set; }
        public int TimesEnteredClubBerghain { get; set; }
        public int TimesEnteredClubParadiseClub { get; set; }
        public int TimesEnteredClubLeSacre { get; set; }
        public int TimesEnteredClubCasablanca { get; set; }


        public Member(string firstName, string lastName, string orientation,
                      string sex, string country, int member_ID, int membership_ID)
        {
            FirstName = firstName;
            LastName = lastName;
            Orientation = orientation;
            Sex = sex;
            Country = country;
            Membership_ID = member_ID;
            Membership_ID = membership_ID;
        }

        public Member()
        {

        }



        
    }
}
