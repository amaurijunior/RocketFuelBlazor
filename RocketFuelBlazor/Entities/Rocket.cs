namespace RocketFuelBlazor.Entities
{
    public class Rocket
    {

        public Rocket()
        {
        }

        public void update(double fuelMass, int fuelTanks, int oxidizerTanks, bool isReacheble)
        {
            FuelMass = fuelMass;
            FuelTanks = fuelTanks;
            OxidizerTanks = oxidizerTanks;
            IsReacheble = isReacheble;
        }

        public double FuelMass { get; set; }
        public int FuelTanks { get; set; }
        public int OxidizerTanks { get; set; }
        public bool IsReacheble { get; set; }
    }
}
