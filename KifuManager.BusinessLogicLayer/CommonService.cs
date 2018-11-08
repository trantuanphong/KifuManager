using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace KifuManager.BusinessLogicLayer
{
    public class CommonService
    {
        public static string GetContentInBracket(string input, string title)
        {
            string pattern = title + @"\[(.*?)\]";
            Match match = Regex.Match(input, pattern);
            return match.Groups[1] + "";
        }

        public static ArrayList Rotate90(ArrayList opening)
        {
            StringBuilder switchChar = new StringBuilder();
            for (int i = 97; i < 117; i++)
            {
                switchChar.Append(Convert.ToChar(i));
            }
            for (int i = 0; i < opening.Count; i++)
            {
                StringBuilder sb = new StringBuilder(opening[i].ToString());
                int index = switchChar.ToString().IndexOf(sb[1]);
                sb[1] = sb[0];
                sb[0] = switchChar[switchChar.Length - 1 - index];
                opening[i] = sb.ToString();
            }
            return opening;
        }

        public static int CountExistOpening(ArrayList steps, ArrayList opening)
        {
            StringBuilder blackSteps = new StringBuilder();
            StringBuilder whiteSteps = new StringBuilder();
            bool check1 = true, check2 = true;
            int count = 0;
            for (int i = 0; i < opening.Count; i++)
            {
                blackSteps.Append(steps[i * 2] + "|");
                whiteSteps.Append(steps[i * 2 + 1] + "|");
            }
            for (int i = 0; i < opening.Count; i++)
            {
                if (!blackSteps.ToString().Contains(opening[i].ToString()))
                {
                    check1 = false;
                }
                if (!whiteSteps.ToString().Contains(opening[i].ToString()))
                {
                    check2 = false;
                }
            }
            count = (check1 == true) ? count + 1 : count; //count = 1 black
            count = (check2 == true) ? count + 2 : count; //count = 2 white
            //count = 3 both
            return count;
        }

        public static ArrayList OpeningStep(string inputContent)
        {
            ArrayList ouputContent = new ArrayList();
            //Cut the string from AB to FG
            int indexAB = inputContent.IndexOf("AB");
            string temp = inputContent.Remove(0, indexAB + 2);
            for (int i = 0; i < temp.Length; i++)
            {
                int charToInt = Convert.ToInt32(temp[i]);
                if (charToInt >= 65 && charToInt <= 90)
                {
                    temp = temp.Remove(i);
                    break;
                }
            }
            //Search all steps which has form like ac, dk, qw,....
            String pattern = @"[a-z]{2}";
            int k = 0;
            foreach (Match m in Regex.Matches(temp, pattern))
            {
                //Each m.Value is a step
                ouputContent.Add(m.Value);
            }
            return ouputContent;
        }
    }
}
