namespace TybaStr.Core
{
    public class Brain
    {
        protected Fraction _fraction;
        protected FractionTask? _task;
        protected Unit _unit;
        public Brain(Fraction fraction)
        {
            _fraction = fraction;
        }
        public void Bind(Unit unit)
        {
            _unit = unit;
        }
    }
}
