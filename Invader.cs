namespace TreehouseDefense
{
    class Invader
    {
        private readonly Path _path;
        private int _pathStep = 0;
        
        // This is some crazy syntactic sugar. Invader.Location will return the result of the line "_path.GetLocationAt(_pathStep);"
        public MapLocation Location => _path.GetLocationAt(_pathStep);
        
        public int Health {get; private set;}
        
        // True if the invader has reached the end of the path
        public bool HasScored => (_pathStep >= _path.Length);
        
        public bool IsDead => (Health <= 0);
        
        // Invader is active if he isn't dead and hasn't scored
        public bool IsActive => !(IsDead || HasScored);
        
        public Invader(Path path, int health)
        {
            _path = path;
            Health = health;
        }
        
        public void Move()
        {
            _pathStep++;
            System.Console.WriteLine(this.Location.X + "," + this.Location.Y);
        }
        
        public void Damage(int damage)
        {
            Health -= damage;
        }
    }
}