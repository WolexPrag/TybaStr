
using System;
using System.Collections.Generic;
using UnityEngine;

public class UnitFactory : Building
{
    #region Struct UnitProduce
    [Serializable]
    public struct UnitProduceRequestInfo
    {
        [SerializeField] private float Price;
        [SerializeField] private Unit unit;
    }
    [Serializable]
    private struct UnitProduceInfo
    {
        public UnitProduceInfo(UnitProduceRequestInfo requestInfo)
        {
            this.requestInfo = requestInfo;
        }
        [SerializeField] public UnitProduceRequestInfo requestInfo;
    }
    #endregion

    public event Action<Unit> OnRelease;
    [SerializeField] private List<UnitProduceRequestInfo> _produceOptions;
    public IReadOnlyList<UnitProduceRequestInfo> ProduceOptions => _produceOptions;
    [SerializeField] private List<UnitProduceInfo> _produceInfo;


    public void SendRequest(UnitProduceRequestInfo produceInfo)
    {
        _produceInfo.Add(new UnitProduceInfo());
    }
}

