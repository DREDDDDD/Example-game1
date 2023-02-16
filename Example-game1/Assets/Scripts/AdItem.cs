using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdItem : Item
{
    public float Attack;

    public override void Use()
    {
        ItemManager.Instance.player.Attack += Attack;
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
