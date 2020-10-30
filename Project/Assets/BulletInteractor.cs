using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletInteractor : MonoBehaviour
{

    public Rigidbody2D rb;


    // Start is called before the first frame update
    void Start()
    {
        //var bullet = Instantiate(bulletPrefab) as Transform;
        Transform player = GameObject.Find("Player").transform;
        Physics2D.IgnoreCollision(player.GetComponent<Collider2D>(), GetComponent<Collider2D>());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

        void OnTriggerEnter2D(Collider2D hitInfo)
    {
        Debug.Log("Hit something");
        Debug.Log(hitInfo.name);

        Enemy enemy = hitInfo.GetComponent<Enemy>();
        if (enemy != null && enemy is Enemy)
        {
            enemy.Die();
        }

        Destroy(gameObject);
    }
}
