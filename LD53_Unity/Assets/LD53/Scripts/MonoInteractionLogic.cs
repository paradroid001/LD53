using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace LD53
{
    public class MonoInteractionLogic : MonoBehaviour
    {
        public virtual bool Interact(IInteractor interactor, IInteractable interactable)
        {
            //override me.
            return false;
        }
    }
}