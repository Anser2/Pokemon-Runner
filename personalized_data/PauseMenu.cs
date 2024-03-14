using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public GameObject PAUSEMENU;
    public bool is_paused;


    // Start is called before the first frame update
    void Start()
    {
        PAUSEMENU.SetActive(false);

    }

    void Update()
    {
     if(Input.GetKeyDown(KeyCode.Escape))
        { if(is_paused)
        
            ResumeGame();
        else
          PauseGame();
        }
    }

    public void PauseGame()
    {
        PAUSEMENU.SetActive(true);
        Time.timeScale = 0f; //stops all animations and movements and executions
        is_paused = true;    
    }
    public void ResumeGame() {
        PAUSEMENU.SetActive(false);
        Time.timeScale = 1f;
        is_paused = false;
    }

    

}

