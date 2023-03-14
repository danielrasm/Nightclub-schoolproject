using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NightClub_DataLogging
{
    internal class Club
    {
        public int Club_ID { get; set; }
        public string ClubName { get; set; }
        public string City { get; set; }
        public string Country { get; set; }

        public Club()
        {

        }

        public Club(int club_ID, string clubName, string city, string country)
        {
            Club_ID = club_ID;
            ClubName = clubName;
            City = city;
            Country = country;
        }
    }
}
