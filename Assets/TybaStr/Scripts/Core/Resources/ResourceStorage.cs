using UnityEngine;
using TybaStr.Core.Resources;
using System.Collections.Generic;


public class ResourceStorage
{
    [SerializeField] private List<Resource> _resources = new();

    public void SetResources(List<Resource> resources)
    {
        _resources = new List<Resource>(resources);
    }

    private bool TryFindIndex(IResourceType type, out int output)
    {
        output = _resources.FindIndex(f => f.Type == type);
        return output != -1;
    }
}
