
namespace DesignPatterns.CreationalPatterns.ThreadSafeLazySingleton
{
    public sealed class ThreadSafeLazySingleton
    {
        private static ThreadSafeLazySingleton Instance;
        private static readonly object Padlock = new ();
        private readonly int _objectNumber;
        private readonly string _objectName;

        private ThreadSafeLazySingleton()
        {
            _objectNumber++;
            _objectName = $"Instance SN: {_objectNumber}.";
        }

        // Double check locking for being thread safe and higher performance.
        public static ThreadSafeLazySingleton GetObject()
        {
            // Using "double check" to improve performance via escaping unnecessarily locked null checks.
            if (Instance == null)
            {
                // Using "locking" to be thread safe.
                lock (Padlock)
                {
                    if (Instance == null)
                        Instance = new ThreadSafeLazySingleton();
                }
            }
            
            return Instance;
        }

        public string GetName()
        {
            return _objectName;
        }
    }
}
