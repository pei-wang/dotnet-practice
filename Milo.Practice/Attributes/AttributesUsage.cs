using System;
using System.Collections.Generic;

public class MiloAttributeUsage
{
    public IEnumerable<object> TestAttributes()
    {
        var baseClass = new BaseClass();
        var dBaseClass = new DBaseClass();

        Console.WriteLine("Attributes on baseClass");
        var attrs = baseClass.GetType().GetCustomAttributes(true);
        return attrs;
    }
}

[First, Second]
class BaseClass { }

[Third, Third]
class DBaseClass : BaseClass { }

[System.AttributeUsage(AttributeTargets.Class, Inherited = false)]
class FirstAttribute : System.Attribute { }

[System.AttributeUsage(AttributeTargets.Class)]
class SecondAttribute : System.Attribute { }

[System.AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
class ThirdAttribute : System.Attribute { }
