using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Study_SelfTest
{
    internal class MyClass
    {
        public string m_name;
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            MyClass myClass = new MyClass();
            myClass.m_name = "가";

            Console.WriteLine(myClass.m_name);
        }
    }
}
