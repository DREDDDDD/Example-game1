using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Player : Character
{
    public Player player;
    public bool isDefending;

    public void AttackEnemy(Enemy enemy)
    {
       
        enemy.CurrentHealth -= Attack;
        if(enemy.CurrentHealth <= 0)
        {
            Debug.Log("Enemy dies");
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
