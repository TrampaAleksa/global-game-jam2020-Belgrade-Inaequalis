using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MainMenu : MonoBehaviour
{
    public bool OnSt()
    {
        AudioManager.Instance.PlaySound("backgroundSound");
        return false;
    }
    private void Start() {
        LoopsHandler.LoopDelegate onStDelegate = OnSt;
        LoopsHandler.Instance.Loop(0.001f, OnSt);
    }
    public void PlayGame() 
    {  
        AudioManager.Instance.PlaySound("click");
        // Loads next scene in queue
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void QuitGame()
    {
        AudioManager.Instance.PlaySound("click");
        Debug.Log("QUIT");
        Application.Quit();
    }


}
