using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerDown : MonoBehaviour
{   [SerializeField]
    Vector3 DownForce;
    
    [SerializeField]
    KeyCode DownButton;
    void Update()
    {
        if(Input.GetKeyDown(DownButton))
            GetComponent<Rigidbody>().velocity += DownForce;
    }
}
