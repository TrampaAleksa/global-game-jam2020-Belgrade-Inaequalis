using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandsMovement : MonoBehaviour
{
    
    public Rigidbody2D handLeft;
    public Rigidbody2D handRight;

    public float handsSpeed=10f;
    Vector2 movement1;
    Vector2 movement2;

    //to do later ---> inicijalizovati sa private

    void Start()
    {
        

    }

    // Update is called once per frame
    void Update()
    {
       handleHandsAxis();       
    }

  
    void FixedUpdate()
    {
        handleInput();
    }

    public void handleInput()
    {
        if (Input.GetKey("a") || Input.GetKey("d") || Input.GetKey("s") || Input.GetKey("w"))
        {
            handLeft.MovePosition(handLeft.position + movement1 * Time.fixedDeltaTime * handsSpeed);
        }
         if (Input.GetKey("left") || Input.GetKey("right") || Input.GetKey("up") || Input.GetKey("down"))
        {
            handRight.MovePosition(handRight.position + movement2 * Time.fixedDeltaTime * handsSpeed);
        }
    }
    public void handleHandsAxis()
    {
        movement1.x = Input.GetAxisRaw("Horizontal");
        movement1.y = Input.GetAxisRaw("Vertical");

        movement2.x = Input.GetAxisRaw("Horizontal2");
        movement2.y = Input.GetAxisRaw("Vertical2");
    }

   
    }

