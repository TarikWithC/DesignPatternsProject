
namespace DesignPatterns.CreationalPatterns.Singleton
{
    public class Singleton
    {
        private static readonly Singleton SingletonObject = new();
        private readonly int _objectNumber;
        private readonly string _objectName;

        private Singleton()
        {
            _objectNumber++;
            _objectName = $"Singleton Object Initialized. Instance Number: {_objectNumber}. ";
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
