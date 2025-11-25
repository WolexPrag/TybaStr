
using System;
using TybaStr.Core.Resources;

namespace TybaStr.Core.Recources
{
    public struct Resource
    {
        public Resource(IResourceType type, int amount)
        {
            Type = type;
            Amount = amount;
        }
        public IResourceType Type { get; private set; }
        public int Amount { get; private set; }
        public bool CanAdd(int value)
        {
            return value >= 0;
        }
        public bool CanTake(int value)
        {
            return value > 0 && value <= Amount;
        }
        public void Add(int value)
        {
            if (!CanAdd(value))
            {
                throw new Exception($"Can`t {nameof(Add)} value to {nameof(Resource)}.{nameof(Amount)}");
            }
            Amount += value;
        }
        public int Take(int value)
        {
            if (!CanTake(value))
            {
                throw new Exception($"Can`t {nameof(Take)} value from {nameof(Resource)}.{nameof(Amount)}");
            }
            Amount -= value;
            return value;
        }
    }
}
