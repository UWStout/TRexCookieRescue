using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CookieScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //check when the player touches something
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "ChocoloateChip")//if the player touches a chocolate chip
        {
            //increase score by +1
            global.score += 1;
        }

        if (col.gameObject.name == "ChocoloateChunk")//if the player touches a chocolate chunk
        {
            //increase score by +10
            global.score += 10;
        }

        if (col.gameObject.name == "DinosaurToy")//if the player touches a dinosaur toy
        {
            //push player back
        }

        if (col.gameObject.name == "Milk")//if the player touches milk
        {
            //slow player
        }
    }
}
