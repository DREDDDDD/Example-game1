using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterInteractable : Interactable
{
    
    public Text Dialogue;
    public string[] dialogueOptions = new string[]
    {
        "Siema, mam na sprzeda¿ crack.",
        "Siema, wsm to nie wiem o co chodzi temu ziutowi po lewo.",
        "Co tam u Ciebie s³ychaæ?",
        "Jak tam dzisiaj min¹³ dzieñ?"
    };

    public override void Interact()
    {
        base.Interact();
        int randomIndex = Random.Range(0, dialogueOptions.Length);
        Dialogue.text = dialogueOptions[randomIndex];
        Dialogue.gameObject.SetActive(true);
    }

    public void OnTriggerExit2D(Collider2D other)
    {
        Dialogue.gameObject.SetActive(false);
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
