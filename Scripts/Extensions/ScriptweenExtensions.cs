using System;
using System.ComponentModel;
using System.Linq;
using System.Reflection;

namespace Scriptweener
{
    public static class ScriptweenExtensions
    {
        public static string GetDescription<T>(this T obj) 
        {
            var type = obj.GetType();

            return type.GetDescription();
        }

        public static string GetDescription(this Type type)
        {
            var attributes = type.GetCustomAttributes(typeof(DescriptionAttribute), false);

            if (attributes.Length == 0)
                return type.Name;
 
            return (attributes.Single() as DescriptionAttribute)?.Description;
        }

        public static string GetCategory(this Type type)
        {
            var attributes = type.GetCustomAttributes(typeof(CategoryAttribute), false);

            if (attributes.Length == 0)
                return type.Name;
 
            return (attributes.Single() as CategoryAttribute)?.Category;
        }

        public static MethodInfo GetMethodInfoAtt(this Type type)
        {
            var methodDefinitionAttribute = GetMethodDefinitionAtt(type);

            return methodDefinitionAttribute.Type.GetMethod(methodDefinitionAttribute.Name,
                methodDefinitionAttribute.ParameterTypes);
        }
        
        public static MethodDefinitionAttribute GetMethodDefinitionAtt(this Type type)
        {
            var attributes = type.GetCustomAttributes(typeof(MethodDefinitionAttribute), false);

            if (attributes.Length == 0)
                throw new NotImplementedException();
 
            return attributes.Single() as MethodDefinitionAttribute;
        }
    }
}