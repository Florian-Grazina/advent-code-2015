using _06;

LightGrid lightGrid = new LightGrid();

string[] input = File.ReadAllLines("../../../input.txt");
foreach(string line in input)
{
    Command command = new(line);
    lightGrid.Action(command);
}

long result = lightGrid.Lights.Cast<Light>().Sum(light => light.Brigthness);
{ }