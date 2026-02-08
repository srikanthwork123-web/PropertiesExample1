using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertiesExample1
{
    /*
     if you are not applying any access modifier inside class,defaultly it will take private for variables and methods and for class defaultly internal will apply by your c# compiler.
    */
     class sipdashboard
    {
        int empid;
        string empname;
        string empaddress;
        //by using private constructor we can restrict to create th objecte outside of the call .
        //whenver if you apply public or internal then only you can  create object for this calss outside.
       internal  sipdashboard()//user defined default constructor.
        {
            empid = 1;
            empname = "sachin";
            empaddress = "Hyd";
        }
        void displayEmpDetails()
        {
            Console.WriteLine(empid);
            Console.WriteLine(empname);
            Console.WriteLine(empaddress);
        }
    }
}
