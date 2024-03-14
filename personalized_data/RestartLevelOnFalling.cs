using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class RestartLevelOnFalling : MonoBehaviour
{
    [SerializeField]
    string strTAG;
    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == strTAG)
          SceneManager.LoadScene("GameOver");
        //SceneManager.GetActiveScene().name
    }

}