using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Scriptweener;
using DG.Tweening;

namespace Scriptweener.Examples
{
    public class ExBarrier : MonoBehaviour
    {
        [SerializeField]
        private Scriptween m_EnterTween;

        [SerializeField]
        private Scriptween m_ExitTween;

        [SerializeField]
        private Transform m_Renderer;

        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }

        private void OnTriggerEnter(Collider other)
        {
            DOTween.Kill(this);
            m_EnterTween.Play(m_Renderer).SetId(this);
        }

        private void OnTriggerExit(Collider other)
        {
            DOTween.Kill(this);
            m_ExitTween.Play(m_Renderer).SetId(this);
        }
    }
}