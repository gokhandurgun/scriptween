using System;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using DG.Tweening.Plugins.Core.PathCore;

namespace Scriptweener
{
    [System.ComponentModel.Description("DOBlendableMoveBy")]
    [MethodDefinition("DOBlendableMoveBy", typeof(ShortcutExtensions), typeof(Transform), typeof(Vector3), typeof(Single), typeof(Boolean))]
    [Serializable]
    public class DOBlendableMoveByScriptween : BaseScriptweenMethod
    {
        public Vector3 byValue;
        public Single duration;
        public Boolean snapping;
    }
}