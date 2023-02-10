using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerInteract : MonoBehaviour
{
    
    
    private Interactable currentInteractable;
    private void OnTriggerEnter2D(Collider2D other)
    {
        currentInteractable = other.GetComponent<Interactable>();
        Debug.Log("xD");
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        currentInteractable = null;
        
        
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (currentInteractable != null)
            {
                currentInteractable.Interact();
            } 
        } 
    }
}
