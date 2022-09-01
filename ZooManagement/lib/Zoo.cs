namespace Metacube.Net.ZooManagement;

public class Zoo
{
    // Zoo class has following private attributes
    private string zooName;
    private int maxZones;
    // Zone arrays for each type of zone
    private Zone<Mammal>[] mammleZones;
    private Zone<Reptile>[] reptileZones;
    private Zone<Bird>[] birdZones;

    // Following attributes keep track count of each zone 
    private int currentMammleZone;
    private int currentReptileZone;
    private int currentBirdZone;

    // Following attributes keep track count of animals of each zone
    private int currentMammlesCount;
    private int currentReptilesCount;
    private int currentBirdsCount;

    public Zoo()
    {
        // Object Initialization
        zooName = "New-Zoo";
        maxZones = 5;
        mammleZones = new Zone<Mammal>[maxZones];
        reptileZones = new Zone<Reptile>[maxZones];
        birdZones = new Zone<Bird>[maxZones];
        currentMammleZone = 0;
        currentReptileZone = 0;
        currentBirdZone = 0;
        currentMammlesCount = 0;
        currentReptilesCount = 0;
        currentBirdsCount = 0;

        // Now we have to create default zone for each index for each zone type
        for (int i = 0; i < maxZones; i++)
        {
            mammleZones[i] = new Zone<Mammal>();
            reptileZones[i] = new Zone<Reptile>();
            birdZones[i] = new Zone<Bird>();
        }
    }

    public Zoo(string name, int max) : this()
    {
        zooName = name;
        maxZones = max;
    }

    
    public bool addMammalAnimal(Mammal newAnimal)
    {
        // If zones are not full
        if (currentMammleZone < mammleZones.Length)
        {

            // If current zone is not full
            if (mammleZones[currentMammleZone].addAnimal(newAnimal))
            {

                currentMammlesCount++;
                return true;
            }

            // In case current zone is full but there is another zone remaing in zones array
            else if (currentMammleZone != mammleZones.Length - 1)
            {

                currentMammleZone += 1;
                mammleZones[currentMammleZone].addAnimal(newAnimal);
                return true;
            }

            // In case no zone is available for this category so can't add new animal
            else return false;
        }

        // else Zone array is full
        else return false;
    }

    public bool addReptileAnimal(Reptile newAnimal)
    {

        // If zones are not full
        if (currentReptileZone < reptileZones.Length)
        {

            // If current zone is not full
            if (reptileZones[currentReptileZone].addAnimal(newAnimal))
            {

                currentReptilesCount++;
                return true;
            }

            // In case current zone is full but there is another zone remaing in zones array
            else if (currentReptileZone != reptileZones.Length - 1)
            {

                currentReptileZone += 1;
                reptileZones[currentReptileZone].addAnimal(newAnimal);
                return true;
            }

            else return false;
        }

        else return false;
    }

    public bool addBirdAnimal(Bird newAnimal)
    {

        if (currentBirdZone < birdZones.Length)
        {

            if (birdZones[currentBirdZone].addAnimal(newAnimal))
            {

                currentBirdsCount++;
                return true;
            }

            else if (currentBirdZone != birdZones.Length - 1)
            {

                currentBirdZone += 1;
                birdZones[currentBirdZone].addAnimal(newAnimal);
                return true;
            }

            else return false;
        }

        else return false;
    }

    public string getZoneInfo(ZoneType zone)
    {

        // Initialize zoneInfo array 
        string zoneInfo = "";

        // According to zoneType add all zone animals

        if (zone == ZoneType.Mammal)
        {

            // For each zone in zones array
            foreach (Zone<Mammal> zoneAnimals in mammleZones)
            {

                // add zone animals in zone info
                zoneInfo += zoneAnimals;
            }

        }
        else if (zone == ZoneType.Reptile)
        {

            foreach (Zone<Reptile> zoneAnimals in reptileZones)
            {

                zoneInfo += zoneAnimals;
            }

        }
        else if (zone == ZoneType.Bird)
        {

            foreach (Zone<Bird> zoneAnimals in birdZones)
            {

                zoneInfo += zoneAnimals;
            }

        }

        // returns whole zone info
        return zoneInfo;

    }

    public override string ToString()
    {

        // Basic Zone info
        string zooInfo = $"\nZoo Name: {zooName}\nZoo Max Zones per each Category: {maxZones}\nZoo has following info: \n";

        // Now add zone info only if there is any animal of that particular zone type

        zooInfo += "Mammals:\n";
        // Adding mammle info
        if (currentMammlesCount != 0) { zooInfo += getZoneInfo(ZoneType.Mammal) + "\n"; }

        else
        {
            zooInfo += "\nThere is no Mammle in this Zoo";
        }

        // Adding Reptiles info
        zooInfo += "\nReptiles:\n";

        if (currentReptilesCount != 0) { zooInfo += getZoneInfo(ZoneType.Reptile) + "\n"; }

        else
        {
            zooInfo += "\nThere is no Reptile in this Zoo";
        }

        // Adding Birds info
        zooInfo += "\nBirds:\n";

        if (currentBirdsCount != 0) { zooInfo += getZoneInfo(ZoneType.Bird) + "\n"; }

        else
        {
            zooInfo += "\nThere is no Bird in this Zoo";
        }

        return zooInfo;

    }
}