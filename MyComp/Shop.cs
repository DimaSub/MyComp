using System;
using System.Collections.Generic;

namespace MyComp
{
    public class Shop
    {
        public Shop(int id, string name, Address address, int area, Manager manager, List<Computer> computer)
        {
            this.id = id;
            this.name = name;
            this.address = address;
            this.area = area;
            this.manager = manager;
            this.computer = computer;
        }

        private int id;
        private string name;
        private Address address;
        private int area;
        private Manager manager;
        private List<Computer> computer;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public Address Address { get => address; set => address = value; }
        public int Area { get => area; set => area = value; }
        public Manager Manager { get => manager; set => manager = value; }
        public List<Computer> Computer { get => computer; set => computer = value; }
        
        public override string ToString()
        {
            return "Store ID: " + id +
                   "\nBranch name: " + name +
                   "\nAddress: \n" + address +
                   "\nArea size: " + area +
                   "\nBranch manager: \n" + manager;
        }
    }
}
