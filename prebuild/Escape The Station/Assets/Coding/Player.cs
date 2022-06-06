using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth;
    public GameObject restartButton,backgroundOver,gameoverText,backtomenu;
    public HealthBar healthBar;

    public Renderer playerRenderer;
    private float flashCounter;
    public float flashLehgth = 0.1f;

    public float invincibilityLength;
    private float invincibilityCounter;

    private GameObject[] EE;
    void Start()
    {

        EE = GameObject.FindGameObjectsWithTag("Enemy");

        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
        
    }

    void Update()
    {
        if(invincibilityCounter > 0)
        {
            invincibilityCounter -= Time.deltaTime;

            flashCounter -= Time.deltaTime;
            if(flashCounter <= 0)
            {
                playerRenderer.enabled = !playerRenderer.enabled;
                flashCounter = flashLehgth;
            }

            if(invincibilityCounter <= 0)
            {
                playerRenderer.enabled = true;
            }
        }
    }
    // Update is called once per frame


    public void TakeDamage(int damage)
    {
        if (invincibilityCounter <= 0)
        {
            currentHealth -= damage;

            healthBar.SetHealth(currentHealth);
            invincibilityCounter = invincibilityLength;

            playerRenderer.enabled = false;

            flashCounter = flashLehgth;
        }

        if (currentHealth <= 0)
        {
            Die();
            backgroundOver.SetActive(true);
            restartButton.SetActive(true);
            gameoverText.SetActive(true);
            backtomenu.SetActive(true);
           

        }
    }

    public void HealthIncrease(int plushealth)
    {
        currentHealth += plushealth;

        healthBar.SetHealth(currentHealth);
    }

    void Die()
    {
        for (int i = 0; i < EE.Length; i++)
        DestroyObject (EE[i]);


        Destroy(this.gameObject);
    }

}
