namespace Metacube.Net.ZooManagement;

public abstract class Mammal : Animal 
{
    // Additional attribute
    private bool hasFur;
    public Mammal(string animal_name, int animal_id, int animal_age, AnimalType animal_type, bool furred, AnimalList cageType) : base(ZoneType.Mammal, animal_name, animal_id, animal_age, animal_type, "Mammal", cageType) {
        hasFur = furred;
    }

    public bool HasFur {
        get => hasFur;
        set => hasFur = value;
    }
    
    public override string ToString() {
        return $"{base.ToString()}Has furres? = {hasFur}\n"; 
    }
}
