using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertiesExample1
{
    internal class Only_GetAccessorExample
    {
        private static int cnt;//this is one static variable
        // to define constructor
        public Only_GetAccessorExample()//Default INSTANCE CONSTRUTOR OR NORMAL CONSTRUCTOR
        {
            // increment the counter
            // using constructor
            cnt++;//++ is the increament opertor it increase +1;//cnt=cnt+1;
        }
        // Declare counter property
        public static int Counter   //static get accessor property.and we called this as static property
        {
            // read-only property OR GET accessor.
            get
            {
                return cnt;
            }
        }

    }
}
/*
properties are classified into two types.
========================================
1) Non static property or instance property.
2) Static property.
Instance property: - while defining a property if we d idn‟t use static keyword
====================
which can be called as instance property.
 Using instance property we can assign value to an instance variable as well as
we can retrieve value from instance variable.
Static property: - while defining a property if we use static keyword then that
===============
property is called as static property.
 Using this property we can assign a value to static variable as well as we can
retrieve value from static variable.
*/