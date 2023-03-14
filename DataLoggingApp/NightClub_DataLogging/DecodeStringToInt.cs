using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NightClub_DataLogging
{
    internal class DecodeStringToInt
    {
        string adminCard = "0430C5009F1C03";
        string greenTag = "2479BC57";
        string blackTag = "44BA3085";
        string blueTag = "B415C066";
        string redTag = "240B376A";
        string yellowTag = "B20AE61B";

        public int DecodeRFIDAndReturnID(string RFIDcode)
        {
            int member_ID = 6;

            if (RFIDcode == adminCard)
            {
                member_ID = 0;
            }
            else if (RFIDcode == greenTag)
            {
                member_ID = 1;
            }
            else if (RFIDcode == blackTag)
            {
                member_ID = 2;
            }
            else if (RFIDcode == blueTag)
            {
                member_ID = 3;
            }
            else if (RFIDcode == redTag)
            {
                member_ID = 4;
            }
            else if (RFIDcode == yellowTag)
            {
                member_ID = 5;
            }
            return Convert.ToInt32(member_ID);
        }

        public int ConvertCBOStringToINT(string toConvert)
        {
            int temp_ID = 0;

            if (toConvert == "Standard")
            {
                temp_ID = 1;

            }
            else if (toConvert == "VIP")
            {
                temp_ID = 2;
            }

            return temp_ID;
        }


    }
}
