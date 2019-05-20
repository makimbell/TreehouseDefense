namespace TreehouseDefense
{
    class Map
    {
        public readonly int Width;
        public readonly int Height;
        
        public Map(int width, int height)
        {
            Width = width;
            Height = height;
        }
        
        public bool OnMap(Point point)
        {
            return (this.Width - point.X >= 0) && 
                   (this.Height - point.Y >= 0);
        }
    }
}