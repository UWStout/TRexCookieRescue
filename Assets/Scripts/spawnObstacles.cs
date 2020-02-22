using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using System;

public class spawnObstacles : MonoBehaviour
{
    public Transform[] teleport;//location array
    public GameObject[] prefab;//prefab array
    public float respawnTime = 1.0f;//time between spawns
    public float objectSpeed = 1.0f;//gotta go fast
    // public GameObject chocolateChunkPrefab;
    // private Vector2 objectBounds;
    // public static GameObject[] myObjects;//array of prefabs
    // Start is called before the first frame update
    void Start()
    {
        //objectBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));//defines the boundaries of the screen on an x and y axis
        //myObjects = Resources.LoadAll<GameObject> ("Prefabs");//store all prefabs in the array

        StartCoroutine(obstacleWave());
  }

    private void spawnObstacle()
    {
        int tele_num = Random.Range(0, 3);//choose a location
        int prefab_num = Random.Range(0, 4);//choose a prefab

        GameObject obj = (GameObject)Instantiate(prefab[prefab_num], teleport[tele_num].position, teleport[tele_num].rotation); //clones prefab at position
        Rigidbody2D rb = obj.GetComponent<Rigidbody2D>(); //the rigidbody of prefab just cloned
        rb.velocity = new Vector2(-objectSpeed, 0); //begins moving it towards player at speed given
        

    /*
    GameObject a = Instantiate(chocolateChunkPrefab) as GameObject;//creates the object

    //a.transform.position = new Vector2(objectBounds.x, Random.Range(-objectBounds.y, objectBounds.y));//spawn range, currently the screen

    //randomly choose 0,1 or 2
    //int rando = Random.Range(0, 2);
    //Random rando = new Random();
    // int ranNum = rando.Next(0,2);
    // int ranNum = rando.Next(0,2);

    //Random random = new Random();
    //int rando = random.Next(0, 3);


    int rando = Random.Range(0, 3);
    //spawn based on the random number given
    Debug.Log("Thing" + rando);
    switch (rando)
    {
        case 0:
            new Vector2(4.75f, -3.25f);

            //Instantiate(chocolateChunkPrefab, new Vector3(4.75f, -3.25f,0));
            break;
        case 1:
            new Vector2(4.5f, -3.7f);
            break;
        case 2:
            new Vector2(4.25f, -4.1f);
            break;
    }
    */

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
