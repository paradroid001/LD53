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
    public class InteractionDef
    {
        public string interactionName;
        public string interactionDescription;
        public int interactionID;
    }
    public interface IInteractable
    {
        public InteractionDef[] GetInteractions(IInteractor interactor);
        public bool Interact(IInteractor interactor, int interactionID); //'select' the interaction
        public bool CancelInteraction(IInteractor interactor, int interactionID);
        public InteractionState GetInteractionState(IInteractor interactor, int interactionID);
        public void BecomeInteractable();
        public void BecomeUninteractable();
    }

}
