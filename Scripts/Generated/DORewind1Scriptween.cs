using System;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using DG.Tweening.Plugins.Core.PathCore;

namespace Scriptweener
{
    [System.ComponentModel.Description("DORewind<Component,Boolean>")]
    [MethodDefinition("DORewind", typeof(ShortcutExtensions), typeof(Component), typeof(Boolean))]
    [Serializable]
    public class DORewind1Scriptween : BaseScriptweenMethod
    {
        public Boolean includeDelay;
    }
}