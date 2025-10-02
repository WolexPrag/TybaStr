using TybaStr.Core;
using UnityEngine;

public class UnitFactory : Factory<Unit>
{
    [SerializeField] protected ProduceStatus currentProducing;
    [SerializeField] protected Vector3 _spawnPoint;
    private void FixedUpdate()
    {
        Produce(Time.fixedDeltaTime,currentProducing);
    }
    private void Produce(float timeStep,ProduceStatus producing)
    {
        if (producing == null)   
        {
            if (_produceQueue.Count<1)
            {
                return;
            }
            producing = _produceQueue.Peek();
        }
        producing.AddProgress(timeStep);

        if (producing.Progress >= 1)
        {
            Release(producing);
            producing = null;
        }
    }
    private void Release(ProduceStatus producing)
    {
        Unit product = Instantiate(producing.RequestInfo.Product);
        product.transform.position = _spawnPoint;
        NotifyRelease(product);
    }

}
