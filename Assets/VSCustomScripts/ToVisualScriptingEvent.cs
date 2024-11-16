using UnityEngine;
using Unity.VisualScripting;

namespace VSCustomScripts
{
    /// <summary>
    /// Can be placed on a script machine or state machine,
    /// or you can specify a target script machine or state machine to trigger a custom event.
    /// </summary>
    public class ToVisualScriptingEvent : MonoBehaviour
    {
        [SerializeField, Tooltip("The Script Machine or State Machine with the Custom Funciton to be triggered")]
        private GameObject scriptMachine = null;

        private void Awake()
        {
            if (scriptMachine == null)
            {
                scriptMachine = gameObject;
            }
        }

        public void TriggerEvent(string eventName)
        {
            CustomEvent.Trigger(scriptMachine, eventName);
        }
    }
}
