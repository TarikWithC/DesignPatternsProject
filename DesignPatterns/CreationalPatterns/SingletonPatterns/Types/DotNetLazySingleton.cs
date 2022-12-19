using DesignPatterns.CreationalPatterns.SingletonPatterns.Interfaces;

namespace DesignPatterns.CreationalPatterns.SingletonPatterns.Types
{
    public sealed class DotNetLazySingleton : ISingleton
    {
        #region Class/Object Information

        private readonly int _objectNumber;
        private readonly string _objectName;
        private const string PatternName = ".NET Lazy Singleton";

        public string GetPatternName()
        {
            return PatternName;
        }

        #endregion Class/Object Information

        private static readonly Lazy<DotNetLazySingleton> instance = new(() => new DotNetLazySingleton());

        private DotNetLazySingleton()
        {
            _objectNumber++;
            _objectName = $"Instance SN: {_objectNumber}.";
        }

        //Best practice for thread safe lazy singleton objects using .NET
        public static DotNetLazySingleton Instance => instance.Value;

        public string GetName()
        {
            return _objectName;
        }
    }
}