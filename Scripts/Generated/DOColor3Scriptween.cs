using System;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using DG.Tweening.Plugins.Core.PathCore;

namespace Scriptweener
{
    [System.ComponentModel.Description("DOColor<LineRenderer,Color2,Color2,Single>")]
    [MethodDefinition("DOColor", typeof(ShortcutExtensions), typeof(LineRenderer), typeof(Color2), typeof(Color2), typeof(Single))]
    [Serializable]
    public class DOColor3Scriptween : BaseScriptweenMethod
    {
        public Color2 startValue;
        public Color2 endValue;
        public Single duration;
    }
}