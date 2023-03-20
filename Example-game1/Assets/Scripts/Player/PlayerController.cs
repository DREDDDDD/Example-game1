using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    public Player player;
    public FightManager fightManager;
    public Animator animator;
    private Rigidbody2D rb;
    private Vector3 change;

    private void Start()
    {
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (player.canMove)
        {
            change = Vector3.zero;
            change.x = Input.GetAxisRaw("Horizontal");
            change.y = Input.GetAxisRaw("Vertical");

            if (change != Vector3.zero)
            {
                animator.SetFloat("moveX", change.x);
                animator.SetFloat("moveY", change.y);
                animator.SetBool("moving", true);
            }
            else animator.SetBool("moving", false);
            
            
            
        }
        else
        {
            change = Vector3.zero;
        }
    }
    private void FixedUpdate()
    {
        rb.MovePosition(transform.position + change * speed * Time.fixedDeltaTime);
    }

}
