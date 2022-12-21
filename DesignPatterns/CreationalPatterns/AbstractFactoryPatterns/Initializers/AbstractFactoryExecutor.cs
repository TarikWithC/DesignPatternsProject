﻿using Core.Interfaces;
using Core.Utils;
using DesignPatterns.Base;

namespace DesignPatterns.CreationalPatterns.AbstractFactoryPatterns.Initializers
{
    public sealed class AbstractFactoryExecutor : BaseExecutor, IPatternExecutor
    {
        #region Class/Object Information

        private const string PatternName = "Abstract Factory";

        public string GetPatternName()
        {
            return PatternName;
        }

        #endregion Class/Object Information

        private readonly AbstractFactoryTester _abstractFactoryTest = new();

        public void Execute()
        {
            GenericExecutor.ExecuteStandardTest(tester: _abstractFactoryTest, patternName: PatternName);
        }
    }
}