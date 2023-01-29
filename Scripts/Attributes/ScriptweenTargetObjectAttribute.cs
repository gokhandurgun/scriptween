using System;

namespace Scriptweener
{
    [AttributeUsage(AttributeTargets.Field, AllowMultiple = false, Inherited = true)]
    public class ScriptweenTargetObjectAttribute : Attribute
    {
        public string TypeProvider { get; set; }

        public ScriptweenTargetObjectAttribute(string typeProvider)
        {
            TypeProvider = typeProvider;
        }
    }
}