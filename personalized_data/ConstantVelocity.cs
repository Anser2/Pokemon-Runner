using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConstantVelocity : MonoBehaviour
{
    [SerializeField]
    Vector3 ConstantForce;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Rigidbody>().velocity += ConstantForce;
    }
}
