using System;
namespace Metacube.Net.ZooManagement
{

    public class BirdZone : Zones
    {
        public List<Bird> birdList = new List<Bird>();
        int currentCage = 1;
        int currentCapacity = 0;
        public BirdZone(int cage, int capacity, string park, string canteen)
        {
            NoOfCages = cage;
            Capacity = capacity;
            hasPark = park;
            hasCanteen = canteen;
        }

        public void animalDetails()
        {

            Console.WriteLine("Enter bird Name");
            string AnimalName = Console.ReadLine();
            Console.WriteLine("Enter bird Age");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter bird Weight");
            int weight = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the type of sound bird produces");
            string sound = Console.ReadLine();
            Bird b = new Bird(AnimalName, age, weight, sound);
            Console.WriteLine("The sound Bird produces is " + b.getSound());
            birdList.Add(b);
        }
        public void addBird()
        {
            animalDetails();
            if (currentCage <= NoOfCages)
            {
                if (currentCapacity < Capacity)
                {
                    Console.WriteLine("Bird is added in BirdZone Cage" + currentCage);
                    currentCapacity = currentCapacity + 1;
                }
                else
                {
                    if (currentCage == NoOfCages)
                    {
                        Console.WriteLine("Cage is needed to be add in BirdZone");
                    }
                    else
                    {
                        currentCage = currentCage + 1;
                        currentCapacity = 0;
                    }
                }
            }
            else
            {
                Console.WriteLine("Cage is needed to be add in BirdZone");
            }
        }

        public void addCage()
        {
            NoOfCages = NoOfCages + 1;
            Console.WriteLine("Cage is added in BirdZone");
        }

        public void removeBird()
        {
            try
            {
                birdList.RemoveAt(birdList.Count - 1);
                System.Console.WriteLine("Last Bird is removed from cage");
            } catch(Exception e){
                    System.Console.WriteLine("Something went wrong");
            }
        }

        public void showBird()
        {
            foreach (Bird bird in birdList)
            {
                Console.WriteLine($" Name : {bird.Name} Age : {bird.Age} Weight : {bird.Weight} Sound : {bird.getSound()}");
            }
            System.Console.WriteLine("------------");
        }
    }
}