using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace LD53
{
    [System.Serializable]
    public struct ItemDetails
    {
        public string name;
        public string description;
    }

    public class Item : MonoBehaviour, IInteractable
    {
        public InteractionDef[] interactions;
        
        [SerializeField]
        protected ItemDetails _itemDetails;
        
        public ItemDetails itemDetails
        {
            get {return _itemDetails;}
        }

        public virtual InteractionDef[] GetInteractions(GameObject interactor)
        {
            return interactions;
        }

        public virtual bool Interact(GameObject interactor, int interactionID)
        {
            Debug.Log("Interacted");
            return true;
        }

        public bool CancelInteraction(GameObject interactor, int interactionID)
        {
            return true;
        }
        public InteractionState GetInteractionState(GameObject interactor, int interactionID)
        {
            return InteractionState.IDLE;
        }

        // Start is called before the first frame update
        void Start()
        {
            
        }

        // Update is called once per frame
        void Update()
        {
            
        }
    }

}
