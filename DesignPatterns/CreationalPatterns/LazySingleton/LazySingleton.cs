
namespace DesignPatterns.CreationalPatterns.LazySingleton
{
    public sealed class LazySingleton
    {
        private static LazySingleton? Instance;
        private readonly int _objectNumber;
        private readonly string _objectName;

        private LazySingleton()
        {
            _objectNumber++;
            _objectName = $"Instance SN: {_objectNumber}.";
        }

        // This type of using lazy initializer is not thread safe.
        // You can see abnormalities in console output. (Sometimes)
        public static LazySingleton GetObject()
        {
            if (Instance == null)
                Instance = new LazySingleton();
            return Instance;
        }

        public string GetName()
        {
            return _objectName;
        }
    }
}
