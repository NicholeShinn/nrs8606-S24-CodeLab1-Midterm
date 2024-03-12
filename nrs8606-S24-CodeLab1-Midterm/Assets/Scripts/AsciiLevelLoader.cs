using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class AsciiLevelLoader : MonoBehaviour
{
    //you can make it a singleton
    public int currentLevel = 0;
    //look at matt's script to finalize
    public GameObject groundParent;
    GameObject level;

    public int CurrentLevel
    {
        get
        {
            return currentLevel;
            //anytime someone changes the level, we load the next level
        }
        set
        {
            currentLevel = value;
            LoadLevel();
        }
    }

    string FILE_PATH;

    public static AsciiLevelLoader instance;

    void Start()
    {
        instance = this;
        FILE_PATH = Application.dataPath + "/Levels/LevelNum.txt";
        LoadLevel();
        //solution for rotation was to have position match level objects on awake, then on start they all together rotate too 0, 0, 0 rotation from -90 x value, otherwise level objects would not parent properly
        groundParent.transform.rotation = Quaternion.Euler(new Vector3(0, 0, 0));
    }
    
    void LoadLevel()
    {
        Destroy(level);
        
        level = new GameObject("Level Objects");
        level.transform.parent = groundParent.transform;
        //below you can see me struggle with setting rotation with the new level objects
        //level.transform.Rotate(new Vector3(0, 0, -90));
        //level.transform.rotation = new Quaternion(45, 0, 0, 0);
       /* level.transform.eulerAngles = new Vector3(
              level.transform.eulerAngles.x -90,
              level.transform.eulerAngles.y,
              level.transform.eulerAngles.z
        );*/
        
        //reading the first line in the file as an array, 0 is line 1
        string[] lines = File.ReadAllLines(FILE_PATH.Replace("Num", currentLevel + ""));

        for (int y = 0; y < lines.Length; y++)
        {
            Debug.Log(lines[y]);

            //line is equal to the first line in the array 0
            string line = lines[y].ToUpper();

            //turns one line into many individual characters as ab array
            char[] characters = line.ToCharArray();

            for (int x = 0; x < characters.Length; x++)
            {
                //defining the first character on the array
                char c = characters[x];

                Debug.Log(c);

                GameObject newObject = null;

                switch (c)
                {
                    case 'W': //if the character is a 'w'
                        newObject =
                            Instantiate(Resources.Load<GameObject>("Prefabs/cubespike"));
                        break;
                    case 'P'://if the character is a 'p'
                        newObject =
                            Instantiate(Resources.Load<GameObject>("Prefabs/spike"));
                       // Camera.main.transform.parent = newObject.transform;
                      //  Camera.main.transform.position = new Vector3(0, 0, -10);
                        break;
                    case 'S':
                        newObject =
                            Instantiate(Resources.Load<GameObject>("PreFabs/extraspike"));
                        break;
                    case 'E':
                        newObject =
                            Instantiate(Resources.Load<GameObject>("PreFabs/squarespike"));
                        break;
                    default:
                        break;
                        
                }
                                
                if (newObject != null)
                {
                    newObject.transform.parent = level.transform;
                    //give it a position based on where it was in the ASCII file
                    newObject.transform.position = new Vector3(x-10.5f, y-15.5f, 0);
                    //newObject.transform.rotation = Quaternion.Euler(new Vector3(-90, 50, 0));
                }
                
            }
        }
    }
}
