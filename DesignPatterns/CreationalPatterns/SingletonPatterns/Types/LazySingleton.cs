using DesignPatterns.CreationalPatterns.SingletonPatterns.Interfaces;

namespace DesignPatterns.CreationalPatterns.SingletonPatterns.Types
{
    public sealed class LazySingleton : ISingleton
    {
        #region Class/Object Information

        private readonly int _objectNumber;
        private readonly string _objectName;
        private const string PatternName = "Lazy Singleton";

        public string GetPatternName()
        {
            return PatternName;
        }

        #endregion Class/Object Information

        private static LazySingleton? instance;

        private LazySingleton()
        {
            _objectNumber++;
            _objectName = $"Instance SN: {_objectNumber}.";
        }

        // This type of using lazy initializer is not thread safe.
        // You can see abnormalities in console output. (Sometimes)
        public static LazySingleton Instance
        {
            get
            {
                if (instance == null)
                    instance = new LazySingleton();
                return instance;
            }
        }

        public string GetName()
        {
            return _objectName;
        }
    }
}