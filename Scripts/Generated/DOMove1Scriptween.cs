using System;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using DG.Tweening.Plugins.Core.PathCore;

namespace Scriptweener
{
    [System.ComponentModel.Description("DOMove<Transform,Vector3,Single,Boolean>")]
    [MethodDefinition("DOMove", typeof(ShortcutExtensions), typeof(Transform), typeof(Vector3), typeof(Single), typeof(Boolean))]
    [Serializable]
    public class DOMove1Scriptween : BaseScriptweenMethod
    {
        public Vector3 endValue;
        public Single duration;
        public Boolean snapping;
    }
}