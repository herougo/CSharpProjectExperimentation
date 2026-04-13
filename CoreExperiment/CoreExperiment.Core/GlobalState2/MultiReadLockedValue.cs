using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CoreExperiment.Core.GlobalState2
{
    internal class MultiReadLockValue<T> : IDisposable
    {
        // Represents a lock that is used to manage access to a resource, allowing multiple
        // threads for reading or exclusive access for writing.
        private readonly ReaderWriterLockSlim _lock = new ReaderWriterLockSlim(LockRecursionPolicy.NoRecursion);
        private T _value;

        public MultiReadLockValue(T value) { _value = value; }

        public T Get()
        {
            _lock.EnterReadLock();
            try
            {
                return _value;
            }
            finally
            {
                _lock.ExitReadLock();
            }
        }

        public void Set(T value)
        {
            _lock.EnterWriteLock();
            try
            {
                _value = value;
            }
            finally
            {
                _lock.ExitWriteLock();
            }
        }

        public void Dispose()
        {
            _lock.Dispose();
        }
    }
}
