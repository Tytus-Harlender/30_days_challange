using System;
using System.Collections.Generic;
using System.Text;

namespace Day9
{
    class SingletonClass
    {
        private static object _connection;

        public SingletonClass()
        {
        
        }

        public static object GiveMeConnection()
        {
            if (_connection == null)
            {
                SingletonClass _connection = new SingletonClass();
            }

            return _connection;
        }

    }
}
