using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FightManager : MonoBehaviour
{
    public Player player;
    public List<Enemy> enemies;
    public GameObject panel;
    
    
    

    public void Attack()
    {
        Debug.Log("Player Attacked");
        player.AlreadyMoved = true;
        player.AttackEnemy(enemies[0]);
        EndPlayerTurn();
    }
    public void Defend()
    {
        Debug.Log("Player Defending");
        player.AlreadyMoved = true;
        player.isDefending = true;
        EndPlayerTurn();

        
    }

    
    

    private bool CheckWinCondition()
    {
        Debug.Log("Checking win condition");
        foreach (Enemy enemy in enemies)
        {
            if (!enemy.Dead)
            {
                return false;
            }
        }
        return true;
        
    }

    private bool CheckLoseCondition()
    {
        Debug.Log("Checking lose condition");
        if (!player.Dead)
        {
            return false;
        }
        return true;
        
    }



    private void StartNewTurn()
    {
        Debug.Log("Starting new turn");
        if (EveryoneFinished())//jezeli wszyscy skonczyli 
        {
            //odswiezamy ruch
            enemies[0].AlreadyMoved = false;
            player.AlreadyMoved = false;
        }

        DecideTurnOrder();//rozdajemy tury w odpowiedniej kolejnosci
    }

    private bool EveryoneFinished()
    {
        if (player.AlreadyMoved)
        {
            if (enemies[0].AlreadyMoved)
            {
                return true;
            }
        }
        return false;
    }

    private void DecideTurnOrder()
    {
        //proownujemy incijatywy
        //ponizsze rozwiazanie jest tylko chwilowe i player zawsze ma pierwszenstwo nad przeciwnikiem
        if (player.AlreadyMoved)
        {
            if (!enemies[0].AlreadyMoved)
            {
                StartEnemyTurn(enemies[0]);
            }
        }
        else StartPlayerTurn();
    }

    private void StartPlayerTurn()
    {
        Debug.Log("Starting player turn");
        player.isDefending = false;
        panel.SetActive(true);
    }
    private void StartEnemyTurn(Enemy enemy)
    {
        
        Debug.Log("Starting enemy turn");
        enemy.AttackPlayer(player);
        if (CheckLoseCondition())
        {
            Debug.Log("Player dead, you lost");
            return;
        }
        else StartNewTurn();

    }
    private void EndPlayerTurn()
    {
        Debug.Log("Ending player turn");
        panel.SetActive(false);
        if (CheckWinCondition())
        {
            Debug.Log("Enemy dead, you win!");
            return;
            
        }
        else StartNewTurn();
        
        
    }
    
    public void StartFight()
    {
        StartNewTurn();
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
