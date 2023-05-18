using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace LD53
{
    [CreateAssetMenu(fileName = "Interaction", menuName = "GameKit/Interaction", order = 1)]

    public class SOInteraction : ScriptableObject
    {
        public InteractionDef definition;
        public MonoInteractionLogic[] interactionSteps;
        public MonoBehaviour[] otherSteps;

        protected void OnEnable()
        {
            //Log.Debug("Interaction got enabled.");
        }

        public MonoInteractionLogic GetInteractionStep(int index)
        {
            if (index >= 0 && index < interactionSteps.Length)
            {
                return interactionSteps[0];
            }
            return null;
        }

        public int GetInteractionStepCount()
        {
            return interactionSteps.Length;
        }

    }
}