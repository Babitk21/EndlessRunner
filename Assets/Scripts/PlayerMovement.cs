using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody2D playerRB;
    public float speed;
    float direction = 0f;
    SpriteRenderer playerSprite;
    // Start is called before the first frame update
    void Start()
    {
        playerRB = GetComponent<Rigidbody2D>();
        playerSprite = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if(Input.mousePosition.x>Screen.width/2)
            {
                direction = 1.0f;
                print("move left");             
            }
            else if(Input.mousePosition.x<Screen.width/2)
            {
                direction = -1.0f;
                print("move right");
            }
            else
            {
                direction = 0f;
                print("middle");
            }          
        }
        playerRB.AddForce(transform.right * speed * direction);
        FlipThePlayer();
    }
    void FlipThePlayer()
    {
        if(playerRB.velocity.x<0)
        {
            playerSprite.flipX = true;
        }
        else if (playerRB.velocity.x >0)
        {
            playerSprite.flipX = false;
        }
    }
}
