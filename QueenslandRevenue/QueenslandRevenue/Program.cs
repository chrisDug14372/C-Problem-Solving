using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


namespace QueenslandRevenue
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfCOntestants;
            string name;
            char code;
            bool isInt;


            WriteLine("Please enter the number of contestants :\n ");
            isInt = int.TryParse(ReadLine(), out numberOfCOntestants);
            TestIntValid(isInt, ref numberOfCOntestants);
            CalcRev(numberOfCOntestants);


            string[] allNames = new string[numberOfCOntestants];


            Contestant[] contestants2019 = new Contestant[numberOfCOntestants];

            for (int x = 0; x < numberOfCOntestants; x++)
            {
                CLASSINPUT(out name, out code);
                contestants2019[x] = new Contestant(name, code);
                


            }
            for (int x=0; x<numberOfCOntestants; x++)
            {
                allNames[x] = contestants2019[x].ContestantName;
            }


            const int dummy = 0;
            string testCode;
            VALIDCAT();
            char validCode;


            while (dummy < 1)
            {
                WriteLine("Please enter the talent code and we\nwill display a list of contestants with that skill\n");
                testCode = ReadLine();
                validCode = CharValid(testCode);
                for (int t = 0; t < numberOfCOntestants; t++)
                {
                    WriteTalentLists(validCode, contestants2019[t].ContestantCode, contestants2019[t].ContestantName);
                }



            }
        }


        public static void TestIntValid(bool isInt, ref int numberOfCOntestants)
        {
            const int LOWNUM = 0;
            const int HIGHNUM = 30;
            while (isInt != true || numberOfCOntestants < LOWNUM || numberOfCOntestants > HIGHNUM)
            {
                WriteLine("Please enter a VALID number");

                isInt = int.TryParse(ReadLine(), out numberOfCOntestants);
            }

        }

        public static void CalcRev(int numberOfCon)
        {
            const double COSTPP = 25.00;
            double showRevenue;

            showRevenue = numberOfCon * COSTPP;

            WriteLine("There are {0} people in the show this year.\n" +
                "The tickets are {1} which means the revenue for the show is : {2}", numberOfCon, COSTPP.ToString("C2"), showRevenue.ToString("C2"));
        }

        public static void CLASSINPUT(out string name, out char code)
        {

            string codeStr;
            WriteLine("\nPlease enter the contestants name");
            name = Convert.ToString(ReadLine());
            WriteLine("\nPlease enter the talent code which correspondes to the below categories :\n");
            VALIDCAT();
            codeStr = ReadLine();
            char.TryParse(codeStr, out code);
        }

        public static void VALIDCAT()
        {
            string[] TALENTDES = new string[] { "Singing", "Dancing", "Muscian", "Other" };
            for (int x = 0; x < TALENTDES.Length; x++)
            {
                WriteLine("{0}", TALENTDES[x]);

            }
        }

        public static char CharValid (string testChar)
        {
            char[] TALENTCODES = new char[] { 'S', 'D', 'M', 'O' };
            bool isNum;
            bool isChar;
            bool isValidChar = false;
            char talChar;
            int talInt;
            isNum = int.TryParse(testChar, out talInt);
            isChar = char.TryParse(testChar, out talChar);
            if (isNum == true)
            {
                WriteLine("You entered a number! not a Character!\n");
            }
            else
            {
                for (int x=0; x<TALENTCODES.Length; x++)
                {
                    if (talChar == TALENTCODES[x])
                    {
                        isValidChar = true;
                    }

                }

            }
            if (isValidChar == false && isNum ==false)
            {
                WriteLine("You did not enter a valid character!!\n");
            }

            return talChar;
        }
  
        public static void WriteTalentLists(char userCode, char talentCode, string name)
        {
            if (userCode == talentCode && userCode != 'I')
            {
                WriteLine("{0}", name);
            }
        }
    }
}