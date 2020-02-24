using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    // public CollectableScript collectable;
    //public CollectableScript collectable;// = GameObject.Find("ChocolateChip");
    public static int score = 0;
    public static int health = 3;
    public GameObject[] hearts;
    public Text scoreText;

   // CollectableScript collectable = other.GetComponent<CollectableScript>();

    // Start is called before the first frame update
    void Start()
    {
       // CollectableScript collectable = other.GetComponent<CollectableScript>();
        //CollectableScript.Spawns();
        //collectable.Spawns();

        score = 0;
        //scoreText = GetComponent<Text>();//initialize the score to the text variable
    }

    // Update is called once per frame
    void Update()
    {
        //collectable.spawn();
        scoreText.text = "Score: " + score;//update the score to display the players score
      
    }
    public void loseHeart()
    {
    Debug.Log("Ouch!");
      health--; //when a player loses a heart, their health goes down
      Destroy(hearts[health]); //the sprite of the heart is removed
      if (health == 0) //when you hit 0 health
      {
        gameFail();//you lose the game
      }
    }
    public static void gameFail()
    {
        SceneManager.LoadScene("Lose_Scene"); //gameFail() loads the lose scene
    }
}
