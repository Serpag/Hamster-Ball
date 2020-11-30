using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoBola : MonoBehaviour
{
    public float speed = 0;

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

        Vector3 mov = new Vector3(movX, 0, movY);

        _rigidbody.AddForce(mov);
    }
} 