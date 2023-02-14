using System;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using DG.Tweening.Plugins.Core.PathCore;

namespace Scriptweener
{
    [System.ComponentModel.Description("DOBlendableLocalMoveBy")]
    [MethodDefinition("DOBlendableLocalMoveBy", typeof(ShortcutExtensions), typeof(Transform), typeof(Vector3), typeof(Single), typeof(Boolean))]
    [Serializable]
    public class DOBlendableLocalMoveByScriptween : BaseScriptweenMethod
    {
        public Vector3 byValue;
        public Single duration;
        public Boolean snapping;
    }
}