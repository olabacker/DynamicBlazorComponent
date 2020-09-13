using System;
using System.Collections.Generic;
using System.Text;

namespace DynamicComponent
{
    public class DynamicComponentAttribute
    {
        public int Sequence { get; set; }

        public string Name { get; set; }

        public object Value { get; set; }
    }
}
