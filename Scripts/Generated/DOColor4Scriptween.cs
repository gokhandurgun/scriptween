using System;
using UnityEngine;
using DG.Tweening;
using DG.Tweening.Plugins.Core.PathCore;

namespace Scriptweener
{
    [System.ComponentModel.Description("DOColor<Material,Color,Single>")]
    [MethodDefinition("DOColor", typeof(ShortcutExtensions), typeof(Material), typeof(Color), typeof(Single))]
    [Serializable]
    public class DOColor4Scriptween : BaseScriptweenMethod
    {
        public Color endValue;
        public Single duration;
    }
}