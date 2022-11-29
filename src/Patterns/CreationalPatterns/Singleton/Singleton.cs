
namespace CreationalPatterns.Singleton
{
    public class Singleton
    {
        private static readonly Singleton SingletonObject = new();
        private static int _objectNumber = 0;
        private static string _objectName = string.Empty;

        private Singleton()
        {
            _objectNumber++;
            _objectName = $"{_objectNumber}. Singleton Object Initialized";
        }
        public static Singleton GetObject()
        {
            return SingletonObject;
        }

        public static string GetName()
        {
            return _objectName;
        }
    }
}
