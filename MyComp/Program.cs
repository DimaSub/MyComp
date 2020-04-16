using System;
using System.Collections.Generic;
using System.Linq;

namespace MyComp
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int exit = 0;
            string mainmenu = "Please input your option ->" +
                          "\n\n1->Add new shop" +
                          "\n2->Show shop list" +
                          "\n3->Show shop computers list" +
                          "\n4->Find shop by address" +
                          "\n5->Find all shops of the current manager" +
                          "\n6->Manage shop by id" +
                          "\n7->Remove shop" +
                          "\n8->Exit\n";
            string submenu = "Please input your option ->" +
                          "\n\n1->Add new computer" +
                          "\n2->Remove computer" +
                          "\n3->Print computer list by Company Name" +
                          "\n4->Print list of the computers" +
                          "\n5->Calculate the total price of the computers" +
                          "\n6->Еxit\n";
            List<Shop> shopList = new List<Shop>();
            List<Computer> pcList = new List<Computer>();
            List<Address> addressList = new List<Address>();
            List<Manager> managerList = new List<Manager>();
            int shopid = 0;
            int pcid = 0;
            int addressid = 0;
            int managerid = 0;

            while (exit != 8)
            {
                Console.WriteLine(mainmenu);
                Console.Write("Please select an option: ");
                string optionchk = Console.ReadLine();

                while (!int.TryParse(optionchk, out int value))
                {
                    Console.Clear();
                    Console.Write("\"{0}\" is not a valid option, please select again: \n\n", optionchk);
                    Console.WriteLine(mainmenu);
                    Console.Write("Please select an option: ");
                    optionchk = Console.ReadLine();
                }

                int option = int.Parse(optionchk);

                if (option > 0 && option < 9)
                {
                    if (option == 1)
                    {
                        Console.Clear();
                        Console.Write("Enter stores name: ");
                        string storename = Console.ReadLine();
                        Console.WriteLine("\nEnter stores address: ");
                        Console.Write("City - ");
                        string storecity = Console.ReadLine();
                        Console.Write("Street - ");
                        string storestreet = Console.ReadLine();
                        Console.Write("Building number - ");
                        string buildingchk = Console.ReadLine();

                        while (!int.TryParse(buildingchk, out int value))
                        {
                            Console.Write("\"{0}\" is not a valid option.\n", buildingchk);
                            Console.Write("Please enter correct building number: ");
                            buildingchk = Console.ReadLine();
                        }

                        int building = int.Parse(buildingchk);
                        addressList.Add(new Address(addressid, storecity, storestreet, building));
                        addressid++;
                        Console.Write("\nEnter stores area: ");
                        string areachk = Console.ReadLine();

                        while (!int.TryParse(areachk, out int value))
                        {
                            Console.Write("\"{0}\" is not a valid number.\n", areachk);
                            Console.Write("Please enter correct stores area: ");
                            areachk = Console.ReadLine();
                        }

                        int area = int.Parse(areachk);
                        Console.WriteLine("\nEnter stores manager: ");
                        Console.Write("ID Number - ");
                        string identitychk = Console.ReadLine();

                        while (!int.TryParse(identitychk, out int value))
                        {
                            Console.Write("\"{0}\" is not a valid number.\n", identitychk);
                            Console.Write("Please enter correct identity number: ");
                            identitychk = Console.ReadLine();
                        }

                        int identity = int.Parse(identitychk);
                        Console.Write("Name - ");
                        string managername = Console.ReadLine();
                        Console.Write("Surname - ");
                        string managersurname = Console.ReadLine();
                        Console.Write("Address - ");
                        string manageraddress = Console.ReadLine();
                        managerList.Add(new Manager(managerid, identity, managername, managersurname, manageraddress));
                        managerid++;
                        shopList.Add(new Shop(shopid, storename, addressList, area, managerList));
                        shopid++;
                        Console.Clear();
                        Console.WriteLine("New shop added\n");
                    }

                    if (option == 2)
                    {
                        Console.Clear();
                        foreach (Shop item in shopList)
                        {
                            Console.WriteLine(item + "\n");
                        }
                    }

                    if (option == 3)
                    {
                        Console.Clear();
                    }

                    if (option == 4)
                    {
                        Console.Clear();
                    }

                    if (option == 5)
                    {
                        Console.Clear();
                    }

                    if (option == 6)
                    {
                        Console.Clear();
                    }

                    if (option == 7)
                    {
                        Console.Clear();
                    }

                    if (option == 8)
                    {
                        exit = option;
                        Console.Clear();
                        Console.WriteLine("Thank you for using our software");
                    }
                }

                else
                {
                    Console.Clear();
                    Console.WriteLine("\"{0}\" is not a valid option, please select again\n", option);
                }
            }
        }
    }
}
