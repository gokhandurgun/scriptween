using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

namespace Scriptweener.Editor
{
    //TODO: Make all popups into this

    //Source: https://www.youtube.com/watch?v=0HHeIUGsuW8&ab_channel=GameDevGuide
    public class StringListSearchProvider : ScriptableObject, ISearchWindowProvider
    {
        private string _label;
        private string[] _items;
        private Action<string> _onSetIndexCallback;

        public void Load(string label, string[] items, Action<string> onSetIndexCallback)
        {
            _label = label;
            _items = items;
            _onSetIndexCallback = onSetIndexCallback;
        }

        public List<SearchTreeEntry> CreateSearchTree(SearchWindowContext context)
        {
            var retVal = new List<SearchTreeEntry>();
            retVal.Add(new SearchTreeGroupEntry(new GUIContent(_label), 0));

            var sortedListItems = _items.ToList();
            sortedListItems.Sort((a, b) =>
            {
                var split1 = a.Split('/');
                var split2 = b.Split('/');
                for (int i = 0; i < split1.Length; i++)
                {
                    if (i >= split2.Length)
                    {
                        return 1;
                    }
                    int value = split1[i].CompareTo(split2[i]);
                    if (value != 0)
                    {
                        if (split1.Length != split2.Length && (i == split1.Length - 1 || i == split2.Length - 1))
                            return split1.Length < split2.Length ? 1 : -1;
                        return value;
                    }
                }

                return 0;
            });

            var groups = new List<string>();
            foreach (var item in sortedListItems)
            {
                var entryTitle = item.Split('/');
                var groupName = string.Empty;
                for (int i = 0; i < entryTitle.Length - 1; i++)
                {
                    groupName += entryTitle[i];
                    if (!groups.Contains(groupName))
                    {
                        retVal.Add(new SearchTreeGroupEntry(new GUIContent(entryTitle[i]), i + 1));
                        groups.Add(groupName);
                    }

                    groupName += "/";
                }

                SearchTreeEntry entry = new SearchTreeEntry(new GUIContent(entryTitle.Last()));
                entry.level = entryTitle.Length;
                entry.userData = entryTitle.Last();
                retVal.Add(entry);
            }

            return retVal;
        }

        public bool OnSelectEntry(SearchTreeEntry SearchTreeEntry, SearchWindowContext context)
        {
            _onSetIndexCallback?.Invoke((string)SearchTreeEntry.userData);
            return true;
        }
    }
}
