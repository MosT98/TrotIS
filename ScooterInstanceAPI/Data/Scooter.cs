﻿using System;
using System.Collections.Generic;

namespace ScooterInstanceAPI.Data
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
        public int ClimbAngle { get; set; } //degree
        public string ImgName { get; set; }

        //public ICollection<ScooterInstance> ScooterInstances { get; set; }

        public Scooter()
        {
            ScooterId = Guid.NewGuid();
        }

        public static Scooter Create(string brand, string model, int batterylife, int agelimitmin, int agelimitmax, int weightmax, int speedlimit, int climbangle, string imgName)
        {
            return new Scooter
            {
                ScooterId = Guid.NewGuid(),
                //ScooterInstances = new List<ScooterInstance>(),
                Brand = brand,
                Model = model,
                BatteryLife = batterylife,
                AgeLimitMin = agelimitmin,
                AgeLimitMax = agelimitmax,
                WeightMax = weightmax,
                SpeedLimit = speedlimit,
                ClimbAngle = climbangle,
                ImgName = imgName,
            };
        }
    }
}