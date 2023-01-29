using System;
using UnityEngine;
using DG.Tweening;
using DG.Tweening.Plugins.Core.PathCore;

namespace Scriptweener
{
    [System.ComponentModel.Description("DOColor<Material,Color,Int32,Single>")]
    [MethodDefinition("DOColor", typeof(ShortcutExtensions), typeof(Material), typeof(Color), typeof(Int32), typeof(Single))]
    [Serializable]
    public class DOColor6Scriptween : BaseScriptweenMethod
    {
        public Color endValue;
        public Int32 propertyID;
        public Single duration;
    }
}