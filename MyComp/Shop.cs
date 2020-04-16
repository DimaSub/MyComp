using System;
using System.Collections.Generic;

namespace MyComp
{
    public class Shop
    {

        public Shop(int id, string name, List<Address> address, int area, List<Manager> manager)
        {
            this.id = id;
            this.name = name;
            this.address = address;
            this.area = area;
            this.manager = manager;
        }

        private int id;
        private string name;
        private List<Address> address;
        private int area;
        private List<Manager> manager;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public List<Address> Address { get => address; set => address = value; }
        public int Area { get => area; set => area = value; }
        public List<Manager> Manager { get => manager; set => manager = value; }

        public override string ToString()
        {
            return "Store ID: " + id +
                   "\nBranch name: " + name +
                   "\nAddress: \n" + address[id] +
                   "\nArea size: " + area +
                   "\nManager: \n" + manager[id];
        }
    }
}
