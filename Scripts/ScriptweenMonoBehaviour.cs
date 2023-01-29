using UnityEngine;

namespace Scriptweener
{
    public class ScriptweenMonoBehaviour : MonoBehaviour
    {
        //public ScriptweenEntry Entry;

        //[LabelText("OnAwake")]
        public ScriptweenObserver AwakeCalled;

        // [LabelText("OnStart")]
        // public ScriptweenObserver StartCalled;
        // [LabelText("OnEnable")]
        // public ScriptweenObserver EnableCalled;
        // [LabelText("OnDisable")]
        // public ScriptweenObserver DisableCalled;
        // [LabelText("OnDestroy")]
        // public ScriptweenObserver DestroyCalled;
        protected virtual void Awake()
        {
            //AwakeCalled?.InvokeAll();
        }

        protected virtual void Start()
        {
            // StartCalled?.InvokeAll();
        }

        protected virtual void OnEnable()
        {
            // EnableCalled?.InvokeAll();
        }

        protected virtual void OnDisable()
        {
            // DisableCalled?.InvokeAll();
        }

        protected virtual void OnDestroy()
        {
            // DestroyCalled?.InvokeAll();
        }
    }
}