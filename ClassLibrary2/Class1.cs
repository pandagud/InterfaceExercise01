using System;
using System.Diagnostics;
using System.Reflection;

namespace ClassLibrary2
{
    public class Class1
    {
    }

    public interface IDoThings
    {
        void DoNothing();
        int DoSomething(int number);
        string DoSomethingElse(string input);

    }

    public class DoHickey:IDoThings
    {
       
        public void DoNothing()
        {
            Console.WriteLine("Current Class"+this.GetType().Name+" and the methode is" +System.Reflection.MethodBase.GetCurrentMethod().Name);
        }

        public int DoSomething(int number)
        {
            Console.WriteLine("Current Class" + this.GetType().Name + " and the methode is" + System.Reflection.MethodBase.GetCurrentMethod().Name + number);
            return number;
        }

        public string DoSomethingElse(string input)
        {
            Console.WriteLine("Current Class" + this.GetType().Name + " and the methode is" + System.Reflection.MethodBase.GetCurrentMethod().Name+input);
            return input;
        }
    }

    public class DoDickey:IDoThings
    {
        public void DoNothing()
        {
            Console.WriteLine("DoNothing");
        }

        public int DoSomething(int number)
        {
            Console.WriteLine("Number"+number);
            return number;
        }

        public string DoSomethingElse(string input)
        {
            Console.WriteLine("Input"+input);
            return input;
        }
    }
}
