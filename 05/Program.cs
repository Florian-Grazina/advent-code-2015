using _05;

string[] input = File.ReadAllLines("../../../input.txt");
NiceString stringService = new();

foreach (string line in input)
{
    stringService.CheckString(line);
}

Console.WriteLine(stringService.NumberOfNiceStrings);