using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pause : MonoBehaviour
{
    public static bool GameIsPaused = false;


    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape)){
            if(GameIsPaused)
            {
                Resume();
            }
            else{
                Pause();
            }
        }
        
    }

    public void Resume()
    {
        
        Time.timeScale =1f;
        GameIsPaused = false;
    }
    void Pause(){
 
        Time.timeScale =0f;
        GameIsPaused = true;
    }

    

    public void quit(){
         Debug.Log("Quit");
        Application.Quit();
    }
}
