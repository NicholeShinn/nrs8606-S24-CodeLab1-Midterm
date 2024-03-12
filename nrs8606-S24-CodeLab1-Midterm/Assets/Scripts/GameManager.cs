using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using TMPro;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance; //static means that there's one instance of this variable, no matter how many exist. If something changes, it changes for every instance.
    
    
    
    //This is where the information is stored for line 01 to be displayed at the end scene.
    public GameObject gameManagerHolder;
    public GameObject currentLineActual;
    public GameObject currentLineCanvas;

    public string line = "";
    //Setting line01 to be saved into file contents and to pull the file contents to be applied in game
    const string KEY_LINE_ONE = "Line 01";

    public string Line
    {
        get
        { 
            if(File.Exists(DATA_FULL_FILE_PATH)) 
            {
                string fileContents = File.ReadAllText(DATA_FULL_FILE_PATH); //file contents for line 1 is read from the stored text
                line = fileContents; //therefore line 1 equals the file contents
            }

            return line;
        }
        set
        {
            line = value; //now we set the live version that we see from this "get" value
            Debug.Log("line changed!");
             
            string fileContent = "" + line;

            if (!Directory.Exists(Application.dataPath + DATA_DIR))
            {
                Directory.CreateDirectory(Application.dataPath + DATA_DIR);
            }

            File.WriteAllText(DATA_FULL_FILE_PATH, fileContent); //replacing the current saved data, with new by rewriting the saved text
        }
    }
    
    public TextMeshProUGUI poemText;
    
    const string DATA_DIR = "/WordLines/";
    const string DATA_LINE_FILE = "lineHolder.txt";
    
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

    void Start()
    {
        DATA_FULL_FILE_PATH = Application.dataPath + DATA_DIR + DATA_LINE_FILE;
        gameManagerHolder.GetComponent<GameManager>().poemText = currentLineActual.GetComponent<TextMeshProUGUI>();
        
    }

    // Update is called once per frame
    void Update()
    {
        poemText.text = "..." + Line + "...";
 
        if (SceneManager.GetActiveScene().name == "EndScene") 
        {
            currentLineCanvas.SetActive(true);
        }

    }
}
