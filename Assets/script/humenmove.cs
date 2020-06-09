﻿using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Threading;
using UnityEngine;

public class humenmove : MonoBehaviour
{

    public CharacterController2D controller;
    public Animator animator;
    public float runspeed = 50f;
    float horizontamove = 0f;
    bool jump = false;
    public PotionManger potis;

    public int potionvalue = 1;




    void Start()
    {
        potis = FindObjectOfType<PotionManger>();

    }
    // Update is called once per frame
    void Update()
    {

       

            horizontamove = Input.GetAxisRaw("Horizontal") * runspeed;
           
        
        animator.SetFloat("speed", Mathf.Abs(horizontamove));
       

        if (Input.GetButtonDown("Jump"))
        {
                  jump = true;

            animator.SetBool("IsJumbing",true);


        }



    }

    public void OnLanding() {

        animator.SetBool("IsJumbing", false);
    
    
    }

  
    private void OnTriggerEnter2D(Collider2D other) {

        if (other.gameObject.CompareTag("potion"))
        {
         
            Destroy(other.gameObject);
        }
    
    }
    void FixedUpdate()
    {
        controller.Move(horizontamove * Time.fixedDeltaTime, false, jump);

        jump = false;
    }
}