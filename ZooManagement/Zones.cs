using System;
namespace Metacube.Net.ZooManagement
{
    public class Zones
    {
        protected int NoOfCages;
        protected int Capacity;
        protected string hasPark = "";
        protected string hasCanteen = "";

        public void ZonesInfo()
        {
            Console.WriteLine("In Metacube Zoo there are three Zones.");
        }
    }
}