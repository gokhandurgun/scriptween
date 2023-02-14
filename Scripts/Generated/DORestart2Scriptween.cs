using System;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using DG.Tweening.Plugins.Core.PathCore;

namespace Scriptweener
{
    [System.ComponentModel.Description("DORestart<Material,Boolean>")]
    [MethodDefinition("DORestart", typeof(ShortcutExtensions), typeof(Material), typeof(Boolean))]
    [Serializable]
    public class DORestart2Scriptween : BaseScriptweenMethod
    {
        public Boolean includeDelay;
    }
}