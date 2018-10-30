using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace KifuManager.App_Code.BusinessLogicLayer
{
    public class ProcessKifu
    {
        public string SplitPatern(string content, string[] note, int p)
        {
            string[] word = content.Split(note, StringSplitOptions.RemoveEmptyEntries);
            return word.Length > 1 ? word[p] : "";
        }

        public string GetContent(string content, string note)
        {
            string[] note1 = { note + "[" };
            content = SplitPatern(content, note1, 1);
            string[] note2 = { "]" };
            content = SplitPatern(content, note2, 0);
            return content;
        }
    }
}