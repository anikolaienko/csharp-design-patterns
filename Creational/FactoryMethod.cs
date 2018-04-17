/// <summary>
/// From http://www.dofactory.com/net/factory-method-design-pattern
/// My summary: I use factory method, when I need to create a specific implemention of the interface,
/// depending on some variable.
/// So, unlike dofactory page describes, where they use FactoryMethod for creating group of products,
/// I would assume to use switch case and create specific product instead in Factory Method.
/// Implementation from dofactory page actually reminds me more a Builder pattern.
/// </summary>

using System;

namespace CsharpDesignPatterns.Creational {
    public interface IProduct {
        string Name { get; }
    }

    public class ProductA : IProduct {
        public string Name => "ProductA";
    }

    public class ProductB : IProduct {
        public string Name => "ProductB";
    }

    public interface ICreator {
        IProduct GetProduct(string param);
    }

    public class CreatorA : ICreator {
        public IProduct GetProduct(string param) {
            switch (param) {
                case "ProductA":
                    return new ProductA();
                case "ProductB":
                    return new ProductB();
            }
            throw new ArgumentException($"Parameter value {param} is not allowed");
        }
    }
}