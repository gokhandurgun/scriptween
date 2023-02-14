using System;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using DG.Tweening.Plugins.Core.PathCore;

namespace Scriptweener
{
    [System.ComponentModel.Description("DOBlendableColor<SpriteRenderer,Color,Single>")]
    [MethodDefinition("DOBlendableColor", typeof(DOTweenModuleSprite), typeof(SpriteRenderer), typeof(Color), typeof(Single))]
    [Serializable]
    public class DOBlendableColor5Scriptween : BaseScriptweenMethod
    {
        public Color endValue;
        public Single duration;
    }
}