using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace LD53
{
    public class Interactor : MonoBehaviour, IInteractor
    {
        List<IInteractable> _interactables;

        [SerializeField]
        protected float range = 1;
        // Start is called before the first frame update
        void Start()
        {
            _interactables = new List<IInteractable>();
        }

        // Update is called once per frame
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                for (int i = 0; i < _interactables.Count; i++)
                {
                    string interactorName = _interactables[i].ToString();
                    InteractionDef[] interactions = _interactables[i].GetInteractions(this);
                    for (int j = 0; j < interactions.Length; j++)
                    {
                        InteractionDef def = interactions[j];
                        Log.Debug($"{interactorName}: [{def.interactionID}] {def.interactionName} -> {def.interactionDescription}".ToString());
                    }
                }

            }
        }

        void OnTriggerEnter(Collider col)
        {
            IInteractable interactable = col.gameObject.GetComponent<IInteractable>();
            if (interactable != null)
            {
                interactable.BecomeInteractable();
                AddInteractable(interactable);
            }
        }

        void OnTriggerExit(Collider col)
        {
            IInteractable interactable = col.gameObject.GetComponent<IInteractable>();
            if (interactable != null)
            {
                interactable.BecomeUninteractable();
                RemoveInteractable(interactable);
            }
        }

        public List<IInteractable> GetInteractables()
        {
            return _interactables;
        }
        public bool AddInteractable(IInteractable interactable)
        {
            if (!_interactables.Contains(interactable))
            {
                _interactables.Add(interactable);
                return true;
            }
            return false;
        }
        public bool RemoveInteractable(IInteractable interactable)
        {
            if (_interactables.Contains(interactable))
            {
                _interactables.Remove(interactable);
                return true;
            }
            return false;
        }
    }

}
