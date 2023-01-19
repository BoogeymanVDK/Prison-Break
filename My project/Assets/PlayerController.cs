using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public CharacterController2D controller;
    // Start is called before the first frame update
    float horizontalMove = 0f;
    public float runspeed = 40f;
    bool jump = false;

    // Update is called once per frame
    void Update()
    {
     Debug.Log(horizontalMove = Input.GetAxisRaw("Horizontal") * runspeed);

     if(Input.GetButtonDown("Jump"))
     {
        jump = true;
     }
    }

    void FixedUpdate()
    {
        controller.Move(horizontalMove * Time.fixedDeltaTime, false, jump);
        jump = false;
    }

}
