using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HpItem : Item
{
    public float Hp;

    public override void Use()
    {
        ItemManager.Instance.player.CurrentHealth += Hp;
        if (ItemManager.Instance.player.CurrentHealth>ItemManager.Instance.player.MaxHealth)
        {
            ItemManager.Instance.player.CurrentHealth = ItemManager.Instance.player.MaxHealth;
        }
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
