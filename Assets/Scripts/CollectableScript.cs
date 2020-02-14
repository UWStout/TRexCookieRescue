using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectableScript : MonoBehaviour
{
    private Vector2 collectablePosition;
    public float speed;

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
        //nonPlayerMovement(new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical")));
        collectablePosition = new Vector2(transform.position.x - speed, transform.position.y);
        transfrom.position = collectablePosition;
    }

    /*
    //Non-Player Movements
    void nonPlayerMovement(Vector2 Direction)
    {
        //move down the lane it is in, meaning just a horizontal movement
        //transform.Translate(Direction * speed * Time.deltaTime);
    }
    */

    //spawn locations
    void Spawns()
    {
        //randomly choose 0,1 or 2
        int rando = Random.Range(0, 2);
         //Random rando = new Random();
         // int ranNum = rando.Next(0,2);

        //spawn based on the random number given
        switch (rando)
        {
            case 0:
                new Vector2(4.75f, -3.25f);
                break;
            case 1:
                new Vector2(4.5f, -3.7f);
                break;
            case 2:
                new Vector2(4.25f, -4.1f);
                break;
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

}
