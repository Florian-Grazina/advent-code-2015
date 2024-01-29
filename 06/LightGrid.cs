using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06
{
    internal class LightGrid
    {
        // properties
        public Light[,] Lights { get; set; }


        // constructor
        public LightGrid()
        {
            Lights = new Light[1000, 1000];
            InitLights();
        }

        private void InitLights()
        {
            for(int x = 0; x < Lights.GetLength(0); x++)
            {
                for (int y = 0; y < Lights.GetLength(1); y++)
                {
                    Lights[x, y] = new();
                }
            }
        }



        // methods
        internal void Action(Command command)
        {
            int brightness = 2;

            if (command.Action == "turn on")
                brightness = 1;
            else if (command.Action == "turn off")
                brightness = -1;

            for (int x = command.XStart; x <= command.XEnd; x++)
            {
                for (int y = command.YStart; y <= command.YEnd; y++)
                {
                    if (Lights[x, y].Brigthness + brightness >= 0)
                        Lights[x, y].Brigthness += brightness;
                }
            }
        }
    }
}
