using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FF_FROGDEFENSE_APP
{
    class Path
    {
        private readonly MapLocation[] _path;

        public Path(MapLocation[] path)
        {
            _path = path;
        }

        public GetLocationAt(int pathStep)
        {
            return _path[pathStep];
        }

    }
}
