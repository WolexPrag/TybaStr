using System;
using UnityEngine;

﻿namespace TybaStr.Core
{
    [Serializable]
    public class Brain
    {
        [SerializeField] private FractionTask _currentTask;
        [SerializeReference] protected Fraction _fraction;
        [SerializeReference] protected Unit _unit;
        public Brain(Fraction fraction)
        {
            _fraction = fraction;
        }
        public void Bind(Unit unit)
        {
            _unit = unit;
        }
        public void Tick(float deltaTime)
        {
            DoTask(_currentTask, deltaTime);
        }
        public void AssignTask(FractionTask task)
        {
            _currentTask = task;
        }
        private void DoTask(FractionTask task, float deltaTime)
        {
        }
    }
}
