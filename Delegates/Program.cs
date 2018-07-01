﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    class Program
    {
        
        static void Main(string[] args)
        {
           MyClass obj = new MyClass();
            obj.LongRunning(Callback);
        }

        static void SomeMethod()
        {
            Console.WriteLine("Method called");
        }

        static void Callback(int i)
        {
            Console.WriteLine(i);
        }
    }

    public class MyClass
    {
        public delegate void CallBack(int i);
        public void LongRunning(CallBack obj)
        {
            for (int i=0; i < 10000; i++)
            {
                obj(i);
            }
        }
    }
}
