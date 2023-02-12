using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class LeverDestroyInteract : Interactable
{

    public Text ItemBreakDialogue;
    public override void Interact()
    {
        OnInteractDo.Invoke();
        ItemBreakDialogue.text = "D�wignia si� zniszczy�a.";
    }
    public void OnTriggerExit2D(Collider2D other)
    {
        ItemBreakDialogue.gameObject.SetActive(false);
        Destroy(gameObject);
    }
}
