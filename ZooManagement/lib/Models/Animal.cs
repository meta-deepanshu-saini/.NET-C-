namespace Metacube.Net.ZooManagement;

public abstract class Animal
{
    // Private common attributes
    private ZoneType animalZone;
    private string name;
    private int id;
    private int age;
    private AnimalType typeOfAnimal;
    private string species;
    private AnimalList cageType;

    public Animal(ZoneType zone, string animal_name, int animal_id, int animal_age, AnimalType animal_type, string spec, AnimalList animal_cage)
    {

        animalZone = zone;
        name = animal_name;
        id = animal_id;
        age = animal_age;
        species = spec;
        typeOfAnimal = animal_type;
        cageType = animal_cage;
    }

    public Animal(Animal animal)
    {

        animalZone = animal.animalZone;
        name = animal.name;
        id = animal.id;
        age = animal.age;
        species = animal.species;
        typeOfAnimal = animal.typeOfAnimal;
        cageType = animal.cageType;
    }

    public string Name
    {
        get => name;
        set => name = value;
    }

    public int Id
    {
        get => id;
        set => id = value;
    }

    public int Age
    {
        get => age;
        set => age = value;
    }

    public ZoneType AnimalZone
    {
        get;
    }

    public AnimalType TypeOfAnimal
    {
        get => typeOfAnimal;
        set => typeOfAnimal = value;
    }

    public string Species
    {
        get => species;
        set => species = value;
    }

    public AnimalList CageType
    {
        get => cageType;
        set => cageType = value;
    }

    public abstract string getSound();

    public override string ToString()
    {
        return $"\nAnimal: {cageType},\nname: {name}, \tId: {id}, \tAge: {age}\n";
    }
}
