namespace Metacube.Net.ZooManagement;
public class Crocodile : Reptile
{
    /// Additional attribute
    private int bodyLength;

    public Crocodile(string animal_name, int animal_id, int animal_age, AnimalType animal_type, int length)
    : base(animal_name, animal_id, animal_age, animal_type, true, AnimalList.Crocodile)
    {
        bodyLength = length;
    }

    public int BodyLength
    {
        get => bodyLength;
        set => bodyLength = value;
    }

    /// getSound() method is overriden accoarding to Crocodile sound
    public override string getSound()
    {
        return "Zazz";
    }

    /// String representation of Crocodile object
    public override string ToString()
    {
        return $"{base.ToString()}Sound = {this.getSound()}, \tBody length? = {bodyLength}\n";
    }
}
