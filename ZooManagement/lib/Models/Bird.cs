namespace Metacube.Net.ZooManagement;

public abstract class Bird : Animal 
{
    // Additional attribute
    private bool isVegetarian;

    public Bird(string animal_name, int animal_id, int animal_age, AnimalType animal_type, bool isVeg,AnimalList cageType) : base(ZoneType.Bird, animal_name, animal_id, animal_age, animal_type, "Bird", cageType) {
        isVegetarian = isVeg;
    }

    public bool IsVegetarian {
        get => isVegetarian;
        set => isVegetarian = value;
    }
    
    public override string ToString() {
        return $"{base.ToString()}Has furres? = {isVegetarian}\n"; 
    }
}
