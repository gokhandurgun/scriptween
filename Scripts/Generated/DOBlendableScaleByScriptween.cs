using System;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using DG.Tweening.Plugins.Core.PathCore;

namespace Scriptweener
{
    [System.ComponentModel.Description("DOBlendableScaleBy")]
    [MethodDefinition("DOBlendableScaleBy", typeof(ShortcutExtensions), typeof(Transform), typeof(Vector3), typeof(Single))]
    [Serializable]
    public class DOBlendableScaleByScriptween : BaseScriptweenMethod
    {
        public Vector3 byValue;
        public Single duration;
    }
}