﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public void returnMenu(){
        SceneManager.LoadScene(0);
    }
    public void returnStudio(){
        GameObject.Find("PauseScreen").SetActive(false);
    }

    //void Start(){
        //GameObject.Find("PauseScreen").GetComponent<Canvas>().TargetDisplay;
    //}

    void Update(){
        if (Input.GetKeyDown("escape")){returnStudio();}
        }
}