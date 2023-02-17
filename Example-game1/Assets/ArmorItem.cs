using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmorItem : Item
{
    public float Armor;

    public override void Use()
    {
        ItemManager.Instance.player.Armor += Armor;
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
