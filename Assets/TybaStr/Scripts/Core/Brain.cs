namespace TybaStr.Core
{
    [Serializable]
    public class Brain
    {
        [SerializeField] private FractionTask _task;
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
        public void AssignTask(FractionTask task)
        {
            _task = task;
        }
        private void DoTask(FractionTask task, float deltaTime)
        {
        }
    }
}
