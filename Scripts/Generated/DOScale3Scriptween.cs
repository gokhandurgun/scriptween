using System;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using DG.Tweening.Plugins.Core.PathCore;

namespace Scriptweener
{
    [System.ComponentModel.Description("DOScale<Outline,Vector2,Single>")]
    [MethodDefinition("DOScale", typeof(DOTweenModuleUI), typeof(Outline), typeof(Vector2), typeof(Single))]
    [Serializable]
    public class DOScale3Scriptween : BaseScriptweenMethod
    {
        public Vector2 endValue;
        public Single duration;
    }
}