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
        a.transform.position = new Vector2(objectBounds.x, Random.Range(-objectBounds.y, objectBounds.y));//spawn range, currently the screen
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
