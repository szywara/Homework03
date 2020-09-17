using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie03v2
{
    public  class Customer
    {
        public string fname;
        public string lname;
        public int priority;

        public Customer(string fname, string lname, int priority)
        {
            this.fname = fname; this.lname = lname; this.priority = priority;
        }

        public string Fname { get { return fname; } set { fname = value; } }
        public string Lname { get { return lname; } set { lname = value; } }
        public int Priority { get { return priority; } set { priority = value; } }


        
    }
}
