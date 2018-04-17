/// <summary>
/// From http://www.dofactory.com/net/abstract-factory-design-pattern
/// My summary: Abstract factory is used in specific frameworks and apps
/// where client need to create set of different objects
/// and this objects end depends on the settings (framework/app settings or enviroment variables, etc).etc
/// For instance (very rough example):
///     You need to create a DB with such classes as: DBObjectWriter (writes object to DB) and DBObjectReader (reads object from DB).
///     You classes will have different implementation depending on what kind of storage you choose in DB settings: data is stored in file or sent through network, etc.
/// </summary>

using System;

namespace CsharpDesignPatterns.Creational {
    public abstract class AbstractProductA {
        public abstract string Name { get; }
    }

    public class ProductA1 : AbstractProductA {
        public override string Name => "ProductA1 Name";
    }

    public class ProductA2 : AbstractProductA {
        public override string Name => "ProductA2 Name";
    }

    public abstract class AbstractProductB {
        public abstract string Title { get; }
    }

    public class ProductB1 : AbstractProductB {
        public override string Title => "ProductB1 Title";
    }

    public class ProductB2 : AbstractProductB {
        public override string Title => "ProductB2 Title";
    }

    public abstract class AbstractFactory {
        public abstract AbstractProductA CreateProductA();

        public abstract AbstractProductB CreateProductB(); 
    }

    public class ConcreteFactory1 : AbstractFactory {
        public override AbstractProductA CreateProductA() {
            return new ProductA1();
        }

        public override AbstractProductB CreateProductB() {
            return new ProductB1();
        }
    }

    public class ConcreteFactory2 : AbstractFactory {
        public override AbstractProductA CreateProductA() {
            return new ProductA2();
        }

        public override AbstractProductB CreateProductB() {
            return new ProductB2();
        }
    }
}