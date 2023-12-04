using _03;

string input = File.ReadAllText("../../../input.txt");
CoordService santaCoord = new();
CoordService robotCoord = new();

bool santaIsMoving = true;
foreach (char command in input)
{
    if(santaIsMoving)
        santaCoord.Move(command);
    else robotCoord.Move(command);

    santaIsMoving = !santaIsMoving;
}

List<int[]> totalHousesVisited = santaCoord.ListOfVisitedHouses;

foreach (int[] coord in robotCoord.ListOfVisitedHouses)
{
    if(!totalHousesVisited.Any(c => c.SequenceEqual(coord)))
        totalHousesVisited.Add(coord);
}

Console.WriteLine(totalHousesVisited.Count);