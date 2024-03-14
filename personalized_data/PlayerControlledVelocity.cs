using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControlledVelocity : MonoBehaviour
{
   
  
    [SerializeField]
    Vector3 SteeringForce;


    [SerializeField]
    KeyCode KeyPositive;

    [SerializeField]
    KeyCode KeyNegative;

    [SerializeField]
    Vector3 JumpForce;

    [SerializeField]
    KeyCode JumpButton;

    [SerializeField]
    KeyCode downButton;
   
    void Update()
    {
        if (Input.GetKey(KeyPositive))
            GetComponent<Rigidbody>().velocity += SteeringForce;

        if (Input.GetKey(KeyNegative))
            GetComponent<Rigidbody>().velocity -= SteeringForce;

        if (Input.GetKey(JumpButton))
            GetComponent<Rigidbody>().velocity += JumpForce;

       

    }

}

