using System;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using DG.Tweening.Plugins.Core.PathCore;

namespace Scriptweener
{
    [System.ComponentModel.Description("DOGradientColor<SpriteRenderer,Gradient,Single>")]
    [MethodDefinition("DOGradientColor", typeof(DOTweenModuleSprite), typeof(SpriteRenderer), typeof(Gradient), typeof(Single))]
    [Serializable]
    public class DOGradientColor1Scriptween : BaseScriptweenMethod
    {
        public Gradient gradient;
        public Single duration;
    }
}