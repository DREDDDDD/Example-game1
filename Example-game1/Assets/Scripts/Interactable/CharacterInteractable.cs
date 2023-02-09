using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterInteractable : Interactable 
{  
    public Text Dialogue;
    
    public override void Interact()
    {
        base.Interact();
        Dialogue.text = "Siema, mam na sprzeda¿ crack.";
        
        

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
