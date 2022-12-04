
namespace DesignPatterns.CreationalPatterns.SingletonPatterns.DotNetLazySingleton
{
    public sealed class DotNetLazySingleton
    {
        private static readonly Lazy<DotNetLazySingleton> Instance = new(() => new DotNetLazySingleton());
        private readonly int _objectNumber;
        private readonly string _objectName;

        private DotNetLazySingleton()
        {
            _objectNumber++;
            _objectName = $"Instance SN: {_objectNumber}.";
        }

        //Best practice for thread safe lazy singleton objects using .NET
        public static DotNetLazySingleton GetObject()
        {
            return Instance.Value;
        }

        public string GetName()
        {
            return _objectName;
        }
    }
}
