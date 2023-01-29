using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Scriptweener
{
    [Serializable]
    public class BaseScriptweenMethodWrapper
    {
        [SerializeField] private ClassTypeReference _baseScriptweenType;
        public ClassTypeReference BaseScriptweenType => _baseScriptweenType;

        [SerializeField] private string _name;
        public string Name => _name;

        private MethodDefinitionAttribute _methodDefinitionAttribute;
        public MethodDefinitionAttribute MethodDefinitionAttribute
        {
            get
            {
                if (_methodDefinitionAttribute == null)
                {
                    _methodDefinitionAttribute = BaseScriptweenType.Type.GetMethodDefinitionAtt();
                }

                return _methodDefinitionAttribute;
            }
        }

        private MethodInfo _methodInfo;
        public MethodInfo MethodInfo
        {
            get
            {
                if (_methodInfo == null)
                {
                    _methodInfo = BaseScriptweenType.Type.GetMethodInfoAtt();
                }

                return _methodInfo;
            }
        }

        private BaseScriptweenMethodWrapper()
        {
        }

        public static BaseScriptweenMethodWrapper Create(Type type)
        {
            return new BaseScriptweenMethodWrapper()
            {
                _baseScriptweenType = type,
                _name = type.GetDescription()
            };
        }

        public ParameterInfo[] GetParameters() => MethodInfo.GetParameters();
    }
}
