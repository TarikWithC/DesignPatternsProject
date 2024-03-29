﻿using DesignPatterns.CreationalPatterns.SingletonPatterns.Abstractions;

namespace DesignPatterns.CreationalPatterns.SingletonPatterns.Types
{
    public sealed class NestedLazySingleton : ISingleton
    {
        #region Class/Object Information

        private readonly int _objectNumber;
        private readonly string _objectName;
        private const string PatternName = "Nested Lazy Singleton";

        public string GetPatternName()
        {
            return PatternName;
        }

        #endregion Class/Object Information

        public static NestedLazySingleton Instance => Nested.instance;

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