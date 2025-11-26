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
    public bool TryAdd(Resource resource)
    {
        if (TryFindIndex(resource.Type, out int i))
        {
            _resources[i].Add(resource.Amount);
        }
        else
        {
            _resources.Add(resource);
        }
        return true;
    }
    public bool TryTake(in Resource request)
    {
        if (TryFindIndex(request.Type, out int i))
        {
            if (_resources[i].CanTake(request.Amount))
            {
                _resources[i].Take(request.Amount);
                if (_resources[i].Amount == 0)
                {
                    _resources.RemoveAt(i);
                }
                return true;
            }
        }
        return false;
    }
}
