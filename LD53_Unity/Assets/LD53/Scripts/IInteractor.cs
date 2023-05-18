using System.Collections;
using System.Collections.Generic;

namespace LD53
{
    public interface IInteractor
    {
        public List<IInteractable> GetInteractables();
        public bool AddInteractable(IInteractable interactable);
        public bool RemoveInteractable(IInteractable interactable);
    }
}