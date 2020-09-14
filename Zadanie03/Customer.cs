using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie03
{
    class Customer
    {
        private string fname;
        private string lname;
        private int priority;
        public string Fname { get { return fname; } set { fname = value; } }
        public string Lname { get { return lname; } set { lname = value; } }
        public int Priority { get { return priority; } set { priority = value; } }

    }
}
