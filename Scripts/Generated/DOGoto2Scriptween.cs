using System;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using DG.Tweening.Plugins.Core.PathCore;

namespace Scriptweener
{
    [System.ComponentModel.Description("DOGoto<Component,Single,Boolean>")]
    [MethodDefinition("DOGoto", typeof(ShortcutExtensions), typeof(Component), typeof(Single), typeof(Boolean))]
    [Serializable]
    public class DOGoto2Scriptween : BaseScriptweenMethod
    {
        public Single to;
        public Boolean andPlay;
    }
}