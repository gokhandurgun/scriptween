using System;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using DG.Tweening.Plugins.Core.PathCore;

namespace Scriptweener
{
    [System.ComponentModel.Description("DOBlendableRotateBy")]
    [MethodDefinition("DOBlendableRotateBy", typeof(ShortcutExtensions), typeof(Transform), typeof(Vector3), typeof(Single), typeof(RotateMode))]
    [Serializable]
    public class DOBlendableRotateByScriptween : BaseScriptweenMethod
    {
        public Vector3 byValue;
        public Single duration;
        public RotateMode mode;
    }
}