/* Create a Program to save data from a struct into
 * a binary file, load the file and list all file contents.
*/

using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

// TODO: Make the structure serializable
[Serializable]
struct Item
{
    public int PetId;
    public string Name;
}

class Inventory
{
    Item[] items;
    int itemCount;

    public Inventory()
    {
        items = new Item[10];
    }

    private string FileName = "inventory.dat";

    // Create a formatter object
    BinaryFormatter formatter = new BinaryFormatter();

    public void LoadFile()
    {
        // Check if the file exists (File.Exists)
        if (File.Exists(FileName))
        {
            // Open the file (File.Open)
            FileStream stream = File.Open(FileName, FileMode.Open);

            // Deserialize the stream using (Item[])
            items = (Item[])formatter.Deserialize(stream);

            // Close the stream
            stream.Close();
        }
    }

    public void SaveFile()
    {
        // Recreate the file (File.Create)
        FileStream stream = File.Create(FileName);

        // Serialize the items
        foreach (Item item in items)
        {
            formatter.Serialize(stream,items);
        }

        // Close the stream
        stream.Close();
    }

    public void Add(int petId, string name)
    {
        Item item;

        item.PetId = petId;
        item.Name = name;

        items[itemCount] = item;

        itemCount++;
    }

    public void ListAll()
    {
        Console.WriteLine("List All Pets");
        for (int index = 0; index < itemCount; index++)
        {
            Item item = items[index];

            Console.WriteLine(
                "{0,4} {1}",
                item.PetId,
                item.Name);
        }
    }
}

class ProjectMain
{
    static void Main()
    {
        Inventory inventory = new Inventory();

        inventory.Add(1, "Rover");
        inventory.Add(2, "Chippie");
        inventory.Add(3, "Lucy");
        inventory.Add(4, "Rusty");
        inventory.Add(5, "Bleu");
        inventory.Add(6, "Jazzy");
        inventory.Add(7, "Louis");
        inventory.Add(8, "Piper");

        inventory.SaveFile();

        inventory.LoadFile();

        inventory.ListAll();

        Console.ReadLine();

    }
}