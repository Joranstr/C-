namespace VannOppgave
{
    public class Water
    {
        public int Temperature { get; private set; }
        public int Amount { get; private set; }

        public WaterState State
        {
            get
            {
                if (Temperature < 0) return WaterState.Ice;
                else if (Temperature > 0 && Temperature < 100) return WaterState.Fluid;
                return WaterState.Gas;
            }
        }

        public Water(int amount, int temperature)
        {
            Temperature = temperature;
            Amount = amount;
        }
    }
}