using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop_Inventory
{ 
    public class Shop
    {
        private Dictionary<int, string> inventory = new Dictionary<int, string>();
        //

        public string this[int id]{

            get{

                string itemName;
                if (inventory.TryGetValue(id, out itemName))
                {
                    return itemName;
                }

                throw new ArgumentException("Inventory item missing or unassigned");

            }

            set{

                if (inventory.ContainsKey(id))
                {
                    
                    throw new ArgumentException("Duplicate Inventory item found");

                }

                inventory[id] = value;

            }
        }

    }

}