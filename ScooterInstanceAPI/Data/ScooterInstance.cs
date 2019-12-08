using System;
using System.Runtime.CompilerServices;
using TrotIS.Shared;

namespace ScooterInstanceAPI.Data
{
    public class ScooterInstance
    {
        public Guid ScooterInstanceId { get; set; }

        public int ScooterAutonomy { get; set; } //km

        public Scooter Scooter { get; set; }

        public ScooterInstance()
        {
            ScooterInstanceId = Guid.NewGuid();
        }

        public static ScooterInstance Create(int scooterAutonomy, Scooter scooter)
        {
            return new ScooterInstance()
            {
                ScooterAutonomy = scooterAutonomy,
                Scooter = scooter
            };
        }

        //TODO: scuter, autonomie, id + relatiile cu scuter in oldContext, maybe ala de locatie sau scooter

    }
}
