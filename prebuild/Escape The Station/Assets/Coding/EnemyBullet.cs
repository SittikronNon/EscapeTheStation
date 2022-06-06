using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour
{

    GameObject target;
    public float speed;
    public int damage = 20;
    Rigidbody2D bulletRB;

    // Start is called before the first frame update
    void Start()
    {
        bulletRB = GetComponent<Rigidbody2D>();
        target = GameObject.FindGameObjectWithTag("Player");
        Vector2 moveDir = (target.transform.position - transform.position).normalized * speed;
        bulletRB.velocity = new Vector2(moveDir.x, moveDir.y);
        
    }

    private void OnTriggerEnter2D(Collider2D hitInfo)
    {
        Physics2D.IgnoreLayerCollision(13, 14);

        //Destroy bullet when it hit something pepegaclap or something i don't know mate.
        Player player = hitInfo.GetComponent<Player>();

        if (player != null)
        {
            player.TakeDamage(damage);
        }
        
        
        

        Destroy(gameObject);

    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
