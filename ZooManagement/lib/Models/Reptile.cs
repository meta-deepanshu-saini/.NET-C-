namespace Metacube.Net.ZooManagement;

public abstract class Reptile : Animal 
{
    // Additional attribute
    private bool canSwim;

    public Reptile(string animal_name, int animal_id, int animal_age, AnimalType animal_type, bool swim, AnimalList cageType) : base(ZoneType.Reptile, animal_name, animal_id, animal_age, animal_type, "Reptile", cageType) {
        canSwim = swim;
    }

    public bool CanSwim {
        get => canSwim;
        set => canSwim = value;
    }
    
    public override string ToString() {
        return $"{base.ToString()}Can swim? = {canSwim}\n"; 
    }
}
