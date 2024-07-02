using DesignPatterns.Models;
using System;

namespace DesignPatterns.Infraestructure.DesignPatterns.ModelBuilder
{
    public class CarModelBuilder
    {
        //private para que no puedan modificar las propiedades
        private string color = "Red";
        private string brand = "Ford";
        private string model = "Mustang";
        private int year = DateTime.Today.Year;

        public CarModelBuilder setColor(string color)
        {
            this.color = color;
            return this;
        }

        public CarModelBuilder setBrand(string brand)
        {
            this.brand = brand;
            return this;
        }

        public CarModelBuilder setModel(string model)
        {
            this.model = model;
            return this;
        }
        public CarModelBuilder setYear(int year)
        {
            this.year = year;
            return this;
        }
        public Vehicle Build()
        {
            return new Car(color, brand, model, year);
        }
    }
}
