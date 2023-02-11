using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeverChangePCStats : Interactable
{
    private float speed;
    public PlayerController controller;

    public override void Interact()
    {
        base.Interact();
        controller.speed = controller.speed * 2;
        Debug.Log("lol");
    }
}
