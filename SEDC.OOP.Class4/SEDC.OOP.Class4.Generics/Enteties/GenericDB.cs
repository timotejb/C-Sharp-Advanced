using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.OOP.Class4.Generics.Enteties
{
    public class GenericDB<T>where T : BaseEntity
    {
        private List<T> items;

        public GenericDB()
        {
            items = new List<T>();
        }

        public void AddItem(T item)
        {
            items.Add(item);
            Console.WriteLine($"Item Added! Type: {typeof(T)}");
        }
        public void PrintInfo()
        {
            foreach (T item in items)
                item.PrintInfo();
        }
        public void DeleteItem(T itemToDelete)
        {
            T item = items.FirstOrDefault(x => x == itemToDelete);
            if (item != null)
            {
                items.Remove(item);
                Console.WriteLine($"Item with Id{item.Id} Deleted");
            }
            else
                Console.WriteLine("Item was not found!");
        }
        public void DeleteItemById(int id)
        {
            T item = items.FirstOrDefault(x => x.Id == id);
            if(item != null)
            {
                items.Remove(item);
            }
        }
    }
}
