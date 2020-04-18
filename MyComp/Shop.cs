using System;
using System.Collections.Generic;

namespace MyComp
{
    public class Shop
    {
        public Shop(int id, string name, List<Address> address, int area, List<Manager> manager, int price, List<Computer> computer)
        {
            this.id = id;
            this.name = name;
            this.address = address;
            this.area = area;
            this.manager = manager;
            this.price = price;
            this.computer = computer;
        }

        private int id;
        private string name;
        private List<Address> address;
        private int area;
        private List<Manager> manager;
        private int price;
        private List<Computer> computer;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public List<Address> Address { get => address; set => address = value; }
        public int Area { get => area; set => area = value; }
        public List<Manager> Manager { get => manager; set => manager = value; }
        public int Price { get => price; set => price = value; }
        public List<Computer> Computer { get => computer; set => computer = value; }
        
        public override string ToString()
        {
            return "Store ID: " + id +
                   "\nBranch name: " + name +
                   "\nAddress: \n" + address[id] +
                   "\nArea size: " + area +
                   "\nBranch manager: \n" + manager[id] +
                   "\nTotal warehouse value: " + price + "\n";
        }
    }
}
