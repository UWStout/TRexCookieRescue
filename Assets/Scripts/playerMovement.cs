using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
      // changes the player's order in sprite sorting layer so objects can overlap naturally
      sprite = this.transform.GetChild(0).gameObject.GetComponent<SpriteRenderer>();
      sprite.sortingOrder = laneTracker;
    }

    // Update is called once per frame
    //private Vector2 collectablePosition;
    //private Vector2 objectBounds;

    //private Vector2 cookiePos;
    //public float yPosChange = (1/2);
    //public float xPosChange = 1;

    public int laneTracker = 1; //index of game object in array, value shown here will be the player's starting lane
    public GameObject[] lanes; //game objects that player will move towards, must be 3
    public float speed; //how fast the cookie should change lanes
    private SpriteRenderer sprite;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            if(laneTracker == 1 || laneTracker == 0)
            {
                laneTracker++;
                // updates sorting layer based on lane
                sprite.sortingOrder = laneTracker;
            } 
        }
        else if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            if (laneTracker == 1 || laneTracker == 2)
            {
                laneTracker--;
                // updates sorting layer based on lane
                sprite.sortingOrder = laneTracker;
              }
        }
        // moves player towards game object position (the lanes)
        float step = speed * Time.deltaTime;
        this.transform.position = Vector2.MoveTowards(this.transform.position, lanes[laneTracker].transform.position, step);
  }

    void OnTriggerEnter2D(Collider2D col)
    {
      void collectAnim ()
      {
        // disables collider so that multiple collisions aren't made
        col.GetComponent<BoxCollider2D>().enabled = false;
        // pushes collected object to front sorting layer so it is visible
        SpriteRenderer ord = col.transform.GetChild(0).gameObject.GetComponent<SpriteRenderer>();
        ord.sortingOrder = 3;
        // sets velocity to 0 to prevent movement
        col.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
        // sets bool so that animation plays
        col.transform.GetChild(0).gameObject.GetComponent<Animator>().SetBool("IsCollected", true);
      }
      
      if (col.gameObject.tag == "ChocChip")
      {
        GameManager.score += 1;
        collectAnim();
      }
      else if (col.gameObject.tag == "ChocChunk")
      {
        GameManager.score += 10;
        collectAnim();
      }
      else if (col.gameObject.tag == "DinoToy" || col.gameObject.tag == "MilkPuddle")
      {
        // destroys heart object
        GameObject.Find("Canvas").GetComponent<GameManager>().loseHeart();
        collectAnim();
      }
    }
}
