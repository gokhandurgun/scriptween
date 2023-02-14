using System;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using DG.Tweening.Plugins.Core.PathCore;

namespace Scriptweener
{
    [System.ComponentModel.Description("DORestart<Component,Boolean>")]
    [MethodDefinition("DORestart", typeof(ShortcutExtensions), typeof(Component), typeof(Boolean))]
    [Serializable]
    public class DORestart1Scriptween : BaseScriptweenMethod
    {
        public Boolean includeDelay;
    }
}