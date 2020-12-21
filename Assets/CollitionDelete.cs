using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollitionDelete : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            StartCoroutine(Destroyer());
        }
        
    }

    private IEnumerator Destroyer()
    {
        yield return new WaitForSeconds(3f);
        Destroy(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
