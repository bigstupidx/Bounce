using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public int life;
    public float speed;
    public float JumpHeight;
    public float move;
    public bool bold;

    public Rigidbody2D player;

    public bool grounded;
    public bool topGrounded;
    public bool wallLeft;
    public bool wallRight;
    public bool powerGravityScale;
    public bool moveLeft, moveRight, jump;
    public Sprite bigBall;
    public Quaternion originalRotation;



    // Use this for initialization
    void Start()
    {
        player = GetComponent<Rigidbody2D>();
        life = 3;
        SetJump(false);
        SetMoveRight(false);
        SetMoveLeft(false);
        if(bold)
        {
            player.GetComponent<SpriteRenderer>().sprite = bigBall;
            player.GetComponent<CircleCollider2D>().radius = 1.05f;
        }
        originalRotation = this.transform.rotation;
    }


    // Update is called once per frame
    void FixedUpdate()
    {
        Move();
        powerGravity();
    }

    private void Update()
    {
        powerGravity();
    }

    public void SetMoveRight(bool moveRight)
    {
        this.moveRight = moveRight;
    }

    public void SetMoveLeft(bool moveLeft)
    {
        this.moveLeft = moveLeft;
    }

    public void SetJump(bool jump)
    {
        this.jump = jump;
    }

    void Move()
    {
        player.velocity = new Vector2(move * speed * Time.deltaTime, player.velocity.y);
        if (jump)
        {
            Jump();
        }
    }


    public void MoveRight()
    {
        if(!wallRight)
        {
            player.velocity = new Vector2(speed * Time.deltaTime, player.velocity.y);
        }
        
    }

    void MoveLeft()
    {
        if(!wallLeft)
        {
            player.velocity = new Vector2(speed * Time.deltaTime, player.velocity.y);
        }
        
    }

    public void Jump()
    {
        if (grounded)
        {
            player.velocity = new Vector2(player.velocity.x, JumpHeight);
            grounded = false;
        }
        if(powerGravityScale)
        {
            if(topGrounded)
            {
                player.velocity = new Vector2(player.velocity.x, -JumpHeight);
                topGrounded = false;
            }
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Ground")
        {
            grounded = true;
        }
        if(other.gameObject.tag == "TopGround")
        {
            topGrounded = true;
        }
        if (other.gameObject.tag == "WallRight")
        {
            wallRight = true;
            speed = 0;
        }
        if (other.gameObject.tag == "WallLeft")
        {
            wallLeft = true;
            speed = 0;
        }
        if(other.gameObject.tag == "leftAscent")
        {
            Debug.Log("LeftAscent");
            grounded = true;
        }
    }

    

    private void OnTriggerStay2D(Collider2D other)
    {
        if(other.gameObject.tag == "Ground")
        {
            grounded = true;
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag == "Ground")
        {
            grounded = false;
            
        }
        if(other.gameObject.tag == "TopGround")
        {
            topGrounded = false;
        }
        if (other.gameObject.tag == "WallLeft")
        {
            wallLeft = false;
            speed = 300;
        }
        if (other.gameObject.tag == "WallRight")
        {
            wallRight = false;
            speed = 300;
        }
        if(other.gameObject.tag == "leftAscent")
        {
            
            grounded = false;
        }
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Ground")
        {
            grounded = true;
        }
        if (other.gameObject.tag == "TopGround")
        {
            topGrounded = true;
        }
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Ground")
        {
            grounded = true;
        }
        if(collision.gameObject.tag == "TopGround")
        {
            topGrounded = true;
        }
    }

    private void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.tag == "Ground")
        {
            grounded = false;
        }
        if (other.gameObject.tag == "TopGround")
        {
            topGrounded = false;
        }
        
    }

    private void powerGravity()
    {
        if(this.powerGravityScale)
        {
            player.gravityScale = -2f;
        }
        else
        {
            player.gravityScale = 2f;
        }
    }
}
