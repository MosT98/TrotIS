using System;

namespace TrotIS.Shared
{
    public class Scooter
    {
        public Guid ScooterId { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int BatteryLife { get; set; } //km
        public int AgeLimitMin { get; set; }
        public int AgeLimitMax { get; set; }
        public int WeightMax { get; set; } //kg
        public int SpeedLimit { get; set; } //km/h
        public int ClimbAngle { get; set; } //degrees

        public Scooter(string brand, string model, int batteryLife, int ageLimitMin, int ageLimitMax, int weightMax, int speedLimit, int climbAngle)
        {
            ScooterId = Guid.NewGuid();
            Brand = brand;
            Model = model;
            BatteryLife = batteryLife;
            AgeLimitMin = ageLimitMin;
            AgeLimitMax = ageLimitMax;
            WeightMax = weightMax;
            SpeedLimit = speedLimit;
            ClimbAngle = climbAngle;
        }

        public Scooter()
        {
            ScooterId = Guid.NewGuid();
        }
    }
}
