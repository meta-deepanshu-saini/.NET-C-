namespace Metacube.Net.ZooManagement;

public class Zone<T> where T : Animal {
    
    // Private attributes
    private int zoneSize;
    private Cage<T>[] zoneCages;   // List of T type cages to store animals in this zone
    private int currentCount;
    private bool hasPark;     // Additional attributes
    private static int currentAvlId = 100;
    private int zoneId;

    public Zone() {
        zoneSize = 5;
        hasPark = false;
        zoneCages = new Cage<T>[zoneSize];
        currentCount = -1;
        this.addCage();
        zoneId = currentAvlId++;
    }
    public Zone(int zSize, bool park) : this() {

        // In case invalid zone size is provided
        if (zSize <= 0 ) {
        throw new ArgumentException("Zone size not valid");
       }
        zoneSize = zSize;
        hasPark = park;
    }

    public int ZoneSize {
        get => zoneSize;
        set => zoneSize = value;
    }

    public int CurrentCount {
        get => currentCount;
        set => currentCount = value;
    }

    public bool HasPark {
        get => hasPark;
        set => hasPark = value;
    }

    public int ZoneId {
        get => zoneId;
        set => zoneId = value;
    }

    public bool addCage() {

        // if new cage can be added
        if (currentCount < zoneSize-1) {
            // Add a new cage
            zoneCages[++currentCount] = new Cage<T>();
            return true;
        } else {
            // if zone is already full
            return false;
        }

    }
    public bool addAnimal(T newAnimal) {

        // If zone is already full
        if (currentCount >= zoneSize) {
            return false;
        }
        else {

            // Finding if cage for this animal exists
            for (int i = 0; i <= currentCount; i++ ) {
                
                // If animal can be added to  current cage
                if (zoneCages[i].addAnimal(newAnimal)) {
                    return true;
                } 

            }

            // If adding a new cage is possible
            if (this.addCage()) {

                // Then add animal in new cage
                zoneCages[currentCount].addAnimal(newAnimal);
                return true;

            } else {
                return false;
            }
        }
    }

    public int getTotalAnimals() {

        int animalSum = 0;  // Initializes counter

        // For each cage in this zone
        for(int i = 0; i <= currentCount; i++) {
            // get total animal count for this cage and add it in sum
            animalSum += zoneCages[i].CurrentCount;
        }

        return animalSum;
    }

    public override string ToString() {

        // Return nothing if no animals in this zone
        if (this.getTotalAnimals() < 1) return "";

        // Return zone info as string
        string allAnimals = $"\nZone Id: {zoneId} has park: {hasPark}, Animals: \n";

        foreach(Cage<T> cage in zoneCages) {
            allAnimals += cage;
        }
        return allAnimals+"\n";
    }
}