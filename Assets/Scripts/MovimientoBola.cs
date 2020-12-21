using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoBola : MonoBehaviour
{
    public float speed = 0;
    public float airSpeed;
    private bool _touchingFloor;

    public float jumpForce;
    
    Rigidbody _rigidbody;

    float movX;

    float movY;   
    // Start is called before the first frame update
    void Start() 
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        movX = Input.GetAxis("Horizontal");

        movY = Input.GetAxis("Vertical");
        
        if (_touchingFloor)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                _rigidbody.AddForce(Vector3.up*jumpForce);
            } 
            
            Vector3 mov = new Vector3(movX, 0, movY);

            _rigidbody.AddForce(mov*speed);
        }
        else
        {
            Vector3 mov = new Vector3(movX, 0, movY);
            
            _rigidbody.AddForce(mov*airSpeed);
        }

    }

    private void OnCollisionStay(Collision other)
    {
        _touchingFloor = true;
     //   print("Collition lol");
    }

    private void OnCollisionExit(Collision other)
    {
        _touchingFloor = false;
     //   print("no collition gang >:D");
    }
} 