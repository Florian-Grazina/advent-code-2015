using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _06
{
    internal class Command
    {
        public int XStart { get; set; }
        public int XEnd { get; set; }
        public int YStart { get; set; }
        public int YEnd { get; set; }
        public string Action { get; set; }


        public Command(string input)
        {
            Parse(input);
        }

        private void Parse(string input)
        {
            Match match = Regex.Match(input, @"^([^\d]+)(\d+),(\d+) through (\d+),(\d+)");
            Action = match.Groups[1].Value.Trim();
            XStart = int.Parse(match.Groups[2].Value.Trim());
            YStart = int.Parse(match.Groups[3].Value.Trim());
            XEnd = int.Parse(match.Groups[4].Value.Trim());
            YEnd = int.Parse(match.Groups[5].Value.Trim());
        }
    }
}
