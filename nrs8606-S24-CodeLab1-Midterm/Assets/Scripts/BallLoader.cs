using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using Random = UnityEngine.Random;

public class BallLoader: MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        //if you press B you load more balls (function)
        if (Input.GetKeyDown(KeyCode.B))
        {
            LoadBalls();
        }
    }

    void LoadBalls()
    {
        //creating a new game object instance of the prefab, balls in a random range new vector 3 each time instantiated
        GameObject newObject;
        
        newObject =
            Instantiate(Resources.Load<GameObject>("Prefabs/Balls"));
        newObject.transform.position = new Vector3(Random.Range(-4, 4), Random.Range(-2, 2), 0);
        //randomly assigning x, y spawn for new prefab group position 
    }


}
