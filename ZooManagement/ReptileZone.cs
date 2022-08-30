using System;
namespace Metacube.Net.ZooManagement
{
    public class ReptileZone : Zones
    {
        public List<Reptile> reptileList = new List<Reptile>();
        int currentCage = 1;
        int currentCapacity = 0;
        public ReptileZone(int cage, int capacity, string park, string canteen)
        {
            NoOfCages = cage;
            Capacity = capacity;
            hasPark = park;
            hasCanteen = canteen;
        }

        public void animalDetails()
        {

            Console.WriteLine("Enter Animal Name");
            string AnimalName = Console.ReadLine();
            Console.WriteLine("Enter Animal Age");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Animal Weight");
            int weight = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the type of sound animal produces");
            string sound = Console.ReadLine();
            Reptile r = new Reptile(AnimalName, age, weight, sound);
            Console.WriteLine("The sound animal produces is " + r.getSound());
            reptileList.Add(r);
        }

        public void addAnimal()
        {
            animalDetails();
            if (currentCage <= NoOfCages)
            {
                if (currentCapacity < Capacity)
                {
                    Console.WriteLine("Animal is added in ReptiltZone Cage" + currentCage);
                    currentCapacity = currentCapacity + 1;
                }
                else
                {
                    if (currentCage == NoOfCages)
                    {
                        Console.WriteLine("Cage is needed to be add in ReptileZone");
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
                Console.WriteLine("Cage is needed to be add in ReptileZone");
            }
        }

        public void addCage()
        {
            NoOfCages = NoOfCages + 1;
            Console.WriteLine("Cage is added in ReptileZone");
        }

        public void removeReptile()
        {
            try
            {
                reptileList.RemoveAt(reptileList.Count - 1);
                System.Console.WriteLine("Last Reptile is removed from cage");
            } catch(Exception e){
                    System.Console.WriteLine("Something went wrong");
            }
        }

        public void showReptile()
        {
            foreach (Reptile rep in reptileList)
            {
                Console.WriteLine($" Name : {rep.Name} Age : {rep.Age} Weight : {rep.Weight} Sound : {rep.getSound()}");
            }
            System.Console.WriteLine("------------");
        }
    }
}