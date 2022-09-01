namespace Metacube.Net.ZooManagement;

public class Ostrich : Bird
{
    // Additional attribute
    private string color;

    public Ostrich(string animal_name, int animal_id, int animal_age, AnimalType animal_type, string clr) 
    : base(animal_name, animal_id, animal_age, animal_type, true, AnimalList.Ostrich) {
        color = clr;
    }

    public string Color {
        get => color;
        set => color = value;
    }
    
    /// getSound() method is overriden accoarding to ostrich sound
    public override string getSound()
    {
        return "Wisses";
    }

    /// String representation of Ostrich object
    public override string ToString() {
        return $"{base.ToString()}Sound = {this.getSound()}, \tColor = {color}\n"; 
    }
}
