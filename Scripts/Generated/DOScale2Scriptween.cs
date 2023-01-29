using System;
using UnityEngine;
using DG.Tweening;
using DG.Tweening.Plugins.Core.PathCore;

namespace Scriptweener
{
    [System.ComponentModel.Description("DOScale<Transform,Single,Single>")]
    [MethodDefinition("DOScale", typeof(ShortcutExtensions), typeof(Transform), typeof(Single), typeof(Single))]
    [Serializable]
    public class DOScale2Scriptween : BaseScriptweenMethod
    {
        public Single endValue;
        public Single duration;
    }
}