using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; 

public class ShowFinalText : MonoBehaviour
{
    public GameObject gameManagerHolder;
    public GameObject currentLineActual;
    public GameObject currentLineCanvas;
    // Start is called before the first frame update
    void Start()
    {
        
        gameManagerHolder.GetComponent<GameManager>().poemText = currentLineActual.GetComponent<TextMeshProUGUI>();

    }

    // Update is called once per frame
    void Update()
    {
       
    }
}
