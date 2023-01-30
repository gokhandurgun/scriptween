using UnityEngine;

namespace Scriptweener
{
    public class ScriptweenMonoBehaviour : MonoBehaviour
    {
        public ScriptweenObserver AwakeTweens;
        public ScriptweenObserver StartTweens;
        public ScriptweenObserver EnableTweens;
        public ScriptweenObserver DisableTweens;
        public ScriptweenObserver DestroyTweens;

        protected virtual void Awake()
        {
            AwakeTweens?.InvokeAll();
        }

        protected virtual void Start()
        {
            StartTweens?.InvokeAll();
        }

        protected virtual void OnEnable()
        {
            EnableTweens?.InvokeAll();
        }

        protected virtual void OnDisable()
        {
            DisableTweens?.InvokeAll();
        }

        protected virtual void OnDestroy()
        {
            DestroyTweens?.InvokeAll();
        }
    }
}