using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cookie_Movement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private Vector2 collectablePosition;
    private Vector2 objectBounds;

    private Vector2 cookiePos;
    public float yPosChange = (1/2);
    public int laneTracker = 1;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            if(laneTracker == 1 || laneTracker == 0)
            {
                cookiePos = new Vector2(transform.position.x, transform.position.y + yPosChange);
                transform.position = cookiePos;
            laneTracker++;
        } 


        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            if (laneTracker == 1 || laneTracker == 2)
            {
                cookiePos = new Vector2(transform.position.x, transform.position.y - yPosChange);
                transform.position = cookiePos;
                laneTracker--;

            }
            

        }

    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        if ((col.gameObject.tag == "DinoHazard") && (gameObject.tag == "Player"))//if the player touches a dino
        {
            collectablePosition = new Vector2(transform.position.x - 1f, transform.position.y);
            transform.position = collectablePosition;
            //knockback player by 
        }

        if ((col.gameObject.tag == "Milk") && (gameObject.tag == "Player"))//if the player touches milk
        {
            collectablePosition = new Vector2(transform.position.x - .5f, transform.position.y);
            transform.position = collectablePosition;
            //knockback player by 
        }
    }
}
