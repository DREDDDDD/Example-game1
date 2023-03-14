using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FightManager : MonoBehaviour
{
    public Player player;
    public List<Enemy> enemies;
    public GameObject panel;
    public PlayerController playerController;
    public Enemy enemy;
    public GameObject MainCamera;
    public GameObject BattleCamera;
    public GameObject EnemyBattleSpot;
    public GameObject PlayerBattleSpot;
    public Transform PositionPlaceHolder;
    
    


    
    

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
        Debug.Log("Checking win condition");    //sprawdzamy WinCondition, Dla ka¿dego enemy w Klasie Enemy z listy enemies[] sprawdza czy jest martwy
        foreach (Enemy enemy in enemies)        //jeœli tak, zwraca true jeœli enemy nie jest dead zwraca false
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
        Debug.Log("Checking lose condition"); //sprawdzamy LoseCondition, jeœli player nie jest dead, zwraca false
        if (!player.Dead)                     //a jeœli jest zaznaczony Dead to zwraca true
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
        if (player.AlreadyMoved && enemies[0].AlreadyMoved)
        {
            StartNewTurn();
            return;
        }

        // Compare incentives of player and enemy
        if (player.Incentive >= enemies[0].Incentive)
        {
            // Player goes first
            if (player.AlreadyMoved)
            {
                StartEnemyTurn(enemies[0]);
            }
            else
            {
                StartPlayerTurn();
            }
        }
        else
        {
            // Enemy goes first
            if (enemies[0].AlreadyMoved)
            {
                StartPlayerTurn();
            }
            else
            {
                StartEnemyTurn(enemies[0]);
            }
        }
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
            player.canMove = true;
            MainCamera.gameObject.SetActive(true);
            BattleCamera.gameObject.SetActive(false);
            player.transform.position = PositionPlaceHolder.position;
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
            player.canMove = true;
            MainCamera.gameObject.SetActive(true);
            BattleCamera.gameObject.SetActive(false);
            player.transform.position = PositionPlaceHolder.position;
            return;

        }
        else StartNewTurn();


    }


    public void StartFight()
    {
        
        foreach (Enemy enemy in enemies)       
        {
            if (!enemy.Dead)
            {
                player.canMove = false;
                MainCamera.gameObject.SetActive(false);
                BattleCamera.gameObject.SetActive(true);
                player.transform.position = new Vector2(-42f, 0.4f);
                StartNewTurn();
            }
            
            else
            {
                Debug.Log("All enemies dead!");
                MainCamera.gameObject.SetActive(true);
                BattleCamera.gameObject.SetActive(false);
                player.transform.position = PositionPlaceHolder.position;
                return;
            }
        }
        if (player.Dead)
        {
            Debug.Log("Player is dead!");
            panel.SetActive(false);
            MainCamera.gameObject.SetActive(true);
            BattleCamera.gameObject.SetActive(false);
            player.transform.position = PositionPlaceHolder.position;
            player.canMove = true;
            return;
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
