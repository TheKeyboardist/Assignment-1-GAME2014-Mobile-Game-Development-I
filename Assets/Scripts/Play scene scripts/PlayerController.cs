using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //pick up variables;
    int totalPickUps = 1;
    public bool hasPickUp = false;
    public bool hasMilk = false;
    public bool hasTrap = false;

    //movement and animation variables
    public CharacterController controller;
    public Rigidbody2D rb;
    public Joystick joystick;
    public float runSpeed = 2f;
    Vector2 movemenet;
    public Animator animator;
    //

    // Update is called once per frame
    void Update()//INPUT 
    {
        transform.localScale = new Vector3(1.0f, 1, 1);
        if (joystick.Horizontal <= 0)
        {
            transform.localScale = new Vector3(-1.0f, 1, 1);
        }
        movemenet.x = joystick.Horizontal  * runSpeed;
        movemenet.y = joystick.Vertical * runSpeed;
        animator.SetFloat("Horizontal", movemenet.x);
        animator.SetFloat("Vertical", movemenet.y);
        animator.SetFloat("Speed", movemenet.sqrMagnitude);

    }

    void FixedUpdate()//OUTPUT
    {
        rb.MovePosition(rb.position + movemenet * runSpeed * Time.fixedDeltaTime);
    }
}
