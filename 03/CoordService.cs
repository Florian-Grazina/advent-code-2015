namespace _03
{
    internal class CoordService
    {
        public int X { get; set; }
        public int Y { get; set; }
        public List<int[]> ListOfVisitedHouses { get; set; } = [[0, 0]];
        int[] Coord => [X, Y];

        public void Move(char command)
        {
            switch (command)
            {
                case '>': X++; break;
                case '<': X--; break;
                case '^': Y++; break;
                case 'v': Y--; break;
            }

            if(!ListOfVisitedHouses.Any(c => c.SequenceEqual(Coord)))
                ListOfVisitedHouses.Add(Coord);
        }
    }
}
