using MediatR;
using ScooterInstanceAPI.Data;

namespace ScooterInstanceAPI.DTOs
{
    public class CreateScooter : IRequest<Scooter>
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int BatteryLife { get; set; } //km
        public int AgeLimitMin { get; set; }
        public int AgeLimitMax { get; set; }
        public int WeightMax { get; set; } //kg
        public int SpeedLimit { get; set; } //km/h
        public int ClimbAngle { get; set; } //degree
        public string ImgName { get; set; }

    }
}
