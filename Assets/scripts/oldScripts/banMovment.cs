using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class banMovment : MonoBehaviour
{
    private CharacterController cc;

    public float graviry = -9.8f;
    public float speed = 15.0f;

    public float jspeed = 0.0f;
    public float jumpForce = 15;
    // Vector3 moveVelocity;
    private void Start()
    {
        cc = GetComponent<CharacterController>();
    }
    private void Update()
    {
        float horizontal = 0;
        float vertical = 0;

        if (cc.isGrounded)
        {
            horizontal = Input.GetAxis("Horizontal") * speed;
            vertical = Input.GetAxis("Vertical") * speed;

            //moveVelocity = transform.forward * horizontal;

            if (Input.GetKeyDown(KeyCode.Space))
            {
                jspeed = jumpForce;
            }
        }
        jspeed += graviry * Time.deltaTime * 3f;
        Vector3 dir = new Vector3(horizontal, jspeed, vertical);

        dir *= Time.deltaTime;
        dir = transform.TransformDirection(dir);
        cc.Move(dir);
    }
}
