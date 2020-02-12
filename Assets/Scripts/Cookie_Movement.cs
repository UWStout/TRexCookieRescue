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

    private Vector2 cookiePos;
    public float yPosChange = 2;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            cookiePos = new Vector2(transform.position.x, transform.position.y + yPosChange);
            transform.position = cookiePos;

        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            cookiePos = new Vector2(transform.position.x, transform.position.y - yPosChange);
            transform.position = cookiePos;

        }

    }
}
