using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerPlatformerController : PhysicsObject
{
    public float maxSpeed = 7; 
    public float jumpTakeoffSpeed = 7;

    public GameController gameController; 

    private SpriteRenderer spriteRenderer;
    private Animator animator; 
   

    // Start is called before the first frame update
    void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame

    protected override void ComputeVelocity()
    {
        if (gameController.gameOver)
        {
            return;
        }
        base.ComputeVelocity();
        Vector2 move = Vector2.zero;
        move.x = Input.GetAxis("Horizontal");

        if(Input.GetButtonDown("Jump"))// && grounded)//no double jumping 
        {
            velocity.y = jumpTakeoffSpeed; 
        }

        else if(Input.GetButtonUp("Jump"))
        {
            if (velocity.y > 0)
            {
                velocity.y = velocity.y * 0.5f;
            }
        }

       
        
        bool flipSprite = (spriteRenderer.flipX ? (move.x > 0.01f) : (move.x < 0));


        if (flipSprite)
        {
            spriteRenderer.flipX = !spriteRenderer.flipX;
        }

        animator.SetBool("grounded", grounded);
        animator.SetFloat("velocityX", Mathf.Abs(velocity.x) / maxSpeed);
        animator.SetFloat("velocityY", velocity.y);

        targetVelocity = move * maxSpeed; 

    }
}
