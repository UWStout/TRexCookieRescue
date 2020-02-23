using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rollingPinDespawns : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

  void OnTriggerEnter2D(Collider2D col)
  {
    // disables collider so that accidental collisions aren't made
    col.GetComponent<BoxCollider2D>().enabled = false;
    // pushes collected object to front sorting layer so it is visible
    //SpriteRenderer ord = col.transform.GetChild(0).gameObject.GetComponent<SpriteRenderer>();
    //ord.sortingOrder = 3;
    // sets velocity to 0 to prevent movement
    //col.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
    // sets bool so that animation plays
    col.transform.GetChild(0).gameObject.GetComponent<Animator>().SetBool("IsSquashed", true);
  }
}
