/// <summary>
/// From http://www.dofactory.com/net/prototype-design-pattern
/// My summary: .Net has an interface ICloneable with method Clone.
/// So it's very wise to use that interface in your Prototype implementation.
/// </summary>

using System;

namespace CsharpDesignPatterns.Creational {
    public class Product1 : ICloneable {
        public string Name {get;}

        public Product1(string name) {
            Name = name;
        }

        public Object Clone() {
            return new Product1(Name);
        }
    }

    public class Product2 : ICloneable {
        public string Title {get;}

        public Product2(string title) {
            Title = title;
        }

        public Object Clone() {
            return new Product2(Title);
        }
    }
}