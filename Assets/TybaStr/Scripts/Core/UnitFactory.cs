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
    [SerializeField] private Transform posExit;

    #region TEST
#if UNITY_EDITOR
    [Serializable]
    private struct TEST_DATA
    {
        public int IdOptions;
    }
    [SerializeField] TEST_DATA TEST_DATA_BIND1;

    [ContextMenu("Call SendRequest")]
    private void TEST_SendRequest()
    {
        SendRequest(TEST_DATA_BIND1.IdOptions);
    }
#endif
    #endregion

    public void SendRequest(int id)
    {
        _produceInfo.Add(new Produce(_produceOptions[id]));
    }
    private void Producing()
    {
        Produce produceInfo =  _produceInfo[0];
        if (_produceInfo[0].timeConstructed>produceInfo.requestInfo.TimeConstruct)
        {
            ExitUnit(0);
            return;
        }
        produceInfo.timeConstructed += Time.deltaTime;
    }
    private bool TryProduce()
    {
        if (_produceInfo.Count < 1)
        {
            return false;
        }
        return true;
    }
    private void ExitUnit(int id)
    {
        Unit unit = Instantiate(_produceInfo[id].requestInfo.Unit);
        unit.transform.position = posExit.position;
        _produceInfo.RemoveAt(id);
        OnRelease?.Invoke(unit);
    }
    private void Update()
    {
        if (TryProduce())
        {
            Producing();
        }
    }
}

