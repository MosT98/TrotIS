using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TrotIS.Shared
{
    public class Address
    {
        public Guid AddressId { get; private set; }
        public string Country { get; private set; }
        public string County { get; private set; }
        public string City { get; private set; }
        public string Street { get; private set; }
        public int Number { get; private set; }
        public string Block { get; private set; }
        public int Floor { get; private set; }
        public string Apartment { get; private set; }
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
    }
}
