namespace Metacube.Net.ZooManagement
{
    public class Reptile : Animal
    {

        public Reptile(string name, int age, int weight, string sound)
        {
            Name = name;
            Age = age;
            Weight = weight;
            ProducesSound = sound;
        }

        public override string getSound()
        {
            return ProducesSound;
        }
    }
}