using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Scriptweener
{ 
    [Serializable]
    public class ScriptweenMethodOptionCatalogue
    {
        private static List<Type> _optionClassList =
               new List<Type>()
               {
                typeof(SetIdOption),
                typeof(SetEase1Option),
                typeof(SetEase2Option),
                typeof(SetRelativeOption),
                typeof(SetLoopsOption),
                typeof(SetDelayOption),
                typeof(SetSpeedBasedOption)
               };

        public IEnumerable<string> OptionNames
        {
            get
            {
                var currentCategories = Options?.Select(x => x.GetType().GetCategory()).Distinct() ?? Enumerable.Empty<string>();

                for (var i = 0; i < _optionClassList.Count; i++)
                {
                    var item = _optionClassList[i];
                    if (currentCategories.Contains(item.GetCategory())) continue;

                    yield return $"{item.GetCategory()}/{item.GetDescription()}";
                }
            }
        }

        [SerializeReference]
        public List<BaseScriptweenMethodOption> Options;

        public void AddOption(string selectedOption)
        {
            if (selectedOption == "(select)") return;
            var selectedType = _optionClassList.First(x => $"{x.GetCategory()}/{x.GetDescription()}" == selectedOption);

            if (selectedType.IsSubclassOf(typeof(BaseScriptweenMethodOption)))
            {
                if (Options == null)
                {
                    Options = new List<BaseScriptweenMethodOption>();
                }

                Options.Add(Activator.CreateInstance(selectedType) as BaseScriptweenMethodOption);
            }
        }
    }
}
