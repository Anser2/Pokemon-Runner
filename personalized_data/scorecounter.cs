
using UnityEngine;
using UnityEngine.UI;
public class scorecounter : MonoBehaviour
{
    public Transform player;
    public Text scoreText;


    // Update is called once per frame
    void Update()
    {
        scoreText.text = player.position.x.ToString("0");


    }
}