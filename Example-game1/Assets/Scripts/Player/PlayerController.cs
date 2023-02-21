using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    public Player player;
    public FightManager fightManager;
    
    
    

    private Rigidbody2D rb;
    private Vector2 moveVelocity;

    private void Start()
    {
        rb= GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (player.canMove)
        {
            Vector2 moveInput = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
            moveVelocity.x = Mathf.Clamp(moveInput.x, -1f, 1f) * speed; // Only allow movement along X axis
            moveVelocity.y = Mathf.Clamp(moveInput.y, -1f, 1f) * speed; // Only allow movement along Y axis
        }
        else
        {
            moveVelocity = Vector2.zero;
        }
    }
    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + moveVelocity * Time.fixedDeltaTime);
    }

}
