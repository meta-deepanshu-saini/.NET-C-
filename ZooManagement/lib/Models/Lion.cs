namespace Metacube.Net.ZooManagement;
public class Lion : Mammal
{
    // Additional attribute
    private bool hasMane;

    public Lion(string animal_name, int animal_id, int animal_age, AnimalType animal_type, bool mane) : base(animal_name, animal_id, animal_age, animal_type, true, AnimalList.Lion) {
        hasMane = mane;
    }

    public bool HasMane {
        get => hasMane;
        set => hasMane = value;
    }

    /// getSound() method is overriden accoarding to lion sound
    public override string getSound()
    {
        return "Roar";
    }

    /// String representation of Lion object
    public override string ToString() {
        return $"{base.ToString()}Sound = {this.getSound()}, \tHas Mane? = {hasMane}\n"; 
    }
}
