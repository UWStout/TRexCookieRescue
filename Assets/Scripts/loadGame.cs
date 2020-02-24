using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class loadGame : MonoBehaviour
{
    void Start()
    {
        GameManager.health = 3; //reset player health whenever a scene is transitioned 
    }
   
    public void loadMainScene()
    {
            SceneManager.LoadScene("main"); //load the main scene
    }

    public void loadMainMenu()
    {
            SceneManager.LoadScene("Main_Menu"); //load main menu
    }

    
}
