using System;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using DG.Tweening.Plugins.Core.PathCore;

namespace Scriptweener
{
    [System.ComponentModel.Description("DOTiling<Material,Vector2,String,Single>")]
    [MethodDefinition("DOTiling", typeof(ShortcutExtensions), typeof(Material), typeof(Vector2), typeof(String), typeof(Single))]
    [Serializable]
    public class DOTiling2Scriptween : BaseScriptweenMethod
    {
        public Vector2 endValue;
        public String property;
        public Single duration;
    }
}