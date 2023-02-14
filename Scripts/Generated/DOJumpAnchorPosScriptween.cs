using System;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using DG.Tweening.Plugins.Core.PathCore;

namespace Scriptweener
{
    [System.ComponentModel.Description("DOJumpAnchorPos")]
    [MethodDefinition("DOJumpAnchorPos", typeof(DOTweenModuleUI), typeof(RectTransform), typeof(Vector2), typeof(Single), typeof(Int32), typeof(Single), typeof(Boolean))]
    [Serializable]
    public class DOJumpAnchorPosScriptween : BaseScriptweenMethod
    {
        public Vector2 endValue;
        public Single jumpPower;
        public Int32 numJumps;
        public Single duration;
        public Boolean snapping;
    }
}