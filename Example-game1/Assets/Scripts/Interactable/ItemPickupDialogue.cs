using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemPickupDialogue : Interactable
{
    
    public Text Dialogue;

    public override void Interact()
    {
        base.Interact();
        Dialogue.text = "Ooo, Fajny masz miecz.";
        
    }

    public void OnTriggerExit2D(Collider2D other)
    {
        Dialogue.gameObject.SetActive(false);
    }

}
