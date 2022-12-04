
namespace DesignPatterns.CreationalPatterns.Singleton
{
    public sealed class Singleton
    {
        private static readonly Singleton Instance = new();
        private readonly int _objectNumber;
        private readonly string _objectName;

        static Singleton()
        {
        }
        private Singleton()
        {
            _objectNumber++;
            _objectName = $"Singleton Object Initialized. Instance Number: {_objectNumber}. ";
        }
        public static Singleton GetObject()
        {
            return Instance;
        }

        public string GetName()
        {
            return _objectName;
        }
    }
}
