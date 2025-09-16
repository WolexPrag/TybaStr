
using System;
using System.Collections.Generic;
using UnityEngine;

public class UnitFactory : Building
{
    #region Struct UnitProduce
    [Serializable]
    public struct Request
    {
        //TODO: private Factory factory; witch have self method create unit
        [SerializeField] private float _price;
        [SerializeField] private float _timeConstruct;
        [SerializeField] private Unit _unit;

        public float Price => _price;
        public float TimeConstruct => _timeConstruct;
        public Unit Unit => _unit;
    }
    [Serializable]
    private class Produce
    {
        public Produce(Request request)
        {
            this.requestInfo = request;
            timeConstructed = 0f;
        }
        [SerializeField] public float timeConstructed;
        [SerializeField] public Request requestInfo;
    }
    #endregion

    public event Action<Unit> OnRelease;
    [SerializeField] private List<Request> _produceOptions;
    public IReadOnlyList<Request> ProduceOptions => _produceOptions;
    [SerializeField] private List<Produce> _produceInfo;


    public void SendRequest(UnitProduceRequestInfo produceInfo)
    {
        _produceInfo.Add(new UnitProduceInfo());
    }
}

