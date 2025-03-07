using System;
using System.Collections.Generic;

namespace ClassLibrary1
{
    public class Class1
    {
        public List<(int, string)> TupleMethod()
        {
            return new List<(int, string)>()
            {
                (1, "one"),
                (2, "two"),
                (3, "three"),
            };
        }
    }
}