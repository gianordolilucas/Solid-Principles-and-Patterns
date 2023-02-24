using System;

namespace OCP.Vehicle
{
    internal class Car : Vehicle
    {
        private int doors;
        private int seats;

        public Car(int year, string color, double engine, int doors, int seats) : base(year, color, engine)        {
            this.doors = doors;
            this.seats = seats;
        }

        public void ConfigureCar()
        {
            Console.WriteLine($"Criando um carro {color}, {year}, {engine}, {doors} portas e {seats} assentos");
        }

    }
}
