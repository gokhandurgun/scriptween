using System;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using DG.Tweening.Plugins.Core.PathCore;

namespace Scriptweener
{
    [System.ComponentModel.Description("DOColor<SpriteRenderer,Color,Single>")]
    [MethodDefinition("DOColor", typeof(DOTweenModuleSprite), typeof(SpriteRenderer), typeof(Color), typeof(Single))]
    [Serializable]
    public class DOColor7Scriptween : BaseScriptweenMethod
    {
        public Color endValue;
        public Single duration;
    }
}