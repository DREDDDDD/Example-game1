using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireballScript : MonoBehaviour
{
    public Transform target;
    public float speed;
    public bool once;
    



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
        if(Vector2.Distance(transform.position, target.position)<0.1f)
        {
            if (once)
            {
                gameObject.SetActive(false);
                FightManager.Instance.player.AttackEnemy(FightManager.Instance.enemies[0]);
                FightManager.Instance.EndPlayerTurn();
                once = false;
            }
                
            
        }
        
    }
}
