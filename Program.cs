using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace ArrayListCrud
{
    public class ArrayListCrud
    {
        public ArrayList obj = new ArrayList();

        public void AddItems()
        {
            obj.Add(10);
            obj.Add(20);
            obj.Add(30);
            obj.Add("This is fourth value.");
            obj.Insert(0, "This is the first index");
        }

        public void DisplayItems()
        {
            foreach (var item in obj)
            {
                Console.WriteLine(item);
            }
        }

        public void UpdateItems()
        {
            if (obj.Contains(10))
            {
                obj[0] = "Nikhil";
            }
            Console.WriteLine("\nAfter updating the ArrayList.\n");
            DisplayItems();
            Console.WriteLine("\nCapacity: {0}\n", obj.Capacity);
        }

        public void DeleteItems()
        {
            obj.Remove("This is the first index");
            Console.WriteLine("After deleting the item:\n");
            DisplayItems();
        }

        public static void Main(string[] args)
        {
            ArrayListCrud crud = new ArrayListCrud();

            // Perform CRUD operations
            crud.AddItems();
            crud.DisplayItems();
            crud.UpdateItems();
            crud.DeleteItems();

            // Wait for user input before closing the console window
            Console.ReadLine();
        }
    }
}





