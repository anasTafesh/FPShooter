using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Interactable : MonoBehaviour
{
    public bool useEvents;
    [SerializeField]
    public string promptMessage;
    // Start is called before the first frame update
    public virtual string OnLook()
    {
        return promptMessage;
    }
    public void BaseInteract ()
    {
        if (useEvents)
            GetComponent<InteractionEvent>().onInteract.Invoke();
        Interact();
    }
protected virtual void Interact()
    {

    }
}
