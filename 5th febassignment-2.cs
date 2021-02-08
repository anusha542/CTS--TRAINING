 
 -----WAP to add three numbers----
 
 namespace firstproject
{
    class sum
    {
        static void Main()
        {
            int s = 0;
            int n;
            for ( n = 1; n <20; n++) ;
            s = s + n;
            Console.WriteLine(s);
        }

    }
}

-----WAP to print sum and average of 1st 20 natural numbers-----

namespace firstproject
{
    class avg
    {
        static void Main()
        {
            int s = 0;
            int n;
            for (n = 1; n < 20; n++) ;
            s = n*(n + 1) / 2;
            Console.WriteLine(s);
        }
    }
}


-------WAP to print first 50 even numbers---

namespace firstproject
{
    class even
    {
        static void Main()
        {
            
            int NUM;
            for (NUM = 0; NUM < 50; NUM++)
            {
                if (NUM % 2 == 0)
                {
                    Console.WriteLine(NUM);
                }
            }

            
        }
    }
}

------WAP to check whether a number is prime or not-----

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstproject
{
    class prime
    {
        static void Main()
        {

            int NUM;
            int i;
            Console.WriteLine("Enter NUM");
            NUM = Convert.ToInt16(Console.ReadLine());
            for (i = 2; i <= NUM / 2; i++)
            {
                if (NUM % i == 0)
                {
                    Console.WriteLine("Number is not a prime");

                    break;
                }

            
              else
            {
                Console.WriteLine("Number is a prime");
            }

        }


        }
    }
}

---------WAP to print table of entered number in following format

5 * 1 = 5
5 * 2 = 10------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstproject
{
    class table
    {
        static void Main()
        {

            int NUM;
            int i;
            Console.WriteLine("Enter NUM");
            NUM = Convert.ToInt16(Console.ReadLine());
            for (i = 1; i <= 10; i++)
            {
                Console.WriteLine(" {0} X {1} = {2}   ", NUM, i, NUM * i);
            }
        }
    }
}

----------WAP to take some numbers from user. Note the difference between ToIn16, ToInt32 , ToByte and other methods available---

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstproject
{
    class difference
    {
        static void Main()
        {

            int NUM1, NUM2,  NUM4;
            long  NUM3;
            Console.WriteLine("Enter NUM1");
            NUM1 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter NUM2");
            NUM2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter NUM3");
            NUM3 = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Enter NUM4");
            NUM4 = Convert.ToByte(Console.ReadLine());
            Console.WriteLine(NUM1);
            Console.WriteLine(NUM2);
            Console.WriteLine(NUM3);
            Console.WriteLine(NUM4);

            
        }
    }
}

///What is System in the program. What is Console? What are Write, WriteLine

.System is a namespace which Contains fundamental classes and base classes that define commonly-used value and reference data types, events and event handlers, interfaces, attributes, and processing exceptions.

 Console is a class in the System namespace which is used to represent the standard input, output, and error streams for the console applications.
  
.In C#, to print the data on the console output screen the following method are used – Console.Write() and Console.WriteLine() method. Console is a predefined class of System namespace.
 
.While Write() and WriteLine() both are the Console Class methods.

 Convert is a class in the System namespace which converts a base data type to another base data type.
 
 ReadLine is a method in Console class which reads the next line of characters from the standard input stream.
 
• ToByte is a method in Convert class which converts a specified value to an 8-bit unsigned integer.


The only difference between the Write() and WriteLine() is that Console.Write is used to print data without printing the new line, while Console.WriteLine  is used to print data along with printing the new line.

-------Is it mandatory to have a class in the project---
It is impossible to create a class without having a namespace . But in asp.net we can create a class without having a namespace , in this case asp.net compiler will add a namespace called global under which the classes will be added 

A main method is static since it is available to run when the C# program starts. It is the entry point of the program and runs without even creating an instance of the class.
