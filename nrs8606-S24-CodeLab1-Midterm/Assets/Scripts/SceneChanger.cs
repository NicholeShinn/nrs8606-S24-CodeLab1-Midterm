using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class SceneChanger : MonoBehaviour
{
    public GameObject gameManagerHolder;
    public GameObject currentLineActual;
    public GameObject currentLineCanvas;
    public void IntroButton() //function to use on click event 
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); // Load Scene through getting the current scene and continuing by 1 in the build settings index
    }
    
    public void ChangePoemText()
    {
        currentLineCanvas.SetActive(true);
        gameManagerHolder.GetComponent<GameManager>().poemText = currentLineActual.GetComponent<TextMeshProUGUI>();
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        
    }
}
