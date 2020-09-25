using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Singleton
{
    public class Singleton <T> 
    {
        private static Singleton<T> instance = null;

        public static Singleton<T> Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Singleton<T>();
                }
                return instance;
            }
        }
    }
}
