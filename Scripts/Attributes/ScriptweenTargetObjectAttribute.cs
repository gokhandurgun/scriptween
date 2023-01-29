using System;
using UnityEngine;

namespace Scriptweener
{
    [AttributeUsage(AttributeTargets.Field, AllowMultiple = false, Inherited = true)]
    public class ScriptweenTargetObjectAttribute : PropertyAttribute
    {
        public string TypeProvider { get; set; }

        public ScriptweenTargetObjectAttribute(string typeProvider)
        {
            TypeProvider = typeProvider;
        }
    }
}