using TybaStr.Core;
using UnityEngine;

public class UnitFactory : Factory<Unit>
{
    [SerializeReference] protected ProduceStatus currentProducing;
    [SerializeField] protected Transform _spawnPoint;
    private void FixedUpdate()
    {
        Produce(Time.fixedDeltaTime, ref currentProducing);
    }
    private void Produce(float timeStep,ref ProduceStatus producing)
    {
        if (producing == null)
            if (!TryPeekProduce(out producing))
                return;
        producing.AddProgress(timeStep);

        if (producing.Progress >= 1)
        {
            Release(producing);
            producing = null;
        }
    }
    private void Release(ProduceStatus producing)
    {
        Unit product = Instantiate(producing.Request.Product);
        product.transform.position =  _spawnPoint.position;
        product.Brain = Belong.GetBrain(product);
        NotifyRelease(product);
    }

}
