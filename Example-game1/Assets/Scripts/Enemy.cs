using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Enemy : Character
{
    private float ReducedAttack;
    public void AttackPlayer(Player player)
    {
        if (player.isDefending)
        {
            Debug.Log("Player got attacked while defending");
            ReducedAttack = Attack - player.Armor;
            if (ReducedAttack <= 0)
            {
                ReducedAttack = 0;
            }
            player.CurrentHealth -= ReducedAttack * 0.5f;
            



            if (player.CurrentHealth <= 0)
            {
                
                player.Dead = true;
            }
            AlreadyMoved = true;
            
        }
        else
        {
            Debug.Log("Player got attacked, and was not defending");
            ReducedAttack = Attack - player.Armor;
            if (ReducedAttack <= 0)
            {
                ReducedAttack=0;
            }
            player.CurrentHealth -= ReducedAttack;
            
            
            if (player.CurrentHealth <= 0)
            {
                player.Dead = true;
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
