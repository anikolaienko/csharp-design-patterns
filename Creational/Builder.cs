/// <summary>
/// From http://www.dofactory.com/net/builder-design-pattern
/// My summary: builder is more useful when it implement fluent interface and you can create object part by part.
/// I wouldn't say that Director is the most needed part, I used builder without Director,
/// cause usually you need to pass a lot of parameters to each part of the object
/// and passing all those parameters to the Director first is overhead.
/// But basically, my understanding of the builder pattern is to have something that does complex object constructions.
/// Also sinse everybody is using IoC in thier app Builder is not that popular any more.
/// </summary>

using System;
using System.Text;

namespace CsharpDesignPatterns.Creational {
    public class Director {
        public Product Construct(Builder builder) {
            return builder.BuildPartA().BuildPartB().GetProduct();
        }
    }

    public class Product {
        private StringBuilder _details = new StringBuilder();

        public string Details => _details.ToString();

        public void AddPart(string part){
            var separator = _details.Length == 0 ? "" : " + ";
            _details.Append(separator + part);
        }
    }

    public abstract class Builder {
        public abstract Builder BuildPartA();
        public abstract Builder BuildPartB();

        public abstract Product GetProduct();
    }

    public class ConcreateBuilder : Builder {
        private Product _product = new Product();

        public override Builder BuildPartA() {
            _product.AddPart("partA");
            return this;
        }

        public override Builder BuildPartB() {
            _product.AddPart("partB");
            return this;
        }

        public override Product GetProduct() {
            return _product;
        }
    }
}