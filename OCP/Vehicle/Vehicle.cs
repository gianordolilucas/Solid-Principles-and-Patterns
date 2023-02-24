using System;

namespace OCP.Vehicle
{
    internal class Vehicle : IVehicle
    {
        protected int year;
        protected string color;
        protected double engine;

        public Vehicle(int year, string color, double engine) 
        {
            this.year = year;
            this.color = color;
            this.engine = engine;
        }

        public void StartVehicle()
        {
            Console.WriteLine($"Ligando os motores!!");
        }
    }
}
