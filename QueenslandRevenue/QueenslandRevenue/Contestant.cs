using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueenslandRevenue
{
    class Contestant
    {
        ///datafields
        ///

        public static char[] TALENTCODES = new char[] { 'S', 'D', 'M', 'O' };
        public static string[] TALENTDES = new string[] { "Singing", "Dancing", "Muscian", "Other" };
        string contenstantName;
        public string contestantCodeDes;
        char contestantCode;
        char contestantCodeNew;


        ///properties
        ///

        public string ContestantName
        {
            set { contenstantName = value; }
            get { return contenstantName; }
        }


        public char ContestantCode
        {
            set { contestantCode = value;
                
            }
            get {
                contestantCodeNew = ValidCode(contestantCode);
                return contestantCodeNew; }
        }

        public string CodeDes
        {
            get
            {
                contestantCodeDes = AssignDes(contestantCode);

                return contestantCodeDes; }
        }


        public Contestant() { }


        public Contestant( string name, char codes)
        {
            contenstantName = name;
            contestantCode = codes;
        }

        

        public static string AssignDes (char code)
        {
            string contestantCodeDes="";

            for (int x = 0; x < TALENTCODES.Length; x++)
                 {
                     if (code == TALENTCODES[x])
                     {
                         contestantCodeDes = TALENTDES[x];
                          
                         break;
                     }
                     else
                     {
                         contestantCodeDes = "Invalid";
                     }

                 }

            return contestantCodeDes;

        }

        public static char ValidCode (char code)
        {
            bool isValid = false;
            char newcode;
            for (int x=0; x<TALENTCODES.Length; x++)
            {
                if(code == TALENTCODES[x])
                {
                    isValid = true;
                }
            }

            if (isValid == false)
            {
                newcode = 'I';
            }
            else
            {
                newcode = code;
            }

            return newcode;
        }

    }
}
