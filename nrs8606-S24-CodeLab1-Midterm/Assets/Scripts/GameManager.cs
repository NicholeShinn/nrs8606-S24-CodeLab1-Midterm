using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance; //static means that there's one instance of this variable, no matter how many exist. If something changes, it changes for every instance.
    
    // //singletons should appear in awake over start, so that there's no weird errors. It can run initially, over first frame
    void Awake()
    {
        if (instance == null) // if the instance hasn't been set
        {
            instance = this; // then set the instance to this one (game manager)
            DontDestroyOnLoad(gameObject); //specifying the object this code is attached to 
        }
        else // if there is already a singleton of it's type, you must destroy the game object this is attached to
        {
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
