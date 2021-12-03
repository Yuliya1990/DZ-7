using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid1
{
    //Порушено принцип єдиного обов'язку (The single responsibility principle SRP)
    class Item
    {

    }
    class Order
    {
        private List<Item> itemList;

        internal List<Item> ItemList
        {
            get
            {
                return itemList;
            }

            set
            {
                itemList = value;
            }
        }
        
        public void GetItems() {/*...*/}
        public void GetItemCount() {/*...*/}
        public void AddItem(Item item) {/*...*/}
        public void DeleteItem(Item item) {/*...*/}
        public void ShowOrder() {/*...*/}

    }
    public class Calculator
    {
        public void CalculateTotalSum() {/*...*/}
    }

    public class PrintManager
    {
        public void PrintOrder() {/*...*/}
    }
    public class OrderRepository
    {
        public void Load() {/*...*/}
        public void Save() {/*...*/}
        public void Update() {/*...*/}
        public void Delete() {/*...*/}
    }

    class Program
    {
        static void Main()
        {
        }
    }
}
