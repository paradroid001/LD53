using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace LD53
{
    public class MonoItem : MonoBehaviour, IInteractable
    {
        [SerializeField]
        protected ItemDetails _itemDetails;
        public ItemDetails itemDetails
        {
            get { return _itemDetails; }
        }
        public SOInteraction[] itemInteractions;
        // Start is called before the first frame update

        protected SOInteraction GetInteractionWithID(int id)
        {
            for (int i = 0; i < itemInteractions.Length; i++)
            {
                SOInteraction interaction = itemInteractions[i];
                if (interaction.definition.interactionID == id)
                {
                    return interaction;
                }
            }
            return null;
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
            SOInteraction interaction = GetInteractionWithID(interactionID);
            if (interaction != null)
            {
                int steps = interaction.GetInteractionStepCount();
                for (int i = 0; i < steps; i++)
                {
                    MonoInteractionLogic step = interaction.GetInteractionStep(i);
                    step.Interact(interactor, this);
                }
            }

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

        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}