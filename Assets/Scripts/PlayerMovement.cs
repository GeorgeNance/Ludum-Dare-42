using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {
    public float speed = 10;
    public float runSpeed = 15;
    Rigidbody rb;
    CharacterController cc;
	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();
        cc = GetComponent<CharacterController>();
	}
	
	// Update is called once per frame
	void FixedUpdate () {


        Movement(Time.fixedDeltaTime);
	}


    void Movement(float time){
        float s = 0;
        if (Input.GetKey(KeyCode.LeftShift))
        {
            s = runSpeed;
        }
        else
        {
            s = speed;
        }
        // Movmenet
        float forwardSpeed = Input.GetAxis("Vertical") * s;
        float sideSpeed = Input.GetAxis("Horizontal") * s;

        Vector3 movement = new Vector3(sideSpeed, Physics.gravity.y, forwardSpeed);

        movement = transform.rotation * movement;


        cc.Move(movement * Time.deltaTime);
    }


}
