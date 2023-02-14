using System;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using DG.Tweening.Plugins.Core.PathCore;

namespace Scriptweener
{
    [System.ComponentModel.Description("DORewind<Material,Boolean>")]
    [MethodDefinition("DORewind", typeof(ShortcutExtensions), typeof(Material), typeof(Boolean))]
    [Serializable]
    public class DORewind2Scriptween : BaseScriptweenMethod
    {
        public Boolean includeDelay;
    }
}