//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Week4Task
//{
//    internal class Number2
//    {
//        static void Main(string[] args)
//        {


            
//                List<Item> itemlist = new List<Item>


//                {

//                    new Item { ItemId = 1, ItemDes = "Bag" },

//                    new Item { ItemId = 2, ItemDes = "Pen" },

//                    new Item { ItemId = 3, ItemDes = "Book " },

//                    new Item { ItemId = 4, ItemDes = "Shoe " },

//                    new Item { ItemId = 5, ItemDes = "Pin " }

//                 };

//                List<Sales> saleslist = new List<Sales>
//                {
//                    new Sales{ InvNo=1, ItemId = 3, Qty = 10 },

//                    new Sales{ InvNo=2, ItemId = 2, Qty = 20 },

//                    new Sales{ InvNo=3, ItemId = 3, Qty = 500 },

//                    new Sales{ InvNo=4, ItemId = 4, Qty = 20 },

//                    new Sales{ InvNo=5, ItemId = 3, Qty = 100 },

//                     new Sales{ InvNo=6, ItemId = 1, Qty = 50 }

//                 };

//            var joinItems = itemlist.Join(saleslist, items => items.ItemId, sales => sales.ItemId, (items, sales) => new
//            {
//                ItemName = items.ItemDes,
//                ItemId = items.ItemId,
//                Qty = sales.Qty,
//            });
//            Console.WriteLine("Item ID" + "   " + "Item Name" + "   " + "Quantity");
//            Console.WriteLine("-----------------------------------");
//            foreach (var item in joinItems)
//            {
                
//                Console.WriteLine($"{item.ItemId,-10} {item.ItemName,-10} {item.Qty,5}");
//            }
//        }
//    }
//}
