using System;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using DG.Tweening.Plugins.Core.PathCore;

namespace Scriptweener
{
    [System.ComponentModel.Description("DOFade<Material,Single,Single>")]
    [MethodDefinition("DOFade", typeof(ShortcutExtensions), typeof(Material), typeof(Single), typeof(Single))]
    [Serializable]
    public class DOFade1Scriptween : BaseScriptweenMethod
    {
        public Single endValue;
        public Single duration;
    }
}