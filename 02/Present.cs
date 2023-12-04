using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02
{
    internal class Present
    {
        public int Length { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public List<int> Min {  get; set; }
        public int Ribbon { get; set; }


        public Present(string[] input)
        {
            Length = int.Parse(input[0]);
            Width = int.Parse(input[1]);
            Height = int.Parse(input[2]);
            Min = new List<int>(){Length, Width, Height}.OrderBy(x => x).ToList();
            CalculateRibbon();
        }


        public void CalculateRibbon()
        {
            Ribbon = Min[0] * 2 + Min[1] * 2 + Length * Width * Height;
        }
    }
}
