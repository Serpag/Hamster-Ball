using UnityEngine;

public class DieOnContact : MonoBehaviour
{
    public GameObject checkpoint;

    private Rigidbody _rigidbody;                                        
    // Start is called before the first frame update
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }
    
    private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("KillZone"))
            {
                _rigidbody.velocity = Vector3.zero;
                _rigidbody.angularVelocity = Vector3.zero;
                transform.position = checkpoint.transform.position;
            }
        }
}
