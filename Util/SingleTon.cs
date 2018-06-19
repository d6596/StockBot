
using System;
using System.Reflection;

namespace StockBot.Util
{
    public class SingleTon<T> where T : class
    {
        private static object _synobj = new object();
        private static volatile T _instance = null;

        public static T GetInstance
        {
            get
            {
                if (_instance == null)  CreateInstance();
                return _instance;
            }
        }

        private static void CreateInstance()
        {

        }
    }

}

