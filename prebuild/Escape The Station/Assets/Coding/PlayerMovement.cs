using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour

{
    public GameObject speedEffect;

    public CharacterController2D controller;

    public Animator animator;

    public float runSpeed;

    float horizontalMove = 0f;

    bool jump = false;

    private float boostimer;
    private bool boosting;

    void Start()
    {
        runSpeed = 40f;
    }

    void Update()
    {
        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;

        animator.SetFloat("Speed", Mathf.Abs(horizontalMove));

        if (Input.GetButtonDown("Jump"))
        {
            jump = true;
            animator.SetBool("IsJumping", true);
        }

        if (boosting)
        {
            boostimer += Time.deltaTime;
            if(boostimer >= 10)
            {
                speedEffect.SetActive(false);
                runSpeed = 40f;
                boostimer = 0;
                boosting = false;
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        
        if(other.tag == "SpeedBoost")
        {
            speedEffect.SetActive(true);
            boosting = true;
            runSpeed = 100f;
            Destroy(other.gameObject);
        }
    }

    //set animation to false after landing from jumping
    public void OnLanding()
    {
        animator.SetBool("IsJumping", false);
    }


    void FixedUpdate()
    {
        controller.Move(horizontalMove * Time.fixedDeltaTime, false, jump);

        jump = false;
    }
}
