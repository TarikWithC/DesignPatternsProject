using DesignPatterns.CreationalPatterns.SingletonPatterns.Interfaces;

namespace DesignPatterns.CreationalPatterns.SingletonPatterns.Types
{
    public sealed class Singleton : ISingleton
    {
        #region Class/Object Information

        private readonly int _objectNumber;
        private readonly string _objectName;
        private const string PatternName = "Singleton";

        public string GetPatternName()
        {
            return PatternName;
        }

        #endregion Class/Object Information

        private static readonly Singleton instance = new();

        static Singleton()
        {
        }

        private Singleton()
        {
            _objectNumber++;
            _objectName = $"Singleton Object Initialized. Instance Number: {_objectNumber}. ";
        }

        public static Singleton Instance
        {
            get
            {
                return instance;
            }
        }

        public string GetName()
        {
            return _objectName;
        }
    }
}