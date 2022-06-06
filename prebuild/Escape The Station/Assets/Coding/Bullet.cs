using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public int damage = 40;
    public float speed = 20f;
    public Rigidbody2D rb;
    public GameObject impactEffect;

    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = transform.right * speed;

    }

    private void OnTriggerEnter2D (Collider2D hitInfo)
    {
        //Destroy bullet when it hit something pepegaclap or something i don't know mate.
        Enemy enemy = hitInfo.GetComponent<Enemy>();
        Boss boss = hitInfo.GetComponent<Boss>();
        if (enemy != null)
        {
            enemy.TakeDamage(damage);
        }
        else if (boss != null)
        {
            boss.TakeDamage(damage);
        }

        Instantiate(impactEffect, transform.position, transform.rotation);

        Destroy(gameObject);
        
    }

    private void OnBecameInvisible()
    {
        enabled = false;
        Destroy(gameObject);
    }


}
