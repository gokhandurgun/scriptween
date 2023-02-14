using System;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using DG.Tweening.Plugins.Core.PathCore;

namespace Scriptweener
{
    [System.ComponentModel.Description("DOOffset<Material,Vector2,String,Single>")]
    [MethodDefinition("DOOffset", typeof(ShortcutExtensions), typeof(Material), typeof(Vector2), typeof(String), typeof(Single))]
    [Serializable]
    public class DOOffset2Scriptween : BaseScriptweenMethod
    {
        public Vector2 endValue;
        public String property;
        public Single duration;
    }
}