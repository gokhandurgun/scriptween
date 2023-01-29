using System;
using UnityEngine;
using DG.Tweening;
using DG.Tweening.Plugins.Core.PathCore;

namespace Scriptweener
{
    [System.ComponentModel.Description("DOComplete<Component,Boolean>")]
    [MethodDefinition("DOComplete", typeof(ShortcutExtensions), typeof(Component), typeof(Boolean))]
    [Serializable]
    public class DOComplete1Scriptween : BaseScriptweenMethod
    {
        public Boolean withCallbacks;
    }
}