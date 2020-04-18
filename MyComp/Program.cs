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
                          "\n5->Calculate the total price of the computers\n";
            List<Shop> shopList = new List<Shop>();
            int shopid = 0;
            int pcid = 0;

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
                        shopList.Add(new Shop(shopid, storename, new Address(shopid, storecity, storestreet, building), area, new Manager(shopid, identity, managername, managersurname, manageraddress), new List<Computer>()));
                        shopid++;
                        Console.Clear();
                        Console.WriteLine("New shop added\n");
                    }

                    if (option == 2)
                    {
                        Console.Clear();
                        if (shopList.Any())
                        {
                            foreach (Shop item in shopList)
                            {
                                int shopsum = 0;
                                Console.WriteLine(item);
                                foreach (Computer list in item.Computer)
                                {
                                    shopsum = shopsum + list.Price;
                                }
                                Console.WriteLine("Warehouse stock price is: {0}\n", shopsum);
                            }
                        }

                        else Console.WriteLine("Shop list is empty\n");
                    }

                    if (option == 3)
                    {
                        Console.Clear();
                        if (shopList.Any())
                        {
                            Console.Write("Please input shop id: ");
                            string shopselectchk = Console.ReadLine();

                            while (!int.TryParse(shopselectchk, out int value))
                            {
                                Console.Clear();
                                Console.Write("\"{0}\" is not a valid shop id, please select again: \n\n", shopselectchk);
                                Console.Write("Please input correct shop id: ");
                                shopselectchk = Console.ReadLine();
                            }

                            int shopselect = int.Parse(shopselectchk);
                            bool storeflag = false;
                            int shopindex = -1;

                            foreach (Shop item in shopList)
                            {
                                if (item.Id == shopselect)
                                {
                                    storeflag = true;
                                    shopindex = shopList.IndexOf(item);
                                }
                            }

                            if (storeflag)
                            {
                                Console.Clear();
                                if (shopList[shopindex].Computer.Any())
                                {
                                    Console.WriteLine("Computers in inventory:");

                                    foreach (Computer list in shopList[shopindex].Computer)
                                    {
                                        Console.WriteLine(list + "\n");
                                    }
                                }

                                else Console.WriteLine("No computers in inventory\n");
                            }

                            else
                            {
                                Console.Clear();
                                Console.WriteLine("Shop doesnt exist\n");
                            }
                        }

                        else Console.WriteLine("Shop list is empty\n");
                    }
                    

                    if (option == 4)
                    {
                        Console.Clear();
                    }

                    if (option == 5)
                    {
                        Console.Clear();
                        if (shopList.Any())
                        {
                            Console.Write("Enter manger ID: ");
                            string shopbyidchk = Console.ReadLine();

                            while (!int.TryParse(shopbyidchk, out int value))
                            {
                                Console.Clear();
                                Console.Write("\"{0}\" is not a valid manager id, please select again: \n\n", shopbyidchk);
                                Console.Write("Please input correct manager id: ");
                                shopbyidchk = Console.ReadLine();
                            }

                            int shopbyid = int.Parse(shopbyidchk);

                            Console.Clear();
                            foreach (Shop item in shopList)
                            {
                                if (item.Manager.Identity == shopbyid)
                                {
                                    Console.WriteLine(item);
                                    Console.WriteLine();
                                }
                            }
                        }

                        else Console.WriteLine("Shop list is empty\n");
                    }

                    if (option == 6)
                    {
                        Console.Clear();
                        if (shopList.Any())
                        {
                            Console.Write("Please input shop id: ");
                            string shopselectchk = Console.ReadLine();

                            while (!int.TryParse(shopselectchk, out int value))
                            {
                                Console.Clear();
                                Console.Write("\"{0}\" is not a valid shop id, please select again: \n\n", shopselectchk);
                                Console.Write("Please input correct shop id: ");
                                shopselectchk = Console.ReadLine();
                            }

                            int shopselect = int.Parse(shopselectchk);
                            bool storeflag = false;
                            int shopindex = -1;

                            foreach (Shop item in shopList)
                            {
                                if (item.Id == shopselect)
                                {
                                    storeflag = true;
                                    shopindex = shopList.IndexOf(item);
                                }
                            }

                            if (storeflag)
                            {
                                Console.Clear();
                                Console.WriteLine("Managing shop id: {0}\n",shopselect);
                                Console.WriteLine(submenu);
                                Console.Write("Please select an option: ");
                                string suboptionchk = Console.ReadLine();

                                while (!int.TryParse(suboptionchk, out int value))
                                {
                                    Console.Clear();
                                    Console.Write("\"{0}\" is not a valid option, please select again: \n\n", suboptionchk);
                                    Console.WriteLine(submenu);
                                    Console.Write("Please select an option: ");
                                    suboptionchk = Console.ReadLine();
                                }

                                int suboption = int.Parse(suboptionchk);

                                if (suboption > 0 && suboption < 6)
                                {
                                    if (suboption == 1)
                                    {
                                        Console.Clear();
                                        Console.Write("Enter computer brand: ");
                                        string brand = Console.ReadLine();
                                        Console.Write("Enter processor type: ");
                                        string processor = Console.ReadLine();
                                        Console.Write("Enter storage type: ");
                                        string storagetype = Console.ReadLine();
                                        Console.Write("Enter storage size: ");
                                        string storagechk = Console.ReadLine();

                                        while (!int.TryParse(storagechk, out int value))
                                        {
                                            Console.Write("\"{0}\" is not a valid option, please select again: \n", storagechk);
                                            Console.Write("Please enter correct storage size: ");
                                            storagechk = Console.ReadLine();
                                        }

                                        int storagesize = int.Parse(storagechk);
                                        Console.Write("Enter RAM size: ");
                                        string ramchk = Console.ReadLine();

                                        while (!int.TryParse(ramchk, out int value))
                                        {
                                            Console.Write("\"{0}\" is not a valid option, please select again: \n", ramchk);
                                            Console.Write("Please enter correct RAM size: ");
                                            ramchk = Console.ReadLine();
                                        }

                                        int ram = int.Parse(ramchk);
                                        Console.Write("Enter computers price: ");
                                        string pricechk = Console.ReadLine();

                                        while (!int.TryParse(pricechk, out int value))
                                        {
                                            Console.Write("\"{0}\" is not a valid option, please select again: \n", pricechk);
                                            Console.Write("Please enter correct price: ");
                                            pricechk = Console.ReadLine();
                                        }

                                        int price = int.Parse(pricechk);
                                        Console.Write("Enter quantity: ");
                                        string quantitychk = Console.ReadLine();

                                        while (!int.TryParse(quantitychk, out int value))
                                        {
                                            Console.Write("\"{0}\" is not a valid option, please select again: \n", quantitychk);
                                            Console.Write("Please enter correct quantity: ");
                                            quantitychk = Console.ReadLine();
                                        }

                                        int quantity = int.Parse(quantitychk);
                                        Console.Write("Enter number of accessories to add: ");
                                        string accessoriesnumchk = Console.ReadLine();

                                        while (!int.TryParse(accessoriesnumchk, out int value))
                                        {
                                            Console.Write("\"{0}\" is not a valid option, please select again: \n", accessoriesnumchk);
                                            Console.Write("Please enter correct number of accessories to add: ");
                                            accessoriesnumchk = Console.ReadLine();
                                        }

                                        int accessoriesnum = int.Parse(accessoriesnumchk);
                                        string[] accessories;
                                        if (accessoriesnum != 0)
                                        {
                                            accessories = new string[accessoriesnum];
                                            for (int i = 0; i < accessoriesnum; i++)
                                            {
                                                Console.Write("Enter accessory number {0} out of {1}: ", i + 1, accessoriesnum);
                                                accessories[i] = Console.ReadLine();
                                            }
                                        }

                                        else accessories = new string[1] { "None" };

                                        shopList[shopindex].Computer.Add(new Computer(pcid, brand, processor, storagetype, storagesize, ram, price, quantity, accessories));
                                        pcid++;
                                        Console.Clear();
                                        Console.WriteLine("Computer added\n");
                                    }

                                    if (suboption == 2)
                                    {
                                        Console.Clear();
                                        if (shopList[shopindex].Computer.Any())
                                        {
                                            Console.WriteLine("Computers in inventory:");

                                            foreach (Computer list in shopList[shopindex].Computer)
                                            {
                                                Console.WriteLine(list + "\n");
                                            }

                                            Console.Write("Please select id to delete: ");
                                            string delchk = Console.ReadLine();

                                            while (!int.TryParse(delchk, out int value))
                                            {
                                                Console.Write("\"{0}\" is not a valid option, please select again: \n", delchk);
                                                Console.Write("Please enter correct ID input: ");
                                                delchk = Console.ReadLine();
                                            }

                                            int del = int.Parse(delchk);
                                            var id_del = shopList[shopindex].Computer.SingleOrDefault(x => x.Id == del);
                                            if (id_del != null)
                                            {
                                                shopList[shopindex].Computer.Remove(id_del);
                                                Console.Clear();
                                                Console.WriteLine("ID {0}: was successfully deleted\n", del);

                                                if (shopList[shopindex].Computer.Any())
                                                {
                                                    foreach (Computer item in shopList[shopindex].Computer)
                                                    {
                                                        Console.WriteLine(item);
                                                    }
                                                }

                                                else Console.WriteLine("Computer list is empty\n");
                                            }

                                            else
                                            {
                                                Console.Clear();
                                                Console.WriteLine("ID not found\n");
                                            }
                                        }

                                        else Console.WriteLine("No computers in inventory\n");
                                    }

                                    if (suboption == 3)
                                    {
                                        Console.Clear();
                                        Console.Write("Please select pc brand to find: ");
                                        string brand = Console.ReadLine();
                                        Console.WriteLine();

                                        List<Computer> pcBrand = new List<Computer>();

                                        foreach (Computer list in shopList[shopindex].Computer)
                                        {
                                            if (list.Brand == brand)
                                            {
                                                pcBrand.Add(list);
                                            }
                                        }

                                        if (pcBrand.Any())
                                        {
                                            foreach (Computer list in pcBrand)
                                            {
                                                Console.WriteLine(list + "\n");
                                            }
                                        }

                                        else
                                        {
                                            Console.Clear();
                                            Console.WriteLine("Brand doesnt exist\n");
                                        }
                                    }

                                    if (suboption == 4)
                                    {
                                        Console.Clear();
                                        if (shopList[shopindex].Computer.Any())
                                        {
                                            Console.WriteLine("Computers in inventory:");

                                            foreach (Computer list in shopList[shopindex].Computer)
                                            {
                                                Console.WriteLine(list + "\n");
                                            }
                                        }

                                        else Console.WriteLine("No computers in inventory\n");
                                    }

                                    if (suboption == 5)
                                    {
                                        Console.Clear();
                                        int sum = 0;
                                        foreach (Computer list in shopList[shopindex].Computer)
                                        {
                                            sum = sum + list.Price;
                                        }

                                        Console.Clear();
                                        Console.WriteLine("Total computer price is: {0}\n", sum);
                                    }
                                }

                                else
                                {
                                    Console.Clear();
                                    Console.WriteLine("\"{0}\" is not a valid option, please select again\n", suboption);
                                }
                            }

                            else
                            {
                                Console.Clear();
                                Console.WriteLine("Shop doesnt exist\n");
                            }
                        }

                        else Console.WriteLine("Shop list is empty\n");
                    }

                    if (option == 7)
                    {
                        Console.Clear();
                        if (shopList.Any())
                        {
                            Console.Write("Please input shop id to delete: ");
                            string shopdelchk = Console.ReadLine();

                            while (!int.TryParse(shopdelchk, out int value))
                            {
                                Console.Clear();
                                Console.Write("\"{0}\" is not a valid shop id, please select again: \n\n", shopdelchk);
                                Console.Write("Please input correct shop id: ");
                                shopdelchk = Console.ReadLine();
                            }

                            int shopdel = int.Parse(shopdelchk);
                            bool storedelflag = false;
                            int shopdelindex = -1;

                            foreach (Shop item in shopList)
                            {
                                if (item.Id == shopdel)
                                {
                                    storedelflag = true;
                                    shopdelindex = shopList.IndexOf(item);
                                }
                            }

                            if (storedelflag)
                            {
                                Console.Clear();
                                shopList.RemoveAt(shopdelindex);
                                Console.WriteLine("Store {0} was successfully deleted\n", shopdel);
                            }

                            else
                            {
                                Console.Clear();
                                Console.WriteLine("Shop doesnt exist\n");
                            }
                        }

                        else Console.WriteLine("Shop list is empty\n");
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
