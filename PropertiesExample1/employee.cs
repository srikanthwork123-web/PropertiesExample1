using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertiesExample1
{
    internal class employee
    {
        /*Property Definition:
         *========================
         Property is a member of class used to write/set/assign  the data in the (data field/variables) and read/get the data from the (data field/variables)
property  will have Three Types or accessories .
1) Set accessor or Write only
2) Get accessor or Read only
3)Set accessor or Write only and Get accessor or Read only
synatx for property:
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
(3)Set accessor or Write only and Get accessor or Read only
=====================================================
<access modifier><Variablenamedatatype><property name>
{
Get
{
Return <data member or variablename>;
}
Set
{
<data member or variablename>=value;
}
}


Note:inside class variable we can also called data member.
By using this property .we can get the data from variablename and we can set or assign the data to variablename.
==========================
        */
        //Instance variables or non static variables or fileds or data fileds or datamember
        int empno;//this is int varibale
        string empname;//this is string variable
        double empsal;//this is double variable
        internal string collegename;//without public or internal accessmofifier you can't access this variable outside class.
//before or earlier we can assign the data to this instance variables or non static variables by using constructor. 
//Without Constructor also we can assign the data to instace variables.by using property concept we can assign.
/*How many ways  to assign the data to instance variables?
A)we can assign the data to instance variables or non static variables by using constructor.
2)Through prpoerty we can assign the data to instance variables or non static variables.
Note:If class having a private variables ,if you want to access outside create a property for that variable and 
we can access the property outside and we can also assign the data to private variable by using property..
Without property concept we can't assign the data to private variables from outside class.

*/
        //==========Empno property Start here==================
        //by using this property we can assign the data  and we can red the data from property.
        //And To assign the data to private varibles and get the data from private variables purpose we used propery
        //by using peroperty we can provide the sceurity to instance variables.here we are hiding the orginal varailename and outside class we are showing another name.
        public int Empno  //Empno is a  Property Name.Properties are never store the value/data but used to transfer a value/data.
        {
            set //It will assign the value to variable.
            {
                empno = value;//empno is our orginal variablename
            }
            get //get accessor will  reading the value or retrieving or accessing  the value from variable.
            {
                return empno;
            }
        }
        //public int Empno{get;set;}  //this is shortcut for new version propeties we called this concept as  autoimplemeted properteis. /
        //============Empno property End here===================
        //============Empname property start here==============
        public string Empname  //non static property.
        {
            get   //Get accessor or Read only
            {
                return empname;
            }
            set //Set accessor or Write only
            {
                empname = value;
            }
        }
        //============Empname property End here=====================
        //============Empsal property Start here====================
        public double Empsal//Empsal  is propertyname
        {
            get
            {
                return empsal;//empsal is Variablename
            }
            set
            {
                empsal = value;
            }
        }
        //===============Empsal property Ends here======================
        public void DisplayProprtiesData()
        {
            Console.WriteLine(empno);
            Console.WriteLine(empsal);
            Console.WriteLine(empname);
        }
        
    }

}
