using System;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using DG.Tweening.Plugins.Core.PathCore;

namespace Scriptweener
{
    [System.ComponentModel.Description("DOBlendableColor<Material,Color,Int32,Single>")]
    [MethodDefinition("DOBlendableColor", typeof(ShortcutExtensions), typeof(Material), typeof(Color), typeof(Int32), typeof(Single))]
    [Serializable]
    public class DOBlendableColor4Scriptween : BaseScriptweenMethod
    {
        public Color endValue;
        public Int32 propertyID;
        public Single duration;
    }
}