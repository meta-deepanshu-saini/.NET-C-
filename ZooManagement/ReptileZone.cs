using System;
namespace Metacube.Net.ZooManagement
{
    public class ReptileZone : Zones {

    int currentCage = 1;
    int currentCapacity = 0;
    public ReptileZone(int cage, int capacity, string park, string canteen) {
        NoOfCages = cage;
        Capacity = capacity;
        hasPark = park;
        hasCanteen = canteen;
    }

    public void animalDetails() {

        Console.WriteLine("Enter Animal Name");
        string AnimalName = Console.ReadLine();
        Console.WriteLine("Enter Animal Age");
        int age = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Animal Weight");
        int weight = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the type of sound animal produces");
        string sound = Console.ReadLine();
        Mammal m = new Mammal(AnimalName, age, weight, sound);
        Console.WriteLine("The sound animal produces is " + m.getSound());
    }

    public void addAnimal() {
        animalDetails();
        if(currentCage <= NoOfCages) {
            if(currentCapacity < Capacity) {
                Console.WriteLine("Animal is added in ReptiltZone Cage" + currentCage);
                currentCapacity = currentCapacity+1;
            }
            else {
                if(currentCage == NoOfCages) {
                    Console.WriteLine("Cage is needed to be add in ReptileZone");
                }
                else {
                    currentCage = currentCage + 1;
                    currentCapacity = 0;
                }
            }
        }
        else {
            Console.WriteLine("Cage is needed to be add in ReptileZone");
        }
    }

    public void addCage() {
        NoOfCages = NoOfCages+1;
        Console.WriteLine("Cage is added in ReptileZone");
    }
}
}