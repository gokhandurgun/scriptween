using System;
using System.Collections.Generic;
using System.Linq;
using DG.Tweening;
using UnityEngine;

namespace Scriptweener
{
    [Serializable]
    public class SequenceScriptween : IScriptween
    {
        public ScriptweenMethodOptionCatalogue OptionCatalogue => _optionCatalogue;

        public List<SequenceScriptweenEntry> Entries;

        [SerializeField] private ScriptweenMethodOptionCatalogue _optionCatalogue;

        public Sequence Play()
        {
            if (Entries == null || !Entries.Any())
            {
                Debug.LogError("Sequence entries is empty");
                return null;
            }
            
            var sequence = DOTween.Sequence();

            foreach (var e in Entries)
            {
                Next(sequence, e);
            }
            
            foreach (var option in _optionCatalogue.Options)
            {
                option.Apply(sequence);
            }
            
            return sequence;
        }

        private void Next(Sequence sequence, SequenceScriptweenEntry entry)
        {
            switch (entry.EntryMethod)
            {
                case SequenceScriptweenEntryMethod.Append:
                    sequence.Append(entry.Scriptween.EntryOptions.PlayTween(entry.Scriptween.Scriptween));
                    break;
                case SequenceScriptweenEntryMethod.Prepend:
                    sequence.Prepend(entry.Scriptween.EntryOptions.PlayTween(entry.Scriptween.Scriptween));
                    break;
                case SequenceScriptweenEntryMethod.Join:
                    sequence.Join(entry.Scriptween.EntryOptions.PlayTween(entry.Scriptween.Scriptween));
                    break;
                case SequenceScriptweenEntryMethod.Insert:
                    sequence.Insert(entry.AtPosition, entry.Scriptween.EntryOptions.PlayTween(entry.Scriptween.Scriptween));
                    break;
                case SequenceScriptweenEntryMethod.AppendInterval:
                    sequence.AppendInterval(entry.Interval);
                    break;
                case SequenceScriptweenEntryMethod.PrependInterval:
                    sequence.PrependInterval(entry.Interval);
                    break;
                case SequenceScriptweenEntryMethod.AppendCallback:
                    sequence.AppendCallback(() => entry.Callback.Invoke());
                    break;
                case SequenceScriptweenEntryMethod.PrependCallback:
                    sequence.PrependCallback(() => entry.Callback.Invoke());
                    break;
                case SequenceScriptweenEntryMethod.InsertCallback:
                    sequence.InsertCallback(entry.AtPosition, () => entry.Callback.Invoke());
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
    }
}