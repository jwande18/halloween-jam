// Script: movingcam_cube.cs
// Desc: Script to handle player movement.
// Author: Unity
// Date: 10/06/2019

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movingcam_cube : MonoBehaviour
{
    public Camera firstPersonCamera;
    public Camera overheadCamera;
    private bool box;
    public void ShowOverheadView()
    {
        firstPersonCamera.enabled = false;
        overheadCamera.enabled = true;
    }

    public void ShowFirstPersonView()
    {
        firstPersonCamera.enabled = true;
        overheadCamera.enabled = false;
    }
    // rigid body of the player object
    private Rigidbody playerBody;

    // keybinds for movement
    private KeyCode moveForward = KeyCode.W;
    private KeyCode moveLeft = KeyCode.A;
    private KeyCode moveBackward = KeyCode.S;
    private KeyCode moveRight = KeyCode.D;
    private KeyCode jump = KeyCode.Space;


    // speed of movement
    private float moveSpeed = .5f;

    // force of jumping
    private float jumpForce = 100f;

    // trigger to determine whether the player is climbing or not
    private bool climbTrigger;

    // trigger to determine whether the player can jump or not
    private bool canJump;

    // enables the climb trigger when player enters the trigger collider
    // do not change method name/args - method is built-in to unity
    float smooth = 5.0f;
    float tiltAngle = 60.0f;

       
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("ladder"))
        {
            climbTrigger = true;
        }
    }

    // disables the climb trigger when player exits the trigger collider
    // do not change method name/args - method is built-in to unity
    public void OnTriggerExit(Collider other)
    {
        climbTrigger = false;
    }

    // checks if the player is on the ground (technically if player is in contact with another object)
    // do not change method name/args - method is built-in to unity
    public void OnCollisionStay(Collision other)
    {
        canJump = true;
    }

    // called when the script is first enabled
    void Start()
    {
        playerBody = GetComponent<Rigidbody>();
    }

    // update is called once per frame


    void Update()
    {


  



            if (Input.GetKeyDown("o"))
        {
            ShowFirstPersonView();
            box = true;

        }
        if (Input.GetKeyDown("p"))
        {
            ShowOverheadView();
            box = false;
        }



        if (box == true)
        {
            if (Input.GetKey(moveForward)) // forward movement
            {
                if (climbTrigger) // checks for a ladder
                {
                    transform.Translate(0, 1, 0 * moveSpeed);
                }
                else // no ladder -> move normally
                {
                    transform.Translate(Vector3.forward * moveSpeed);
                }
            }

            if (Input.GetKey(moveLeft)) // left movement
            {
                
                transform.Rotate(0, -3, 0);

            }

            if (Input.GetKey(moveBackward)) // backward movement
            {
                transform.Translate(Vector3.back * moveSpeed);
            }

            if (Input.GetKey(moveRight)) // right movement
            {
                
                transform.Rotate(0, 3, 0);

            }

            if (Input.GetKeyDown(jump) && canJump) // jumping
            {
                playerBody.AddForce(Vector3.up * jumpForce); // apply jump force
                canJump = false; // prevent infinite jumps
            }
        }
    }
}

