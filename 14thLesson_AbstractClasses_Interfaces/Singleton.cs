using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14thLesson_AbstractClasses_Interfaces
{
    public sealed class Singleton
    {
        private static Singleton instance = null;
        private static readonly object threadLocker = new object();

        private Singleton() { }

        public static Singleton Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (threadLocker) 
                    {
                        if(instance == null)
                        {
                            instance = new Singleton();
                        }
                    }
                }
                return instance;
            }
        }
    }
}
