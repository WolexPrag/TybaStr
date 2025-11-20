
namespace TybaStr.Core.Recources
{
    public struct Recource
    { 
        public Recource(IResourceType type,int amout)
        {
            Type = type;
            Amout = amout;
        }
        public IResourceType Type { get; private set; }
        public int Amout { get; private set; }
    }
}
