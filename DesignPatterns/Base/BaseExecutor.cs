using Core.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Base
{
    public class BaseExecutor
    {
        protected readonly GenericExecutor GenericExecutor = new();
    }
}
