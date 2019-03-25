using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parse_JSON_Version_1
{
    class jsonPersonComplex : jsonPersonSimple
    {
        /* Inheritance avoids need for these.
        public string firstname { get; set; }
        public string lastname { get; set; }
        public double age { get; set; }
        public bool isAlive { get; set; }
        */
        public addr address { get; set; }

        public class addr
        {
            public string streetAddress { get; set; }
            public string city { get; set; }
            public string postCode { get; set; }
        }
    }
}
