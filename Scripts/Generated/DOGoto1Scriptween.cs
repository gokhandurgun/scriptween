using System;
using UnityEngine;
using DG.Tweening;
using DG.Tweening.Plugins.Core.PathCore;

namespace Scriptweener
{
    [System.ComponentModel.Description("DOGoto<Component,Single,Boolean>")]
    [MethodDefinition("DOGoto", typeof(ShortcutExtensions), typeof(Component), typeof(Single), typeof(Boolean))]
    [Serializable]
    public class DOGoto1Scriptween : BaseScriptweenMethod
    {
        public Single to;
        public Boolean andPlay;
    }
}