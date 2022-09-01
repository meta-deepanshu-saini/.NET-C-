using Metacube.Net.ZooManagement;

public class Program {
    public static void Main(string[] args){

        // Creating a default Zoo object
        Zoo myZoo = new Zoo();

        // Adding some animals in this zoo
        myZoo.addMammalAnimal(new Lion("Tommy1", 1001, 6,AnimalType.AdultMale, true));
        myZoo.addMammalAnimal(new Lion("Tyson1", 1002, 8,AnimalType.AdultMale, true));
        myZoo.addReptileAnimal(new Crocodile("Tommy1", 2001, 6,AnimalType.AdultMale, 21));
        myZoo.addReptileAnimal(new Crocodile("Tyson1", 2002, 8,AnimalType.AdultMale, 20));
        myZoo.addBirdAnimal(new Ostrich("Tommy1", 3001, 6,AnimalType.AdultMale, "black"));
        myZoo.addBirdAnimal(new Ostrich("Tyson1", 3002, 8,AnimalType.AdultMale, "brown"));

        // Zoo information
        Console.WriteLine(myZoo);
    }
}