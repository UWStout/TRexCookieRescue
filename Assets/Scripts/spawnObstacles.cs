using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnObstacles : MonoBehaviour
{
    public GameObject chocolateChunkPrefab;
    public float respawnTime = 1.0f;//time between spawns
    private Vector2 objectBounds;
    // Start is called before the first frame update
    void Start()
    {
        objectBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));//defines the boundaries of the screen on an x and y axis
        StartCoroutine(obstacleWave());
    }

    private void spawnObstacle()
    {
        GameObject a = Instantiate(chocolateChunkPrefab) as GameObject;//creates the object
        //a.transform.position = new Vector2(objectBounds.x, Random.Range(-objectBounds.y, objectBounds.y));//spawn range, currently the screen

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

    IEnumerator obstacleWave()
    {
        while (true)
        {
            yield return new WaitForSeconds(respawnTime);//respawn time
            spawnObstacle();//calls for them to spawn
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
