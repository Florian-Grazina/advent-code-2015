using _02;

string[] input = File.ReadAllLines("../../../input.txt");
List<Present> presents = new();

foreach(string line in input)
{
    presents.Add(new(line.Split("x")));
}

Console.WriteLine(presents.Sum(p => p.Ribbon));