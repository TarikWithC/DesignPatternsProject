
namespace DesignPatterns.CreationalPatterns.LazySingleton
{
    public class LazySingleton
    {
        private static LazySingleton LazySingletonObject;
        private readonly int _objectNumber;
        private readonly string _objectName;

        private LazySingleton()
        {
            _objectNumber++;
            _objectName = $"Instance SN: {_objectNumber}.";
        }
        public static LazySingleton GetObject()
        {
            if (LazySingletonObject == null)
                LazySingletonObject = new LazySingleton();
            return LazySingletonObject;
        }

        public string GetName()
        {
            return _objectName;
        }
    }
}
