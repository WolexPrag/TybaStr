
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
    }
}
