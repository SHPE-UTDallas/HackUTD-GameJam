using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PlayerMovement : MonoBehaviour
{

    public float moveSpeed = 500f;

    public Rigidbody2D rb;

    public Text nameText;
    
    float timer = 0;

    Vector2 movement;

    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        //Input
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        if (movement.x != 0)
            transform.localScale = new Vector3(-1*movement.x,1f,1f);

        timer += Time.deltaTime;    
        nameText.text = "Time Survived: " + (int)timer;
        /*
         if (movement.x < 0)
            transform.Rotate(0f, 180f, 0f);
        else if (movement.x > 0)
            tranform.Rotate(0f, 0f, 0f);
         */

    }

    void FixedUpdate()
    {
        //Movement
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    }
}
