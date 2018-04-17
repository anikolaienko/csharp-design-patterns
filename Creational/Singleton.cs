/// <summary>
/// From http://www.dofactory.com/net/singleton-design-pattern
/// My summary: the most clasic creational pattern,
/// cause there's so many times you want to store some settings in single object.
/// Since everybody is using IoC now, it's allmost not used in that implementation anymore.
/// 
/// Really good article about all implementations of Singleton in C#:
/// http://csharpindepth.com/Articles/General/Singleton.aspx
/// </summary>

using System;
using System.Threading;

namespace CsharpDesignPatterns.Creational {
        public sealed class Singleton {
        private Singleton() {}

        public static Singleton Instance { get { return Nested.instance; } }
            
        private class Nested
        {
            // Explicit static constructor to tell C# compiler
            // not to mark type as beforefieldinit
            static Nested()
            {
            }

            internal static readonly Singleton instance = new Singleton();
        }
    }
}