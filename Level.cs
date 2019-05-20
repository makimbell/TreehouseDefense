namespace TreehouseDefense
{
    class Level
    {
        private readonly Invader[] _invaders;
        
        public Tower[] Towers { get; set; }
        
        public Level(Invader[] invaders)
        {
            _invaders = invaders;
        }
        
        // Returns true if the player wins. Flase otherwise.
        public bool Play()
        {
            // Run until all invaders neutralized or an invader reaches the end of the path.
            int remainingInvaders = _invaders.Length;
            
            while(remainingInvaders > 0)
            {
                // Each tower has an opportunity to fire on invaders.
                foreach(Tower tower in Towers)
                {
                    tower.FireOnInvaders(_invaders);
                }
                
                // Count and move the invaders that are still active
                remainingInvaders = 0;
                foreach(Invader invader in _invaders)
                {
                    if(invader.IsActive)
                    {
                        invader.Move();
                        
                        if(invader.HasScored)
                        {
                            return false;
                        }
                        
                        remainingInvaders++;
                    }
                }
            }
            // If you get here, that means you finished the loop and all invaders are dead            
            return true;
        }
    }
}