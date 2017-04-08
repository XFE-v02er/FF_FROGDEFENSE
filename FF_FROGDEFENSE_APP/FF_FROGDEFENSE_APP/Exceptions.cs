using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FF_FROGDEFENSE_APP
{
    class TreehouseDefenseException : Exception
    {
        public TreehouseDefenseException()
        {

        }

        public TreehouseDefenseException(string message) : base(message)
        {

        }
    }

    class OutOfBoundsException : TreehouseDefenseException
    {

        public OutOfBoundsException()
        {

        }

        public OutOfBoundsException(string message) : base(message)
        {

        }
    }
}
