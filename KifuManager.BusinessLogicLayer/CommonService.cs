using System;
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
            return match + "";
        }
    }
}
