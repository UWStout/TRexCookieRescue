using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DinoHazardPrefab : MonoBehaviour
{

    //Translate movement
    private Vector2 collectablePosition;
    public float speed = .01f;
    //private Rigidbody2D rb;
    private Vector2 objectBounds;

    // Start is called before the first frame update
    void Start()
    {
        //rb = this.GetComponent<Rigidbody2D>();
        //rb.velocity = new Vector2(-speed, 0);
        //objectBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));//defines the boundaries of the screen on an x and y axis
        //objectBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));//defines the boundaries of the screen on an x and y axis
        //spawn in one of the 3 lanes
        //Spawns();
    }

    // Update is called once per frame
    void Update()
    {
        /*
        if(transform.position.x < objectBounds.x)
        {
            Destroy(this.gameObject);//destroys the gameObject
        }
        */
        //calling the movement for the non player objects
        //nonPlayerMovement(new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical")));

        //Translate movement
        collectablePosition = new Vector2(transform.position.x - speed, transform.position.y);
        transform.position = collectablePosition;
    }

    /*
    //Non-Player Movements
    void nonPlayerMovement(Vector2 Direction)
    {
        //move down the lane it is in, meaning just a horizontal movement
        //transform.Translate(Direction * speed * Time.deltaTime);
    }
    */

    /*spawn locations
    public void Spawns()
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
    }*/

    void OnCollisionEnter2D(Collision2D col)
    {
        if ((col.gameObject.tag == "Player") && (gameObject.tag == "DinoHazard"))//if the player touches a dino
        {
            //knockback player by 
            Destroy(this.gameObject);//destroys the gameObject
        }

        if ((col.gameObject.tag == "Player") && (gameObject.tag == "Milk"))//if the player touches milk
        {
            //knockback player by 
            Destroy(this.gameObject);//destroys the gameObject
        }
    }

}
