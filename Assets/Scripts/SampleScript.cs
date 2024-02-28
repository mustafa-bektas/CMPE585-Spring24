using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SampleScript : MonoBehaviour
{
    public Rigidbody rb;
    private float forceToBeAdded = 500f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        rb.AddForce(forceToBeAdded * Time.deltaTime, 0, 0);
    }
}
