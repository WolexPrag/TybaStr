using System;
using System.Collections.Generic;
using UnityEngine;
namespace TybaStr.Core
{
    [Serializable]
    public abstract class Factory<T> : Building
    {
        #region Struct Request and Produce
        [Serializable]
        public class Request
        {
            public Request(T product)
            {
                _product = product;
            }
            [SerializeField] private T _product;
            public T Product => _product;

            [SerializeField] private float _timeConstruction;
            public float TimeConstruction => _timeConstruction;
        }

        [Serializable]
        protected class ProduceStatus
        {
            public ProduceStatus(Request request)
            {
                _request = request;
                _percentProgress = 0;
            }
            [SerializeField] private float _percentProgress;
            public float Progress => _percentProgress;

            [SerializeField] private Request _request;
            public Request Request => _request;
            public void AddProgress(float time)
            {
                _percentProgress += time / _request.TimeConstruction ;
            }
        }
        #endregion

        public event Action<T> OnRelease;
        [SerializeField] private List<Request> _produceOptions;
        public IReadOnlyList<Request> ProduceOptions => _produceOptions.AsReadOnly();
        [SerializeField] private Queue<ProduceStatus> _produceQueue;

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
        public virtual void SendRequest(int id)
        {
            _produceQueue.Enqueue(new ProduceStatus(_produceOptions[id]));
        }
        protected void NotifyRelease(T releaseProduct)
        {
            OnRelease?.Invoke(releaseProduct);
        }
    }

}