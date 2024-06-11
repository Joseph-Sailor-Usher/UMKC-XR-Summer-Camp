using UnityEngine.Events;
using UnityEngine;

namespace PuzzleSystem
{
    // Require a box collider
    [RequireComponent(typeof(BoxCollider))]
    public class ZoneTrigger : MonoBehaviour
    {
        public UnityEvent onTriggered, onTriggerExit;
        public string triggerObjectTag = "";
        public void Trigger()
        {
            onTriggered.Invoke();
        }
        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag(triggerObjectTag))
                Trigger();
        }
        private void OnTriggerExit(Collider other)
        {
            if (other.CompareTag(triggerObjectTag))
                onTriggerExit.Invoke();
        }
    }
}
