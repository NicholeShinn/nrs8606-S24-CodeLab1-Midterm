using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class SceneChanger : MonoBehaviour
{

    public void IntroButton() //function to use on click event to load next scene
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); // Load Scene through getting the current scene and continuing by 1 in the build settings index
    }
    
    public void ChangeNextScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        
    }
}
