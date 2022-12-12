
using DesignPatterns.CreationalPatterns.SingletonPatterns.Interfaces;

namespace DesignPatterns.CreationalPatterns.SingletonPatterns.Types
{
    public sealed class ThreadSafeLazySingleton: ISingleton
    {
        #region Class/Object Information
        private readonly int _objectNumber;
        private readonly string _objectName;
        private const string PatternName = "Thread Safe Lazy Singleton";
        public string GetPatternName()
        {
            return PatternName;
        }
        #endregion

        private static readonly object Padlock = new();
        private static ThreadSafeLazySingleton instance;
        private ThreadSafeLazySingleton()
        {
            _objectNumber++;
            _objectName = $"Instance SN: {_objectNumber}.";
        }

        // Double check locking for being thread safe and higher performance.
        public static ThreadSafeLazySingleton Instance
        {
            get
            {
                // Using "double check" to improve performance via escaping unnecessarily locked null checks.
                if (instance == null)
                {
                    // Using "locking" to be thread safe.
                    lock (Padlock)
                    {
                        if (instance == null)
                        {
                            instance = new ThreadSafeLazySingleton();
                        }
                    }
                }

                return instance;
            }
            
        }

        public string GetName()
        {
            return _objectName;
        }
    }
}
