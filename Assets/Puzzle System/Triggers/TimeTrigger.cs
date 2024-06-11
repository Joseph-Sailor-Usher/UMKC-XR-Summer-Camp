using UnityEngine.Events;
using System.Collections;
using UnityEngine;

namespace PuzzleSystem
{
    public class TimeTrigger : MonoBehaviour
    {
        [SerializeField]
        private bool triggerEnabled = true;
        public float SecondsBetweenTriggers = 1f;
        private IEnumerator triggerCoroutine;
        public UnityEvent onTimerStarted, onTimerStopped, onTriggered;
        private void Start()
        {
            InitializeTriggerCoroutine();
            StartTimer();
        }
        private void InitializeTriggerCoroutine()
        {
            if (triggerCoroutine != null) return;
            triggerCoroutine = TriggerCoroutine();
        }
        public void SetTimer(bool value)
        {
            if (value)
            {
                StartCoroutine(triggerCoroutine);
                onTimerStarted.Invoke();
            }
            else
            {
                StopCoroutine(triggerCoroutine);
                onTimerStopped.Invoke();
            }
        }
        public void StartTimer()
        {
            SetTimer(true);
        }
        public void StopTimer()
        {
            SetTimer(false);
        }
        public void Trigger()
        {
            onTriggered.Invoke();
        }
        public bool GetIsTriggerEnabled()
        {
            return triggerEnabled;
        }
        public void SetIsTriggerEnabled(bool value)
        {
            triggerEnabled = value;
            StopCoroutine(triggerCoroutine);

            if (value == true)
            {
                triggerCoroutine = TriggerCoroutine();
                StartCoroutine(triggerCoroutine);
            }
        }
        private IEnumerator TriggerCoroutine()
        {
            while (triggerEnabled)
            {
                yield return new WaitForSeconds(SecondsBetweenTriggers);
                Trigger();
                // Debug.Log("Triggering: " + gameObject.name);
            }
        }
    }
}
