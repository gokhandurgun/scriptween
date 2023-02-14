using System;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using DG.Tweening.Plugins.Core.PathCore;

namespace Scriptweener
{
    [System.ComponentModel.Description("DOFloat<Material,Single,String,Single>")]
    [MethodDefinition("DOFloat", typeof(ShortcutExtensions), typeof(Material), typeof(Single), typeof(String), typeof(Single))]
    [Serializable]
    public class DOFloat1Scriptween : BaseScriptweenMethod
    {
        public Single endValue;
        public String property;
        public Single duration;
    }
}