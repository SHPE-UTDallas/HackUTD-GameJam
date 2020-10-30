using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField]
    Transform player;

    [SerializeField]
    float agroRange;

    [SerializeField]
    float moveSpeed;

    Rigidbody2D rb2d;


    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {//distance to player

        float distToPlayer = Vector2.Distance(transform.position, player.position);
        if (distToPlayer < 100)
        {
            //chase
            chasePlayer();
        }
        else
        {
            //idle
            idle();
        }
    }

    void chasePlayer()
    {
        if (transform.position.x < player.position.x)
        {
            //enemy is to the left
            rb2d.velocity = new Vector2(moveSpeed, 0);
        }
        else
        {
            //enemy is to the right of the player
            rb2d.velocity = new Vector2(-moveSpeed, 0);
        }


    }

    public void Die()
    {
        Destroy(gameObject);
    }

    void idle()
    {

    }

}