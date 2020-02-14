using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    // public CollectableScript collectable;
    public CollectableScript collectable;// = GameObject.Find("ChocolateChip");
    public static int score = 0;
    private Text scoreText;


   // CollectableScript collectable = other.GetComponent<CollectableScript>();

    // Start is called before the first frame update
    void Start()
    {
        CollectableScript collectable = other.GetComponent<CollectableScript>();
        //CollectableScript.Spawns();
        collectable.Spawns();

        score = 0;
        scoreText = GetComponent<Text>();//initialize the score to the text variable
    }

    // Update is called once per frame
    void Update()
    {
        //collectable.spawn();
        scoreText.text = "Score: " + score;//update the score to display the players score
    }
}
