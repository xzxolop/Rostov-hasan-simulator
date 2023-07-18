using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerMovment : MonoBehaviour
{
    public float speed = 7f;
    //public bool ground;
    public float jumpPower = 100f;
    public Rigidbody rb;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //GetInput();    
    }

    private void FixedUpdate()
    {
        GetInput();
    }

    private void GetInput()
    {
        if(Input.GetKey(KeyCode.W))
        {
            transform.localPosition += transform.forward * speed * Time.deltaTime;
            if (Input.GetKey(KeyCode.LeftShift))
            {
                transform.localPosition += transform.forward * speed * Time.deltaTime;
            }
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.localPosition += -transform.forward * speed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.localPosition += transform.right * speed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.localPosition += -transform.right * speed * Time.deltaTime;
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {          
            rb.AddForce(transform.up * jumpPower);          
        }

        
    }


}
