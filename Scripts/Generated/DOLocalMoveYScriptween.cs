using System;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using DG.Tweening.Plugins.Core.PathCore;

namespace Scriptweener
{
    [System.ComponentModel.Description("DOLocalMoveY")]
    [MethodDefinition("DOLocalMoveY", typeof(ShortcutExtensions), typeof(Transform), typeof(Single), typeof(Single), typeof(Boolean))]
    [Serializable]
    public class DOLocalMoveYScriptween : BaseScriptweenMethod
    {
        public Single endValue;
        public Single duration;
        public Boolean snapping;
    }
}