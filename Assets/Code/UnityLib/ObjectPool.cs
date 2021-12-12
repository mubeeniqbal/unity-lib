using System;

namespace UnityLib.Pool
{
    public struct PooledObject<T> : IDisposable where T : class
    {
        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }

    public interface IObjectPool<T> where T : class
    {
        int CountInactive { get; }

        void Clear();
        T Get();
        PooledObject<T> Get(out T v);
        void Release(T element);
    }

    //
    // Summary:
    //     A stack based Pool.IObjectPool_1.
    public class ObjectPool<T> : IDisposable, IObjectPool<T> where T : class
    {
        public ObjectPool(Func<T> createFunc, Action<T> actionOnGet = null, Action<T> actionOnRelease = null, Action<T> actionOnDestroy = null, bool collectionCheck = true, int defaultCapacity = 10, int maxSize = 10000)
        { }

        public int CountAll { get; }
        public int CountActive { get; }
        public int CountInactive { get; }

        public void Clear() { }
        public void Dispose() { }
        public T Get()
        {
            return default(T);
        }
        
        public PooledObject<T> Get(out T v)
        {
            v = default(T);
            return default(PooledObject<T>);
        }

        public void Release(T element) { }
    }
}