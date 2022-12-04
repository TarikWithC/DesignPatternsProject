
namespace DesignPatterns.CreationalPatterns.SingletonPatterns.NestedLazySingleton
{
    public sealed class NestedLazySingleton
    {
        public static NestedLazySingleton Instance => Nested.instance;
        private readonly int _objectNumber;
        private readonly string _objectName;

        private NestedLazySingleton()
        {
            _objectNumber++;
            _objectName = $"Instance SN: {_objectNumber}.";
        }

        private class Nested
        {
            static Nested()
            {
            }

            internal static readonly NestedLazySingleton instance = new();
        }

        public string GetName()
        {
            return _objectName;
        }
    }
}
