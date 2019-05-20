using System;

namespace TreehouseDefense
{
    class Game
    {
        public static void Main()
        {
            Map map = new Map(8, 5);
            
            try
            {
                Path path = new Path(
                    new [] {
                        new MapLocation(0, 2, map),
                        new MapLocation(1, 2, map),
                        new MapLocation(2, 2, map),
                        new MapLocation(3, 2, map),
                        new MapLocation(4, 2, map),
                        new MapLocation(5, 2, map),
                        new MapLocation(6, 2, map),
                        new MapLocation(7, 2, map)
                    }
                );
                
                Invader[] invaders =
                {
                    // TODO: Currently using magic numbers for invader health
                    new Invader(path, 1),
                    new Invader(path, 1),
                    new Invader(path, 2),
                    new Invader(path, 2)
                };
                
                Tower[] towers = {
                    new Tower(new MapLocation(1, 3, map)),
                    new Tower(new MapLocation(3, 3, map)),
                    new Tower(new MapLocation(5, 3, map))
                };
                
                Level level1 = new Level(invaders)
                {
                    // We can do this and set the level's Tower property in the same line we instantiate the level
                    Towers = towers
                };
                
                bool playerWon = level1.Play();
                
                Console.WriteLine(playerWon? "You won!" : "You lost!");
                Console.ReadLine();
            }
            //More specific exceptions need to go first
            catch(OutOfBoundsException e)
            {
                Console.WriteLine(e);
            }
            catch(TreehouseDefenseException)
            {
                Console.WriteLine("Unhandled TreehouseDefenseException");
            }
            catch(Exception e )
            {
                Console.WriteLine("Unhandled System.Exception: " + e);
            }
        }
    }
}