using System;
using System.Collections.Generic;

public class Program
{
    // Main Method
    static void Main(string[] args) // Main Has To Be Capitalized Or Else It Says No Entry Point
    {
        // TASK TWO //
        var bagOne = new Backpack("Blue", "Small");
        var bagTwo = new Backpack("Red", "Medium");
        var bagThree = new Backpack("Green", "Large");     

        // TASK THREE //
        bagTwo.openBag();
        bagTwo.putin("Apple");
        bagTwo.putin("Jacket");
        bagTwo.closeBag();
        bagTwo.openBag();
        bagTwo.takeout("Jacket");
        bagTwo.closeBag();               
    }
}

public class Backpack
{
    // TASK ONE //
    // Variables
    public string colour, size;
    public int level;
    public string[] items;
    public bool open;
    // Class Constructor
    public Backpack (string setColour, string setSize)
    {
        this.colour = setColour;
        this.size = setSize;
        this.items = Array.Empty<string>();
        this.open = false;
    }
    // Open Selected Bag Method
    public void openBag()
    {
        this.open = true;
        Console.WriteLine("Bag open.");
    }
    // Close Selected Bag Method
    public void closeBag()
    {
        this.open = false;
        Console.WriteLine("Bag closed.");        
    }    
    // Put New Item Into Selected Bag Method
    public void putin(string newItem)
    {
        if (this.open)
        {
            List<string> itemsList = new List<string>(this.items);
            itemsList.Add(newItem);
            items = itemsList.ToArray();       
            Console.WriteLine($"Put {newItem} into bag.");
        } else
            Console.WriteLine("Can't put anything in because bag is closed.");
    }
    // Put New Item Into Selected Bag Method
    public void takeout(string oldItem)
    {
        if (this.open)
        {
            List<string> itemsList = new List<string>(this.items);
            itemsList.Remove(oldItem);
            items = itemsList.ToArray();             
            Console.WriteLine($"Pulled {oldItem} out of bag.");    
        } else
            Console.WriteLine("Can't take anything out because bag is closed.");
    
    }    
}