using System;
using System.Collections.Generic;
using System.Text;

namespace Creational_Pattern
{
    public sealed class OtherCarShop
    {
        private OtherCarShop() { }

        public static OtherCarShop instance { get { return Nested.instance; } }

        private class Nested
        {
            static Nested() { }
            internal static readonly OtherCarShop instance = new OtherCarShop();
        }
    }
}
