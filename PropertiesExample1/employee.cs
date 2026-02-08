using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertiesExample1
{
    internal class employee
    {
        /*
property  will have two accessories .
1) Set accessor
2) Get accessor
        synatx for property:
         ==============================
        Set accessor:It will assign the value to variable.
        =============
        Syntax:
        ========
<Access modifier><data type><property name>
{
Set
{
<data member or variablename>=value;
}
}
Get accessor:
=================
This accessor will be reading the value or retrieving the value from variable.
Syntax:
============
<access modifier><data type><property name>
{
Get
{
Return <data member or variablename>;
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
        //==========Empno property Start here==================
        //by using this property we can assign the data  and we can red the data from property.
        //And To assign the data to private varibles and get the data from private variables purpose we used propery
        //by using peroperty we can provide the sceurity to instance variables.here we are hiding the orginal varailename and outside class we are showing another name.
        public int Empno  //Empno Property
        {
            set //It will assign the value to variable.
            {
                empno = value;
            }
            get //get accessor will  reading the value or retrieving or accessing  the value from variable.
            {
                return empno;
            }
        }
        //============Empno property End here===================
        //============Empname property start here==============
        public string Empname
        {
            get
            {
                return empname;
            }
            set
            {
                empname = value;
            }
        }
        //============Empname property End here=====================
        //============Empsal property Start here====================
        public double Empsal
        {
            get
            {
                return empsal;
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
