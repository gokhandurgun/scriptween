using System;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using DG.Tweening.Plugins.Core.PathCore;

namespace Scriptweener
{
    [System.ComponentModel.Description("DOBlendableColor<Graphic,Color,Single>")]
    [MethodDefinition("DOBlendableColor", typeof(DOTweenModuleUI), typeof(Graphic), typeof(Color), typeof(Single))]
    [Serializable]
    public class DOBlendableColor6Scriptween : BaseScriptweenMethod
    {
        public Color endValue;
        public Single duration;
    }
}