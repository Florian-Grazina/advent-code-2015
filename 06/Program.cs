using _06;

LightGrid lightGrid = new LightGrid();

string[] input = File.ReadAllLines("../../../input.txt");
foreach(string line in input)
{
    Command command = new(line);
    lightGrid.Action(command);
}

Console.WriteLine(lightGrid.Lights.Cast<bool>().Count(value => value = true));