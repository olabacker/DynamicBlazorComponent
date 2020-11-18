using System;
using System.Collections.Generic;
using System.Text;

namespace DynamicComponent
{
    /// <summary>
    /// Defines a attribute which will set a property value on a defined property.
    /// </summary>
    public record DynamicComponentAttribute(string PropertyName, object PropertyValue);
}
