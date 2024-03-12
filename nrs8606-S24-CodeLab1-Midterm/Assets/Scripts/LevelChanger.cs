using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelChanger : MonoBehaviour
{
    public GameObject groundParent;
    // Update is called once per frame
    void Update()
    {
        if (AsciiLevelLoader.instance.CurrentLevel < 3)
        {
            if (Input.GetKeyUp(KeyCode.Space))
            {
                groundParent.transform.rotation = Quaternion.Euler(new Vector3(-90, 0, 0));
                Debug.Log("SpacePressed");
                AsciiLevelLoader.instance.CurrentLevel++;
                groundParent.transform.rotation = Quaternion.Euler(new Vector3(0, 0, 0));
            }
        }
        
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
