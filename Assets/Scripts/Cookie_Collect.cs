using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cookie_Collect : MonoBehaviour
{
    public static GameObject health_3;
    public GameObject health_2;
    public GameObject health_1;

    // Start is called before the first frame update
    void Start() 
    {
        health_3 = GameObject.Find("health_3");
        health_2 = GameObject.Find("health_2");
        health_1 = GameObject.Find("health_1");

    }

    // Update is called once per frame
    void Update()
    {
        


    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Collectable"))
        {
            Destroy(collision.gameObject);
        }

        else if (collision.gameObject.CompareTag("Hazard"))
        {
            if(GameManager.health == 3)
            {
                Destroy(health_3);
                GameManager.health = 2;
                Destroy(collision.gameObject);
            }
            else if (GameManager.health == 2)
            {
                Destroy(health_2);
                GameManager.health = 1;
                Destroy(collision.gameObject);
            }
            else if (GameManager.health == 1)
            {
                Destroy(health_1);
                GameManager.health = 0;
                Destroy(collision.gameObject);
            }
            else if (GameManager.health == 0)
            {
                Destroy(collision.gameObject);
                GameManager.gameFail();
            }

        }
    }
}
