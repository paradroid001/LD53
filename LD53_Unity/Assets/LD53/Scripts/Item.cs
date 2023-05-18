using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace LD53
{
    [System.Serializable]
    public struct ItemDetails
    {
        public string name;
        public string description;
    }

    [System.Serializable]
    public class ItemInteractions
    {
        public InteractionDef definition;
        public UnityEvent callback;
    }

    public class Item : MonoBehaviour, IInteractable
    {
        public ItemInteractions[] itemInteractions;

        [SerializeField]
        protected ItemDetails _itemDetails;

        public ItemDetails itemDetails
        {
            get { return _itemDetails; }
        }

        public virtual InteractionDef[] GetInteractions(IInteractor interactor)
        {
            InteractionDef[] interactions = new InteractionDef[itemInteractions.Length];
            for (int i = 0; i < itemInteractions.Length; i++)
            {
                interactions[i] = itemInteractions[i].definition;
            }
            Debug.Log(interactions);
            return interactions;
        }

        public virtual bool Interact(IInteractor interactor, int interactionID)
        {
            Log.Debug("Interacted: interactor = " + interactor + " interaction ID = " + interactionID);
            //Debug.Log("Interacted");
            return true;
        }

        public bool CancelInteraction(IInteractor interactor, int interactionID)
        {
            return true;
        }
        public InteractionState GetInteractionState(IInteractor interactor, int interactionID)
        {
            return InteractionState.IDLE;
        }

        public void BecomeInteractable()
        {
            Log.Debug("Became Interactable " + gameObject);
            Log.Debug(gameObject.ToString());
            Debug.Log(gameObject);
        }
        public void BecomeUninteractable()
        {
            Log.Debug("Became Uninteractable");
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
