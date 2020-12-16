using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoBola2 : MonoBehaviour
{
    public Transform ballSumthing;

    public float camRotSpeed;

    private Vector3 _camDistance;

    public int tolerance;

    private float _xOrigin;

    private float _yOrigin;
    
    private Vector3 _offset;

    private float _yPosition;
    
    // Start is called before the first frame update
    void Start()
    {
        _offset = transform.position - ballSumthing.position;
        _yPosition = transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(ballSumthing.position.x,_yPosition ,ballSumthing.position.z )+ _offset;
        
        if (Input.GetMouseButtonDown(1))
        {
            _xOrigin = Input.mousePosition.x;
            _yOrigin = Input.mousePosition.y;
        }   
        if (Input.GetMouseButton(1))
        {
            if (Input.mousePosition.x >= tolerance)
            {
                gameObject.transform.Translate(Vector3.right*Time.deltaTime*camRotSpeed,Space.Self);
            }
            if (Input.mousePosition.x <= tolerance)
            {
                gameObject.transform.Translate(Vector3.left*Time.deltaTime*camRotSpeed,Space.Self);
            }
        }

        gameObject.transform.rotation = Quaternion.LookRotation(ballSumthing.transform.position-gameObject.transform.position, Vector3.up);
    }
}