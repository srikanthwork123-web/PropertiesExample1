using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertiesExample1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            employee obj=new employee();
            obj.collegename = "JNTU";//without property also we can assign the data instance variables
            
     //======Through property we can assign and get the data from instance variables===================
            obj.Empno = 1;//here i am assigning or set the data to  Empno property.
            Console.WriteLine(obj.Empno);//here i am reading or accessing the Empno property 

            obj.Empname="Sachin Tendulkar";//here i am assigning or set the data to  Empname property.
            Console.WriteLine(obj.Empname);//here i am reading or accessing the Empname property.

            obj.Empsal = 1000.6;//here i am assigning or set the data to  Empsal property.
            Console.WriteLine(obj.Empsal);//here i am reading or accessing the Empsal property.

            //=================================================
            sipdashboard obj1=new sipdashboard();
           // obj1.
           //here you can't access private variables and methods outside class.


        }
    }
}
