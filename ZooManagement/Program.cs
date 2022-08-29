using System;
using Metacube.Net.ZooManagement;

class Program
{
    public static void Main(string[] args)
    {

        int option;
        //Creating Objects
        Program z = new Program();
        Console.WriteLine("Welcome to Metacube Zoo");
        MammalZone mu = new MammalZone(6, 1, "yes", "yes");
        BirdZone bd = new BirdZone(3, 10, "yes", "yes");
        ReptileZone rz = new ReptileZone(4, 2, "yes", "yes");

        Console.WriteLine("Choose the option");
        do
        {
            Console.WriteLine("1. Add animal \t\t\t\t 2. Add Cage \t\t\t\t 3. Remove Animal \t\t\t\t 4. exit");
            //Taking user input about what they are going to do
            option = Convert.ToInt32(Console.ReadLine());

            //If option = 1 user is adding animal
            if (option == 1)
            {
                Console.WriteLine("Which type of animal you have Please choose appropriate option");
                Console.WriteLine("\n 1.Mammal \n 2.Bird \n 3.Reptile");

                //Option 1 also has three category so we are asking user input to know what they want to do
                int choice = Convert.ToInt32(Console.ReadLine());
                //Adding mammal in the Zoo
                if (choice == 1)
                {
                    mu.addAnimal();
                    mu.animalDetails();
                }
                //Adding Bird in the zoo
                else if (choice == 2)
                {
                    bd.addBird();
                }
                //Adding Reptile in the zoo
                else if (choice == 3)
                {
                    rz.addAnimal();
                }
            }
            //If user choose option 2
            else if (option == 2)
            {
                Console.WriteLine("In Which zone you want to add cage");
                Console.WriteLine("1.Mammal \t\t\t\t\t 2.Bird \t\t\t\t\t 3.Reptile");
                //Then we are in which zone they want to add cages
                int choice = Convert.ToInt32(Console.ReadLine());
                //In mammal zone
                if (choice == 1)
                {
                    mu.addCage();
                }
                //In bird zone
                else if (choice == 2)
                {
                    bd.addCage();
                }
                //In Reptiles zone
                else if (choice == 3)
                {
                    rz.addCage();
                }
            }
        } while (option != 4);

    }
}
