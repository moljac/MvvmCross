using System;

namespace FooBar.Dialog.Droid.ElementAttributes
{
    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Property, Inherited = false)]
    public class SkipAttribute : Attribute
    {
    }
}