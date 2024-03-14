using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class HeightIndicator : MonoBehaviour
{
    public Transform player;
    public float height;
    public Text HeightText;
         
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        HeightText.text = player.position.y.ToString("0");
    }
}
