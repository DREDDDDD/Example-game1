using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Player : Character
{
    public Player player;
    public FightManager fightManager;
    public bool isDefending;
    public bool canMove = true;
    

    public void AttackEnemy(Enemy enemy)
    {
        if(enemy == null)
        {
            return;
        }
       
        enemy.CurrentHealth -= Attack;
        if(enemy.CurrentHealth <= 0)
        {
            enemy.Dead = true;
        }
        AlreadyMoved = true;
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
