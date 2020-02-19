using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hazard_Script : MonoBehaviour
{
    //Translate movement
    private Vector2 hazardPosition;
    private Vector2 playerPosition;
    //public float speed;
    public float speed = .01f;
    // Start is called before the first frame update
    public float playerPush = 1f;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        hazardPosition = new Vector2(transform.position.x - speed, transform.position.y);
        transform.position = hazardPosition;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            playerPosition = new Vector2(transform.position.x - 1, transform.position.y);
            collision.gameObject.transform.position = playerPosition;

        }
    }
}
