using System;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using DG.Tweening.Plugins.Core.PathCore;

namespace Scriptweener
{
    [System.ComponentModel.Description("DOGradientColor<Image,Gradient,Single>")]
    [MethodDefinition("DOGradientColor", typeof(DOTweenModuleUI), typeof(Image), typeof(Gradient), typeof(Single))]
    [Serializable]
    public class DOGradientColor2Scriptween : BaseScriptweenMethod
    {
        public Gradient gradient;
        public Single duration;
    }
}