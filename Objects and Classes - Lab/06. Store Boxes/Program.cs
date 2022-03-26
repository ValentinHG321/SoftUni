using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Store_Boxes
{
    class Item
    {
        public Item(string itemName, decimal itemPrice)
        {
            ItemName = itemName;
            ItemPrice = itemPrice;
        }
        public string ItemName { get; set; }
        public decimal ItemPrice { get; set; }


    }
    class Box
    {
        //Serial Number, Item, Item Quantity, and Price for a Box.

        public Box(int serialNumber, Item boxItem, int boxItemQuantity, decimal boxPrice)
        {
            SerialNumber = serialNumber;
            List<Box> boxItem = new List<Box>();
            BoxItem = boxItem;
            BoxItemQuantity = boxItemQuantity;
            BoxPrice = boxPrice;
        }
        public int SerialNumber { get; set; }
        public Item BoxItem { get; set; }
        public int BoxItemQuantity { get; set; }
        public decimal BoxPrice { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //Until you receive "end", you will be receiving data in the following format: "{Serial Number} {Item Name} {Item Quantity} {itemPrice}"
            //The Price of one box has to be calculated: itemQuantity* itemPrice.
            List<Box> listBox = new List<Box>();
            while (true)
            {
                string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();

                if (input[0] == "end")
                {
                    break;
                }

                //Define a class Item, which contains these properties: Name and Price.
                //Define a class Box, which contains these properties: Serial Number, Item, Item Quantity, and Price for a Box.
                //Until you receive "end", you will be receiving data in the following format: "{Serial Number} {Item Name} {Item Quantity} {itemPrice}"
                //The Price of one box has to be calculated: itemQuantity* itemPrice.

                int serialNumber = int.Parse(input[0]);
                string itemName = input[1];
                int itemQuantity = int.Parse(input[2]);
                decimal itemPrice = decimal.Parse(input[3]);
                decimal sum = itemQuantity * itemPrice;
                Item item = new Item(itemName, itemPrice);
                Box box = new Box(serialNumber, item, itemQuantity, sum);
                listBox.Add(box);
            }
            //{ boxSerialNumber}
            //-- { boxItemName} – ${ boxItemPrice}: { boxItemQuantity}
            //-- ${ boxPrice}

        }
    }
}

