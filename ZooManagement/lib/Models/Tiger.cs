namespace Metacube.Net.ZooManagement;

public class Tiger : Mammal
{
    // Additional attribute
    private bool hasStrips;
    public Tiger(string animal_name, int animal_id, int animal_age, AnimalType animal_type, bool mane) : base(animal_name, animal_id, animal_age, animal_type, true, AnimalList.Tiger) {
        hasStrips = mane;
    }
    public bool HasStrips {
        get => hasStrips;
        set => hasStrips = value;
    }

    /// getSound() method is overriden accoarding to tiger sound
    public override string getSound()
    {
        return "Tiger Roar";
    }

    /// String representation of Tiger object
    public override string ToString() {
        return $"{base.ToString()}Sound = {this.getSound()}, \tHas Strips? = {hasStrips}\n"; 
    }
}
