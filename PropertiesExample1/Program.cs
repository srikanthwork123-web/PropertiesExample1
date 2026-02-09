using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
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
           /*
            * Note:If class having a private variables ,if you want to access outside create a property for that variable and 
we can access the property outside and we can also assign the data to private variable by using property..
Without property concept we can't assign the data to private variables from outside class.

            */
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

            //============STATIC PROPERTY================
            // create three instances/objects of
            // Only_GetAccessorExample class it call constructor
            // three times which increase the counter
            Only_GetAccessorExample s = new Only_GetAccessorExample();
            Only_GetAccessorExample s2 = new Only_GetAccessorExample();
            Only_GetAccessorExample s3 = new Only_GetAccessorExample();
            // s.Counter = 10;
            // Compile Time Error: Can't set value of
            // Counter because it is read only.
            //To access static property we will use classname.static propertyname.
            Console.WriteLine("Total No of Student: " + Only_GetAccessorExample.Counter);
            Console.ReadLine();
            // Program Give Warning
            // The variable `s' is assigned but its value is never used
            //=================================================
            SetAccessor_WriteOnlyPropertExamaple s1 = new SetAccessor_WriteOnlyPropertExamaple();
            Console.WriteLine("enter any two number");
            s1.pnum1 = Convert.ToInt32(Console.ReadLine());//pnum1 having only set accessor,it doesn't having a get accessor.
            //Console.WriteLine(s1.pnum1);//here you can't access pnum1 property beacuse you are not written get accessor in property.
            s1.pnum2 = Convert.ToInt32(Console.ReadLine());
            s1.add();
            Console.WriteLine("sum is" + s1.presult);
            s1.multily();
            Console.WriteLine("multiplication is" + s1.presult);
            Console.ReadLine();




            //==================================================


        }
    }
}
