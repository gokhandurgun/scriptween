using System;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using DG.Tweening.Plugins.Core.PathCore;

namespace Scriptweener
{
    [System.ComponentModel.Description("DOLocalPath<Transform,Path,Single,PathMode>")]
    [MethodDefinition("DOLocalPath", typeof(ShortcutExtensions), typeof(Transform), typeof(Path), typeof(Single), typeof(PathMode))]
    [Serializable]
    public class DOLocalPath2Scriptween : BaseScriptweenMethod
    {
        public Path path;
        public Single duration;
        public PathMode pathMode;
    }
}