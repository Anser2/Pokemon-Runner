using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class YLimit : MonoBehaviour
{ public Transform player;
    
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {    
       

        if (transform.position.y > 25)
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);            
    }
}
