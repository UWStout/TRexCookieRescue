using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static int score;
    private Text scoreText;

    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        scoreText = GetComponent<Text>();//initialize the score to the text variable
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Score: " + score;//update the score to display the players score
    }
}
