namespace Metacube.Net.ZooManagement;

public class Cage<T> where T : Animal { 

    // Private attributes
    private int cageSize;
    private T[] cageAnimals;   // This array of Animal type stores Animal objects
    private int currentCount;
    private AnimalList cageAnimal;     // Fixed type of animal that can be inserted in this cage
    private static int currnetAvlId = 200;      // static integer to generate unique id
    private int cageId;

    public Cage() {

        cageSize = 5;
        cageAnimals = new T[cageSize];
        currentCount = 0;
        cageAnimal = AnimalList.General;
        cageId = currnetAvlId++;
    }

    public Cage(int cSize, AnimalList thisCageAnimal) {

        // In case of invalid cagesize throw exception
        if (cSize <= 0 ) {
        throw new ArgumentException("Cage size not valid");
       }

        cageSize = cSize;
        cageAnimals = new T[cageSize];
        currentCount = 0;
        cageAnimal = thisCageAnimal;
        cageId = currnetAvlId++;
    }

    public int CageSize {
        get;
    }

    public int CurrentCount {
        get => currentCount;
        set => currentCount = value;
    }

    public bool addAnimal(T animal) {

        // If cage is full
        if (currentCount >= cageSize) {
            return false;
        }

        // if given animal is invalid
        if (cageAnimal != animal.CageType && cageAnimal != AnimalList.General) return false;

        // if cage is still general type
        if (cageAnimal == AnimalList.General) cageAnimal = animal.CageType;

        cageAnimals[currentCount++] = animal;
        return true;
    }

    /// String representation of Cage object
    public override string ToString() {

        if (currentCount == 0) return "";
        string allAnimals = $"\n{cageAnimal} cage with ID: {cageId}, total animals";
        foreach(Animal animal in cageAnimals) {
            allAnimals += animal;
        }
        return allAnimals+"\n";
    }

}