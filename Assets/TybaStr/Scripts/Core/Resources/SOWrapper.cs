
using UnityEngine;

namespace TybaStr.Core.Resources
{
    [CreateAssetMenu(menuName = "Resource/Wrapper/SOWrapper")]
    public class SOWrapper : Wrapper
    {
        [SerializeReference] private ResourceTypeSO _type;
        [SerializeField] private int _amount;
        public SOWrapper(ResourceTypeSO type)
        {
            this._type = type;
        }
        public string Name => _type.Id;

        public override IResourceType Type => _type;

        public override int Amount => _amount;
    }
}
