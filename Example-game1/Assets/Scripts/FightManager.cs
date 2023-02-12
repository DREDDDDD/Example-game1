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
            return false ;
        }
        return true ;
        
    }
    

    private void StartNewTurn()
    {
        Debug.Log("Starting new turn");

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
        panel.SetActive(true);
        player.isDefending = false;
        
    }
    private void StartEnemyTurn(Enemy enemy)
    {
        Debug.Log("Starting enemy turn");
        enemy.AttackPlayer(player);
        StartNewTurn();
       
    }
    private void EndPlayerTurn()
    {
        Debug.Log("Ending player turn");
        panel.SetActive(false);
        StartNewTurn();
        
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
