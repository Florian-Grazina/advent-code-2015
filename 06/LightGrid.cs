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
        public bool[,] Lights { get; set; }


        // constructor
        public LightGrid()
        {
            Lights = new bool[1000, 1000];
            InitLights();
        }


        // methods
        private void InitLights()
        {
            for(int i = 0; i <  Lights.GetLength(0); i++)
            {
                for(int j = 0; j < Lights.GetLength(1); j++)
                {
                    Lights[i,j] = false;
                }
            }
        }

        internal void Action(Command command)
        {
            bool? turnOn = null;

            if (command.Action == "turn on")
                turnOn = true;
            else if (command.Action == "turn off")
                turnOn = false;

            for (int x = command.XStart; x <= command.XEnd; x++)
            {
                for (int y = command.YStart; y <= command.YEnd; y++)
                {
                    if(turnOn.HasValue)
                        Lights[x, y] = turnOn.Value;
                    else
                        Lights[x, y] = !Lights[x, y];
                }
            }

        }
    }
}
