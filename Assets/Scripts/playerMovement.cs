using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
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

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            if(laneTracker == 1 || laneTracker == 0)
            {
                laneTracker++;
            } 
        }
        else if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            if (laneTracker == 1 || laneTracker == 2)
            {
                laneTracker--;
            }
        }
        // moves player towards game object position (the lanes)
        float step = speed * Time.deltaTime;
        this.transform.position = Vector2.MoveTowards(this.transform.position, lanes[laneTracker].transform.position, step);
  }

    void OnTriggerEnter2D(Collider2D col)
    {
      if (col.gameObject.tag == "ChocChip")
      {
        Debug.Log("Chip!");
        GameManager.score += 1;
      }
      else if (col.gameObject.tag == "ChocChunk")
      {
        Debug.Log("Chunk!");
        GameManager.score += 10;
      }
      else if (col.gameObject.tag == "DinoToy" || col.gameObject.tag == "MilkPuddle")
      {
        Debug.Log("Hazard!");
        GameObject.Find("Canvas").GetComponent<GameManager>().loseHeart();
      }
      else
      {
        Debug.Log("Unknown!");
      }
      Destroy(col.gameObject);
    }
    
}
