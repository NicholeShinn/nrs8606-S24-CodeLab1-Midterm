using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReadInput : MonoBehaviour
{
    public static string inputText01; //identifying lines of poem
    
    //creating an on input (when you press return/enter) to be recorded
    //and then reflected into the next scene text line.
    
    public void ReadStringInput(string a)
    {
        inputText01 = a;
        Debug.Log(inputText01);
        Debug.Log("LineChanged!");
        GameManager.instance.Line01 = inputText01;
    }
}
