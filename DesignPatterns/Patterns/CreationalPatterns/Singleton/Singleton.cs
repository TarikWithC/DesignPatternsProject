using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPatterns.Singleton
{
    public class Singleton
    {
        private static readonly Singleton SingletonObject = new();
        private static int _objectNumber = 0;
        private static string? _objectName;

        private Singleton()
        {
            _objectNumber++;
            _objectName = $"{_objectNumber}. Singleton Object Initialized";
        }
        public static Singleton GetObject()
        {
            return SingletonObject;
        }

        public string GetName()
        {
            return _objectName;
        }
    }
}
