namespace Metacube.Net.ZooManagement
{
    public abstract class Animal
    {
        public string Name="";
        public int Age;
        public double Weight;
        public string ProducesSound = "";

        public abstract string getSound();
    }
}