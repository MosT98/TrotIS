using System;
using System.Collections.Generic;
using System.Text;

namespace TrotIS.Shared
{
    public class Scooter
    {
        public Guid ScooterId { get; private set; }
        public string Brand { get; private set; }
        public string Model { get; private set; }
        public int BatteryLife { get; private set; } //km
        public int AgeLimitMin { get; private set; }
        public int AgeLimitMax { get; private set; }
        public int WeightMax { get; private set; } //kg
        public int SpeedLimit { get; private set; } //km/h
        public int ClimbAngle { get; private set; } //degrees

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

    }
}
