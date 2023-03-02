using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using DG.Tweening;
using UnityEngine;

namespace Scriptweener
{
    [CreateAssetMenu(menuName = "Scriptween", fileName = "Scriptween", order = 0)]
    public class Scriptween : ScriptableObject, IScriptween
    {
        private static BaseScriptweenMethodWrapper[] _scriptweenMethods;

        public static IEnumerable<string> TweenNames => _scriptweenMethods.Select(x => x.Name);

        public ScriptweenMethodOptionCatalogue OptionCatalogue => _optionCatalogue;

        public string Tween;

        [SerializeField] private ScriptweenMethodOptionCatalogue _optionCatalogue;

        [SerializeField] [HideInInspector] private BaseScriptweenMethodWrapper _selectedMethodWrapper;

        [SerializeReference]
        public BaseScriptweenMethod SelectedTween;

        static Scriptween()
        {
            _scriptweenMethods = AppDomain.CurrentDomain.GetAssemblies()
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
            var wrapper = _scriptweenMethods.FirstOrDefault(x => x.Name == Tween);

            if (_selectedMethodWrapper != null && _selectedMethodWrapper.Name == wrapper.Name) return;
            _selectedMethodWrapper = wrapper;

            SelectedTween = Activator.CreateInstance(_selectedMethodWrapper.BaseScriptweenType) as BaseScriptweenMethod;
        }

        public Type GetTargetType()
        {
            if (_selectedMethodWrapper == null)
            {
                _selectedMethodWrapper = _scriptweenMethods.FirstOrDefault(x => x.Name == Tween);
            }

            var targetType = _selectedMethodWrapper.MethodDefinitionAttribute.ParameterTypes[0];
            if (!targetType.IsSubclassOf(typeof(UnityEngine.Object))) return null;

            return targetType;
        }

        public Tween Play(UnityEngine.Object target)
        {
            if (_selectedMethodWrapper == null)
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
            var tween = _selectedMethodWrapper.MethodInfo.Invoke(null, parameters.ToArray()) as Tween;

            foreach (var option in _optionCatalogue.Options)
            {
                option.Apply(tween);
            }
            
            return tween;
        }
    }

}