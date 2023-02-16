using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemInteractable : Interactable
{
    public Renderer objectRenderer;
    public Item item;
    
   public override void Interact()
    {
        base.Interact();
        ItemManager.Instance.OnItemPickup(item);
        gameObject.SetActive(false);
        transform.SetParent(ItemManager.Instance.transform);
        
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
