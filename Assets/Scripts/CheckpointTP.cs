using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckpointTP : MonoBehaviour
{
    public GameObject checkpoint;
    public Collider trigger;
    
    // Start is called before the first frame update
    void Start()
    {
        trigger = GetComponent<Collider>();
        
        
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("CheckpointTrigger"))
        {
            checkpoint.transform.position = new Vector3(transform.position.x, transform.position.y + 6f, transform.position.z);
            print("collition boi");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
