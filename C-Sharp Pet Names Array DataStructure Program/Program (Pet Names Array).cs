/*
 Create a Program that allows the user to add a pet name and the type of pet to a list using an array.
 Include the ability to delete the pet, change the pet, and list the pet. 
 */

using System;

public struct Pet  
{
    public string Name;
    public string TypeOfPet;
}

class Program
{
    static void Main()
    {
        var numberOfPets = 0;
        var pets = new Pet[10];   //container holds 10 objects.

        while (true)
        {
            Console.Write("A)dd D)elete L)ist C)hange pets:");
            var choice = Console.ReadLine();

            switch (choice)
            {
                case "A":  //if add is selected
                case "a":
                    {
                        Console.Write("Name :");
                        var name = Console.ReadLine();

                        Console.Write("Type of pet :");
                        var typeOfPet = Console.ReadLine();

                        // The below statement adds the pet to the end of the array.
                        pets[numberOfPets].Name = name; 
                        pets[numberOfPets].TypeOfPet = typeOfPet;

                        numberOfPets++; 
                        break;
                    }

                case "D": //if delete is selected
                case "d":
                    {
                        if (numberOfPets == 0)
                        {
                            Console.WriteLine("No pets");
                            break;
                        }

                        for (var index = 0; index < numberOfPets; index++)
                        {
                            Console.WriteLine("{0}. {1,-10} {2}", index + 1, pets[index].Name, pets[index].TypeOfPet);
                        }

                        Console.Write("Which pet to remove (1-{0})", numberOfPets);

                        var petNumberToDelete = Console.ReadLine();
                        var indexToDelete = int.Parse(petNumberToDelete);
                        Console.WriteLine("The pet that was deleted is: {0}", pets[indexToDelete - 1].Name);

                        // Squish the array from index to the end
                        for (var index = indexToDelete - 1; index < numberOfPets; index++)
                        {
                            pets[index] = pets[index + 1];     //Note: for shuffling items over, use: Array[last] = Array[last + 1]
                        }
                        numberOfPets--;       

                        break;
                    }

                case "L":    //if list is selected.
                case "l":
                    {
                        if (numberOfPets == 0)
                        {
                            Console.WriteLine("No pets");
                        }

                        for (int index = 0; index < numberOfPets; index++)
                        {
                            Console.WriteLine("{0}. {1,-10} {2}", index + 1, pets[index].Name, pets[index].TypeOfPet);
                        }

                        break;
                    }
                case "C":    //if change is selected.
                case "c":
                    {

                        Console.Write("Which pet to change (1-{0})", numberOfPets);
                        var petNumberToChange = Console.ReadLine();
                        var indextoChange = int.Parse(petNumberToChange);

                        Console.WriteLine("What is the new pet name?");
                        var newPetName = Console.ReadLine();

                        Console.WriteLine("What is the new pet type?");
                        var newPetType = Console.ReadLine();


                        Console.WriteLine("The pet name that was changed was: {0} to: {1}", pets[indextoChange - 1].Name, newPetName);
                        Console.WriteLine("The pet type that was changed was: {0} to: {1}", pets[indextoChange - 1].TypeOfPet, newPetType);

                        pets[indextoChange - 1].Name = newPetName;
                        pets[indextoChange - 1].TypeOfPet = newPetType;
                        break;
                    }
                default:   // If an invalid option is selected.
                {
                    Console.WriteLine("Invalid option [{0}]", choice);
                    break;
                }
            }
        }
    }
}