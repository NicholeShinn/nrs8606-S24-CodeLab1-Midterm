using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallCollect : MonoBehaviour
{
    //could have made this an array....but I was stuck so did this to finish.
    //struggled with having the array have randomized textures for materials & 
    //then assigning a sprite to those randomized textures/prefab. Originally 
    //wanted to make a single sphere with variants but had a hard time triggering
    public GameObject sprite01;
    public GameObject sprite02;
    public GameObject sprite03;
    public GameObject sprite04;
    public GameObject sprite05;
    public GameObject sprite06;
    public GameObject sprite07;
    public GameObject sprite08;
    public GameObject sprite09;
    public GameObject sprite10;
    public GameObject sprite11;
    public GameObject sprite12;
    public GameObject prompt;

    private void Update()
    {
        //when all sprites are active, trigger prompt
        if (sprite01.activeSelf && sprite02.activeSelf && sprite03.activeSelf && sprite04.activeSelf && sprite05.activeSelf && sprite06.activeSelf && sprite07.activeSelf
            && sprite08.activeSelf && sprite09.activeSelf && sprite10.activeSelf && sprite11.activeSelf && sprite12.activeSelf)
        {
            prompt.SetActive(true);
        }
    }

    //if any of the balls that are individually tagged hit the collider, via designated tags designated sprites appear & ball is destroyed
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "ball01")
        {
            sprite01.SetActive( true);
            Debug.Log("ball01enter");
        }
        if (other.gameObject.tag == "ball02")
        {
            sprite02.SetActive( true);
            Debug.Log("ball02enter");
        }
        if (other.gameObject.tag == "ball03")
        {
            sprite03.SetActive( true);
            Debug.Log("ball03enter");
        }
        if (other.gameObject.tag == "ball04")
        {
            sprite04.SetActive( true);
            Debug.Log("ball04enter");
        }
        if (other.gameObject.tag == "ball05")
        {
            sprite05.SetActive( true);
            Debug.Log("ball05enter");
        }
        if (other.gameObject.tag == "ball06")
        {
            sprite06.SetActive( true);
            Debug.Log("ball06enter");
        }
        if (other.gameObject.tag == "ball07")
        {
            sprite07.SetActive( true);
            Debug.Log("ball07enter");
        }
        if (other.gameObject.tag == "ball08")
        {
            sprite08.SetActive( true);
            Debug.Log("ball08enter");
        }
        if (other.gameObject.tag == "ball09")
        {
            sprite09.SetActive( true);
            Debug.Log("ball09enter");
        }
        if (other.gameObject.tag == "ball10")
        {
            sprite10.SetActive( true);
            Debug.Log("ball10enter");
        }
        if (other.gameObject.tag == "ball11")
        {
            sprite11.SetActive( true);
            Debug.Log("ball11enter");
        }
        if (other.gameObject.tag == "ball12")
        {
            sprite12.SetActive( true);
            Debug.Log("ball12enter");
        }
        
    }
}
