using System;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using DG.Tweening.Plugins.Core.PathCore;

namespace Scriptweener
{
    [System.ComponentModel.Description("DOColor<Material,Color,String,Single>")]
    [MethodDefinition("DOColor", typeof(ShortcutExtensions), typeof(Material), typeof(Color), typeof(String), typeof(Single))]
    [Serializable]
    public class DOColor5Scriptween : BaseScriptweenMethod
    {
        public Color endValue;
        public String property;
        public Single duration;
    }
}