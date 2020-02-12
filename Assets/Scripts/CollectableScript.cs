using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    /*temp comment
     
    private  float speed = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
        //spawn in one of the 3 lanes
        Spawns();
    }

    // Update is called once per frame
    void Update()
    {
        //calling the movement for the non player objects
        nonPlayerMovement(new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical")));
    }

    //Non-Player Movements
    void nonPlayerMovement()
    {
            //move down the lane it is in, meaning just a horizontal movement
            transform.translate(direction * speed * Time.deltaTime);
    }

    //spawn locations
    void Spawns()
    {
        //randomly choose 0,1 or 2
        int rando = Random.Range(0, 2);
         //Random rando = new Random();
         // int ranNum = rando.Next(0,2);

        //spawn based on the random number given
        switch (ranNum)
        {
            case 0:
                new Vector2(4.75.x, -3.25.y);
            case 1:
                new Vector2(4.5.x, -3.7.y);
            case 2:
                new Vector2(4.25.x, -4.1.y);
        }
    }

    void OnCollisionEnter(Collision col)
    {
        if ((col.gameObject.name == "Cookie") && (gameObject.name == "ChocoloateChip"))//if the player touches a chocolate chip
        {
            //increase score by +1
            GameManager.score += 1;
            //destroy or disable
        }

        if ((col.gameObject.name == "Cookie") && (gameObject.name == "ChocolateChunk"))//if the player touches a chocolate chunk
        {
            //increase score by +10
            GameManager.score += 10;
            //destroy or disable
        }
    }

    */
}
