using System;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using DG.Tweening.Plugins.Core.PathCore;

namespace Scriptweener
{
    [System.ComponentModel.Description("DOBlendableLocalRotateBy")]
    [MethodDefinition("DOBlendableLocalRotateBy", typeof(ShortcutExtensions), typeof(Transform), typeof(Vector3), typeof(Single), typeof(RotateMode))]
    [Serializable]
    public class DOBlendableLocalRotateByScriptween : BaseScriptweenMethod
    {
        public Vector3 byValue;
        public Single duration;
        public RotateMode mode;
    }
}