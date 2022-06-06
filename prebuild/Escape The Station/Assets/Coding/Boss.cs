using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss : MonoBehaviour
{
    public Transform player;
    
    public bool isFlipped = false;
    public int maxHealth = 2500;
    public int currentHealth;
    public GameObject deathEffect,CoinArtifact;

    public BossHealthBar BosshealthBar;


    void Start()
    {
        currentHealth = maxHealth;
        BosshealthBar.SetMaxHealth(maxHealth);
    }

    public void LookAtPlayer()
    {
        Vector3 flipped = transform.localScale;
        flipped.z *= -1f;

        if (transform.position.x > player.position.x && isFlipped)
        {
            transform.localScale = flipped;
            transform.Rotate(0f, 180f, 0f);
            isFlipped = false;
        }
        else if (transform.position.x < player.position.x && !isFlipped)
        {
            transform.localScale = flipped;
            transform.Rotate(0f, 180f, 0f);
            isFlipped = true;
        }
    }


    public void TakeDamage(int damage)
    {
        currentHealth -= damage;

        BosshealthBar.SetHealth(currentHealth);

        if (currentHealth <= 0)
        {
            Die();
            CoinArtifact.SetActive(true);
            Instantiate(deathEffect, transform.position, Quaternion.identity);


        }

    }
    // Start is called before the first frame update


    void Die()
    {
        Destroy(gameObject);
    }
}
