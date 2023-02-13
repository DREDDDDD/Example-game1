using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Enemy : Character
{
    
    public void AttackPlayer(Player player)
    {
        if (player.isDefending)
        {
            Debug.Log("Player got attacked while defending");
            player.CurrentHealth -= Attack * 0.5f;
            if (player.CurrentHealth <= 0)
            {
                
                player.Dead = true;
            }
            AlreadyMoved = true;
            
        }
        else
        {
            Debug.Log("Player got attacked, and was not defending");
            player.CurrentHealth -= Attack;
            if (player.CurrentHealth <= 0)
            {
                Dead = true;
            }
            AlreadyMoved = true;
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
