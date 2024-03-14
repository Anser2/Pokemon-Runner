using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ScoreManager : MonoBehaviour
{
    public float score;
    public float highscore;

    public Text scoretext;
    public Text highscoretext;
    
    public void AddScore()
    {
        score++;

    }

    void Start()
    {

        highscore = PlayerPrefs.GetFloat("highscore");
    }    
    // Update is called once per frame
    void Update()
    {
        scoretext.text = score.ToString();
        highscoretext.text = highscore.ToString();

        if (score > highscore)
            PlayerPrefs.SetFloat("highscore", score);
    }

}
