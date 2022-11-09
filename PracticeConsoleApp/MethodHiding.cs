using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeConsoleApp
{
    //base class
    public class MethodHiding
    {
        public string firstname = "hello";
        public string lastname = "hi";

        public void printFullName()
        {
            Console.WriteLine(firstname + " " + lastname);
        }
    }

    public class Class3 : MethodHiding
    {
        public new void printFullName()
        {
            base.printFullName();
            Console.WriteLine();
        }

    }

    public class Class4 : MethodHiding
    {

    }

}
