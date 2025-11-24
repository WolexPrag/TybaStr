using UnityEngine;

namespace TybaStr.Core.Recources
{
	[CreateAssetMenu(menuName = "Resource/New")]
	public class ResourceTypeSO : ScriptableObject , IResourceType
	{
		public string Id;
		public Sprite Icon;

        public string Name => Id;
    }
}
