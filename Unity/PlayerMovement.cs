using System.Collections;

using System.Collections.Generic;
using System.Collections.Specialized;
using System.Security.Cryptography;
using System.Threading;
using UnityEngine;


/////////////////////////////////////// SOME CONSTANTS ////////////////////////////////////////////////////////////
public class PlayerMovement : MonoBehaviour

{
    // public CharacterController controller;
    // public Transform cam;
    // public float gravity = -9.81f;
    // public float jumpHeight = 3;
    // public Vector3 velocity;
    // public bool isGrounded;
    // public Transform groundCheck;
    // public float groundDistance = 0.4f;
    // public LayerMask groundMask;
    // float turnSmoothVelocity;
    // public float turnSmoothTime = 0.1f;
    public float horiz;
    public float vert;
    public float speed;
    // public float turnSpeed;

//////////////////////////////////////////// FUNCTIONS //////////////////////////////////////////////////////////////////////////////////////


    // Update is called once per frame
    void Update()
{      
        
        horiz = Input.GetAxis("Horizontal");
        vert = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * speed * vert * Time.deltaTime);
        transform.Translate(Vector3.right * speed * horiz * Time.deltaTime);
        
    }
}