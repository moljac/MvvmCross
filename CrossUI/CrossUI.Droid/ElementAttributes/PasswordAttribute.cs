using System;

namespace FooBar.Dialog.Droid.ElementAttributes
{
    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Property, Inherited = false)]
    public class PasswordAttribute : EntryAttribute
    {
        public PasswordAttribute(string placeholder)
            : base(placeholder)
        {
        }
    }
}