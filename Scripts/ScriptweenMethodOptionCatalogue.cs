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
        private static List<Type> m_OptionClassList =
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
                yield return "(select)";

                var currentCategories = Options?.Select(x => x.GetType().GetCategory()).Distinct() ?? Enumerable.Empty<string>();

                for (var i = 0; i < m_OptionClassList.Count; i++)
                {
                    var item = m_OptionClassList[i];
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
            var selectedType = m_OptionClassList.First(x => $"{x.GetCategory()}/{x.GetDescription()}" == selectedOption);

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
