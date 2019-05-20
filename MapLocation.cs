namespace TreehouseDefense
{
    class MapLocation : Point
    {
        public MapLocation(int x, int y, Map map) : base(x, y)
        {
            if (!map.OnMap(this)) //This calls the "OnMap" method of map object that was passed in during creation
            {
                throw new OutOfBoundsException(x + ", " + y + " is outside the boundaries of the map.");
            }
        }
        
        public bool InRangeOf(MapLocation location, int range)
        {
            // Return whether the distance to a certain location is within the specified range
            return DistanceTo(location) <= range;
        }
    }
}