using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using DG.Tweening;
using UnityEngine;

namespace Scriptweener
{
    [CreateAssetMenu(menuName = "Create Scriptween", fileName = "Scriptween", order = 0)]
    public class Scriptween : ScriptableObject, IScriptween
    {
        //TODO: Remove s_, m_
        private static BaseScriptweenMethodWrapper[] s_ScriptweenMethods;

        //TODO: Better
        public static IEnumerable<string> TweenNames => s_ScriptweenMethods.Select(x => x.Name);

        public ScriptweenMethodOptionCatalogue OptionCatalogue => m_OptionCatalogue;

        public string Tween;

        [SerializeField] private ScriptweenMethodOptionCatalogue m_OptionCatalogue;

        [SerializeField] [HideInInspector] private BaseScriptweenMethodWrapper selectedMethodWrapper;

        [SerializeReference]
        public BaseScriptweenMethod SelectedTween;

        static Scriptween()
        {
            s_ScriptweenMethods = AppDomain.CurrentDomain.GetAssemblies()
                .SelectMany(x => x.GetTypes())
                .Where(x => x.IsSubclassOf(typeof(BaseScriptweenMethod)))
                .Select(x => BaseScriptweenMethodWrapper.Create(x))
                .ToArray();
        }

        //For editor code
        public void TweenSelected()
        {
            if (Tween == null)
            {
                Tween = TweenNames.FirstOrDefault();
            }
            var wrapper = s_ScriptweenMethods.FirstOrDefault(x => x.Name == Tween);

            if (selectedMethodWrapper != null && selectedMethodWrapper.Name == wrapper.Name) return;
            selectedMethodWrapper = wrapper;

            SelectedTween = Activator.CreateInstance(selectedMethodWrapper.BaseScriptweenType) as BaseScriptweenMethod;
        }

        public Type GetTargetType()
        {
            if (selectedMethodWrapper == null)
            {
                selectedMethodWrapper = s_ScriptweenMethods.FirstOrDefault(x => x.Name == Tween);
            }

            var targetType = selectedMethodWrapper.MethodDefinitionAttribute.ParameterTypes[0];
            if (!targetType.IsSubclassOf(typeof(UnityEngine.Object))) return null;

            return targetType;
        }

        public Tween Play(UnityEngine.Object target)
        {
            if (selectedMethodWrapper == null)
            {
                Debug.LogError("ScriptweenWrapper is null");
                return null;
            }

            if (SelectedTween == null)
            {
                Debug.LogError("Scriptween is null");
                return null;
            }

            if (target == null)
            {
                Debug.LogError("Target is null");
                return null;
            }

            var targetType = GetTargetType();
            if (!targetType.IsInstanceOfType(target))
            {
                Debug.LogError("Bad format target");
                return null;
            }

            var parameters = SelectedTween.GetValues().ToList();
            parameters.Insert(0, target);
            var tween = selectedMethodWrapper.MethodInfo.Invoke(null, parameters.ToArray()) as Tween;

            foreach (var option in m_OptionCatalogue.Options)
            {
                option.Apply(tween);
            }
            
            return tween;
        }
    }

    [Serializable]
    public class BaseScriptweenMethodWrapper
    {
        [SerializeField] private ClassTypeReference m_BaseScriptweenType;
        public ClassTypeReference BaseScriptweenType => m_BaseScriptweenType;

        [SerializeField] private string m_Name;
        public string Name => m_Name;

        private MethodDefinitionAttribute m_MethodDefinitionAttribute;

        public MethodDefinitionAttribute MethodDefinitionAttribute
        {
            get
            {
                if (m_MethodDefinitionAttribute == null)
                {
                    m_MethodDefinitionAttribute = BaseScriptweenType.Type.GetMethodDefinitionAtt();
                }

                return m_MethodDefinitionAttribute;
            }
        }

        private MethodInfo m_MethodInfo;

        public MethodInfo MethodInfo
        {
            get
            {
                if (m_MethodInfo == null)
                {
                    m_MethodInfo = BaseScriptweenType.Type.GetMethodInfoAtt();
                }

                return m_MethodInfo;
            }
        }

        private BaseScriptweenMethodWrapper()
        {
        }

        public static BaseScriptweenMethodWrapper Create(Type type)
        {
            return new BaseScriptweenMethodWrapper()
            {
                m_BaseScriptweenType = type,
                m_Name = type.GetDescription()
            };
        }

        public ParameterInfo[] GetParameters() => MethodInfo.GetParameters();
    }
}