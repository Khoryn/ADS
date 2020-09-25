using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Singleton
{
    // Not thread - safe

    //public class Singleton <T> where T : class, new()
    //{
    //    private static T instance = null;

    //    public static T Instance
    //    {
    //        get
    //        {
    //            if (instance == null)
    //            {
    //                instance = new T();
    //            }
    //            return instance;
    //        }
    //    }
    //}

    public sealed class Singleton<T> where T: new()
    {
        private static readonly T InstanceHolder = new T();

        static Singleton() { }

        private Singleton() { }

        public static T Instance => InstanceHolder;
    }
}
