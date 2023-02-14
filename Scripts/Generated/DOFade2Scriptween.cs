using System;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using DG.Tweening.Plugins.Core.PathCore;

namespace Scriptweener
{
    [System.ComponentModel.Description("DOFade<Material,Single,String,Single>")]
    [MethodDefinition("DOFade", typeof(ShortcutExtensions), typeof(Material), typeof(Single), typeof(String), typeof(Single))]
    [Serializable]
    public class DOFade2Scriptween : BaseScriptweenMethod
    {
        public Single endValue;
        public String property;
        public Single duration;
    }
}