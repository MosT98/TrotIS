using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TrotIS.Shared
{
    public class Address
    {
        public Guid AddressId { get; set; }
        public string Country { get; set; }
        public string County { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public int Number { get; set; }
        public string Block { get; set; }
        public int Floor { get; set; }
        public string Apartment { get; set; }
        //spublic virtual User User { get; set; }

        public Address(string country, string county, string city, string street, int number, string block, int floor, string apartment)
        {
            AddressId = Guid.NewGuid();
            Country = country;
            County = county;
            City = city;
            Street = street;
            Number = number;
            Block = block;
            Floor = floor;
            Apartment = apartment;
        }

        public Address()
        {
            AddressId = Guid.NewGuid();
        }
    }
}
