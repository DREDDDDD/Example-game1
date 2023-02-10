using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ItemInteractable1 : Interactable
{

    public Sprite newSprite;

    public override void Interact()
    {
        base.Interact();
        SpriteRenderer spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer.sprite = newSprite;
    }
}

