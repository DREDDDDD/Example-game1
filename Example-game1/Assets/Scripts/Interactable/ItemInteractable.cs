using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemInteractable : Interactable
{
    public Renderer objectRenderer;
    public Color newColor;
   public override void Interact()
    {
        base.Interact();
        Destroy(gameObject);
        objectRenderer.material.color = newColor;
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
