using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace LD53
{
    public enum InteractionState
    {
        IDLE,
        RUNNING,
        FINISHED
    }
    [System.Serializable]
    public struct InteractionDef
    {
        public string interactionName;
        public string interactionDescription;
        public int interactionID;
    }
    public interface IInteractable
    {
        public InteractionDef[] GetInteractions(GameObject interactor);
        public bool Interact(GameObject interactor, int interactionID); //'select' the interaction
        public bool CancelInteraction(GameObject interactor, int interactionID);
        public InteractionState GetInteractionState(GameObject interactor, int interactionID);
    }

}
