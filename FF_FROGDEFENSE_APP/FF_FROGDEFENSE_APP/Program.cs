using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FF_FROGDEFENSE_APP
{
    class Game
    {
        public static void Main(string[] args)
        {

            Map map = new Map(8, 5);

            try
            {
                MapLocation[] path =
                {
                    new MapLocation(0, 2, map),
                    new MapLocation(1, 2, map),
                    new MapLocation(2, 2, map),
                    new MapLocation(3, 2, map),
                    new MapLocation(4, 2, map),
                    new MapLocation(5, 2, map),
                    new MapLocation(6, 2, map),
                    new MapLocation(7, 2, map)

                };
            }

            catch(OutOfBoundsException ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadKey();
            }

 
            Console.ReadLine();

        }
    }
}
