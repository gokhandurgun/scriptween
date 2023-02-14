using System;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using DG.Tweening.Plugins.Core.PathCore;

namespace Scriptweener
{
    [System.ComponentModel.Description("DOScale<Transform,Vector3,Single>")]
    [MethodDefinition("DOScale", typeof(ShortcutExtensions), typeof(Transform), typeof(Vector3), typeof(Single))]
    [Serializable]
    public class DOScale1Scriptween : BaseScriptweenMethod
    {
        public Vector3 endValue;
        public Single duration;
    }
}