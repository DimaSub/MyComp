using System;
using System.Collections.Generic;

namespace MyComp
{
    public class Address
    {
        public Address(int id, string city, string street, int building)
        {
            this.id = id;
            this.city = city;
            this.street = street;
            this.building = building;
        }

        private int id;
        private string city;
        private string street;
        private int building;

        public int Id { get => id; set => id = value; }
        public string City { get => city; set => city = value; }
        public string Street { get => street; set => street = value; }
        public int Building { get => building; set => building = value; }

        public override string ToString()
        {
            return "City - " + city +
                   "\nStreet - " + street +
                   "\nBuilding number - " + building;
        }
    }
}
