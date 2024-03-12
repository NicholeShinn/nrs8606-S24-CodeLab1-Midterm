using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.IO;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager instance; //static means that there's one instance of this variable, no matter how many exist. If something changes, it changes for every instance.
    
    public string line01 = "";
    public TextMeshProUGUI poemText;
    
    const string KEY_LINE_ONE = "Line 01";
    public string Line01
    {
        get
        {
            if (File.Exists(DATA_FULL_FILE_PATH)) 
            {
                string fileContents = File.ReadAllText(DATA_FULL_FILE_PATH); //file contents for line 1 is read from the stored text
                line01 = fileContents; //therefore line 1 equals the file contents
            }
            
            return line01; //so we return with that data saved
        }

        set
        {
            line01 = value; //now we set the live version that we see from this "get" value
            Debug.Log("line changed!");
             
            string fileContent = "" + line01;

            if (!Directory.Exists(Application.dataPath + DATA_DIR))
            {
                Directory.CreateDirectory(Application.dataPath + DATA_DIR);
            }

            File.WriteAllText(DATA_FULL_FILE_PATH, fileContent); //replacing the current saved data, with new by rewriting the saved text
        }
        
    }
    
    const string DATA_DIR = "/WordLines/";
    const string DATA_LINE_FILE = "LineHolder.txt";
    
    string DATA_FULL_FILE_PATH;
    
    
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

    private void Start()
    {
        DATA_FULL_FILE_PATH = Application.dataPath + DATA_DIR + DATA_LINE_FILE;
    }

    // Update is called once per frame
    void Update()
    {
        poemText.text = "..." + line01 + "...";
        /*if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }*/
    }
}
