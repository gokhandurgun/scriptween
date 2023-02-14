using System;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using DG.Tweening.Plugins.Core.PathCore;

namespace Scriptweener
{
    [System.ComponentModel.Description("DOAnchorPos3D")]
    [MethodDefinition("DOAnchorPos3D", typeof(DOTweenModuleUI), typeof(RectTransform), typeof(Vector3), typeof(Single), typeof(Boolean))]
    [Serializable]
    public class DOAnchorPos3DScriptween : BaseScriptweenMethod
    {
        public Vector3 endValue;
        public Single duration;
        public Boolean snapping;
    }
}