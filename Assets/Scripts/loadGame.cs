using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class loadGame : MonoBehaviour
{
   
        public void loadMainScene()
        {
            SceneManager.LoadScene("main");
        }

        public void loadMainMenu()
        {
            SceneManager.LoadScene("Main_Menu");
        }

    
}
