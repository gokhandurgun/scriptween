using System;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using DG.Tweening.Plugins.Core.PathCore;

namespace Scriptweener
{
    [System.ComponentModel.Description("DOFade<SpriteRenderer,Single,Single>")]
    [MethodDefinition("DOFade", typeof(DOTweenModuleSprite), typeof(SpriteRenderer), typeof(Single), typeof(Single))]
    [Serializable]
    public class DOFade4Scriptween : BaseScriptweenMethod
    {
        public Single endValue;
        public Single duration;
    }
}