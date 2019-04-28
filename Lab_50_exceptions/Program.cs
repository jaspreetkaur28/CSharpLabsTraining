using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_50_exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            try { } //something can go wrong here
            catch (Exception e)//process the 'exception' ie 'handle it
            {
                Console.WriteLine(e); //(also write e.Data or E.Message) 
                                      //  e.Message shows a nice error for user. 
                throw; //just shows the exception with 'unhandled exception'
            }
            finally { }//always do this code regardless if exception or not
           

            //EXAMPLE

            //Divide by zero
            int x = 10, y = 0;
            try
            {
                int z = x / y;//cannot divide by 0 so problem (unhandled Exception)
            }
            catch (DivideByZeroException ed) // Catch every exception of all types! So lets change it to something specific
            {
                Console.WriteLine("Error - Cannot Divide by zero! ");
                Console.WriteLine(ed.Message); //Nice message
                System.IO.File.WriteAllText("Error Log", "major mulfunction" + DateTime.Now);// tells us there is a error
            }
            catch (Exception e) 
            {
                Console.WriteLine("Oops! Snap! Something went wrong!");
                Console.WriteLine(e);
            }
          
            finally
            {
                Console.WriteLine("But program still works!");
            }
        }
    }
}
