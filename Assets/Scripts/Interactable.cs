using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Interactable : MonoBehaviour
{
    public bool useEvents;

    // Message displayed to the player when looking at an interactable
    public string promptMessage;

    /// <summary>
    /// This function will be called from our player
    /// </summary>
    public void BaseInteract()
    {
        if (useEvents) 
        { 
            GetComponent<InteractionEvent>().onInteract.Invoke();
        }
        Interact();
    } 

    /// <summary>
    /// This is a template function to be overridden by our subclasses
    /// </summary>
    protected virtual void Interact()
    {

    }
}
