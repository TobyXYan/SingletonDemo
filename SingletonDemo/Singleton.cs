using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace SingletonDemo
{
    public class Singleton
    {
        private static readonly Lazy<Singleton> _instance = new Lazy<Singleton>();
        public static Singleton Instance 
        {
            get
            {
                return _instance.Value;
            }
        }
        private Singleton() { }


        //private static readonly Object lockObj = new object();

        //         if (null == Instance)
        //                {
        //                    lock (lockObj)
        //                    {

        //                        _instance = new Singleton();
        //    }
        //}

        //private static readonly Singleton _instance = new Singleton();

        //public static Singleton Instance
        //{
        //    get => _instance;
        //}


        public void PrintDetails(string strMsg)
        {
            Console.WriteLine(strMsg);
        }
    }
}
