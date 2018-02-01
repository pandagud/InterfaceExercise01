using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary2;

namespace InterfaceExercise01
{
    class DoStuff
    {
        static void Main(string[] args)
        {
           
            
            Console.WriteLine("Want a DoHicky press 1 or DoDickey press 2 ????");
            string inputfromuser = Console.ReadLine();
            if (inputfromuser == "1")
            {
               IDoThings myStuff = new DoHickey();
                myStuff.DoNothing();

            }
            else if(inputfromuser == "2")
            {
                IDoThings myStuff = new DoDickey();
                myStuff.DoNothing();
            }    
            else
            {
                Console.WriteLine("You wrote something else then 1 or 2? Stupid.. ");
            }
            Console.ReadLine();
        }
    }
}
