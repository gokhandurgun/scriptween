using System;

namespace Scriptweener
{
    [AttributeUsage(AttributeTargets.Class)]
    public class MethodDefinitionAttribute : Attribute
    {
        public string Name { get; }
        
        public Type Type { get; }

        public Type[] ParameterTypes { get; set; }
        
        public MethodDefinitionAttribute(string name, Type type, params Type[] parameterTypes)
        {
            this.Name = name;
            this.Type = type;
            this.ParameterTypes = parameterTypes;
        }
    }
}