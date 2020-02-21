using System;
using VannOppgave2._0;

namespace VannOppgave
{
    public class Water
    {
        public double Temperature { get; private set; }
        public int Amount { get; private set; }
        public double? ProportionFirstState { get; private set; }

        private const double CaloriesMeltIcePerGram = 80;
        private const double CaloriesEvaporateWaterPerGram = 600;

        public WaterState State { get; private set; }

        public Water(int amount, double temperature, double? proportion = null)
        {
            Temperature = temperature;
            ProportionFirstState = proportion.Value;
            Amount = amount;
            State = temperature <= 0 ? WaterState.Ice : temperature > 100 ? WaterState.Gas : WaterState.Fluid;

            if (Temperature != 100 && Temperature != 0) return;

            if (proportion == null) throw new ArgumentException("When temperature is 0 or 100, you must provide a value for proportion");

            if (ProportionFirstState==1)return;
            if (ProportionFirstState == 0) State = temperature == 0 ? WaterState.Fluid : WaterState.Gas;
            else State = temperature == 0 ? WaterState.IceAndFluid : WaterState.FluidAndGas;

            //if ((temperature == 0.0 || temperature == 100) && part == null) throw new ArgumentException("When temperature is 0 or 100, you must provide a value for proportion");
        }

        public void AddEnergy(double calories)
        {
            if (Temperature < 0) calories = HeatTo(calories, 0);
            if (Temperature == 0 && State != WaterState.Fluid) calories = DoStateChangeAsMuchAsPossible(calories);
            if (Temperature < 100) calories = HeatTo(calories, 100);
            if (Temperature == 100 && State != WaterState.Gas) calories = DoStateChangeAsMuchAsPossible(calories);
            HeatMax(calories);

        }

        private double DoStateChangeAsMuchAsPossible(double calories)
        {
            if (calories <= 0) return 0;
            if (Temperature != 0 && Temperature != 100)
                throw new ArgumentException("Cannot do state change when temperature is not 0 or 100.");

            var isMeltingIce = Temperature == 0;
            var stateChangeENvergyPerGram = isMeltingIce ? CaloriesMeltIcePerGram : CaloriesEvaporateWaterPerGram;
            var caloriesNeeded = stateChangeENvergyPerGram * Amount;

            if (calories >= caloriesNeeded)
            {
                State = isMeltingIce ? WaterState.Fluid : WaterState.Gas;
            }

            ProportionFirstState = 1 - calories / caloriesNeeded;
            State = isMeltingIce ? WaterState.IceAndFluid : WaterState.FluidAndGas;
            return 0;

        }

        private double HeatTo(double calories, int temprature)
        {
            if (calories <= 0) return 0;
            var caloriesForHeatting = (temprature - Temperature) * Amount;
            if (!(calories >= caloriesForHeatting)) return HeatMax(calories);
            Temperature = temprature;
            return calories - caloriesForHeatting;
        }

        private double HeatMax(double calories)
        {
            if (calories <= 0) return 0;
            var tempratureChange = calories / Amount;
            Temperature += tempratureChange;
            return 0;

        }
    }
}