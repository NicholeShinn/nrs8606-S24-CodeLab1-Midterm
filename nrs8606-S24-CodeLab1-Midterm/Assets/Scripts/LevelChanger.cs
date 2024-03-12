using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelChanger : MonoBehaviour
{
    public GameObject groundParent;
    // Update is called once per frame
    void Update()
    {
        //if the levels are less than 3, we cycle through the names ++ of the levels on space press
        if (AsciiLevelLoader.instance.CurrentLevel < 3)
        {
            if (Input.GetKeyUp(KeyCode.Space))
            {
                //similar issue with the parenting/rotation of level objects, so we reset it at -90 so they can rotate together
                //it's in a single frame so it's not noticable
                groundParent.transform.rotation = Quaternion.Euler(new Vector3(-90, 0, 0));
                Debug.Log("SpacePressed");
                AsciiLevelLoader.instance.CurrentLevel++;
                groundParent.transform.rotation = Quaternion.Euler(new Vector3(0, 0, 0));
            }
        }
        
        //if the level loaded is at level 3 when you press space it resets to 0. Also could have tried arrays for-->each, but I struggle with arrays
        if (AsciiLevelLoader.instance.CurrentLevel >= 3)
        {
            if (Input.GetKeyUp(KeyCode.Space))
            {
                groundParent.transform.rotation = Quaternion.Euler(new Vector3(-90, 0, 0));
                Debug.Log("SpacePressed");
                AsciiLevelLoader.instance.CurrentLevel = 0;
                groundParent.transform.rotation = Quaternion.Euler(new Vector3(0, 0, 0));
            }
        }
        
    }
}
