using DictionaryOperations;
using System;
using System.ComponentModel;
using System.Drawing;

namespace DictionaryOperations
{
    public class DictionaryOperation
    {
        Dictionary<string, int> myValues = new Dictionary<string, int>();

        public void AddValues()
        {
            myValues.Add(" First ", 1);
            myValues.Add("Second", 2);
            myValues.Add("Third", 3);
            myValues.Add("Fourth", 4);
            myValues.Add("Fifth", 5);
            DisplayValues();
        }

        public void DisplayValues()
        {
            foreach (KeyValuePair<string, int> item in myValues)
            {
                Console.WriteLine("Key: {0}, Value: {1}", item.Key, item.Value);
            }
        }

        public void UpdateValues()
        {
            if (myValues.ContainsKey("Fifth"))
            {
                myValues["Fifth"] = 9;
            }
            if (myValues.ContainsValue(4))
            {
                myValues["Fourth"] = 10;
            }
            Console.WriteLine("\nAfter Updating the Elements in Dictionary.\n");
            DisplayValues();
        }

        public void RemoveValues()
        {
            if (myValues.ContainsKey("Fifth"))
            {
                myValues.Remove("Fifth");
            }
            Console.WriteLine("\nAfter Removing the Element in Dictionary.\n");
            DisplayValues();
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            DictionaryOperation dictionaryOperation = new DictionaryOperation();

            dictionaryOperation.AddValues();
            dictionaryOperation.UpdateValues();
            dictionaryOperation.RemoveValues();

            // Wait for user input before closing the console window
            Console.ReadLine();
        }
    }
}







 