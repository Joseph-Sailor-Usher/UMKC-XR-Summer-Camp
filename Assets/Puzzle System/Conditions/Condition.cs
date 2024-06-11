using UnityEngine.Events;
using UnityEngine;

namespace PuzzleSystem
{
    public class Condition : MonoBehaviour {
        [SerializeField]
        private bool isMet = false;
        public UnityEvent onBecomesTrue, onStaysTrue, onBecomesFalse, onStaysFalse, onUpdate;
        public bool GetCondition() {
            return isMet;
        }
        public void SetCondition(bool value) {
            onUpdate.Invoke();
            // if condition stays what it is
            if(value == isMet) {
                // If it is true
                if(isMet) {
                    onStaysTrue.Invoke();
                } else {
                    onStaysFalse.Invoke();
                }
            } else {
                isMet = value;
                if(value) {
                    onBecomesFalse.Invoke();
                } else {
                    onBecomesTrue.Invoke();
                }
            }
        }
        public void SetConditionTrue() {
            SetCondition(true);
        }
        public void SetConditionFalse() {
            SetCondition(false);
        }
        public void ToggleCondition() {
            SetCondition(!isMet);
        }
    }
}
