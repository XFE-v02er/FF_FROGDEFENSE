using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FF_FROGDEFENSE_APP
{
    class Tower
    {
        private const int _range = 1;
        private const int _power = 1;
        private const double _accuracy = .75;

        private static readonly Random _random = new Random();

        private readonly MapLocation _location;

        public Tower(MapLocation location)
        {
            _location = location;
        }

        public bool IsSuccessfulShot()
        {
            return _random.NextDouble() < _accuracy;
        }

        public void FireOnInvaders(Invader[] invaders)
        {
           
            for (int i = 0; i < invaders.Length; i++)
            {
                if (invaders[i].IsActive && _location.InRangeOf(invaders[i].Location, _range))
                {
                    if (IsSuccessfulShot())
                    {
                        invaders[i].DecreaseHealth(_power);
                    }
                    break;
                }
            }


        }
    }
}
