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
        public string City { get; set; }
        public string Street { get; set; }
        public int Number { get; set; }


        public static Address Create(string country, string city, string street, int number)
        {
            return new Address()
            {
                AddressId = Guid.NewGuid(),
                Country = country,
                City = city,
                Street = street,
                Number = number
            };
        }

        public Address()
        {
            AddressId = Guid.NewGuid();
        }

        public void Update(string country, string city, string street, int number)
        {
            Country = country;
            City = city;
            Street = street;
            Number = number;
        }
    }
}
