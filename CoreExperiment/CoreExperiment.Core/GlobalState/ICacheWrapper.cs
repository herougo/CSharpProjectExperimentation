using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreExperiment.Core.GlobalState
{
    internal interface ICacheWrapper
    {
        public object? Get(string key);

        public void Set(string key, object value);
    }
}
