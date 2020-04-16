using System;
namespace MyComp
{
    public class Manager
    {
        public Manager(int id, int identity, string name, string surname, string address)
        {
            this.id = id;
            this.identity = identity;
            this.name = name;
            this.surname = surname;
            this.address = address;
        }

        private int id;
        private int identity;
        private string name;
        private string surname;
        private string address;

        public int Id { get => id; set => id = value; }
        public int Identity { get => identity; set => identity = value; }
        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }
        public string Address { get => address; set => address = value; }

        public override string ToString()
        {
            return "ID Number - " + identity +
                   "\nName - " + name +
                   "\nSurname - " + surname +
                   "\nAddress - " + address;
        }
    }
}
