using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedItem : Item
{
    public float speed;

    public override void Use()
    {
        ItemManager.Instance.player.Incentive += speed;
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
