
namespace DesignPatterns.CreationalPatterns.ThreadSafeLazySingleton
{
    public sealed class ThreadSafeLazySingleton
    {
        private static ThreadSafeLazySingleton ThreadSafeLazySingletonObject;
        private readonly int _objectNumber;
        private readonly string _objectName;

        private ThreadSafeLazySingleton()
        {
            _objectNumber++;
            _objectName = $"Instance SN: {_objectNumber}.";
        }

        // This type of using lazy initializer is not thread safe.
        // You can see abnormalities in console output. 
        public static ThreadSafeLazySingleton GetObject()
        {
            if (ThreadSafeLazySingletonObject == null)
                ThreadSafeLazySingletonObject = new ThreadSafeLazySingleton();
            return ThreadSafeLazySingletonObject;
        }

        public string GetName()
        {
            return _objectName;
        }
    }
}
