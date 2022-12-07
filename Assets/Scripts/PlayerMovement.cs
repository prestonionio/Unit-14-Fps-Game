using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed;
    public Animator animator;

    void Start()
    {

    }

    void Update() 

    { 
        Debug.Log("Update");
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(x, 0, z);
        animator.SetInteger("WeaponType_int", 1);
        transform.Translate(movement * speed * Time.deltaTime);

        animator.SetFloat("Speed_f", movement.magnitude);   

        if(Input.GetKeyDown(KeyCode.C))
        {
            animator.SetBool("Crouch_b", true);
        }
        else if (Input.GetKeyUp(KeyCode.C))
        {
            animator.SetBool("Crouch_b", false);
        }
    }

}

