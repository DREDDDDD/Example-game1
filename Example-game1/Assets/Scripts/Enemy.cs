using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : Character
{
    public void AttackPlayer(Player player)
    {
        player.CurrentHealth -= Attack;
        AlreadyMoved = true;
        Debug.Log("Player got Attacked");
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
