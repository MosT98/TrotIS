using System;

namespace Client.Blazor.Data
{
	public class Location
    {
		public Guid LocationID { get; set; }
		public decimal Longitude { get; set; }
		public decimal Latitude { get; set; }
		public string Comment { get; set; }

		public Location()
		{
			LocationID = Guid.NewGuid();
		}

		public static Location Create(decimal longitude, decimal latitude, string comment)
		{
			return new Location
			{
				LocationID = Guid.NewGuid(),
				Longitude = longitude,
				Latitude = latitude,
				Comment = comment
			};
		}
	}
}
