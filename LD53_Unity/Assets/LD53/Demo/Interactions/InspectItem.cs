using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using LD53;
public class InspectItem : MonoInteractionLogic
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public override bool Interact(IInteractor interactor, IInteractable interactable)
    {
        Log.Debug($"Interact step = INSPECT, interactor = {interactor}, interactable = {interactable}");
        return true;
    }
}
