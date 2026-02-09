using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertiesExample1
{
    internal class SetAccessor_WriteOnlyPropertExamaple
    {
        /*
 *synatx for property:
==============================
(1)Set accessor or Write only:It will assign the value to variable.
===================================================================
Syntax:
========
<Access modifier><Variablenamedatatype><property name>
{
Set
{
<data member or variablename>=value;
}
}

(2)Get accessor or Read only:
==================================================
This accessor will be reading the value or retrieving the value from variable.
Syntax:
============
<access modifier><Variablenamedatatype><property name>
{
Get
{
Return <data member or variablename>;
}

}
*/
    private    int num1, num2, result;//create 3 private variables and data is not assigned.(we called this as variable declaration)
        //Set accessor or write only propert usage 
        public int pnum1
        {
            set { num1 = value; }//If you set/assign the data to variables we can use set accessor.
            //get { return result; }
        }
        public int pnum2
        {
            set { num2 = value; }
        }
        public int presult
        {
            get { return result; }//we can read the data from the variablename using get accessor.
        }
        public void add()
        {
            result = num1 + num2;
        }
        public void multily()
        {
            result = num1 * num2;
        }
    }
}
