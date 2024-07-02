using DesignPatterns.Infraestructure.DesignPatterns.ModelBuilder;
using DesignPatterns.Models;

namespace DesignPatterns.Infraestructure.DesignPatterns.FactoryMethod
{
    public class FordExplorerCreator : ICreator
    {
        public Vehicle Create()
        {
            var builder = new CarModelBuilder();
            return builder.setBrand("Ford").setModel("Explorer").Build();
        }
    }
}
